using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    unsafe public struct Container<T>
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public char[] name;
        public ulong Limit;
        public ulong SizeOf;
        public long Last;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public byte[] unknown_10C;
        public IntPtr* List;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte unknown_14C;
        public ulong Bits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] unknown_190;
    }

    [StructLayout(LayoutKind.Sequential, Size = 0x1d0)]
    unsafe public struct ContainerActor
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public char[] name;
        public ulong Limit;
        public ulong SizeOf;
        public long Last;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public byte[] unknown_10C;
        public IntPtr List;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte unknown_14C;
        public ulong Bits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] unknown_190;
    }
}
