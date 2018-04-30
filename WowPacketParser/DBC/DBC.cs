using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using WDBXLib.Reader;
using WDBXLib.Storage;
using WDBXLib.Definitions.Legion_7_2_0;
using WowPacketParser.Misc;

namespace WowPacketParser.DBC
{
    public static class DBC
    {
        public static DBEntry<AreaTable> AreaTableEntry = DBReader.Read<AreaTable>(GetPath("AreaTable.db2"));
        public static DBEntry<Achievement> AchievementEntry = DBReader.Read<Achievement>(GetPath("Achievement.db2"));
        public static DBEntry<BroadcastText> BroadcastTextEntry = DBReader.Read<BroadcastText>(GetPath("BroadcastText.db2"));
        public static DBEntry<Creature> CreatureEntry = DBReader.Read<Creature> (GetPath("Creature.db2"));
        public static DBEntry<CreatureDifficulty> CreatureDifficultyEntry = DBReader.Read<CreatureDifficulty>(GetPath("CreatureDifficulty.db2"));
        public static DBEntry<CreatureFamily> CreatureFamilyEntry = DBReader.Read<CreatureFamily>(GetPath("CreatureFamily.db2"));
        public static DBEntry<CreatureDisplayInfo> CreatureDisplayInfoEntry = DBReader.Read<CreatureDisplayInfo>(GetPath("CreatureDisplayInfo.db2"));
        public static DBEntry<CriteriaTree> CriteriaTreeEntry = DBReader.Read<CriteriaTree>(GetPath("CriteriaTree.db2"));
        public static DBEntry<Criteria> CriteriaEntry = DBReader.Read<Criteria>(GetPath("Criteria.db2"));
        public static DBEntry<Difficulty> DifficultyEntry = DBReader.Read<Difficulty>(GetPath("Difficulty.db2"));
        public static DBEntry<Faction> FactionEntry = DBReader.Read<Faction>(GetPath("Faction.db2"));
        public static DBEntry<FactionTemplate> FactionTemplateEntry = DBReader.Read<FactionTemplate>(GetPath("FactionTemplate.db2"));
        public static DBEntry<Item> ItemEntry = DBReader.Read<Item>(GetPath("Item.db2"));
        public static DBEntry<ItemSparse> ItemSparseEntry = DBReader.Read<ItemSparse>(GetPath("ItemSparse.db2"));
        public static DBEntry<Map> MapEntry = DBReader.Read<Map>(GetPath("Map.db2"));
        public static DBEntry<MapDifficulty> MapDifficultyEntry = DBReader.Read<MapDifficulty>(GetPath("MapDifficulty.db2"));
        public static DBEntry<PhaseXPhaseGroup> PhaseXPhaseGroupEntry = DBReader.Read<PhaseXPhaseGroup>(GetPath("PhaseXPhaseGroup.db2"));
        public static DBEntry<SoundKit> SoundKitEntry = DBReader.Read<SoundKit>(GetPath("SoundKit.db2"));
        public static DBEntry<Spell> SpellEntry = DBReader.Read<Spell>(GetPath("Spell.db2"));
        public static DBEntry<SpellEffect> SpellEffectEntry = DBReader.Read<SpellEffect>(GetPath("SpellEffect.db2"));

        private static string GetPath()
        {
            return System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Settings.DBCPath, Settings.DBCLocale);
        }

        private static string GetPath(string fileName)
        {
            return System.IO.Path.Combine(GetPath(), fileName);
        }

