using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Magic;
using System.Diagnostics;
using D3x;

namespace Sample
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }

        private void Sample_Load(object sender, EventArgs e)
        {
            try
            {
                Game.Attach(SProcess.GetProcessesFromWindowTitle("Diablo III")[0]);
                Debug.Print("DEBUG: count: " + Game.ObjectManager.Storage.GetActorContainer().GetList().Count);
                int i = 0;
                foreach (D3x.Structures.Actor actor in Game.ObjectManager.Storage.GetActorContainer().GetList())
                {
                    String tmp = (i++).ToString() + ": ";
                    tmp += System.Text.Encoding.ASCII.GetString(actor.name).TrimEnd(new char[] { (char)0 });

                    /*try
                    {
                        float hp = actor.GetFAG().GetFloat((uint)D3x.Enumerators.ActorAttribute.Hitpoints_Cur);
                        if (hp > 0)
                        {
                            tmp += ", HP: " + hp.ToString();
                        }
                    }
                    catch (Exception) { }*/

                    lstActors.Items.Add(tmp);
                }

                i = 0;
                foreach (D3x.Structures.ActorCommonData acd in Game.ObjectManager.Storage.GetActorCommonDataContainer().GetList())
                {
                    String tmp = (i++).ToString() + ": ";
                    tmp += acd.GetName();
                    tmp += " ------ "+Enum.GetName(typeof(D3x.Enumerators.ItemLocation), acd.itemLoc);
                    /*try
                    {
                        float hp = actor.GetFAG().GetFloat((uint)D3x.Enumerators.ActorAttribute.Hitpoints_Cur);
                        if (hp > 0)
                        {
                            tmp += ", HP: " + hp.ToString();
                        }
                    }
                    catch (Exception) { }*/

                    lstACDs.Items.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
