using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Ansi, Size = 0x428)]
    unsafe public struct ActorMovement
    {
        public uint* vt; // 0x000 
        public uint Active; // 0x004 
        public float Speed; // 0x008 
        public float SpeedCurrent; // 0x00C 
        public fixed byte unknown_10[12]; // 0x010 
        public float ScaleSize; // 0x01C 
        public uint Flags; // 0x020 
        public fixed byte unknown_24[16]; // 0x024 
        public uint IsMoving; // 0x034 
        public uint PathIsWalkable; // 0x038 
        public Vec3 MovTo; // 0x03C 
        public fixed byte unknown_48[4]; // 0x048 
        public Vec3 Pos2; // 0x04C 
        public fixed byte unknown_58[28]; // 0x058 
        public Vec3 Tp; // 0x074 
        public fixed byte unknown_80[8]; // 0x080 
        public uint unk; // 0x088 
        public fixed byte unknown_8C[24]; // 0x08C 
        public Vec3 Pos3; // 0x0A4 
        public fixed byte unknown_B0[8]; // 0x0B0 
        public float Speed2; // 0x0B8 
        public fixed byte unknown_BC[160]; // 0x0BC 
        public uint id_actor; // 0x15C 
        public uint FrameMov; // 0x160 
        public uint Frame; // 0x164 
        public uint FramePrev; // 0x168 
        public fixed byte unknown_16C[4]; // 0x16C 
        public float Direction; // 0x170 
        public fixed byte unknown_174[707]; // 0x174 
    };
}