        public static async void Load()
        {
            if (!Directory.Exists(GetPath()))
            {
                Trace.WriteLine($"DBC folder \"{ GetPath() }\" not found");
                return;
            }
            else
                Trace.WriteLine($"DBC folder \"{ GetPath() }\" found");

            Trace.WriteLine("File name                           LoadTime             Record count");
            Trace.WriteLine("---------------------------------------------------------------------");

            /*Parallel.ForEach(Assembly.GetAssembly(typeof(DBC)).GetTypes(), type =>
            {
                if (!type.IsClass)
                    return;

                var startTime = DateTime.Now;
                //var attr = type.GetCustomAttribute<DBFileAttribute>();
                if (attr == null)
                    return;

                var times = new List<long>();
                var instanceType = typeof(Storage<>).MakeGenericType(type);
                var countGetter = instanceType.GetProperty("Count").GetGetMethod();
                var instance = Activator.CreateInstance(instanceType, $"{ GetPath(attr.FileName) }.db2", true);
                var recordCount = (int)countGetter.Invoke(instance, new object[] { });

                var endTime = DateTime.Now;
                var span = endTime.Subtract(startTime);

                Trace.WriteLine($"{ attr.FileName.PadRight(33) } { TimeSpan.FromTicks(span.Ticks).ToString().PadRight(28) } { recordCount.ToString().PadRight(19) }");
            });*/

            await Task.WhenAll(Task.Run(() =>
            {
                if (AreaTableEntry != null)
                    foreach (var db2Info in AreaTableEntry.Rows)
                    {
                        if (db2Info.ParentAreaID != 0 && !Zones.ContainsKey(db2Info.ParentAreaID))
                            Zones.Add(db2Info.ParentAreaID, db2Info.ZoneName);
                    }
            }), Task.Run(() =>
            {
                if (MapDifficultyEntry != null)
                {
                    foreach (var mapDifficulty in MapDifficultyEntry.Rows)
                    {
                        int difficultyID = 1 << mapDifficulty.DifficultyID;

                        if (MapSpawnMaskStores.ContainsKey(mapDifficulty.MapID))
                            MapSpawnMaskStores[mapDifficulty.MapID] |= difficultyID;
                        else
                            MapSpawnMaskStores.Add(mapDifficulty.MapID, difficultyID);
                    }
                }
            }), Task.Run(() =>
            {
                if (CriteriaTreeEntry != null && AchievementEntry != null)
                {
                    ICollection<Achievement> achievementLists = AchievementEntry.Rows;
                    var achievements = achievementLists.GroupBy(achievement => achievement.CriteriaTree)
                        .ToDictionary(group => group.Key, group => group.ToList());

                    foreach (var criteriaTree in CriteriaTreeEntry.Rows)
                    {
                        string result = "";
                        ushort criteriaTreeID = criteriaTree.Parent > 0 ? criteriaTree.Parent : (ushort)criteriaTree.ID;

                        List<Achievement> achievementList;
                        if (achievements.TryGetValue(criteriaTreeID, out achievementList))
                            foreach (var achievement in achievementList)
                                result = $"AchievementID: {achievement.ID} Description: \"{ achievement.Description }\"";

                        if (!CriteriaStores.ContainsKey((ushort)criteriaTree.CriteriaID))
                        {
                            if (criteriaTree.Description != string.Empty)
                                result += $" - CriteriaDescription: \"{criteriaTree.Description }\"";

                            CriteriaStores.Add((ushort)criteriaTree.CriteriaID, result);
                        }
                        else
                            CriteriaStores[(ushort)criteriaTree.CriteriaID] += $" / CriteriaDescription: \"{ criteriaTree.Description }\"";
                    }
                }
            }), Task.Run(() =>
            {
                if (FactionEntry != null && FactionTemplateEntry != null)
                {
                    foreach (var factionTemplate in FactionTemplateEntry.Rows)
                    {
                        if (FactionEntry.Rows.ContainsKey(factionTemplate.Faction))
                            FactionStores.Add((uint)factionTemplate.ID, FactionEntry.Rows[factionTemplate.Faction]);
                    }
                }
            }), Task.Run(() =>
            {
                if (SpellEffectEntry != null)
                    foreach (var effect in SpellEffectEntry.Rows)
                    {
                        var tuple = Tuple.Create(effect.SpellID, effect.EffectIndex);
                        SpellEffectStores[tuple] = effect;
                    }
            }), Task.Run(() =>
            {
                if (PhaseXPhaseGroupEntry != null)
                    foreach (var phase in PhaseXPhaseGroupEntry.Rows)
                    {
                        if (!Phases.ContainsKey(phase.PhaseGroupID))
                            Phases.Add(phase.PhaseGroupID, new List<ushort>() { phase.PhaseID });
                        else
                            Phases[phase.PhaseGroupID].Add(phase.PhaseID);
                    }
            }));
        }

        public static HashSet<ushort> GetPhaseGroups(HashSet<ushort> phases)
        {
            if (!phases.Any())
                return new HashSet<ushort>();

            HashSet<ushort> phaseGroups = new HashSet<ushort>();

            foreach (var phaseGroup in Phases)
            {
                bool valid = true;

                foreach (var phase in phaseGroup.Value)
                {
                    if (!phases.Contains(phase))
                        valid = false;
                }

                if (valid)
                {
                    Trace.WriteLine($"PhaseGroup: { phaseGroup.Key } Phases: { string.Join(" - ", phaseGroup.Value) }");
                    phaseGroups.Add(phaseGroup.Key);
                }
            }

            return phaseGroups;
        }

        public static readonly Dictionary<uint, string> Zones = new Dictionary<uint, string>();
        public static readonly Dictionary<int, int> MapSpawnMaskStores = new Dictionary<int, int>();
        public static readonly Dictionary<ushort, string> CriteriaStores = new Dictionary<ushort, string>();
        public static readonly Dictionary<uint, Faction> FactionStores = new Dictionary<uint, Faction>();
        public static readonly Dictionary<Tuple<uint, uint>, SpellEffect> SpellEffectStores = new Dictionary<Tuple<uint, uint>, SpellEffect>();
        public static readonly Dictionary<ushort, List<ushort>> Phases = new Dictionary<ushort, List<ushort>>();
    }
}
