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
        public static Structures.ObjectManager ObjectManager;

        public static void Attach(Int32 procId)
        {
            try
            {
                Game.Memory.OpenProcessAndThread(procId);
                UInt32 addrObjectManager = Game.Memory.ReadUInt(Offsets.objectManager);
                ObjectManager = (Structures.ObjectManager)Memory.ReadObject((UInt32)addrObjectManager, typeof(Structures.ObjectManager));

                Structures.Actor Me;
                foreach (Structures.Actor actor in Game.ObjectManager.Storage.GetActors())
                {
                    if (actor.id_acd == 0x77BC0000) Me = actor;
                }

                foreach (Structures.AttributeGroup attrib in Game.ObjectManager.Storage.GetFastAttribGroupsContainer().GetFastAttribGroupsContainer().GetList())
                {
                    //Debug.Print(attrib.id_attrib);
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message.ToString());
            }
        }
    }
}
