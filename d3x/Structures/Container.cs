using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace D3x.Structures
{
    // Following is unused, haven't managed to get it to play nice.
    /*[StructLayout(LayoutKind.Sequential)]
    unsafe public struct Container<T>
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string name;
        public UInt32 Limit;
        public UInt32 SizeOf;
        public Int32 Last;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public byte[] unknown_10C;
        public UInt32 List;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] unknown_14C;
        public UInt32 Bits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] unknown_190;
    }*/

    [StructLayout(LayoutKind.Sequential)]
    public struct tContainerActor
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string name;
        public UInt32 Limit;
        public UInt32 SizeOf;
        public Int32 Last;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public byte[] unknown_10C;
        public UInt32 pList;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] unknown_14C;
        public UInt32 Bits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] unknown_190;

        public List<Structures.Actor> GetList()
        {
            List<Structures.Actor> items = new List<Structures.Actor>();
            UInt32 offsetCurrentListItem = Game.Memory.ReadUInt((UInt32)pList); //todo Need to move this to MemoryNew
            UInt32 pFirstItem = (UInt32)offsetCurrentListItem;

            UInt32 pCurrentItem = pFirstItem;
            for (int i = 0; i < this.Last; i++)
            {
                Actor item = (Structures.Actor)Game.Memory.ReadObject(pCurrentItem, typeof(Structures.Actor));
                //Debug.Print(item.name + ": " + Enum.GetName(typeof(SNO.Actor), item.id_sno));
                items.Add(item);
                pCurrentItem = (UInt32)pCurrentItem + SizeOf;
            }
            return items;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tContainerActorCommonData
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string name;
        public UInt32 Limit;
        public UInt32 SizeOf;
        public Int32 Last;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public byte[] unknown_10C;
        public UInt32 pList;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] unknown_14C;
        public UInt32 Bits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] unknown_190;

        public List<Structures.ActorCommonData> GetList()
        {
            List<Structures.ActorCommonData> items = new List<Structures.ActorCommonData>();
            UInt32 offsetCurrentListItem = Game.Memory.ReadUInt((uint)pList); //todo Need to move this to MemoryNew
            UInt32 pFirstItem = (UInt32)offsetCurrentListItem;

            UInt32 pCurrentItem = pFirstItem;
            for (int i = 0; i < this.Last; i++)
            {
                ActorCommonData item = (Structures.ActorCommonData)Game.Memory.ReadObject(pCurrentItem, typeof(Structures.ActorCommonData));
                //Debug.Print(item.name + ": " + Enum.GetName(typeof(SNO.Actor), item.id_sno));
                items.Add(item);
                pCurrentItem = (UInt32)((UInt32)pCurrentItem + SizeOf);
            }
            return items;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tContainerFastAttribGroups
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string name;
        public UInt32 Limit;
        public UInt32 SizeOf;
        public Int32 Last;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public byte[] unknown_10C;
        public UInt32 pList;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] unknown_14C;
        public UInt32 Bits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] unknown_190;

        public List<Structures.AttributeGroup> GetList()
        {
            List<Structures.AttributeGroup> items = new List<Structures.AttributeGroup>();
            UInt32 offsetCurrentListItem = Game.Memory.ReadUInt((uint)pList); //todo Need to move this to MemoryNew
            UInt32 pFirstItem = (UInt32)offsetCurrentListItem;

            UInt32 pCurrentItem = pFirstItem;
            for (int i = 0; i < this.Last; i++)
            {
                AttributeGroup item = (Structures.AttributeGroup)Game.Memory.ReadObject(pCurrentItem, typeof(Structures.AttributeGroup));
                //Debug.Print(item.name + ": " + Enum.GetName(typeof(SNO.Actor), item.id_sno));
                items.Add(item);
                pCurrentItem = (UInt32)((UInt32)pCurrentItem + SizeOf);
            }
            return items;
        }
    }
}
