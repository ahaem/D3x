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

        public static void Attach(Int32 procId)
        {
            try
            {
                Game.Memory.OpenProcessAndThread(procId);
                UInt32 addrObjectManager = Game.Memory.ReadUInt(Offsets.objectManager);
                ObjectManager = new ObjectManager(addrObjectManager);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message.ToString());
            }
        }
    }
}
