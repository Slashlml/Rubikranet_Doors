using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MetroSet_UI.Controls;
using System.IO.Ports;

namespace Rubikranet_Doors
{
    public partial class puerto : MaterialSkin.Controls.MaterialForm
    {
        public puerto()
        {
            InitializeComponent();
        }

        void conexion_puertos(){

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                select_puertos.Items.Add(port);
            }
        }

        void areas() {

            conexion.Consulta(String.Format("select id_area,nombre from areas"));
            conexion.CargaCombos("Selecciona un área", select_areas, "id_area", "nombre");
            conexion.con.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (select_puertos.Text == "") {

                MessageBox.Show("Selecciona un puerto");

            } else {

                if (select_areas.Text == ""){

                    MessageBox.Show("Selecciona un área");
                }
                else {

                    Acceso access = new Acceso();
                    access.port = select_puertos.Text;
                    string newarea = (select_areas.SelectedItem as conexion.AttrCB).Value.ToString();
                    access.area = newarea;
                    //access.area =select_areas.SelectedValue);
                    this.Hide();
                    access.ShowDialog();
                }
                
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            select_puertos.Items.Clear();
            conexion_puertos();
        }

        private void puerto_Load(object sender, EventArgs e)
        {
            conexion_puertos();
            areas();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }
       
    }
}
