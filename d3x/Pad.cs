using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x
{
    public class Pad
    {
        private UInt32 addressBase;
        private UInt32 unknown_0 = 0x000; // 0x000
        private UInt32 FrameCurrent = 0x004; // 0x038
        private UInt32 unknown_3C = 0x008; // 0x03C

        public Pad(UInt32 _addressBase)
        {
            this.addressBase = _addressBase;
        }

        public UInt32 frame
        {
            get
            {
                return (UInt32)Game.Memory.ReadUInt(addressBase + FrameCurrent);
            }
        }
    };

}
