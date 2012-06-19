using System;
using System.Collections.Generic;
using System.Text;

namespace D3x
{
    public class ObjectManagerStorage
    {
        private UInt32 addressBase;

        private UInt32 offsetUnknown_0 = 0x000;
        private UInt32 offsetFl_120 = 0x010;
        private UInt32 offsetFl_1 = 0x014;
        private UInt32 offsetUnknown_18 = 0x018;
        private UInt32 offsetData = 0x0A8; //*
        private UInt32 offsetUnknown_AC = 0x0AC;
        private UInt32 offsetAttribGroups = 0x0C8; //*
        private UInt32 offsetUnknown_CC = 0x0CC;
        private UInt32 offsetACD = 0x0D4; //*
        private UInt32 offsetUnknown_D8 = 0x0D8;
        private UInt32 offsetMode = 0x118;
        private UInt32 offsetUnknown_11C = 0x11C;
        private UInt32 offsetLights = 0x128;
        private UInt32 offsetCutscenes = 0x12C;
        private UInt32 offsetUnknown_130 = 0x130;
        private UInt32 offsetActors = 0x134; //*
        private UInt32 offsetUnknown_138 = 0x138;
        private UInt32 offsetPpCloth = 0x13C;
        private UInt32 offsetPpExplosion = 0x140;
        private UInt32 offsetUnknown_144 = 0x144;
        private UInt32 offsetFrames = 0x168; //*
        private UInt32 offsetUnknown_16C = 0x16C;
        private UInt32 offsetScenes = 0x178;
        private UInt32 offsetUnknown_17C = 0x17C;
        private UInt32 offsetMovHistory = 0x184; //*
        private UInt32 offsetUnknown_188 = 0x188;
        private UInt32 offsetWorlds = 0x1B0;
        private UInt32 offsetUnknown_1B4 = 0x1B4;
        private UInt32 offsetLocal = 0x1B8; //*
        private UInt32 offsetUnknown_1BC = 0x1BC;

        public ObjectManagerStorage(UInt32 _addressBase)
        {
            addressBase = _addressBase;
        }

        public tContainer<ActorCommonData> ActorCommonData
        {
            get
            {
                return new tContainer<ActorCommonData>(Game.Memory.ReadUInt(addressBase + offsetACD));
            }
        }

        //public tContainer<Actor> Actors
        //{
        //    get
        //    {
        //        return new tContainer<Actor>(Game.memory.ReadUInt(addressBase + offsetActors));
        //    }
        //}

        public List<Actor> Actors
        {
            get
            {
                //tContainer<Actor> actorContainer = new tContainer<Actor>(Game.memory.ReadUInt(addressBase + offsetActors));
                tContainer<Actor> actorContainer = new tContainer<Actor>(Game.Memory.ReadUInt(addressBase + offsetActors));
                List<Actor> actorList = actorContainer.List;
                return actorList;
            }
        }

    }
}
