using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    unsafe public struct ObjectData
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] unknown_0; // 0x000 
        public UInt32 id_anim; // 0x004 
        public UInt32 id_actor; // 0x008 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 308)]
        public byte[] unknown_C; // 0x00C 
    }
}
