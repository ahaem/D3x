using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NativeSceneSNO
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public int[] Header;
        public int dwordC;
        //public AABB AABBBounds;
        //public AABB MarkerSetBounds;
        //public NativeNavMeshDef NavMeshDef;
        public int ApperanceSNO;
        public int PhysMeshSNO;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] serExclusions;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
        public int[] Exclusions;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] serInclusions;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
        public int[] Inclusions;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] serMarkerSets;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
        public int[] MarkerSets;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x48)]
        public byte[] pad228;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] serMsgTriggeredEvents;
        public UInt32 NavZoneDef;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] dword278;
        public int dword310;
    }





}
