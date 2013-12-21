﻿using System;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using CoreParsers = WowPacketParser.Parsing.Parsers;

namespace WowPacketParserModule.V5_4_2_17658.Parsers
{
    public static class MovementHandler
    {

        [Parser(Opcode.SMSG_PLAYER_MOVE)]
        public static void HandlePlayerMove(Packet packet)
        {
            var pos = new Vector4();
            var guid = new byte[8];
            var transportGUID = new byte[8];

            guid[7] = packet.ReadBit();

            var hasExtraMovementFlags = !packet.ReadBit();
            var hasPitch = !packet.ReadBit();
            var hasSplineElevation = !packet.ReadBit();
            var bit95 = packet.ReadBit();
            var isAlive = !packet.ReadBit();

            guid[6] = packet.ReadBit();

            var bit94 = packet.ReadBit();

            guid[0] = packet.ReadBit();

            var hasTransportData = packet.ReadBit();

            bool hasTransportTime2 = false;
            bool hasTransportTime3 = false;

            if (hasTransportData)
            {
                transportGUID[4] = packet.ReadBit();
                transportGUID[1] = packet.ReadBit();
                transportGUID[6] = packet.ReadBit();
                transportGUID[0] = packet.ReadBit();
                hasTransportTime2 = packet.ReadBit();
                hasTransportTime3 = packet.ReadBit();
                transportGUID[2] = packet.ReadBit();
                transportGUID[7] = packet.ReadBit();
                transportGUID[3] = packet.ReadBit();
                transportGUID[5] = packet.ReadBit();
            }

            guid[4] = packet.ReadBit();
            var hasMovementFlags = !packet.ReadBit();
            guid[5] = packet.ReadBit();
            guid[3] = packet.ReadBit();
            var hasOrientation = !packet.ReadBit();
            guid[1] = packet.ReadBit();
            var hasTimeStamp = !packet.ReadBit();
            guid[2] = packet.ReadBit();
            var bits98 = (int)packet.ReadBits(22);

            if (hasExtraMovementFlags)
                packet.ReadEnum<MovementFlagExtra>("Extra Movement Flags", 13);

            var bitAC = packet.ReadBit();

            if (hasMovementFlags)
                packet.ReadEnum<MovementFlag>("Movement Flags", 30);

            var hasFallData = packet.ReadBit();
            
            var hasFallDirection = false;
            if (hasFallData)
                hasFallDirection = packet.ReadBit();

            if (hasFallData)
            {
                if (hasFallDirection)
                {
                    packet.ReadSingle("Horizontal Speed");
                    packet.ReadSingle("Fall Sin");
                    packet.ReadSingle("Fall Cos");
                }

                packet.ReadInt32("Fall Time");
                packet.ReadSingle("Velocity Speed");
            }

            if (hasTransportData)
            {
                var transPos = new Vector4();

                packet.ReadXORByte(transportGUID, 1);

                transPos.Y = packet.ReadSingle();

                if (hasTransportTime2)
                    packet.ReadInt32("Transport Time 2");

                packet.ReadXORByte(transportGUID, 5);

                transPos.X = packet.ReadSingle();
                packet.ReadByte("Seat");
                packet.ReadInt32("Transport Time");

                packet.ReadXORByte(transportGUID, 3);
                packet.ReadXORByte(transportGUID, 6);

                transPos.O = packet.ReadSingle();
                transPos.Z = packet.ReadSingle();

                if (hasTransportTime3)
                    packet.ReadInt32("Transport Time 3");

                packet.ReadXORByte(transportGUID, 7);
                packet.ReadXORByte(transportGUID, 4);
                packet.ReadXORByte(transportGUID, 2);
                packet.ReadXORByte(transportGUID, 0);
                
                packet.WriteGuid("Transport Guid", transportGUID);
                packet.WriteLine("Transport Position {0}", transPos);
            }

            packet.ReadXORByte(guid, 3);

            pos.Y = packet.ReadSingle();

            if (hasPitch)
                packet.ReadSingle("Pitch");

            for (var i = 0; i < bits98; ++i)
                packet.ReadInt32("IntEA", i);

            packet.ReadXORByte(guid, 5);
            packet.ReadXORByte(guid, 0);
            packet.ReadXORByte(guid, 7);
            packet.ReadXORByte(guid, 6);

            if (hasTimeStamp)
                packet.ReadInt32("Timestamp");

            pos.Z = packet.ReadSingle();

            if (hasSplineElevation)
                packet.ReadSingle("Spline Elevation");

            packet.ReadXORByte(guid, 1);

            if (isAlive)
                packet.ReadInt32("time(isAlive)");

            pos.X = packet.ReadSingle();

            if (hasOrientation)
                pos.O = packet.ReadSingle();

            packet.ReadXORByte(guid, 2);
            packet.ReadXORByte(guid, 4);

            packet.WriteGuid("Guid", guid);
            packet.WriteLine("Position: {0}", pos);
        }

