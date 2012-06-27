using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace D3x.Structures
{
    [StructLayout(LayoutKind.Sequential/*, Pack = 4, CharSet = CharSet.Ansi*/, Size = 0x2D0)] //Offsets.ACDSize)
    public struct ActorCommonData
    {
        public UInt32 id_acd; // 0x000
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] name; // 0x004
        public UInt32 unk_0; // 0x084 
        public UInt32 id_unk1; // 0x088 
        public UInt32 id_unk2; // 0x08C 
        public UInt32 id_sno; // 0x090 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] unknown_94; // 0x094 
        public UInt32 id_acd_gBall; // 0x0B4  
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public byte[] unknown_B8;  // 0x0B8 
        public Vec3 PosWorld; // 0x0D0 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
        public byte[] unknown_DC; // 0x0DC 
        public float RadiusDefault; // 0x100 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] unknown_104; // 0x104 
        public UInt32 id_world; // 0x108 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] unknown_10C; // 0x10C 
        public UInt32 id_owner; // 0x110 
        public Enumerators.ItemLocation itemLoc; // 0x114 
        public uint itemX; // 0x118
        public uint itemY; // 0x11C
        public UInt32 id_fag; //id_attrib; // 0x120 
        public UInt32 id_unk3; // 0x124 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 244)]
        public byte[] unknown_128; // 0x128 
        public byte NBAD848; // 0x21C 
        public byte RadiusType; // 0x21D 
        public byte NBB56E9; // 0x21E 
        public byte NBBA038; // 0x21F 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public byte[] unknown_220; // 0x220 
        public float RadiusScaled; // 0x238 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 148)]
        public byte[] unknown_23C; // 0x23C 

        public UInt32 addressBase;

        public string GetName()
        {
            return System.Text.Encoding.ASCII.GetString(name).TrimEnd(new char[] { (char)0 });
        }
    }
}