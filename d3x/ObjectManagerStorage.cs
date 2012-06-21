using System;
using System.Collections.Generic;
using System.Text;

namespace D3x
{
    public class ObjectManagerStorage
    {
        public UInt32 addressBase;

        public UInt32 offsetUnknown_0 = 0x000;
        public UInt32 offsetFl_120 = 0x010;
        public UInt32 offsetFl_1 = 0x014;
        public UInt32 offsetUnknown_18 = 0x018;
        public UInt32 offsetData = 0x0A8; //*
        public UInt32 offsetUnknown_AC = 0x0AC;
        public UInt32 offsetAttribGroups = 0x0C8; //*
        public UInt32 offsetUnknown_CC = 0x0CC;
        public UInt32 offsetACD = 0x0D4; //*
        public UInt32 offsetUnknown_D8 = 0x0D8;
        public UInt32 offsetMode = 0x118;
        public UInt32 offsetUnknown_11C = 0x11C;
        public UInt32 offsetLights = 0x128;
        public UInt32 offsetCutscenes = 0x12C;
        public UInt32 offsetUnknown_130 = 0x130;
        public UInt32 offsetActors = 0x134; //*
        public UInt32 offsetUnknown_138 = 0x138;
        public UInt32 offsetPpCloth = 0x13C;
        public UInt32 offsetPpExplosion = 0x140;
        public UInt32 offsetUnknown_144 = 0x144;
        public UInt32 offsetFrames = 0x168; //*
        public UInt32 offsetUnknown_16C = 0x16C;
        public UInt32 offsetScenes = 0x178;
        public UInt32 offsetUnknown_17C = 0x17C;
        public UInt32 offsetMovHistory = 0x184; //*
        public UInt32 offsetUnknown_188 = 0x188;
        public UInt32 offsetWorlds = 0x1B0;
        public UInt32 offsetUnknown_1B4 = 0x1B4;
        public UInt32 offsetLocal = 0x1B8; //*
        public UInt32 offsetUnknown_1BC = 0x1BC;

        public ObjectManagerStorage(UInt32 _addressBase)
        {
            addressBase = _addressBase;
        }

        public float getfl_120() // testing function! :P
        {
            return Game.Memory.ReadFloat(addressBase + 0x010);
        }

        public float getfl_1() // testing function! :P
        {
            return Game.Memory.ReadFloat(addressBase + 0x014);
        }

        public tContainer<ActorCommonData> ActorCommonData
        {
            get
            {
                return new tContainer<ActorCommonData>(Game.Memory.ReadUInt(addressBase + offsetACD));
            }
        }

        public IntPtr pActorsContainer() // testing function! :P
        {
            return (IntPtr)Game.Memory.ReadUInt(addressBase + offsetActors);
        }

        public ulong pCutscenes()
        {
            return (ulong)Game.Memory.ReadUInt64(addressBase + offsetCutscenes);
        }
    
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
