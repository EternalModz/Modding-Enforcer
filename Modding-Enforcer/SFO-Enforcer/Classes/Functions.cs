using System;
using System.Linq;

namespace SFO_Enforcer
{
    internal static class Functions
    {
        public static UInt16 SwapByteOrder(this UInt16 value)
        {
            return (UInt16)((value & 0xFFU) << 8 | (value & 0xFF00U) >> 8);
        }

        public static UInt32 SwapByteOrder(this UInt32 value)
        {
            return (value & 0x000000FFU) << 24 | (value & 0x0000FF00U) << 8 |
                   (value & 0x00FF0000U) >> 8 | (value & 0xFF000000U) >> 24;
        }

        public static UInt64 SwapByteOrder(this UInt64 value)
        {
            return
                ((value & 0xff00000000000000L) >> 56) |
                ((value & 0x00ff000000000000L) >> 40) |
                ((value & 0x0000ff0000000000L) >> 24) |
                ((value & 0x000000ff00000000L) >> 8) |
                ((value & 0x00000000ff000000L) << 8) |
                ((value & 0x0000000000ff0000L) << 24) |
                ((value & 0x000000000000ff00L) << 40) |
                ((value & 0x00000000000000ffL) << 56);
        }

        public static bool CompareBytes(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }

        public static byte[] StringToByteArray(this string hex)
        {
            if ((hex.Length % 2) != 0) hex = hex.PadLeft(hex.Length + 1, '0');
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }
    }
}