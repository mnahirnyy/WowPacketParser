using WowPacketParser.Parsing;

namespace WowPacketParserModule.V8_1_0_28724.Enums
{
    public enum ObjectField
    {
        [UpdateField(UpdateFieldType.Int)]
        OBJECT_FIELD_ENTRY                                     = 0,
        OBJECT_DYNAMIC_FLAGS                                   = 1,
        [UpdateField(UpdateFieldType.Float)]
        OBJECT_FIELD_SCALE_X                                   = 2,
        OBJECT_END                                             = 3,
    }

    public enum ObjectDynamicField
    {
        OBJECT_DYNAMIC_END                                     = 0x000,
    }

    public enum ItemField
    {
        [UpdateField(UpdateFieldType.Uint, true)]
        ITEM_FIELD_DYNAMIC_COUNT_1                             = ObjectField.OBJECT_END + 0,
        [UpdateField(UpdateFieldType.DynamicInt)]
        ITEM_FIELD_DYNAMIC_1                                   = ObjectField.OBJECT_END + 1,
        [UpdateField(UpdateFieldType.Guid)]
        ITEM_FIELD_2                                           = ObjectField.OBJECT_END + 2,
        [UpdateField(UpdateFieldType.Guid)]
        ITEM_FIELD_3                                           = ObjectField.OBJECT_END + 3,
        [UpdateField(UpdateFieldType.Guid)]
        ITEM_FIELD_4                                           = ObjectField.OBJECT_END + 4,
        [UpdateField(UpdateFieldType.Guid)]
        ITEM_FIELD_5                                           = ObjectField.OBJECT_END + 5,
        [UpdateField(UpdateFieldType.Uint, UpdateFieldCreateFlag.Unk1)]
        ITEM_FIELD_6                                           = ObjectField.OBJECT_END + 6,
        [UpdateField(UpdateFieldType.Uint)]
        ITEM_FIELD_7                                           = ObjectField.OBJECT_END + 7,

        // ArraySize 5
        [UpdateField(UpdateFieldType.Int)]
        ITEM_FIELD_8                                           = ObjectField.OBJECT_END + 8,

        [UpdateField(UpdateFieldType.Uint)]
        ITEM_FIELD_13                                          = ObjectField.OBJECT_END + 13,

        // ArraySize 13
        [UpdateField(UpdateFieldType.Int, 4)]
        ITEM_FIELD_14                                          = ObjectField.OBJECT_END + 14,
        [UpdateField(UpdateFieldType.Uint)]
        ITEM_FIELD_15                                          = ObjectField.OBJECT_END + 15,
        [UpdateField(UpdateFieldType.Short)]
        ITEM_FIELD_16                                          = ObjectField.OBJECT_END + 16,
        [UpdateField(UpdateFieldType.Ushort)]
        ITEM_FIELD_17                                          = ObjectField.OBJECT_END + 17,

        [UpdateField(UpdateFieldType.Int)]
        ITEM_FIELD_66                                          = ObjectField.OBJECT_END + 66,
        [UpdateField(UpdateFieldType.Int)]
        ITEM_FIELD_67                                          = ObjectField.OBJECT_END + 67,
        [UpdateField(UpdateFieldType.Uint, UpdateFieldCreateFlag.Unk1)]
        ITEM_FIELD_68                                          = ObjectField.OBJECT_END + 68,
        [UpdateField(UpdateFieldType.Uint, UpdateFieldCreateFlag.Unk1)]
        ITEM_FIELD_69                                          = ObjectField.OBJECT_END + 69,
        [UpdateField(UpdateFieldType.Uint)]
        ITEM_FIELD_70                                          = ObjectField.OBJECT_END + 70,
        [UpdateField(UpdateFieldType.Uint, UpdateFieldCreateFlag.Unk1)]
        ITEM_FIELD_71                                          = ObjectField.OBJECT_END + 71,
        [UpdateField(UpdateFieldType.Int)]
        ITEM_FIELD_72                                          = ObjectField.OBJECT_END + 72,
        [UpdateField(UpdateFieldType.Ulong, UpdateFieldCreateFlag.Unk1)]
        ITEM_FIELD_73                                          = ObjectField.OBJECT_END + 73,
        [UpdateField(UpdateFieldType.Byte, UpdateFieldCreateFlag.Unk1)]
        ITEM_FIELD_74                                          = ObjectField.OBJECT_END + 74,
        [UpdateField(UpdateFieldType.Uint, true)]
        ITEM_FIELD_DYNAMIC_COUNT_2                             = ObjectField.OBJECT_END + 75,
        [UpdateField(UpdateFieldType.Uint, true)]
        ITEM_FIELD_DYNAMIC_COUNT_3                             = ObjectField.OBJECT_END + 76,
        [UpdateField(UpdateFieldType.Uint, true)]
        ITEM_FIELD_DYNAMIC_COUNT_4                             = ObjectField.OBJECT_END + 77,
        [UpdateField(UpdateFieldType.Uint, UpdateFieldCreateFlag.Unk1)]
        ITEM_FIELD_78                                          = ObjectField.OBJECT_END + 78,

        // DynamicArray
        [UpdateField(UpdateFieldType.DynamicInt)]
        ITEM_FIELD_DYNAMIC_2                                   = ObjectField.OBJECT_END + 79,

        // DynamicArray
        [UpdateField(UpdateFieldType.DynamicShort, 3)]
        ITEM_FIELD_DYNAMIC_3                                   = ObjectField.OBJECT_END + 80,
        [UpdateField(UpdateFieldType.DynamicByte)]
        ITEM_FIELD_DYNAMIC_4                                   = ObjectField.OBJECT_END + 81,
        [UpdateField(UpdateFieldType.DynamicByte)]
        ITEM_FIELD_DYNAMIC_5                                   = ObjectField.OBJECT_END + 82,

        // DynamicArray with substructure
        [UpdateField(UpdateFieldType.DynamicInt, 15)]
        ITEM_FIELD_DYNAMIC_6                                   = ObjectField.OBJECT_END + 83,
        // ArraySize 13 substructure
        [UpdateField(UpdateFieldType.DynamicShort)]
        ITEM_FIELD_DYNAMIC_7                                   = ObjectField.OBJECT_END + 84,

        [UpdateField(UpdateFieldType.DynamicByte)]
        ITEM_FIELD_DYNAMIC_8                                   = ObjectField.OBJECT_END + 97,

        ITEM_END                                               = ObjectField.OBJECT_END + 98,
    }

    public enum ItemDynamicField
    {
        ITEM_DYNAMIC_FIELD_MODIFIERS                           = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x000, // Flags: OWNER
        ITEM_DYNAMIC_FIELD_BONUSLIST_IDS                       = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x001, // Flags: OWNER, 0x100
        ITEM_DYNAMIC_FIELD_ARTIFACT_POWERS                     = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x002, // Flags: OWNER
        ITEM_DYNAMIC_FIELD_GEMS                                = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x003, // Flags: OWNER
        ITEM_DYNAMIC_END                                       = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x004,
    }

    public enum ContainerField
    {
        // ArraySize 36
        [UpdateField(UpdateFieldType.Guid)]
        CONTAINER_FIELD_SLOT_1                                 = ItemField.ITEM_END + 0, // Size: 144, Flags: PUBLIC
        [UpdateField(UpdateFieldType.Uint)]
        CONTAINER_FIELD_NUM_SLOTS                              = ItemField.ITEM_END + 36, // Size: 1, Flags: PUBLIC
        CONTAINER_END                                          = ItemField.ITEM_END + 37,
    }

    public enum ContainerDynamicField
    {
        CONTAINER_DYNAMIC_END                                  = ItemDynamicField.ITEM_DYNAMIC_END + 0x000,
    }

    public enum AzeriteEmpoweredItemField
    {
        [UpdateField(UpdateFieldType.Int)]
        AZERITE_EMPOWERED_ITEM_FIELD_SELECTIONS                = ItemField.ITEM_END + 0,
        AZERITE_EMPOWERED_ITEM_END                             = ItemField.ITEM_END + 5,
    }

