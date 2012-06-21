using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace D3x
{
    public class Actor : Base
    {
        public UInt32 addressBase;
        private UInt32 offsetId_actor = 0x000;
        private UInt32 offsetId_acd = 0x004;
        public UInt32 offsetName = 0x008; //[128]
        private UInt32 offsetId_sno = 0x088;
        private UInt32 offsetGuid_world = 0x0D8;
        private UInt32 offsetGuid_unk = 0x0DC;
        private UInt32 offsetPosObj = 0x210;
        private UInt32 offsetActorMovement = 0x380;
        private UInt32 offsetDirection = 0x384;
        private UInt32 offsetVel = 0x3A0;
        private UInt32 offsetFrame = 0x418;
        private UInt32 offsetDiff = 0x41C;
        //todo missing

        public Actor()
        {
            //todo Till I find a way to add a constructor to the Generic Container.
            throw new NotSupportedException("You must provide a base address");
        }

        public Actor(UInt32 _addressBase)
        {
            addressBase = _addressBase;
            //Debug.Print("D3x. Init Actor: " + this.Name);
        }

        public String Name
        {
            get
            {
                return Game.Memory.ReadASCIIString(addressBase + offsetName, 64);
            }
        }
    }
}
