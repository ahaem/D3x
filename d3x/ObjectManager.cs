using System;
using System.Collections.Generic;
using System.Text;

namespace D3x
{
    public class ObjectManager
    {
        private UInt32 addressBase;
        private UInt32 offsetData = 0x000;
        private UInt32 offsetStorage = 0x77C;
        private UInt32 offsetUnknown_BC8 = 0xBC8;

        public ObjectManager(UInt32 _baseAddress)
        {
            addressBase = _baseAddress;
        }

        public Structures.tPad Data
        {
            get
            {
                return new Structures.tPad(); //dummy
            }
        }

        public ObjectManagerStorage Storage
        {
            get
            {
                return new ObjectManagerStorage(addressBase + offsetStorage);
            }
        }        

    }

}
