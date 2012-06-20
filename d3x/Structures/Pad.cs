using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    unsafe public struct Pad
    {
        public fixed byte unknown_0[56]; // 0x000 
        public uint FrameCurrent; // 0x038
        public fixed byte unknown_3C[1856]; // 0x03C
    };
}
