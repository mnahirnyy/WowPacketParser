using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;

namespace WowPacketParserModule.V8_0_1_27101.Parsers
{
    public static class ChannelHandler
    {
        [Parser(Opcode.SMSG_CHANNEL_NOTIFY_JOINED, ClientVersionBuild.V8_1_0_28724)]
        public static void HandleChannelNotifyJoined(Packet packet)
        {
            var bits544 = packet.ReadBits(8);
            var bits24 = packet.ReadBits(10);

            packet.ReadUInt32E<ChannelFlag>("ChannelFlags");
            packet.ReadInt32("ChatChannelID");
            packet.ReadUInt64("InstanceID");

            packet.ReadWoWString("Channel", bits544);
            packet.ReadWoWString("ChannelWelcomeMsg", bits24);
        }

        [Parser(Opcode.SMSG_CHANNEL_NOTIFY_LEFT, ClientVersionBuild.V8_1_0_28724)]
        public static void HandleChannelNotifyLeft(Packet packet)
        {
            var bits20 = packet.ReadBits(8);
            packet.ReadBit("Suspended");
            packet.ReadInt32("ChatChannelID");
            packet.ReadWoWString("Channel", bits20);
        }

        [Parser(Opcode.CMSG_CHAT_JOIN_CHANNEL, ClientVersionBuild.V8_1_0_28724)]
        public static void HandleChannelJoin(Packet packet)
        {
            packet.ReadInt32("ChatChannelId");
            packet.ReadBit("CreateVoiceSession");
            packet.ReadBit("Internal");

            var channelLength = packet.ReadBits(8);
            var passwordLength = packet.ReadBits(8);

            packet.ResetBitReader();

            packet.ReadWoWString("ChannelName", channelLength);
            packet.ReadWoWString("Password", passwordLength);
        }

        [Parser(Opcode.CMSG_CHAT_MESSAGE_GUILD, ClientVersionBuild.V8_1_0_28724)]
        [Parser(Opcode.CMSG_CHAT_MESSAGE_YELL, ClientVersionBuild.V8_1_0_28724)]
        [Parser(Opcode.CMSG_CHAT_MESSAGE_SAY, ClientVersionBuild.V8_1_0_28724)]
        [Parser(Opcode.CMSG_CHAT_MESSAGE_PARTY, ClientVersionBuild.V8_1_0_28724)]
        [Parser(Opcode.CMSG_CHAT_MESSAGE_INSTANCE_CHAT, ClientVersionBuild.V8_1_0_28724)]
        public static void HandleClientChatMessage(Packet packet)
        {
            packet.ReadInt32E<Language>("Language");
            var len = packet.ReadBits(10);
            packet.ReadWoWString("Text", len);
        }

        [Parser(Opcode.CMSG_CHAT_MESSAGE_WHISPER, ClientVersionBuild.V8_1_0_28724)]
        public static void HandleClientChatMessageWhisper(Packet packet)
        {
            packet.ReadInt32E<Language>("Language");
            var recvName = packet.ReadBits(9);
            var msgLen = packet.ReadBits(10);

            packet.ReadWoWString("Target", recvName);
            packet.ReadWoWString("Text", msgLen);
        }
    }
}
