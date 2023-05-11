using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

internal class ARC_Classes
{
    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool CopyFileEx(string string_0, string string_1, ARC_Classes.Delegate1 delegate1_0, IntPtr intptr_0, ref int int_1, ARC_Classes.Enum6 enum6_0);

    public void method_0(string string_0, string string_1)
    {
        ARC_Classes.CopyFileEx(string_0, string_1, new ARC_Classes.Delegate1(this.method_1), IntPtr.Zero, ref this.int_0, (ARC_Classes.Enum6)10U);
    }

    private ARC_Classes.Enum4 method_1(long long_0, long long_1, long long_2, long long_3, uint uint_0, ARC_Classes.Enum5 enum5_0, IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
    {
        return (ARC_Classes.Enum4)0U;
    }

    public ARC_Classes()
    {
        Class50.dTjArREzVyevQ();
    }

    private int int_0;

    private delegate ARC_Classes.Enum4 Delegate1(long TotalFileSize, long TotalBytesTransferred, long StreamSize, long StreamBytesTransferred, uint dwStreamNumber, ARC_Classes.Enum5 dwCallbackReason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData);

    private enum Enum4 : uint
    {

    }

    private enum Enum5 : uint
    {

    }

    [Flags]
    private enum Enum6 : uint
    {

    }
}

internal class Class47
{
    public Class47()
    {
        Class50.dTjArREzVyevQ();
        this.bool_0 = true;
    }

    public Class47(bool bool_1)
    {
        Class50.dTjArREzVyevQ();
        this.bool_0 = true;
        this.bool_0 = bool_1;
    }

    public bool method_0()
    {
        return this.bool_0;
    }

    public void method_1(bool bool_1)
    {
        this.bool_0 = bool_1;
    }

    internal short method_2(Stream stream_0)
    {
        byte[] array = this.method_6(stream_0, 2);
        bool flag = BitConverter.IsLittleEndian && this.method_0();
        if (flag)
        {
            Array.Reverse(array);
        }
        return BitConverter.ToInt16(array, 0);
    }

    internal ushort method_3(Stream stream_0)
    {
        byte[] array = this.method_6(stream_0, 2);
        bool flag = BitConverter.IsLittleEndian && this.method_0();
        if (flag)
        {
            Array.Reverse(array);
        }
        return BitConverter.ToUInt16(array, 0);
    }

    internal int method_4(Stream stream_0)
    {
        byte[] array = this.method_6(stream_0, 4);
        bool flag = BitConverter.IsLittleEndian && this.method_0();
        if (flag)
        {
            Array.Reverse(array);
        }
        return BitConverter.ToInt32(array, 0);
    }

    internal uint method_5(Stream stream_0)
    {
        byte[] array = this.method_6(stream_0, 4);
        bool flag = BitConverter.IsLittleEndian && this.method_0();
        if (flag)
        {
            Array.Reverse(array);
        }
        return BitConverter.ToUInt32(array, 0);
    }

    private byte[] method_6(Stream stream_0, int int_0)
    {
        byte[] array = new byte[int_0];
        stream_0.Read(array, 0, int_0);
        return array;
    }

    internal string method_7(Stream stream_0)
    {
        ushort num = this.method_3(stream_0);
        byte[] array = new byte[(int)num];
        for (int i = 0; i < (int)num; i++)
        {
            byte b = (byte)stream_0.ReadByte();
            array[i] = b;
        }
        Encoding utf = Encoding.UTF8;
        return utf.GetString(array);
    }

    internal int method_8(Stream stream_0)
    {
        int result = this.method_4(stream_0);
        stream_0.Seek(-4L, SeekOrigin.Current);
        return result;
    }

    internal void method_9(short short_0, Stream stream_0)
    {
        byte[] bytes = BitConverter.GetBytes(short_0);
        bool flag = BitConverter.IsLittleEndian && this.method_0();
        if (flag)
        {
            Array.Reverse(bytes);
        }
        stream_0.Write(bytes, 0, bytes.Length);
    }

    internal void method_10(int int_0, Stream stream_0)
    {
        byte[] bytes = BitConverter.GetBytes(int_0);
        bool flag = BitConverter.IsLittleEndian && this.method_0();
        if (flag)
        {
            Array.Reverse(bytes);
        }
        stream_0.Write(bytes, 0, bytes.Length);
    }

    internal void method_11(uint uint_0, Stream stream_0)
    {
        byte[] bytes = BitConverter.GetBytes(uint_0);
        bool flag = BitConverter.IsLittleEndian && this.method_0();
        if (flag)
        {
            Array.Reverse(bytes);
        }
        stream_0.Write(bytes, 0, bytes.Length);
    }

    internal void method_12(string string_0, MemoryStream memoryStream_0)
    {
        Encoding utf = Encoding.UTF8;
        byte[] bytes = utf.GetBytes(string_0);
        this.method_9((short)bytes.Length, memoryStream_0);
        memoryStream_0.Write(bytes, 0, bytes.Length);
    }

    private bool bool_0;
}

internal class Class50
{
    internal static void dTjArREzVyevQ()
    {
    }

    private static bool bool_0;
}
