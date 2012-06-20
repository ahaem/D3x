using System;
using System.Collections.Generic;
using System.Text;

namespace D3x.Structures
{
   unsafe public struct AttributeGroupsContainer
    {
    public Wtf a; // 0x000 
    public Wtf b; // 0x01C 
    public Wtf c; // 0x038 
    public Wtf d; // 0x054 
    //public Container<CAttribGroup>* FastAttribGroups; // 0x070 
    public fixed byte unknown_74[32]; // 0x074 
    }
}
