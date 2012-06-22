using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Pad
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
        public byte[] unknown_0; // 0x000 
        public UInt32 FrameCurrent; // 0x038
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1856)]
        public byte[] unknown_3C; // 0x03C
    };
}
