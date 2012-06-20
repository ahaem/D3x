using System;
using System.Collections.Generic;
using System.Text;

namespace D3x.Structures
{
   unsafe public struct ObjectManagerStorage
    {
        public fixed byte unknown_0[16]; // 0x000 
        public float fl_120; // 0x010 
        public float fl_1; // 0x014 
        public fixed byte unknown_18[144]; // 0x018 
        public ObjectDataContainer* Data; // 0x0A8 
        public fixed byte unknown_AC[28]; // 0x0AC 
        public AttributeGroupsContainer* AttribGroups; // 0x0C8 
        public fixed byte unknown_CC[8]; // 0x0CC 
        //public Container<ActorCommonData>** ACD; // 0x0D4 
        public fixed byte unknown_D8[64]; // 0x0D8 
        public uint Mode; // 0x118 
        public fixed byte unknown_11C[12]; // 0x11C 
        public uint Lights; // 0x128 
        public uint Cutscenes; // 0x12C 
        public fixed byte unknown_130[4]; // 0x130 
        //tContainer<CActor>* Actors; // 0x134 
        public fixed byte unknown_138[4]; // 0x138 
        public uint ppCloth; // 0x13C 
        public uint ppExplosion; // 0x140 
        public fixed byte unknown_144[36]; // 0x144 
        //ObManFrames* Frames; // 0x168 
        public fixed byte unknown_16C[12]; // 0x16C 
        public uint Scenes; // 0x178 
        public fixed byte unknown_17C[8]; // 0x17C 
        //CObMovHPtr* MovHistory; // 0x184 
        public fixed byte unknown_188[40]; // 0x188 
        //tContainer<CWorld>* Worlds; // 0x1B0 
        public fixed byte unknown_1B4[4]; // 0x1B4 
        //CObLocal* Local; // 0x1B8 
        public fixed byte unknown_1BC[656]; // 0x1BC 
    }
}
