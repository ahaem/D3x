using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AttributeGroup
    {
        public UInt32 id_attrib; // 0x000 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] unknown_4; // 0x004 
        public UInt32 pFormula; // 0x010 CAttribFormula* Formula;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
        public byte[] unknown_14; // 0x014 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 292)]
        public byte[] unknown_38; // 0x014 
        //tMap<tAttribLink *, 33> Links;     // 0x038 
        // UCHAR unknown_CC[144];     // 0x0CC 
    }
}
