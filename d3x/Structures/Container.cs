using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    unsafe public struct Container<T>
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string name;
        public UInt32 Limit;
        public UInt32 SizeOf;
        public Int32 Last;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public byte[] unknown_10C;
        public IntPtr List;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] unknown_14C;
        public UInt32 Bits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] unknown_190;
    }

    [StructLayout(LayoutKind.Sequential)]
    unsafe public struct ContainerActor
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string name;
        public UInt32 Limit;
        public UInt32 SizeOf;
        public Int32 Last;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public byte[] unknown_10C;
        public IntPtr pList;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] unknown_14C;
        public UInt32 Bits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] unknown_190;

        public List<Structures.Actor> GetList()
        {
            List<Structures.Actor> items = new List<Structures.Actor>();
            //IntPtr pSomething = pList; // This is the first pointer, an iterator maybe?
            //IntPtr pFirstItem = (IntPtr)Marshal.ReadIntPtr(pSomething);
            UInt32 offsetCurrentListItem = Game.Memory.ReadUInt((uint) pList); //debug Not sure why two times. Missing something.
            IntPtr pFirstItem = (IntPtr)offsetCurrentListItem;

            IntPtr pCurrentItem = pFirstItem;
            for (int i = 0; i < this.Last; i++)
            {
                Actor item = (Structures.Actor)Game.MemoryNew.Read(pCurrentItem, typeof(Structures.Actor));
                items.Add(item);
                pCurrentItem = (IntPtr)((UInt32)pCurrentItem + SizeOf);
            }
            return items;
        }
    }
}
