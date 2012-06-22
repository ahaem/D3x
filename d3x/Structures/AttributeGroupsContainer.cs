using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{
    //todo untested
    [StructLayout(LayoutKind.Sequential, Size = 0x94)]
    unsafe public struct AttributeGroupsOuterContainer
    {
        public Wtf a; // 0x000 
        public Wtf b; // 0x01C 
        public Wtf c; // 0x038 
        public Wtf d; // 0x054 
        public UInt32 pFastAttribGroupsContainer; // 0x070 tContainer<CAttribGroup>* FastAttribGroups;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] unknown_74; // 0x074 

        // FastAttribGroupsContainer
        public Structures.tContainerFastAttribGroups GetFastAttribGroupsContainer()
        {
            return (Structures.tContainerFastAttribGroups)Game.Memory.ReadObject(pFastAttribGroupsContainer, typeof(Structures.tContainerFastAttribGroups));
        }
    }
}
