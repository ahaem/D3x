using System;
using System.Collections.Generic;
using System.Text;

namespace D3x.Structures
{
   unsafe public struct ObjectData
    {
        public fixed byte unknown_0[4]; // 0x000 
        public ulong id_anim; // 0x004 
        public ulong id_actor; // 0x008 
        public fixed byte unknown_C[308];     // 0x00C 
    }
}
