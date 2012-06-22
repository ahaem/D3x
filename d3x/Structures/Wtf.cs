using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Wtf
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public byte[] unknown_0; // 0x000 
        public ulong _600DF00D; // 0x018 
    }
}
