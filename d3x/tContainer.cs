using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace D3x
{
    public class tContainer<T> where T : Base, new()
    {
        private UInt32 addressBase;
        private UInt32 offsetName = 0x000;
        private UInt32 offsetLimit = 0x100;
        private UInt32 offsetSizeOf = 0x104;
        private UInt32 offsetLast = 0x108;
        private UInt32 offsetUnknown_10C = 0x10c;
        private UInt32 offsetList = 0x148;
        private UInt32 offsetUnknown_14C = 0x14c;
        //todo more missing

        public tContainer(UInt32 _addressBase)
        {
            addressBase = _addressBase;
            //Debug.Print("D3x. Init tContainer: "+this.Name);
        }

        public String Name
        {
            get
            {
                return Game.Memory.ReadASCIIString(addressBase + offsetName, 256);
            }
        }

        public ulong SizeOf
        {
            get
            {
                return (ulong)Game.Memory.ReadUInt(addressBase + offsetSizeOf);
            }
        }

        public Int32 Count // Last
        {
            get
            {
                return (Int32)Game.Memory.ReadUInt(addressBase + offsetLast);
            }
        }

        public List<T> List
        {
            get
            {
                List<T> items = new List<T>();
                UInt32 offsetCurrentListItem = Game.Memory.ReadUInt(Game.Memory.ReadUInt(addressBase + offsetList)); //debug Not sure why two times. Missing something.
                for (int i = 0; i < this.Count; i++)
                {
                    var item = Activator.CreateInstance(typeof(T), new object[] { offsetCurrentListItem }) as T;
                    items.Add(item);
                    offsetCurrentListItem += (UInt32) this.SizeOf; //todo Why am I converting a ulong to a UInt32?
                }
                return items;
            }
        }

    }
}