        [Parser(Opcode.SMSG_MONSTER_MOVE)]
        public static void HandleMonsterMove(Packet packet)
        {
            var pos = new Vector3();

            var guid2 = new byte[8];
            var factingTargetGUID = new byte[8];
            var ownerGUID = new byte[8];

            ownerGUID[4] = packet.ReadBit();

            var bit40 = !packet.ReadBit();
            var hasTime = !packet.ReadBit();

            ownerGUID[3] = packet.ReadBit();

            var bit30 = !packet.ReadBit();

            packet.ReadBit(); // fake bit

            var splineCount = (int)packet.ReadBits(20);
            var bit98 = packet.ReadBit();
            var splineType = (int)packet.ReadBits(3);
            
            if (splineType == 3)
                packet.StartBitStream(factingTargetGUID, 0, 7, 3, 4, 5, 6, 1, 2);

            var bit55 = !packet.ReadBit();
            var bit60 = !packet.ReadBit();
            var bit54 = !packet.ReadBit();
            var bit34 = !packet.ReadBit();

            ownerGUID[6] = packet.ReadBit();
            ownerGUID[1] = packet.ReadBit();
            ownerGUID[0] = packet.ReadBit();

            packet.StartBitStream(guid2, 1, 3, 4, 5, 6, 0, 7, 2);

            ownerGUID[5] = packet.ReadBit();
            var bit20 = packet.ReadBit();
            ownerGUID[7] = packet.ReadBit();
            var bit2D = !packet.ReadBit();

            var bits84 = 0u;
            if (bit98)
            {
                packet.ReadBits("bits74", 2);
                bits84 = packet.ReadBits(22);
            }

            var hasFlags = !packet.ReadBit();
            ownerGUID[2] = packet.ReadBit();
            var bits64 = (int)packet.ReadBits(22);
            var bit0 = !packet.ReadBit();
            packet.ReadSingle("Float14");
            
            if (splineType == 3)
            {
                packet.ParseBitStream(factingTargetGUID, 1, 6, 4, 3, 5, 0, 2, 7);
                packet.WriteGuid("Facting Target GUID", factingTargetGUID);
            }

            packet.ReadXORByte(ownerGUID, 5);
            if (bit54)
                packet.ReadByte("Byte54");
            packet.ReadXORByte(ownerGUID, 4);
            if (bit98)
            {
                packet.ReadSingle("Float88");
                for (var i = 0; i < bits84; ++i)
                {
                    packet.ReadInt16("short74+2", i);
                    packet.ReadInt16("short74+0", i);
                }

                packet.ReadInt16("Int8C");
                packet.ReadInt16("Int94");
                packet.ReadSingle("Float90");
            }

            if (hasFlags)
                packet.ReadEnum<SplineFlag434>("Spline Flags", TypeCode.Int32);

            if (bit40)
                packet.ReadInt32("Int40");

            if (bit2D)
                packet.ReadByte("Byte2D");

            Vector3 endpos = new Vector3();
            for (var i = 0; i < splineCount; ++i)
            {
                var spot = new Vector3
                {
                    Y = packet.ReadSingle(),
                    X = packet.ReadSingle(),
                    Z = packet.ReadSingle(),
                };
                // client always taking first point
                if (i == 0)
                {
                    endpos = spot;
                }

                packet.WriteLine("[{0}] Spline Waypoint: {1}", i, spot);
            }

            packet.ParseBitStream(guid2, 6, 7, 2, 5, 3, 4, 1, 0);

            if (bit55)
                packet.ReadByte("Byte55");

            packet.ReadInt32("Move Ticks");

            packet.ReadXORByte(ownerGUID, 0);

            if (splineType == 4)
                packet.ReadSingle("Facing Angle");

            pos.Y = packet.ReadSingle();

            if (bit0)
                packet.ReadSingle("Float3C");

            packet.ReadXORByte(ownerGUID, 7);
            packet.ReadXORByte(ownerGUID, 1);

            var waypoints = new Vector3[bits64];
            for (var i = 0; i < bits64; ++i)
            {
                var vec = packet.ReadPackedVector3();
                waypoints[i].X = vec.X;
                waypoints[i].Y = vec.Y;
                waypoints[i].Z = vec.Z;
            }

            if (splineType == 2)
            {
                packet.ReadSingle("FloatA8");
                packet.ReadSingle("FloatAC");
                packet.ReadSingle("FloatB0");
            }

            if (hasTime)
                packet.ReadInt32("Move Time in ms");

            if (bit30)
                packet.ReadInt32("Int30");

            packet.ReadXORByte(ownerGUID, 6);
            packet.ReadSingle("Float1C");
            packet.ReadXORByte(ownerGUID, 3);
            pos.X = packet.ReadSingle();
            packet.ReadXORByte(ownerGUID, 2);

            if (bit34)
                packet.ReadInt32("Int34");

            if (bit60)
                packet.ReadByte("Byte60");

            packet.ReadSingle("Float18");
            pos.Z = packet.ReadSingle();

            // Calculate mid pos
            var mid = new Vector3();
            mid.X = (pos.X + endpos.X) * 0.5f;
            mid.Y = (pos.Y + endpos.Y) * 0.5f;
            mid.Z = (pos.Z + endpos.Z) * 0.5f;
            for (var i = 0; i < bits64; ++i)
            {
                var vec = new Vector3
                {
                    X = mid.X - waypoints[i].X,
                    Y = mid.Y - waypoints[i].Y,
                    Z = mid.Z - waypoints[i].Z,
                };
                packet.WriteLine("[{0}] Waypoint: {1}", i, vec);
            }

            packet.WriteGuid("Owner GUID", ownerGUID);
            packet.WriteGuid("GUID2", guid2);
            packet.WriteLine("Position: {0}", pos);
        }

