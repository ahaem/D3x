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
                foreach (D3x.Structures.Actor actor in Game.ObjectManager.Storage.GetActorContainer().GetList())
                {
                    lstActors.Items.Add(actor.name);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
