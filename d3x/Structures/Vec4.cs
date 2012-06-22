using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Vec4
    {
        public float x; // 0x000 
        public float y; // 0x004 
        public float z; // 0x008 
        public float w; // 0x00C 
    };
}

