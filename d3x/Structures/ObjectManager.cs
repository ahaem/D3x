using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace D3x.Structures
{
    //[StructLayout(LayoutKind.Explicit)]
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ObjectManager
    {
        //[FieldOffset(0x000)]
        public Structures.Pad Data; // 0x000 
        //[FieldOffset(0x77C)]
        public Structures.ObjectManagerStorage Storage; // 0x77C 
        //[FieldOffset(0xBC8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] unknown_BC8; // 0x03C
    }
}
