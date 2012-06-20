using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Ansi, Size = 0x428)]
    unsafe public struct Actor
    {
        public uint id_actor; // 0x000 
        public uint id_acd; // 0x004 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public char[] name; // 0x008 
        public uint id_sno; // 0x088 
        public fixed byte unknown_8C[4]; // 0x08C 
        public Vec3 Rot; // 0x090 
        public float fUnk_Rot; // 0x09C 
        public Vec3 Pos; // 0x0A0 
        public float fUnk_130; // 0x0AC 
        public Vec3 Pos1; // 0x0B0 
        public float fUnk_734; // 0x0BC 
        public Vec3 Pos2; // 0x0C0 
        public fixed byte unknown_CC[4]; // 0x0CC 
        public float RadiusDefault; // 0x0D0 
        public fixed byte unknown_D4[4]; // 0x0D4 
        public uint guid_world; // 0x0D8 
        public uint guid_Unk; // 0x0DC 
        public fixed byte unknown_E0[32]; // 0x0E0 
        public Vec3 Pos3; // 0x100 
        public fixed byte unknown_10C[52]; // 0x10C 
        public Vec3 Pos4; // 0x140 
        public fixed byte unknown_14C[16]; // 0x14C 
        public uint N13E1EB50; // 0x15C 
        public fixed byte unknown_160[96]; // 0x160 
        public uint unknown_data3; // 0x1C0
        public fixed byte unknown_1C4[8];// 0x1C4
        public uint unknown_data2; // 0x1CC
        public fixed byte unknown_1D0[44]; // 0x1D0
        public uint unknown_data1;// 0x1FC
        public Vec3 PosObj; // 0x210 
        public fixed byte unknown_21C[356]; // 0x21C 
        public ActorMovement* Mov; // 0x380 
        public float Direction; // 0x384 
        public fixed byte unknown_388[24]; // 0x388 
        public Vec3 Vel; // 0x3A0 
        public Vec3 Pos6; // 0x3AC 
        public fixed byte unknown_3B8[96]; // 0x3B8 
        public uint Frame; // 0x418 
        public uint Diff; // 0x41C 
        public fixed byte unknown_420[8]; // 0x420 

        public string Name
        {
            get
            {
                return new string(name).TrimEnd(new char[] { (char)0 });
            }
        }
    }
}
