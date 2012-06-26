using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace D3x.Structures
{

    public class FAG
    {
        public uint ptr;

        public FAG(uint _fag_ptr)
        {
            ptr = _fag_ptr;
        }

        public int GetInt(uint a2)
        {
            int ret = get_attribute(this.ptr, a2);

            if (ret != 0)
            {
                int return_value = (int)Game.Memory.ReadUInt((uint)ret + 8);
                //NewObject("return_value: " + return_value);
                return return_value;
            }
            return -1;
        }


        public float GetFloat(uint a2)
        {
            a2 = a2 | 0xFFFFF000;

            int ret = get_attribute(this.ptr, a2);

            if (ret != 0)
            {
                float return_value = Game.Memory.ReadFloat((uint)ret + 8);
                //NewObject("return_value: " + return_value);
                return return_value;
            }
            return -1;
        }

        private static int get_attribute(uint this_, uint a2)
        {

            # region


            int v4; // esi@1
            uint result; // eax@1

            //NewObject("this_: " + this_.ToString("x8"));

            //int v3 = this_;
            uint _10 = Game.Memory.ReadUInt(this_ + 0x10);
            //NewObject("_10: " + _10.ToString("x8"));

            uint _418 = Game.Memory.ReadUInt(_10 + 0x418);
            //NewObject("_418: " + _418.ToString("x8"));

            uint _08 = Game.Memory.ReadUInt(_10 + 0x8);
            //NewObject("_08: " + _08.ToString("x8"));


            v4 = (int)(_418 & (a2 ^ (a2 >> 0x10)));
            //NewObject("v4: " + v4.ToString("x8"));

            uint _res = (uint)((int)_08 + 4 * v4);

            //NewObject("_res: " + _res.ToString("x8"));

            result = Game.Memory.ReadUInt((uint)_res);
            //NewObject("result: " + result.ToString("x8"));
            if (result != 0)
            {
                while (Game.Memory.ReadUInt(result + 0x4) != a2)
                {
                    int zz = (int)Game.Memory.ReadUInt(result + 0x4);
                    //NewObject("zz: " + zz.ToString("x8"));
                    //NewObject("result: " + result.ToString("x8"));
                    result = Game.Memory.ReadUInt(result);
                    if (result == 0)
                    {
                        break;
                        return 0;
                        //goto LABEL_4;
                    }
                }
                //*(result + 8) = a3;
            }
            //NewObject("end-result: " + result.ToString("x8"));
            return (int)result;

            # endregion

        }
    }

    public class D3Attributes
    {

        static D3Attributes main;
        public static D3Attributes Main
        {
            get
            {
                if (main == null)
                {
                    main = new D3Attributes();
                }
                return main;
            }
        }

        # region Fields

        Dictionary<string, int> dict = new Dictionary<string, int>();

        # endregion

        # region Constructors

        public D3Attributes()
        {
            Init();
        }

        # endregion

        # region Methods

        private void Init()
        {

            int count = (0x155159C - 0x1549504) / 0x28;
            for (int i = 0; i < count; i++)
            {
                int ptr = 0x1549504 + i * 0x28;

                //int name_ptr = Game.gu(ptr);
                //string name = Memory.ReadCString((IntPtr)(name_ptr), 100, "");
                //int value = Memory.Read<int>((IntPtr)(0x15494E8 + i * 0x28), "");

                //dict.Add(name, value);
                //Console.WriteLine("i: " + i + " name: " + name);
                //Console.WriteLine("ptr " + _ptr.ToString("x8"));
                //Console.WriteLine("value " + value.ToString("x8"));
            }

        }

        public int GetAttribute(string attribute)
        {
            if (dict.ContainsKey(attribute))
            {
                return dict[attribute];
            }
            return -1;
        }

        # endregion

    }

    [StructLayout(LayoutKind.Explicit)]
    public struct AttributeGroup
    {
        [FieldOffset(0x000)]
        public UInt32 id_attrib; // 0x000 

        [FieldOffset(0x004)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] unknown_4; // 0x004 

        [FieldOffset(0x010)]
        public UInt32 pFormula; // 0x010 CAttribFormula* Formula;

        [FieldOffset(0x014)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
        public byte[] unknown_14; // 0x014 

        [FieldOffset(0x038)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 148)]
        public byte[] unknown_38; // 0x038 

        [FieldOffset(0x0CC)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 144)]
        public byte[] unknown_CC; // 0x0CC 


        [FieldOffset(0x010)]
        public UInt32 addressBase; // 

        //tMap<tAttribLink *, 33> Links;     // 0x038 
        // UCHAR unknown_CC[144];     // 0x0CC 


        public uint GetAttribute(uint attribute)
        {
            uint CAttribFormula = Game.Memory.ReadUInt(addressBase + 0x10);
            uint _418 = Game.Memory.ReadUInt(CAttribFormula + 0x418);
            uint AttributesMap = Game.Memory.ReadUInt(CAttribFormula + 0x8);
            uint IndexMask = (_418 & (attribute ^ (attribute >> 0x10)));
            uint _res = (AttributesMap + 4 * IndexMask);
            uint result = Game.Memory.ReadUInt(_res);
            if (result != 0)
            {
                while (Game.Memory.ReadUInt(result + 0x4) != attribute)
                {
                    result = Game.Memory.ReadUInt(result);

                    if (result == 0)
                    {
                        break;
                    }
                }
            }
            return result;
        }
    }
}
