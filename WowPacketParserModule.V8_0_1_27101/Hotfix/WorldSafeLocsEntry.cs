using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.WorldSafeLocs, HasIndexInData = false)]
    public class WorldSafeLocsEntry
    {
        public string Name { get; set; }
        [HotfixArray(3)]
        public float[] Loc { get; set; }
        public ushort MapId { get; set; }
        public float Facing { get; set; }
    }
}