using System;
using System.Collections.Generic;
using System.Text;

namespace D3x.Structures
{
    unsafe struct ObjectManager
    {
        public Pad Data; // 0x000 
        public ObjectManagerStorage Storage; // 0x77C 
        public fixed byte unknown_BC8[32]; // 0x03C
    }
}
