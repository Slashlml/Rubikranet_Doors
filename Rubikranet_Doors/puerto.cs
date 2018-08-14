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

        private void puerto_Load(object sender, EventArgs e)
        {
            conexion_puertos();
            areas();
        }

        private void conexion_puertos(){

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                select_puertos.Items.Add(port);
            }
        }

        private void areas() {

            conexion.Consulta(String.Format("select id_area,nombre from areas where estatusEliminado <> 1"));
            conexion.CargaCombos("Selecciona un área...", select_areas, "id_area", "nombre");
            conexion.con.Close();
            select_areas.SelectedIndex = 0;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (select_puertos.Text == "" || select_areas.SelectedIndex == 0)
            {
                Mensajes.Caja("Information", "Aviso", "Es necesario seleccionar el puerto y el área para poder continuar.");
            }
            else
            {
                Acceso access = new Acceso();
                access.port = select_puertos.Text;
                string newarea = (select_areas.SelectedItem as conexion.AttrCB).Value.ToString();
                access.area = newarea;
                this.Hide();
                access.ShowDialog();
                this.Close();
            }
        }

        private void btnRefresca_Click(object sender, EventArgs e)
        {
            select_puertos.Items.Clear();
            conexion_puertos();
        }
    }
}
