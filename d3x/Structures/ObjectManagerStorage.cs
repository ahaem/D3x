﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ObjectManagerStorage
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] unknown_0; // 0x000 
        public float fl_120; // 0x010 
        public float fl_1; // 0x014 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 144)]
        public byte[] unknown_18; // 0x018 
        public UInt32 pData; // 0x0A8 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public byte[] unknown_AC; // 0x0AC 
        public UInt32 pAttribGroupsOuterContainer; // 0x0C8 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] unknown_CC; // 0x0CC 
        public UInt32 ACD; // 0x0A8 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] unknown_D8; // 0x0D8 
        public UInt32 Mode; // 0x118 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] unknown_11C; // 0x11C 
        public UInt32 Lights; // 0x128 
        public UInt32 Cutscenes; // 0x12C 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] unknown_130; // 0x130 
        public UInt32 pActorsContainer; // 0x0A8 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] unknown_138; // 0x138 
        public UInt32 ppCloth; // 0x13C 
        public UInt32 ppExplosion; // 0x140 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
        public byte[] unknown_144; // 0x144 
        public UInt32 Frames; // 0x0A8 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] unknown_16C; // 0x16C 
        public UInt32 Scenes; // 0x178 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] unknown_17C; // 0x17C 
        public UInt32 MovHistory; // 0x0A8 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        public byte[] unknown_188; // 0x188 
        public UInt32 Worlds; // 0x0A8 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] unknown_1B4; // 0x1B4 
        public UInt32 Local; // 0x0A8 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 656)]
        public byte[] unknown_1BC; // 0x1BC 

        public Structures.ObjectDataContainer GetData()
        {
            return (Structures.ObjectDataContainer)Game.Memory.ReadObject(pData, typeof(Structures.ObjectDataContainer));
        }

        // Actors
        public Structures.tContainerActor GetActorContainer()
        {
            return (Structures.tContainerActor)Game.Memory.ReadObject(pActorsContainer, typeof(Structures.tContainerActor));
        }

        public List<Structures.Actor> GetActors()
        {
            return this.GetActorContainer().GetList();
        }

        // ActorCommonData
        public Structures.tContainerActorCommonData GetActorCommonDataContainer()
        {
            return (Structures.tContainerActorCommonData)Game.Memory.ReadObject(pActorsContainer, typeof(Structures.tContainerActorCommonData));
        }

        public List<Structures.ActorCommonData> GetActorCommonData()
        {
            return this.GetActorCommonDataContainer().GetList();
        }

        // FastAttribGroupsOuterContainer
        public Structures.AttributeGroupsOuterContainer GetFastAttribGroupsContainer()
        {
            return (Structures.AttributeGroupsOuterContainer)Game.Memory.ReadObject(pAttribGroupsOuterContainer, typeof(Structures.AttributeGroupsOuterContainer));
        }

    }
}