    public enum AzeriteEmpoweredItemDynamicField
    {
        AZERITE_EMPOWERED_ITEM_DYNAMIC_END                     = ItemDynamicField.ITEM_DYNAMIC_END + 0x000,
    }

    public enum AzeriteItemField
    {
        [UpdateField(UpdateFieldType.Ulong)]
        AZERITE_ITEM_FIELD_XP                                  = ItemField.ITEM_END + 0,
        AZERITE_ITEM_FIELD_LEVEL                               = ItemField.ITEM_END + 1,
        AZERITE_ITEM_FIELD_AURA_LEVEL                          = ItemField.ITEM_END + 2,
        [UpdateField(UpdateFieldType.Uint, UpdateFieldCreateFlag.Unk1)]
        AZERITE_ITEM_FIELD_KNOWLEDGE_LEVEL                     = ItemField.ITEM_END + 3,
        [UpdateField(UpdateFieldType.Uint, UpdateFieldCreateFlag.Unk1)]
        AZERITE_ITEM_FIELD_DEBUG_KNOWLEDGE_WEEK                = ItemField.ITEM_END + 4,
        AZERITE_ITEM_END                                       = ItemField.ITEM_END + 5,
    }

    public enum AzeriteItemDynamicField
    {
        AZERITE_ITEM_DYNAMIC_END                               = ItemDynamicField.ITEM_DYNAMIC_END + 0x000,
    }

