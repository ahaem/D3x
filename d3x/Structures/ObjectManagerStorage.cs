using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    unsafe public struct ObjectManagerStorage
    {
        //[FieldOffset(0x000)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] unknown_0; // 0x000 
        /*public float fl_120; // 0x010 
        public float fl_1; // 0x014 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 144)]
        public byte[] unknown_18; // 0x018 
        //[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(TestMarshaler))]
        //public UInt32 Data;
        public IntPtr pData; // 0x0A8 
        //public Structures.ObjectDataContainer* DataContainer; // 0x0A8 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public byte[] unknown_AC; // 0x0AC 
        public IntPtr pAttribGroups; // 0x0A8 
        //public AttributeGroupsContainer* AttribGroups; // 0x0C8 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] unknown_CC; // 0x0CC 
        //public IntPtr* ACD; // 0x0A8 
        //public Container<ActorCommonData>** ACD; // 0x0D4 
        public IntPtr pACD; // 0x0A8 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] unknown_D8; // 0x0D8 
        public ulong Mode; // 0x118 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] unknown_11C; // 0x11C 
        public ulong Lights; // 0x128 
        public ulong Cutscenes; // 0x12C 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] unknown_130; // 0x130 
        public IntPtr pActorsContainer; // 0x0A8 
        //tContainer<CActor>* Actors; // 0x134 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] unknown_138; // 0x138 
        public ulong ppCloth; // 0x13C 
        public ulong ppExplosion; // 0x140 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
        public byte[] unknown_144; // 0x144 
        public IntPtr Frames; // 0x0A8 
        //ObManFrames* Frames; // 0x168 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] unknown_16C; // 0x16C 
        public ulong Scenes; // 0x178 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] unknown_17C; // 0x17C 
        public IntPtr MovHistory; // 0x0A8 
        //CObMovHPtr* MovHistory; // 0x184 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        public byte[] unknown_188; // 0x188 
        public IntPtr Worlds; // 0x0A8 
        //tContainer<CWorld>* Worlds; // 0x1B0 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] unknown_1B4; // 0x1B4 
        public IntPtr Local; // 0x0A8 
        //CObLocal* Local; // 0x1B8 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 656)]
        public byte[] unknown_1BC; // 0x1BC 

        public Structures.ObjectDataContainer GetData()
        {
            return (Structures.ObjectDataContainer)Game.MemoryNew.Read((IntPtr)(pData), typeof(Structures.ObjectDataContainer));
        }

        public Structures.ContainerActor GetActors()
        {
            return (Structures.ContainerActor)Game.MemoryNew.Read((IntPtr)(pData), typeof(Structures.ContainerActor));
        }
        */
    }
}
