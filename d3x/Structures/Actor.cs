﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace D3x.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    unsafe public struct Actor
    {
        public UInt32 id_actor; // 0x000 
        public UInt32 id_acd; // 0x004 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] name; // 0x008 
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
        //public fixed byte unknown_3B8[96]; // 0x3B8 

        public fixed byte unknown_3B8[80]; // 0x3B8
        public float life; // 0x408
        public fixed byte unknown_40C[12]; // 0x40C

        public uint Frame; // 0x418 
        public uint Diff; // 0x41C 
        public fixed byte unknown_420[8]; // 0x420 

        public UInt32 addressBase;
        /*
        /// <summary>
        /// Get an actor attribute (health, armor etc.)
        /// </summary>
        /// <typeparam name="T">int or float</typeparam>
        /// <param name="attribute">Attribute to get</param>
        /// <returns>Value of attribute</returns>
        public float GetAttributeFloat(Enumerators.ActorAttribute attribute)
        {
            uint ret = GetAttribute((uint)attribute | 0xFFFFF000);
            //if (!ret.IsValid())
            //{
            //    return default(T);
            //}

            return Game.Memory.ReadFloat(ret + 8);
        }

        public int GetAttributeInt(Enumerators.ActorAttribute attribute)
        {
            uint ret = GetAttribute((uint)attribute | 0xFFFFF000);
            //if (!ret.IsValid())
            //{
            //    return default(T);
            //}

            return Game.Memory.ReadInt(ret + 8);
        }

        public uint GetAttribute(uint attribute)
        {
            uint pFAG = Game.ObjectManager.Storage.GetFastAttribGroupsContainer().GetFastAttribGroupsContainer().GetList()[2].addressBase;
            uint CAttribFormula = Game.Memory.ReadUInt(pFAG + 0x10); // _10
            uint _418 = Game.Memory.ReadUInt(CAttribFormula + 0x418); // _418
            uint AttributesMap = Game.Memory.ReadUInt(CAttribFormula + 0x8); // _08
            uint IndexMask = (_418 & (attribute ^ (attribute >> 0x10))); // v4
            uint _res = (AttributesMap + 4 * IndexMask); // _res
            uint result = Game.Memory.ReadUInt(_res); // result
            if (result != 0)
            {
                while (Game.Memory.ReadUInt(result + 0x4) != attribute)
                {
                    Debug.Print(Enum.GetName(typeof(Enumerators.ActorAttribute), Game.Memory.ReadUInt(result + 0x4)));
                    result = Game.Memory.ReadUInt(result);
                    if (result == 0)
                    {
                        break;
                    }
                }
            }
            return 0;
        }
        */

        public Structures.FAG GetFAG()
        {
            return new Structures.FAG(this.GetFAGPtr());
        }

        public uint GetFAGPtr()
        {
            return GetFAGPtrFromGUID((int)this.id_acd);
        }

        public static uint GetFAGPtrFromGUID(int GUID)
        {
            UInt32 pFastAttribGroups = Game.ObjectManager.Storage.GetFastAttribGroupsContainer().pFastAttribGroupsContainer;
            UInt32 max = Game.Memory.ReadUInt(pFastAttribGroups + 0x100);
            UInt32 size = 0x180;
            UInt32 result = 0;
            if (GUID == -1)
            {
                result = 0;
            }
            else
            {
                if ((GUID & 0xFFFF) < max)
                {
                    UInt32 _148 = Game.Memory.ReadUInt(pFastAttribGroups + 0x148);
                    Int32 _18c = Game.Memory.ReadInt(pFastAttribGroups + 0x18C);
                    UInt32 a = (_148 + 4 * 0);
                    UInt32 b = (UInt32)(size * (GUID & ((1 << _18c) - 1)));
                    UInt32 v3 = Game.Memory.ReadUInt(a) + b;
                    result = (UInt32)((Int32)v3 & -1);
                }
                else
                {
                    result = 0;
                }
            }
            return result;
        }
    }
}