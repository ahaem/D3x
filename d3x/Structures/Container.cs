using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    unsafe public struct Container<T>
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public char[] name;
        public ulong Limit;
        public ulong SizeOf;
        public long Last; 
        public fixed byte  unknown_10C[60];
        //public T** List; 
        public fixed byte  unknown_14C[64];
        public ulong Bits; 
        public fixed byte  unknown_190[64];
    }
}