    public enum UnitField
    {
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_DISPLAYID                                   = ObjectField.OBJECT_END + 0,
        // ArraySize 2
        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_1                                           = ObjectField.OBJECT_END + 1,

        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_3                                           = ObjectField.OBJECT_END + 3,
        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_4                                           = ObjectField.OBJECT_END + 4,
        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_5                                           = ObjectField.OBJECT_END + 5,
        [UpdateField(UpdateFieldType.Uint, true)]
        UNIT_DYNAMICFIELD_COUNT1                               = ObjectField.OBJECT_END + 6,
        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_7                                           = ObjectField.OBJECT_END + 7,
        [UpdateField(UpdateFieldType.DynamicUint)]
        UNIT_DYNAMIC_1                                         = ObjectField.OBJECT_END + 8,
        [UpdateField(UpdateFieldType.Guid)]
        UNIT_FIELD_CHARM                                       = ObjectField.OBJECT_END + 9,        
        [UpdateField(UpdateFieldType.Guid)]
        UNIT_FIELD_SUMMON                                      = ObjectField.OBJECT_END + 10,       
        [UpdateField(UpdateFieldType.Guid, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_CRITTER                                     = ObjectField.OBJECT_END + 11,       
        [UpdateField(UpdateFieldType.Guid)]
        UNIT_FIELD_CHARMEDBY                                   = ObjectField.OBJECT_END + 12,        
        [UpdateField(UpdateFieldType.Guid)]
        UNIT_FIELD_SUMMONEDBY                                  = ObjectField.OBJECT_END + 13,
        [UpdateField(UpdateFieldType.Guid)]
        UNIT_FIELD_CREATEDBY                                   = ObjectField.OBJECT_END + 14,       
        [UpdateField(UpdateFieldType.Guid)]
        UNIT_FIELD_DEMON_CREATOR                               = ObjectField.OBJECT_END + 15,      
        [UpdateField(UpdateFieldType.Guid)]
        UNIT_FIELD_LOOK_AT_CONTROLLER_TARGET                   = ObjectField.OBJECT_END + 16,      
        [UpdateField(UpdateFieldType.Guid)]
        UNIT_FIELD_TARGET                                      = ObjectField.OBJECT_END + 17,     
        [UpdateField(UpdateFieldType.Guid)]
        UNIT_FIELD_BATTLE_PET_COMPANION_GUID                   = ObjectField.OBJECT_END + 18,
        [UpdateField(UpdateFieldType.Ulong)]
        UNIT_FIELD_NPC_FLAGS                                   = ObjectField.OBJECT_END + 19,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_20                                          = ObjectField.OBJECT_END + 20,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_21                                          = ObjectField.OBJECT_END + 21,
        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_22                                          = ObjectField.OBJECT_END + 22,
        [UpdateField(UpdateFieldType.Bytes)]
        UNIT_FIELD_BYTES_0                                     = ObjectField.OBJECT_END + 23,
        [UpdateField(UpdateFieldType.Byte)]
        UNIT_FIELD_DISPLAY_POWER                               = ObjectField.OBJECT_END + 24,
        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_25                                          = ObjectField.OBJECT_END + 25,
        [UpdateField(UpdateFieldType.Long)]
        UNIT_FIELD_HEALTH                                      = ObjectField.OBJECT_END + 26,
        // ArraySize 6
        [UpdateField(UpdateFieldType.Int, 2)]
        UNIT_FIELD_POWER                                       = ObjectField.OBJECT_END + 27,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_MAXPOWER                                    = ObjectField.OBJECT_END + 28,

        // ArraySize 6
        [UpdateField(UpdateFieldType.Float, UpdateFieldCreateFlag.Unk1 | UpdateFieldCreateFlag.Unk4)] //flags
        UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER                   = ObjectField.OBJECT_END + 39,
        [UpdateField(UpdateFieldType.Float, UpdateFieldCreateFlag.Unk1 | UpdateFieldCreateFlag.Unk4)] //flags
        UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER       = ObjectField.OBJECT_END + 40,

        [UpdateField(UpdateFieldType.Long)]
        UNIT_FIELD_MAXHEALTH                                   = ObjectField.OBJECT_END + 51,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_LEVEL                                       = ObjectField.OBJECT_END + 52,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_EFFECTIVE_LEVEL                             = ObjectField.OBJECT_END + 53,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_CONTENT_TUNING_ID                           = ObjectField.OBJECT_END + 54,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_SCALING_LEVEL_MIN                           = ObjectField.OBJECT_END + 55,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_SCALING_LEVEL_MAX                           = ObjectField.OBJECT_END + 56,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_SCALING_LEVEL_DELTA                         = ObjectField.OBJECT_END + 57,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_SCALING_FACTION_GROUP                       = ObjectField.OBJECT_END + 58,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_SCALING_HEALTH_ITEM_LEVEL_CURVE_ID          = ObjectField.OBJECT_END + 59,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_SCALING_DAMAGE_ITEM_LEVEL_CURVE_ID          = ObjectField.OBJECT_END + 60,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_FACTIONTEMPLATE                             = ObjectField.OBJECT_END + 61,
        // ArraySize 3
        [UpdateField(UpdateFieldType.Int, 3)]
        UNIT_FIELD_62                                          = ObjectField.OBJECT_END + 62,
        [UpdateField(UpdateFieldType.Ushort)]
        UNIT_FIELD_63                                          = ObjectField.OBJECT_END + 63,
        [UpdateField(UpdateFieldType.Ushort)]
        UNIT_FIELD_64                                          = ObjectField.OBJECT_END + 64,

        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_FLAGS                                       = ObjectField.OBJECT_END + 71,
        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_FLAGS_2                                     = ObjectField.OBJECT_END + 72,
        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_FLAGS_3                                     = ObjectField.OBJECT_END + 73,
        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_AURASTATE                                   = ObjectField.OBJECT_END + 74,

        // ArraySize 2
        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_BASEATTACKTIME                              = ObjectField.OBJECT_END + 75,

        [UpdateField(UpdateFieldType.Uint, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_RANGEDATTACKTIME                            = ObjectField.OBJECT_END + 77,
        [UpdateField(UpdateFieldType.Float)]
        UNIT_FIELD_BOUNDINGRADIUS                              = ObjectField.OBJECT_END + 78,
        [UpdateField(UpdateFieldType.Float)]
        UNIT_FIELD_COMBATREACH                                 = ObjectField.OBJECT_END + 79,
        [UpdateField(UpdateFieldType.Float)]
        UNIT_FIELD_DISPLAY_SCALE                               = ObjectField.OBJECT_END + 80,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_NATIVEDISPLAYID                             = ObjectField.OBJECT_END + 81,
        [UpdateField(UpdateFieldType.Float)]
        UNIT_FIELD_NATIVE_X_DISPLAY_SCALE                      = ObjectField.OBJECT_END + 82,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_83                                          = ObjectField.OBJECT_END + 83,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_84                                          = ObjectField.OBJECT_END + 84,
        [UpdateField(UpdateFieldType.Float, UpdateFieldCreateFlag.Unk1 | UpdateFieldCreateFlag.Unk8)]
        UNIT_FIELD_MINDAMAGE                                   = ObjectField.OBJECT_END + 85,
        [UpdateField(UpdateFieldType.Float, UpdateFieldCreateFlag.Unk1 | UpdateFieldCreateFlag.Unk8)]
        UNIT_FIELD_MAXDAMAGE                                   = ObjectField.OBJECT_END + 86,
        [UpdateField(UpdateFieldType.Float, UpdateFieldCreateFlag.Unk1 | UpdateFieldCreateFlag.Unk8)]
        UNIT_FIELD_MINOFFHANDDAMGE                             = ObjectField.OBJECT_END + 87,
        [UpdateField(UpdateFieldType.Float, UpdateFieldCreateFlag.Unk1 | UpdateFieldCreateFlag.Unk8)]
        UNIT_FIELD_MAXOFFHANDDAMAGE                            = ObjectField.OBJECT_END + 88,
        [UpdateField(UpdateFieldType.Bytes)]
        UNIT_FIELD_BYTES_1                                     = ObjectField.OBJECT_END + 89,
        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_PETNUMBER                                   = ObjectField.OBJECT_END + 90,
        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_PET_NAME_TIMESTAMP                          = ObjectField.OBJECT_END + 91,
        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_PETEXPERIENCE                               = ObjectField.OBJECT_END + 92,
        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_PETNEXTLEVELEXP                             = ObjectField.OBJECT_END + 93,
        [UpdateField(UpdateFieldType.Float)]
        UNIT_FIELD_MOD_CAST_SPEED                              = ObjectField.OBJECT_END + 94,
        [UpdateField(UpdateFieldType.Float)]
        UNIT_FIELD_MOD_CAST_HASTE                              = ObjectField.OBJECT_END + 95,
        [UpdateField(UpdateFieldType.Float)]
        UNIT_FIELD_MOD_HASTE                                   = ObjectField.OBJECT_END + 96,
        [UpdateField(UpdateFieldType.Float)]
        UNIT_FIELD_MOD_RANGED_HASTE                            = ObjectField.OBJECT_END + 97,
        [UpdateField(UpdateFieldType.Float)]
        UNIT_FIELD_MOD_HASTE_REGEN                             = ObjectField.OBJECT_END + 98,
        [UpdateField(UpdateFieldType.Float)]
        UNIT_FIELD_MOD_TIME_RATE                               = ObjectField.OBJECT_END + 99,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_CREATED_BY_SPELL                            = ObjectField.OBJECT_END + 100,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_NPC_EMOTESTATE                              = ObjectField.OBJECT_END + 101,

        // ArraySize 4
        [UpdateField(UpdateFieldType.Int, 3, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_STAT                                        = ObjectField.OBJECT_END + 102,
        [UpdateField(UpdateFieldType.Int, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_POSSTAT                                     = ObjectField.OBJECT_END + 103,
        [UpdateField(UpdateFieldType.Int, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_NEGSTAT                                     = ObjectField.OBJECT_END + 104,

        // ArraySize 7
        [UpdateField(UpdateFieldType.Int, UpdateFieldCreateFlag.Unk1 | UpdateFieldCreateFlag.Unk8)]
        UNIT_FIELD_RESISTANCES                                 = ObjectField.OBJECT_END + 114,

        // ArraySize 7
        [UpdateField(UpdateFieldType.Int, 3, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_BONUS_RESISTANCE_MODS                       = ObjectField.OBJECT_END + 121,
        [UpdateField(UpdateFieldType.Int, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_POWER_COST_MODIFIER                         = ObjectField.OBJECT_END + 122,
        [UpdateField(UpdateFieldType.Float, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_POWER_COST_MULTIPLIER                       = ObjectField.OBJECT_END + 123,

        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_BASE_MANA                                   = ObjectField.OBJECT_END + 142,
        [UpdateField(UpdateFieldType.Int, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_BASE_HEALTH                                 = ObjectField.OBJECT_END + 143,
        [UpdateField(UpdateFieldType.Bytes)]
        UNIT_FIELD_BYTES_2                                     = ObjectField.OBJECT_END + 144,
        [UpdateField(UpdateFieldType.Int, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_ATTACK_POWER                                = ObjectField.OBJECT_END + 145,
        [UpdateField(UpdateFieldType.Int, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_ATTACK_POWER_MOD_POS                        = ObjectField.OBJECT_END + 146,
        [UpdateField(UpdateFieldType.Int, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_ATTACK_POWER_MOD_NEG                        = ObjectField.OBJECT_END + 147,
        [UpdateField(UpdateFieldType.Float, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_ATTACK_POWER_MULTIPLIER                     = ObjectField.OBJECT_END + 148,
        [UpdateField(UpdateFieldType.Int, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_RANGED_ATTACK_POWER                         = ObjectField.OBJECT_END + 149,
        [UpdateField(UpdateFieldType.Int, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_RANGED_ATTACK_POWER_MOD_POS                 = ObjectField.OBJECT_END + 150,
        [UpdateField(UpdateFieldType.Int, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_RANGED_ATTACK_POWER_MOD_NEG                 = ObjectField.OBJECT_END + 151,
        [UpdateField(UpdateFieldType.Float, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_RANGED_ATTACK_POWER_MULTIPLIER              = ObjectField.OBJECT_END + 152,
        [UpdateField(UpdateFieldType.Int, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_MAIN_HAND_WEAPON_ATTACK_POWER               = ObjectField.OBJECT_END + 153,
        [UpdateField(UpdateFieldType.Int, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_OFF_HAND_WEAPON_ATTACK_POWER                = ObjectField.OBJECT_END + 154,
        [UpdateField(UpdateFieldType.Int, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_RANGED_HAND_WEAPON_ATTACK_POWER             = ObjectField.OBJECT_END + 155,
        [UpdateField(UpdateFieldType.Int, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_ATTACK_SPEED_AURA                           = ObjectField.OBJECT_END + 156,
        [UpdateField(UpdateFieldType.Float, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_LIFESTEAL                                   = ObjectField.OBJECT_END + 157,
        [UpdateField(UpdateFieldType.Float, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_MINRANGEDDAMAGE                             = ObjectField.OBJECT_END + 158,
        [UpdateField(UpdateFieldType.Float, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_MAXRANGEDDAMAGE                             = ObjectField.OBJECT_END + 159,
        [UpdateField(UpdateFieldType.Float, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_160                                         = ObjectField.OBJECT_END + 160,
        [UpdateField(UpdateFieldType.Float, UpdateFieldCreateFlag.Unk1)]
        UNIT_FIELD_MAXHEALTHMODIFIER                           = ObjectField.OBJECT_END + 161,
        [UpdateField(UpdateFieldType.Float)]
        UNIT_FIELD_HOVERHEIGHT                                 = ObjectField.OBJECT_END + 162,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_163                                         = ObjectField.OBJECT_END + 163,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_164                                         = ObjectField.OBJECT_END + 164,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_165                                         = ObjectField.OBJECT_END + 165,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_166                                         = ObjectField.OBJECT_END + 166,
        [UpdateField(UpdateFieldType.Uint)]
        UNIT_FIELD_167                                         = ObjectField.OBJECT_END + 167,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_168                                         = ObjectField.OBJECT_END + 168,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_169                                         = ObjectField.OBJECT_END + 169,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_170                                         = ObjectField.OBJECT_END + 170,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_171                                         = ObjectField.OBJECT_END + 171,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_LOOK_AT_CONTROLLER_ID                       = ObjectField.OBJECT_END + 172,
        [UpdateField(UpdateFieldType.Int)]
        UNIT_FIELD_173                                         = ObjectField.OBJECT_END + 173,
        [UpdateField(UpdateFieldType.Guid)]
        UNIT_FIELD_GUILD_GUID                                  = ObjectField.OBJECT_END + 174,

        [UpdateField(UpdateFieldType.Int, true)]
        UNIT_DYNAMICFIELD_COUNT2                               = ObjectField.OBJECT_END + 175,
        [UpdateField(UpdateFieldType.Int, true)]
        UNIT_DYNAMICFIELD_COUNT3                               = ObjectField.OBJECT_END + 176,
        [UpdateField(UpdateFieldType.Int, true)]
        UNIT_DYNAMICFIELD_COUNT4                               = ObjectField.OBJECT_END + 177,

        //// DynamicField ArraySize UNIT_DYNAMICFIELD_COUNT2
        [UpdateField(UpdateFieldType.DynamicInt, 2)]
        UNIT_DYNAMIC_2                                         = ObjectField.OBJECT_END + 178,
        [UpdateField(UpdateFieldType.DynamicInt)]
        UNIT_DYNAMIC_3                                         = ObjectField.OBJECT_END + 179,

        //// DynamicField ArraySize UNIT_DYNAMICFIELD_COUNT3
        [UpdateField(UpdateFieldType.DynamicInt)]
        UNIT_DYNAMIC_4                                         = ObjectField.OBJECT_END + 180,

        //// DynamicField ArraySize UNIT_DYNAMICFIELD_COUNT4
        [UpdateField(UpdateFieldType.DynamicGuid)]
        UNIT_DYNAMIC_5                                         = ObjectField.OBJECT_END + 181,

        UNIT_FIELD_END                                         = ObjectField.OBJECT_END + 182,
    }

    public enum UnitDynamicField
    {
        UNIT_DYNAMIC_FIELD_PASSIVE_SPELLS                      = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x000, // Flags: PUBLIC, URGENT
        UNIT_DYNAMIC_FIELD_WORLD_EFFECTS                       = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x001, // Flags: PUBLIC, URGENT
        UNIT_DYNAMIC_FIELD_CHANNEL_OBJECTS                     = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x002, // Flags: PUBLIC, URGENT
        UNIT_DYNAMIC_END                                       = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x003,
    }

    public enum PlayerField
    {
        [UpdateField(UpdateFieldType.Guid)]
        PLAYER_FIELD_0                                         = UnitField.UNIT_FIELD_END + 0,
        [UpdateField(UpdateFieldType.Guid)]
        PLAYER_FIELD_1                                         = UnitField.UNIT_FIELD_END + 1,
        [UpdateField(UpdateFieldType.Guid)]
        PLAYER_FIELD_2                                         = UnitField.UNIT_FIELD_END + 2,
        [UpdateField(UpdateFieldType.Uint)]
        PLAYER_FIELD_3                                         = UnitField.UNIT_FIELD_END + 3,
        [UpdateField(UpdateFieldType.Uint)]
        PLAYER_FIELD_4                                         = UnitField.UNIT_FIELD_END + 4,
        [UpdateField(UpdateFieldType.Uint)]
        PLAYER_FIELD_5                                         = UnitField.UNIT_FIELD_END + 5,
        [UpdateField(UpdateFieldType.Uint)]
        PLAYER_FIELD_6                                         = UnitField.UNIT_FIELD_END + 6,
        [UpdateField(UpdateFieldType.Uint)]
        PLAYER_FIELD_7                                         = UnitField.UNIT_FIELD_END + 7,
        [UpdateField(UpdateFieldType.Bytes)]
        PLAYER_FIELD_8                                         = UnitField.UNIT_FIELD_END + 8,
        // ArraySize 3
        [UpdateField(UpdateFieldType.Byte)]
        PLAYER_FIELD_9                                         = UnitField.UNIT_FIELD_END + 9,

        [UpdateField(UpdateFieldType.Byte)]
        PLAYER_FIELD_12                                        = UnitField.UNIT_FIELD_END + 12,
        [UpdateField(UpdateFieldType.Byte)]
        PLAYER_FIELD_13                                        = UnitField.UNIT_FIELD_END + 13,
        [UpdateField(UpdateFieldType.Byte)]
        PLAYER_FIELD_14                                        = UnitField.UNIT_FIELD_END + 14,
        [UpdateField(UpdateFieldType.Byte)]
        PLAYER_FIELD_15                                        = UnitField.UNIT_FIELD_END + 15,
        [UpdateField(UpdateFieldType.Byte)]
        PLAYER_FIELD_16                                        = UnitField.UNIT_FIELD_END + 16,
        [UpdateField(UpdateFieldType.Byte)]
        PLAYER_FIELD_17                                        = UnitField.UNIT_FIELD_END + 17,
        [UpdateField(UpdateFieldType.Uint)]
        PLAYER_FIELD_18                                        = UnitField.UNIT_FIELD_END + 18,
        [UpdateField(UpdateFieldType.Int)]
        PLAYER_FIELD_19                                        = UnitField.UNIT_FIELD_END + 19,
        // Array ArraySize 100 with array in substructure
        [UpdateField(UpdateFieldType.Int, 28, UpdateFieldCreateFlag.Unk2)]
        PLAYER_FIELD_QUEST_ID                                  = UnitField.UNIT_FIELD_END + 20,
        [UpdateField(UpdateFieldType.Uint, UpdateFieldCreateFlag.Unk2)]
        PLAYER_FIELD_21                                        = UnitField.UNIT_FIELD_END + 21,
        [UpdateField(UpdateFieldType.Uint, UpdateFieldCreateFlag.Unk2)]
        PLAYER_FIELD_22                                        = UnitField.UNIT_FIELD_END + 22,
        [UpdateField(UpdateFieldType.Time, UpdateFieldCreateFlag.Unk2)]
        PLAYER_FIELD_QUEST_ACCEPTED                            = UnitField.UNIT_FIELD_END + 23,
        // SubstructureArray 24 members
        [UpdateField(UpdateFieldType.Ushort, 24, UpdateFieldCreateFlag.Unk2)]
        PLAYER_FIELD_24                                        = UnitField.UNIT_FIELD_END + 24,

        // ArraySize 19
        [UpdateField(UpdateFieldType.Uint, 3)]
        PLAYER_FIELD_2820                                      = UnitField.UNIT_FIELD_END + 2820,
        [UpdateField(UpdateFieldType.Ushort)]
        PLAYER_FIELD_2821                                      = UnitField.UNIT_FIELD_END + 2821,
        [UpdateField(UpdateFieldType.Ushort)]
        PLAYER_FIELD_2822                                      = UnitField.UNIT_FIELD_END + 2822,

        [UpdateField(UpdateFieldType.Int)]
        PLAYER_FIELD_2877                                      = UnitField.UNIT_FIELD_END + 2877,
        [UpdateField(UpdateFieldType.Int)]
        PLAYER_FIELD_2878                                      = UnitField.UNIT_FIELD_END + 2878,
        [UpdateField(UpdateFieldType.Uint)]
        PLAYER_FIELD_2879                                      = UnitField.UNIT_FIELD_END + 2879,
        [UpdateField(UpdateFieldType.Uint)]
        PLAYER_FIELD_2880                                      = UnitField.UNIT_FIELD_END + 2880,
        [UpdateField(UpdateFieldType.Int)]
        PLAYER_FIELD_2881                                      = UnitField.UNIT_FIELD_END + 2881,

        // ArraySize 4
        [UpdateField(UpdateFieldType.Float)]
        PLAYER_FIELD_2882                                      = UnitField.UNIT_FIELD_END + 2882,

        [UpdateField(UpdateFieldType.Byte)]
        PLAYER_FIELD_2886                                      = UnitField.UNIT_FIELD_END + 2886,
        [UpdateField(UpdateFieldType.Int)]
        PLAYER_FIELD_2887                                      = UnitField.UNIT_FIELD_END + 2887,
        [UpdateField(UpdateFieldType.Uint, true)]
        PLAYER_FIELD_2888                                      = UnitField.UNIT_FIELD_END + 2888,
        [UpdateField(UpdateFieldType.Int)]
        PLAYER_FIELD_2889                                      = UnitField.UNIT_FIELD_END + 2889,
        [UpdateField(UpdateFieldType.Int)]
        PLAYER_FIELD_2890                                      = UnitField.UNIT_FIELD_END + 2890,

        // DynamicArray
        [UpdateField(UpdateFieldType.DynamicInt, 7)]
        PLAYER_DYNAMIC_FIELD_0                                 = UnitField.UNIT_FIELD_END + 2891,
        [UpdateField(UpdateFieldType.DynamicInt)]
        PLAYER_DYNAMIC_FIELD_1                                 = UnitField.UNIT_FIELD_END + 2892,
        [UpdateField(UpdateFieldType.DynamicUint)]
        PLAYER_DYNAMIC_FIELD_2                                 = UnitField.UNIT_FIELD_END + 2893,
        [UpdateField(UpdateFieldType.DynamicUint)]
        PLAYER_DYNAMIC_FIELD_3                                 = UnitField.UNIT_FIELD_END + 2894,
        [UpdateField(UpdateFieldType.DynamicUint)]
        PLAYER_DYNAMIC_FIELD_4                                 = UnitField.UNIT_FIELD_END + 2895,
        [UpdateField(UpdateFieldType.DynamicInt)]
        PLAYER_DYNAMIC_FIELD_5                                 = UnitField.UNIT_FIELD_END + 2896,
        [UpdateField(UpdateFieldType.DynamicByte)]
        PLAYER_DYNAMIC_FIELD_6                                 = UnitField.UNIT_FIELD_END + 2897,

        PLAYER_END                                             = UnitField.UNIT_FIELD_END + 2898,

        /*PLAYER_DUEL_ARBITER                                    = UnitField.UNIT_FIELD_END + 0x000, // Size: 4, Flags: PUBLIC
        PLAYER_WOW_ACCOUNT                                     = UnitField.UNIT_FIELD_END + 0x004, // Size: 4, Flags: PUBLIC
        PLAYER_LOOT_TARGET_GUID                                = UnitField.UNIT_FIELD_END + 0x008, // Size: 4, Flags: PUBLIC
        PLAYER_FLAGS                                           = UnitField.UNIT_FIELD_END + 0x00C, // Size: 1, Flags: PUBLIC
        PLAYER_FLAGS_EX                                        = UnitField.UNIT_FIELD_END + 0x00D, // Size: 1, Flags: PUBLIC
        PLAYER_GUILDRANK                                       = UnitField.UNIT_FIELD_END + 0x00E, // Size: 1, Flags: PUBLIC
        PLAYER_GUILDDELETE_DATE                                = UnitField.UNIT_FIELD_END + 0x00F, // Size: 1, Flags: PUBLIC
        PLAYER_GUILDLEVEL                                      = UnitField.UNIT_FIELD_END + 0x010, // Size: 1, Flags: PUBLIC
        PLAYER_BYTES                                           = UnitField.UNIT_FIELD_END + 0x011, // Size: 1, Flags: PUBLIC
        PLAYER_BYTES_2                                         = UnitField.UNIT_FIELD_END + 0x012, // Size: 1, Flags: PUBLIC
        PLAYER_BYTES_3                                         = UnitField.UNIT_FIELD_END + 0x013, // Size: 1, Flags: PUBLIC
        PLAYER_BYTES_4                                         = UnitField.UNIT_FIELD_END + 0x014, // Size: 1, Flags: PUBLIC
        PLAYER_DUEL_TEAM                                       = UnitField.UNIT_FIELD_END + 0x015, // Size: 1, Flags: PUBLIC
        PLAYER_GUILD_TIMESTAMP                                 = UnitField.UNIT_FIELD_END + 0x016, // Size: 1, Flags: PUBLIC
        PLAYER_QUEST_LOG                                       = UnitField.UNIT_FIELD_END + 0x017, // Size: 1600, Flags: PARTY_MEMBER
        PLAYER_VISIBLE_ITEM                                    = UnitField.UNIT_FIELD_END + 0x657, // Size: 38, Flags: PUBLIC
        PLAYER_CHOSEN_TITLE                                    = UnitField.UNIT_FIELD_END + 0x67D, // Size: 1, Flags: PUBLIC
        PLAYER_FAKE_INEBRIATION                                = UnitField.UNIT_FIELD_END + 0x67E, // Size: 1, Flags: PUBLIC
        PLAYER_FIELD_VIRTUAL_PLAYER_REALM                      = UnitField.UNIT_FIELD_END + 0x67F, // Size: 1, Flags: PUBLIC
        PLAYER_FIELD_CURRENT_SPEC_ID                           = UnitField.UNIT_FIELD_END + 0x680, // Size: 1, Flags: PUBLIC
        PLAYER_FIELD_TAXI_MOUNT_ANIM_KIT_ID                    = UnitField.UNIT_FIELD_END + 0x681, // Size: 1, Flags: PUBLIC
        PLAYER_FIELD_AVG_ITEM_LEVEL                            = UnitField.UNIT_FIELD_END + 0x682, // Size: 4, Flags: PUBLIC
        PLAYER_FIELD_CURRENT_BATTLE_PET_BREED_QUALITY          = UnitField.UNIT_FIELD_END + 0x686, // Size: 1, Flags: PUBLIC
        PLAYER_FIELD_HONOR_LEVEL                               = UnitField.UNIT_FIELD_END + 0x687, // Size: 1, Flags: PUBLIC
        PLAYER_END                                             = UnitField.UNIT_FIELD_END + 0x688,*/
    }

    public enum PlayerDynamicField
    {
        PLAYER_DYNAMIC_FIELD_ARENA_COOLDOWNS                   = UnitDynamicField.UNIT_DYNAMIC_END + 0x000, // Flags: PUBLIC
        PLAYER_DYNAMIC_END                                     = UnitDynamicField.UNIT_DYNAMIC_END + 0x001,
    }

    /*public enum ActivePlayerField
    {
        ACTIVE_PLAYER_FIELD_INV_SLOT_HEAD                      = PlayerField.PLAYER_END + 0x000, // Size: 780, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_FARSIGHT                           = PlayerField.PLAYER_END + 0x30C, // Size: 4, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_SUMMONED_BATTLE_PET_ID             = PlayerField.PLAYER_END + 0x310, // Size: 4, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_KNOWN_TITLES                       = PlayerField.PLAYER_END + 0x314, // Size: 12, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_COINAGE                            = PlayerField.PLAYER_END + 0x320, // Size: 2, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_XP                                 = PlayerField.PLAYER_END + 0x322, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_NEXT_LEVEL_XP                      = PlayerField.PLAYER_END + 0x323, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_TRIAL_XP                           = PlayerField.PLAYER_END + 0x324, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_SKILL_LINEID                       = PlayerField.PLAYER_END + 0x325, // Size: 896, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_CHARACTER_POINTS                   = PlayerField.PLAYER_END + 0x6A5, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_MAX_TALENT_TIERS                   = PlayerField.PLAYER_END + 0x6A6, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_TRACK_CREATURES                    = PlayerField.PLAYER_END + 0x6A7, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_TRACK_RESOURCES                    = PlayerField.PLAYER_END + 0x6A8, // Size: 2, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_EXPERTISE                          = PlayerField.PLAYER_END + 0x6AA, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_OFFHAND_EXPERTISE                  = PlayerField.PLAYER_END + 0x6AB, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_RANGED_EXPERTISE                   = PlayerField.PLAYER_END + 0x6AC, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_COMBAT_RATING_EXPERTISE            = PlayerField.PLAYER_END + 0x6AD, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_BLOCK_PERCENTAGE                   = PlayerField.PLAYER_END + 0x6AE, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_DODGE_PERCENTAGE                   = PlayerField.PLAYER_END + 0x6AF, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_DODGE_PERCENTAGE_FROM_ATTRIBUTE    = PlayerField.PLAYER_END + 0x6B0, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_PARRY_PERCENTAGE                   = PlayerField.PLAYER_END + 0x6B1, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_PARRY_PERCENTAGE_FROM_ATTRIBUTE    = PlayerField.PLAYER_END + 0x6B2, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_CRIT_PERCENTAGE                    = PlayerField.PLAYER_END + 0x6B3, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_RANGED_CRIT_PERCENTAGE             = PlayerField.PLAYER_END + 0x6B4, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_OFFHAND_CRIT_PERCENTAGE            = PlayerField.PLAYER_END + 0x6B5, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_SPELL_CRIT_PERCENTAGE1             = PlayerField.PLAYER_END + 0x6B6, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_SHIELD_BLOCK                       = PlayerField.PLAYER_END + 0x6B7, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_SHIELD_BLOCK_CRIT_PERCENTAGE       = PlayerField.PLAYER_END + 0x6B8, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_MASTERY                            = PlayerField.PLAYER_END + 0x6B9, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_SPEED                              = PlayerField.PLAYER_END + 0x6BA, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_AVOIDANCE                          = PlayerField.PLAYER_END + 0x6BB, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_STURDINESS                         = PlayerField.PLAYER_END + 0x6BC, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_VERSATILITY                        = PlayerField.PLAYER_END + 0x6BD, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_VERSATILITY_BONUS                  = PlayerField.PLAYER_END + 0x6BE, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_PVP_POWER_DAMAGE                   = PlayerField.PLAYER_END + 0x6BF, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_PVP_POWER_HEALING                  = PlayerField.PLAYER_END + 0x6C0, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_EXPLORED_ZONES                     = PlayerField.PLAYER_END + 0x6C1, // Size: 320, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_REST_INFO                          = PlayerField.PLAYER_END + 0x801, // Size: 4, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_MOD_DAMAGE_DONE_POS                = PlayerField.PLAYER_END + 0x805, // Size: 7, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_MOD_DAMAGE_DONE_NEG                = PlayerField.PLAYER_END + 0x80C, // Size: 7, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_MOD_DAMAGE_DONE_PCT                = PlayerField.PLAYER_END + 0x813, // Size: 7, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_MOD_HEALING_DONE_POS               = PlayerField.PLAYER_END + 0x81A, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_MOD_HEALING_PCT                    = PlayerField.PLAYER_END + 0x81B, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_MOD_HEALING_DONE_PCT               = PlayerField.PLAYER_END + 0x81C, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_MOD_PERIODIC_HEALING_DONE_PERCENT  = PlayerField.PLAYER_END + 0x81D, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_WEAPON_DMG_MULTIPLIERS             = PlayerField.PLAYER_END + 0x81E, // Size: 3, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_WEAPON_ATK_SPEED_MULTIPLIERS       = PlayerField.PLAYER_END + 0x821, // Size: 3, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_MOD_SPELL_POWER_PCT                = PlayerField.PLAYER_END + 0x824, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_MOD_RESILIENCE_PERCENT             = PlayerField.PLAYER_END + 0x825, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_OVERRIDE_SPELL_POWER_BY_AP_PCT     = PlayerField.PLAYER_END + 0x826, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_OVERRIDE_AP_BY_SPELL_POWER_PERCENT = PlayerField.PLAYER_END + 0x827, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_MOD_TARGET_RESISTANCE              = PlayerField.PLAYER_END + 0x828, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_MOD_TARGET_PHYSICAL_RESISTANCE     = PlayerField.PLAYER_END + 0x829, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_LOCAL_FLAGS                        = PlayerField.PLAYER_END + 0x82A, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_BYTES                              = PlayerField.PLAYER_END + 0x82B, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_PVP_MEDALS                         = PlayerField.PLAYER_END + 0x82C, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_BUYBACK_PRICE                      = PlayerField.PLAYER_END + 0x82D, // Size: 12, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_BUYBACK_TIMESTAMP                  = PlayerField.PLAYER_END + 0x839, // Size: 12, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_KILLS                              = PlayerField.PLAYER_END + 0x845, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_LIFETIME_HONORABLE_KILLS           = PlayerField.PLAYER_END + 0x846, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_WATCHED_FACTION_INDEX              = PlayerField.PLAYER_END + 0x847, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_COMBAT_RATING                      = PlayerField.PLAYER_END + 0x848, // Size: 32, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_ARENA_TEAM_INFO                    = PlayerField.PLAYER_END + 0x868, // Size: 54, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_MAX_LEVEL                          = PlayerField.PLAYER_END + 0x89E, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_SCALING_PLAYER_LEVEL_DELTA         = PlayerField.PLAYER_END + 0x89F, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_MAX_CREATURE_SCALING_LEVEL         = PlayerField.PLAYER_END + 0x8A0, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_NO_REAGENT_COST                    = PlayerField.PLAYER_END + 0x8A1, // Size: 4, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_PET_SPELL_POWER                    = PlayerField.PLAYER_END + 0x8A5, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_PROFESSION_SKILL_LINE              = PlayerField.PLAYER_END + 0x8A6, // Size: 2, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_UI_HIT_MODIFIER                    = PlayerField.PLAYER_END + 0x8A8, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_UI_SPELL_HIT_MODIFIER              = PlayerField.PLAYER_END + 0x8A9, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_HOME_REALM_TIME_OFFSET             = PlayerField.PLAYER_END + 0x8AA, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_MOD_PET_HASTE                      = PlayerField.PLAYER_END + 0x8AB, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_BYTES2                             = PlayerField.PLAYER_END + 0x8AC, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_BYTES3                             = PlayerField.PLAYER_END + 0x8AD, // Size: 1, Flags: PUBLIC, URGENT_SELF_ONLY
        ACTIVE_PLAYER_FIELD_LFG_BONUS_FACTION_ID               = PlayerField.PLAYER_END + 0x8AE, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_LOOT_SPEC_ID                       = PlayerField.PLAYER_END + 0x8AF, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_OVERRIDE_ZONE_PVP_TYPE             = PlayerField.PLAYER_END + 0x8B0, // Size: 1, Flags: PUBLIC, URGENT_SELF_ONLY
        ACTIVE_PLAYER_FIELD_BAG_SLOT_FLAGS                     = PlayerField.PLAYER_END + 0x8B1, // Size: 4, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_BANK_BAG_SLOT_FLAGS                = PlayerField.PLAYER_END + 0x8B5, // Size: 7, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_INSERT_ITEMS_LEFT_TO_RIGHT         = PlayerField.PLAYER_END + 0x8BC, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_QUEST_COMPLETED                    = PlayerField.PLAYER_END + 0x8BD, // Size: 1750, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_HONOR                              = PlayerField.PLAYER_END + 0xF93, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_HONOR_NEXT_LEVEL                   = PlayerField.PLAYER_END + 0xF94, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_PVP_TIER_MAX_FROM_WINS             = PlayerField.PLAYER_END + 0xF95, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_FIELD_PVP_LAST_WEEKS_TIER_MAX_FROM_WINS  = PlayerField.PLAYER_END + 0xF96, // Size: 1, Flags: PUBLIC
        ACTIVE_PLAYER_END                                      = PlayerField.PLAYER_END + 0xF97,
    }*/

    public enum ActivePlayerDynamicField
    {
        ACTIVE_PLAYER_DYNAMIC_FIELD_RESERACH_SITE              = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x000, // Flags: PUBLIC
        ACTIVE_PLAYER_DYNAMIC_FIELD_RESEARCH_SITE_PROGRESS     = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x001, // Flags: PUBLIC
        ACTIVE_PLAYER_DYNAMIC_FIELD_DAILY_QUESTS               = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x002, // Flags: PUBLIC
        ACTIVE_PLAYER_DYNAMIC_FIELD_AVAILABLE_QUEST_LINE_X_QUEST_ID = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x003, // Flags: PUBLIC
        ACTIVE_PLAYER_DYNAMIC_FIELD_HEIRLOOMS                  = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x005, // Flags: PUBLIC
        ACTIVE_PLAYER_DYNAMIC_FIELD_HEIRLOOM_FLAGS             = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x006, // Flags: PUBLIC
        ACTIVE_PLAYER_DYNAMIC_FIELD_TOYS                       = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x007, // Flags: PUBLIC
        ACTIVE_PLAYER_DYNAMIC_FIELD_TRANSMOG                   = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x008, // Flags: PUBLIC
        ACTIVE_PLAYER_DYNAMIC_FIELD_CONDITIONAL_TRANSMOG       = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x009, // Flags: PUBLIC
        ACTIVE_PLAYER_DYNAMIC_FIELD_SELF_RES_SPELLS            = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x00A, // Flags: PUBLIC
        ACTIVE_PLAYER_DYNAMIC_FIELD_CHARACTER_RESTRICTIONS     = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x00B, // Flags: PUBLIC
        ACTIVE_PLAYER_DYNAMIC_FIELD_SPELL_PCT_MOD_BY_LABEL     = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x00C, // Flags: PUBLIC
        ACTIVE_PLAYER_DYNAMIC_FIELD_SPELL_FLAT_MOD_BY_LABEL    = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x00D, // Flags: PUBLIC
        ACTIVE_PLAYER_DYNAMIC_FIELD_RESERACH                   = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x00E, // Flags: PUBLIC
        ACTIVE_PLAYER_DYNAMIC_END                              = PlayerDynamicField.PLAYER_DYNAMIC_END + 0x00F,
    }

    public enum GameObjectField
    {
        [UpdateField(UpdateFieldType.Int)]
        GAMEOBJECT_DISPLAYID                                   = ObjectField.OBJECT_END + 0,
        GAMEOBJECT_SPELL_VISUAL_ID                             = ObjectField.OBJECT_END + 1,
        GAMEOBJECT_STATE_SPELL_VISUAL_ID                       = ObjectField.OBJECT_END + 2,
        GAMEOBJECT_STATE_ANIM_ID                               = ObjectField.OBJECT_END + 3,
        GAMEOBJECT_STATE_ANIM_KIT_ID                           = ObjectField.OBJECT_END + 4,
        [UpdateField(UpdateFieldType.Uint, true)]
        GAMEOBJECT_DYNAMIC_COUNT_1                             = ObjectField.OBJECT_END + 5,
        GAMEOBJECT_STATE_WORLD_EFFECT_ID                       = ObjectField.OBJECT_END + 6,
        [UpdateField(UpdateFieldType.DynamicUint)]
        GAMEOBJECT_DYNAMIC_ENABLE_DOODAD_SETS                  = ObjectField.OBJECT_END + 7,
        [UpdateField(UpdateFieldType.Guid)]
        GAMEOBJECT_FIELD_CREATED_BY                            = ObjectField.OBJECT_END + 8,
        [UpdateField(UpdateFieldType.Guid)]
        GAMEOBJECT_FIELD_GUILD_GUID                            = ObjectField.OBJECT_END + 9,
        GAMEOBJECT_FLAGS                                       = ObjectField.OBJECT_END + 10,
        [UpdateField(UpdateFieldType.Float)]
        GAMEOBJECT_PARENTROTATION                              = ObjectField.OBJECT_END + 11,
        [UpdateField(UpdateFieldType.Int)]
        GAMEOBJECT_FACTION                                     = ObjectField.OBJECT_END + 15,
        [UpdateField(UpdateFieldType.Int)]
        GAMEOBJECT_LEVEL                                       = ObjectField.OBJECT_END + 16,
        GAMEOBJECT_BYTES_1                                     = ObjectField.OBJECT_END + 17,
        [UpdateField(UpdateFieldType.Uint, true)]
        GAMEOBJECT_DYNAMIC_COUNT_2                             = ObjectField.OBJECT_END + 18,
        GAMEOBJECT_FIELD_CUSTOM_PARAM                          = ObjectField.OBJECT_END + 19,
        [UpdateField(UpdateFieldType.DynamicUint)]
        GAMEOBJECT_DYNAMIC_UNKNOWN                             = ObjectField.OBJECT_END + 20,
        GAMEOBJECT_END                                         = ObjectField.OBJECT_END + 21,
    }

    public enum GameObjectDynamicField
    {
        GAMEOBJECT_DYNAMIC_ENABLE_DOODAD_SETS                  = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x000,
        GAMEOBJECT_DYNAMIC_END                                 = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x001,
    }

    public enum DynamicObjectField
    {
        DYNAMICOBJECT_CASTER                                   = ObjectField.OBJECT_END + 0x000, // Size: 4, Flags: PUBLIC
        DYNAMICOBJECT_TYPE                                     = ObjectField.OBJECT_END + 0x004, // Size: 1, Flags: PUBLIC
        DYNAMICOBJECT_SPELL_X_SPELL_VISUAL_ID                  = ObjectField.OBJECT_END + 0x005, // Size: 1, Flags: PUBLIC
        DYNAMICOBJECT_SPELLID                                  = ObjectField.OBJECT_END + 0x006, // Size: 1, Flags: PUBLIC
        DYNAMICOBJECT_RADIUS                                   = ObjectField.OBJECT_END + 0x007, // Size: 1, Flags: PUBLIC
        DYNAMICOBJECT_CASTTIME                                 = ObjectField.OBJECT_END + 0x008, // Size: 1, Flags: PUBLIC
        DYNAMICOBJECT_END                                      = ObjectField.OBJECT_END + 0x009,
    }

    public enum DynamicObjectDynamicField
    {
        DYNAMICOBJECT_DYNAMIC_END                              = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x000,
    }

    public enum CorpseField
    {
        [UpdateField(UpdateFieldType.Uint)]
        CORPSE_FIELD_0                                         = ObjectField.OBJECT_END + 0,
        [UpdateField(UpdateFieldType.Guid)]
        CORPSE_FIELD_OWNER                                     = ObjectField.OBJECT_END + 1,
        [UpdateField(UpdateFieldType.Guid)]
        CORPSE_FIELD_PARTY                                     = ObjectField.OBJECT_END + 2,
        [UpdateField(UpdateFieldType.Guid)]
        CORPSE_FIELD_GUILD_GUID                                = ObjectField.OBJECT_END + 3,
        [UpdateField(UpdateFieldType.Uint)]
        CORPSE_FIELD_4                                         = ObjectField.OBJECT_END + 4,
        [UpdateField(UpdateFieldType.Uint)]
        CORPSE_FIELD_ITEM                                      = ObjectField.OBJECT_END + 5,
        [UpdateField(UpdateFieldType.Bytes)]
        CORPSE_FIELD_BYTES_1                                   = ObjectField.OBJECT_END + 24,
        [UpdateField(UpdateFieldType.Bytes)]
        CORPSE_FIELD_BYTES_2                                   = ObjectField.OBJECT_END + 25,
        [UpdateField(UpdateFieldType.Uint)]
        CORPSE_FIELD_26                                        = ObjectField.OBJECT_END + 26,
        [UpdateField(UpdateFieldType.Int)]
        CORPSE_FIELD_27                                        = ObjectField.OBJECT_END + 27,
        [UpdateField(UpdateFieldType.Byte)]
        CORPSE_FIELD_30                                        = ObjectField.OBJECT_END + 28,

        CORPSE_END                                             = ObjectField.OBJECT_END + 31,

        /*CORPSE_FIELD_DISPLAY_ID                                = ObjectField.OBJECT_END + 0x00C, // Size: 1, Flags: PUBLIC
        CORPSE_FIELD_FLAGS                                     = ObjectField.OBJECT_END + 0x022, // Size: 1, Flags: PUBLIC
        CORPSE_FIELD_DYNAMIC_FLAGS                             = ObjectField.OBJECT_END + 0x023, // Size: 1, Flags: DYNAMIC
        CORPSE_FIELD_FACTIONTEMPLATE                           = ObjectField.OBJECT_END + 0x024, // Size: 1, Flags: PUBLIC
        CORPSE_FIELD_CUSTOM_DISPLAY_OPTION                     = ObjectField.OBJECT_END + 0x025, // Size: 1, Flags: PUBLIC*/
    }

    public enum CorpseDynamicField
    {
        CORPSE_DYNAMIC_END                                     = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x000,
    }

    public enum AreaTriggerField
    {
        [UpdateField(UpdateFieldType.Uint)]
        AREATRIGGER_OVERRIDE_SCALE_CURVE_UINT_1                = ObjectField.OBJECT_END + 0,
        // ArraySize2
        [UpdateField(UpdateFieldType.Float, 2)]
        AREATRIGGER_OVERRIDE_SCALE_FLOAT_1                     = ObjectField.OBJECT_END + 1,
        [UpdateField(UpdateFieldType.Float)]
        AREATRIGGER_OVERRIDE_SCALE_FLOAT_2                     = ObjectField.OBJECT_END + 2,

        [UpdateField(UpdateFieldType.Uint)]
        AREATRIGGER_OVERRIDE_SCALE_CURVE_UINT_2                = ObjectField.OBJECT_END + 5,
        //2 ReadBit
        [UpdateField(UpdateFieldType.Byte)]
        AREATRIGGER_OVERRIDE_SCALE_CURVE_BITS                  = ObjectField.OBJECT_END + 6,
        [UpdateField(UpdateFieldType.Guid)]
        AREATRIGGER_CASTER                                     = ObjectField.OBJECT_END + 7,
        [UpdateField(UpdateFieldType.Uint)]
        AREATRIGGER_DURATION                                   = ObjectField.OBJECT_END + 8,
        [UpdateField(UpdateFieldType.Uint)]
        AREATRIGGER_TIME_TO_TARGET                             = ObjectField.OBJECT_END + 9,
        [UpdateField(UpdateFieldType.Uint)]
        AREATRIGGER_TIME_TO_TARGET_SCALE                       = ObjectField.OBJECT_END + 10,
        [UpdateField(UpdateFieldType.Uint)]
        AREATRIGGER_TIME_TO_TARGET_EXTRA_SCALE                 = ObjectField.OBJECT_END + 11,
        [UpdateField(UpdateFieldType.Int)]
        AREATRIGGER_SPELLID                                    = ObjectField.OBJECT_END + 12,
        [UpdateField(UpdateFieldType.Int)]
        AREATRIGGER_SPELL_FOR_VISUALS                          = ObjectField.OBJECT_END + 13,
        [UpdateField(UpdateFieldType.Int)]
        AREATRIGGER_SPELL_X_SPELL_VISUAL_ID                    = ObjectField.OBJECT_END + 14,
        [UpdateField(UpdateFieldType.Float)]
        AREATRIGGER_BOUNDS_RADIUS_2D                           = ObjectField.OBJECT_END + 15,
        [UpdateField(UpdateFieldType.Uint)]
        AREATRIGGER_DECAL_PROPERTIES_ID                        = ObjectField.OBJECT_END + 16,
        [UpdateField(UpdateFieldType.Guid)]
        AREATRIGGER_CREATING_EFFECT_GUID                       = ObjectField.OBJECT_END + 17,
        [UpdateField(UpdateFieldType.Uint)]
        AREATRIGGER_EXTRA_SCALE_CURVE_UINT_1                   = ObjectField.OBJECT_END + 18,
        // ArraySize2
        [UpdateField(UpdateFieldType.Float, 2)]
        AREATRIGGER_EXTRA_SCALE_CURVE_FLOAT_1                  = ObjectField.OBJECT_END + 19,
        [UpdateField(UpdateFieldType.Float)]
        AREATRIGGER_EXTRA_SCALE_CURVE_FLOAT_2                  = ObjectField.OBJECT_END + 20,

        [UpdateField(UpdateFieldType.Uint)]
        AREATRIGGER_EXTRA_SCALE_CURVE_UINT2                    = ObjectField.OBJECT_END + 23,
        // 2 ReadBit
        [UpdateField(UpdateFieldType.Byte)]
        AREATRIGGER_EXTRA_SCALE_CURVE_BITS                     = ObjectField.OBJECT_END + 24,

        AREATRIGGER_END                                        = ObjectField.OBJECT_END + 25,
    }

    public enum AreaTriggerDynamicField
    {
        AREATRIGGER_DYNAMIC_END                                = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x000,
    }

    public enum SceneObjectField
    {
        SCENEOBJECT_FIELD_SCRIPT_PACKAGE_ID                    = ObjectField.OBJECT_END + 0x000, // Size: 1, Flags: PUBLIC
        SCENEOBJECT_FIELD_RND_SEED_VAL                         = ObjectField.OBJECT_END + 0x001, // Size: 1, Flags: PUBLIC
        SCENEOBJECT_FIELD_CREATEDBY                            = ObjectField.OBJECT_END + 0x002, // Size: 4, Flags: PUBLIC
        SCENEOBJECT_FIELD_SCENE_TYPE                           = ObjectField.OBJECT_END + 0x006, // Size: 1, Flags: PUBLIC
        SCENEOBJECT_END                                        = ObjectField.OBJECT_END + 0x007,
    }

    public enum SceneObjectDynamicField
    {
        SCENEOBJECT_DYNAMIC_END                                = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x000,
    }

    public enum ConversationField
    {
        [UpdateField(UpdateFieldType.Uint, true)]
        CONVERSATION_FIELD_DYNAMIC_COUNT_1                     = ObjectField.OBJECT_END + 0,
        [UpdateField(UpdateFieldType.Int)]
        CONVERSATION_LAST_LINE_END_TIME                        = ObjectField.OBJECT_END + 1,
        // DynamicArray Size CONVERSATION_FIELD_DYNAMIC_COUNT_1
        [UpdateField(UpdateFieldType.DynamicInt, 5)]
        CONVERSATION_DYNAMIC_FIELD_1                           = ObjectField.OBJECT_END + 2,
        [UpdateField(UpdateFieldType.DynamicUint)]
        CONVERSATION_DYNAMIC_FIELD_2                           = ObjectField.OBJECT_END + 3,
        [UpdateField(UpdateFieldType.DynamicInt)]
        CONVERSATION_DYNAMIC_FIELD_3                           = ObjectField.OBJECT_END + 4,
        [UpdateField(UpdateFieldType.DynamicByte)]
        CONVERSATION_DYNAMIC_FIELD_4                           = ObjectField.OBJECT_END + 5,
        [UpdateField(UpdateFieldType.DynamicByte)]
        CONVERSATION_DYNAMIC_FIELD_5                           = ObjectField.OBJECT_END + 6,

        [UpdateField(UpdateFieldType.Uint, true)]
        CONVERSATION_FIELD_DYNAMIC_COUNT_2                     = ObjectField.OBJECT_END + 7,
        // DynamicArray Size CONVERSATION_FIELD_DYNAMIC_COUNT_2
        [UpdateField(UpdateFieldType.DynamicUint, 5)]
        CONVERSATION_DYNAMIC_FIELD_6                           = ObjectField.OBJECT_END + 8,
        [UpdateField(UpdateFieldType.DynamicUint)]
        CONVERSATION_DYNAMIC_FIELD_7                           = ObjectField.OBJECT_END + 9,
        [UpdateField(UpdateFieldType.DynamicGuid)]
        CONVERSATION_DYNAMIC_FIELD_8                           = ObjectField.OBJECT_END + 10,
        [UpdateField(UpdateFieldType.DynamicInt)]
        CONVERSATION_DYNAMIC_FIELD_9                           = ObjectField.OBJECT_END + 11,
        // 2 ReadBit
        [UpdateField(UpdateFieldType.DynamicCustom)]
        CONVERSATION_DYNAMIC_FIELD_10                          = ObjectField.OBJECT_END + 12,

        CONVERSATION_END                                       = ObjectField.OBJECT_END + 13,
    }

    public enum ConversationDynamicField
    {
        CONVERSATION_DYNAMIC_FIELD_ACTORS                      = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x000, // Flags: PUBLIC
        CONVERSATION_DYNAMIC_FIELD_LINES                       = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x001, // Flags: 0x100
        CONVERSATION_DYNAMIC_END                               = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x002,
    }

    // ReSharper restore InconsistentNaming
}
