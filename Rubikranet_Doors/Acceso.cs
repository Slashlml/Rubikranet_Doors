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
using System.Data.SqlClient;

namespace Rubikranet_Doors
{
    public partial class Acceso : MaterialSkin.Controls.MaterialForm
    {
        public Acceso()
        {
            InitializeComponent();
        }

        
        int time = 0;
        string codigo;
        public string port;
        public string area;
        int cupoActual;

        private void Acceso_Load(object sender, EventArgs e)
        {
            serialCod.PortName = port;
            serialCod.Open();
            timer1.Start();
            txtRFID.Select();
            txtRFID.Focus();
        }
        

        private void txtRFID_TextChanged(object sender, EventArgs e)
        {
            if (txtRFID.Text != ""){

                conexion.Consulta(String.Format("EXEC AREAS_PROCEDURE '{0}','{1}'", txtRFID.Text,area));

                if (conexion.result.Read() == true){

                    if (Convert.ToInt32(conexion.result["cupo_actual"]) < Convert.ToInt32(conexion.result["cupo_maximo"])) {

                        lblHola.Visible = true;
                        lblHola.Text = "¡Acceso Correcto!";
                        imgcorrecto.Visible = true;
                        imguser.Visible = true;
                        lblacceso.Visible = true;
                        lblacceso.Text = "Hola " + conexion.result["nombre"].ToString() + " Bienvenid@";
                        txtRFID.Enabled = false;
                        cupoActual = Convert.ToInt32(conexion.result["cupo_actual"]);
                        cupoActual = cupoActual + 1;
                        conexion.Ejecutar(String.Format("EXEC ADD_CUPO '{0}','{1}' ", area, cupoActual));
                        time = 6;
                        timer2.Start();
                       
                    }
                    else
                    {
                        imgcorrecto.Visible = false;
                        imguser.Visible = false;
                        lblacceso.Visible = false;
                        lblHola.Visible = true;
                        imgdenegado.Visible = true;
                        lblHola.Text = "¡Limite de personas al máximo!";
                        time = 6;
                        timer2.Start();

                    }

                }else{

                    txtRFID.Enabled = false;
                    imgcorrecto.Visible = false;
                    imguser.Visible = false;
                    lblacceso.Visible = false;
                    lblHola.Visible = true;
                    imgdenegado.Visible = true;
                    time = 6;
                    timer2.Start();
                    lblHola.Text = "¡Error Acceso Incorrecto!";
                }
            }else{

                lblHola.Visible = false;
                lblacceso.Visible = false;
                imgcorrecto.Visible = false;
                imgdenegado.Visible = false;
                imguser.Visible = false;
            }


        }

        
        void conteo() { 

            if (time == 0){

                timer2.Stop();
                txtRFID.Enabled = true;
                txtRFID.Text = "";
                codigo = "";
            }
            else {

                time = time - 1;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            conteo();
        }

        private void serialCod_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            codigo = serialCod.ReadLine().Trim();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtRFID.Text = codigo;
        }
    }
}
