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
                Debug.Print("DEBUG: count: " + Game.ObjectManager.Storage.Actors.Count);
                foreach (Actor actor in Game.ObjectManager.Storage.Actors)
                {
                    lstActors.Items.Add(actor.Name);
                }
                Debug.Print("OLD: " + Game.ObjectManager.Data.frame.ToString());
                Debug.Print("NEW: " + Game.ObjectManagerNew.Data.FrameCurrent.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
