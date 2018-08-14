using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubikranet_Doors
{
    public partial class Carga : Form
    {
        public Carga()
        {
            InitializeComponent();
        }

        private void Carga_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            for (int i = 0; i < 10000; i++)
            {
                metroProgressSpinner1.Value = i;

                if (i == 9999)
                {
                    timer1.Stop();
                    puerto access = new puerto();
                    this.Hide();
                    access.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
