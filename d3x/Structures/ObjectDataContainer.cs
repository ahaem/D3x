using System;
using System.Collections.Generic;
using System.Text;

namespace D3x.Structures
{
    unsafe public struct ObjectDataContainer
    {
        public fixed byte unknown_0[88]; // 0x000 
        public ObjectData Data; // 0x058 
        public fixed byte unknown_198[256]; // 0x198 
    }
}