        [HasSniffData]
        [Parser(Opcode.SMSG_NEW_WORLD)]
        public static void HandleNewWorld(Packet packet)
        {
            var pos = new Vector4();

            CoreParsers.MovementHandler.CurrentMapId = (uint)packet.ReadEntryWithName<Int32>(StoreNameType.Map, "Map");
            pos.X = packet.ReadSingle();
            pos.O = packet.ReadSingle();
            pos.Y = packet.ReadSingle();
            pos.Z = packet.ReadSingle();

            packet.WriteLine("Position: {0}", pos);
            packet.AddSniffData(StoreNameType.Map, (int)CoreParsers.MovementHandler.CurrentMapId, "NEW_WORLD");
        }

        [Parser(Opcode.SMSG_LOGIN_VERIFY_WORLD)]
        public static void HandleLoginVerifyWorld(Packet packet)
        {
            var pos = new Vector4();

            pos.Y = packet.ReadSingle();
            packet.ReadEntryWithName<Int32>(StoreNameType.Map, "Map");
            pos.X = packet.ReadSingle();
            pos.Z = packet.ReadSingle();
            pos.O = packet.ReadSingle();

            packet.WriteLine("Position: {0}", pos);
        }

        //[Parser(Opcode.SMSG_BINDPOINTUPDATE)]
        public static void HandleBindPointUpdate(Packet packet)
        {
            var pos = new Vector3();

            packet.ReadEntryWithName<Int32>(StoreNameType.Area, "Area Id");
            pos.Z = packet.ReadSingle();
            pos.X = packet.ReadSingle();
            pos.Y = packet.ReadSingle();

            CoreParsers.MovementHandler.CurrentMapId = (uint)packet.ReadEntryWithName<Int32>(StoreNameType.Map, "Map");

            packet.WriteLine("Position: {0}", pos);
        }

        [Parser(Opcode.SMSG_LOGIN_SETTIMESPEED)]
        public static void HandleLoginSetTimeSpeed(Packet packet)
        {
            packet.ReadInt32("Unk Int32");
            packet.ReadInt32("Unk Int32");
            packet.ReadPackedTime("Game Time");
            packet.ReadSingle("Game Speed");

            packet.ReadInt32("Unk Int32");
        }

        [Parser(Opcode.SMSG_TRANSFER_PENDING)]
        public static void HandleTransferPending(Packet packet)
        {
            var customLoadScreenSpell = packet.ReadBit();
            var hasTransport = packet.ReadBit();
            
            packet.ReadEntryWithName<Int32>(StoreNameType.Map, "Map ID");

            if (hasTransport)
            {
                packet.ReadEntryWithName<Int32>(StoreNameType.Map, "Transport Map ID");
                packet.ReadInt32("Transport Entry");
            }

            if (customLoadScreenSpell)
                packet.ReadEntryWithName<UInt32>(StoreNameType.Spell, "Spell ID");
        }
    }
}
