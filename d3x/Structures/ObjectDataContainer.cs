using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    unsafe public struct ObjectDataContainer
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
        public byte[] unknown_0; // 0x000 
        public Structures.ObjectData Data; // 0x058 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] unknown_198; // 0x198 
    }
}
