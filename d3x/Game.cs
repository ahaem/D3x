using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Magic;

namespace D3x
{
    public static class Game
    {
        public static BlackMagic Memory = new BlackMagic();
        public static ObjectManager ObjectManager;
        public static Structures.ObjectManager ObjectManagerNew;

        public static ProcessMemoryReader MemoryNew;
        public static void Attach(Int32 procId)
        {
            try
            {
                Game.Memory.OpenProcessAndThread(procId);
                UInt32 addrObjectManager = Game.Memory.ReadUInt(Offsets.objectManager);
                ObjectManager = new ObjectManager(addrObjectManager);

                MemoryNew = new ProcessMemoryReader(Process.GetProcessById(procId));
                ObjectManagerNew = (Structures.ObjectManager)MemoryNew.Read((IntPtr)addrObjectManager, typeof(Structures.ObjectManager));

                Structures.Actor actor = (Structures.Actor)MemoryNew.Read((IntPtr)(addrObjectManager + 0x919690), typeof(Structures.Actor));
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message.ToString());
            }
        }
    }
}
