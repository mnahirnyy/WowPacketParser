using System;
using System.Runtime.InteropServices;

namespace WowPacketParser.Misc
{
    [StructLayout(LayoutKind.Explicit)]
    public struct UpdateField
    {
        public UpdateField(byte val) : this()
        {
            UInt8Value = val;
        }

        public UpdateField(sbyte val) : this()
        {
            Int8Value = val;
        }

        public UpdateField(ushort val) : this()
        {
            UInt16Value = val;
        }

        public UpdateField(short val) : this()
        {
            Int16Value = val;
        }

        public UpdateField(uint val) : this()
        {
            UInt32Value = val;
        }

        public UpdateField(int val) : this()
        {
            Int32Value = val;
        }

        public UpdateField(float val) : this()
        {
            FloatValue = val;
        }

        public UpdateField(ulong val) : this()
        {
            UInt64Value = val;
        }

        public UpdateField(long val) : this()
        {
            Int64Value = val;
        }

        public UpdateField(object val) : this()
        {
            var returnCode = Type.GetTypeCode(val.GetType());
            switch (returnCode)
            {
                case TypeCode.SByte:
                    Int8Value = (sbyte)val;
                    break;
                case TypeCode.Byte:
                    UInt8Value = (byte)val;
                    break;
                case TypeCode.Int16:
                    Int16Value = (short)val;
                    break;
                case TypeCode.UInt16:
                    UInt16Value = (ushort)val;
                    break;
                case TypeCode.Int32:
                    Int32Value = (int)val;
                    break;
                case TypeCode.UInt32:
                    UInt32Value = (uint)val;
                    break;
                case TypeCode.Int64:
                    Int64Value = (long)val;
                    break;
                case TypeCode.UInt64:
                    UInt64Value = (ulong)val;
                    break;
                case TypeCode.Single:
                    FloatValue = (float)val;
                    break;
            }
        }

        [FieldOffset(0)] public readonly byte UInt8Value;
        [FieldOffset(0)] public readonly sbyte Int8Value;
        [FieldOffset(0)] public readonly ushort UInt16Value;
        [FieldOffset(0)] public readonly short Int16Value;
        [FieldOffset(0)] public readonly uint UInt32Value;
        [FieldOffset(0)] public readonly int Int32Value;
        [FieldOffset(0)] public readonly float FloatValue;
        [FieldOffset(4)] public readonly ulong UInt64Value;
        [FieldOffset(4)] public readonly long Int64Value;

        public override bool Equals(object obj)
        {
            if (obj is UpdateField)
                return Equals((UpdateField) obj);
            return false;
        }

        public bool Equals(UpdateField other)
        {
            if (UInt32Value == other.UInt32Value)
                return true;

            if (UInt64Value == other.UInt64Value)
                return true;

            if (Math.Abs(FloatValue - other.FloatValue) < float.Epsilon)
                return true;

            return false;
        }

        public static bool operator ==(UpdateField first, UpdateField other)
        {
            return first.Equals(other);
        }

        public static bool operator !=(UpdateField first, UpdateField other)
        {
            return !(first == other);
        }

        public override int GetHashCode()
        {
            return UInt32Value.GetHashCode();
        }
    }
}
