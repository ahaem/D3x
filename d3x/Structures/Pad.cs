using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    //[StructLayout(LayoutKind.Explicit)]
    [StructLayout(LayoutKind.Sequential)]
    public struct Pad
    {
        //[FieldOffset(0x000)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
        public byte[] unknown_0; // 0x000 
        //[FieldOffset(0x038)]
        public UInt32 FrameCurrent; // 0x038
        //[FieldOffset(0x03C)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1856)]
        public byte[] unknown_3C; // 0x03C
    };
}
