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
        int time = 0;
        string codigo;
        public string port;
        public string area;
        string id_cliente = "", id_miembro = "", nombreCliente = "";
        bool tipoEdad = false, edad_miembro = false;
        int cupo_maximo = 0, cupo_actual = 0;
        int cupoActual;

        public Acceso()
        {
            InitializeComponent();
        }

        private void Acceso_Load(object sender, EventArgs e)
        {
            serialCod.PortName = port;
            serialCod.Open();
            EdadAccesibilidadArea();
            timer1.Start();
        }
        
        private void EdadAccesibilidadArea()
        {
            conexion.Consulta(
                string.Format("select codigo_edad_accesibilidad from areas where id_area = '{0}'", area)
                );

            if (conexion.result.Read())
            {
                tipoEdad = Convert.ToBoolean(conexion.result["codigo_edad_accesibilidad"]);
            }

            conexion.con.Close();
        }

        private void txtRFID_TextChanged(object sender, EventArgs e)
        {
            if (txtRFID.Text != "")
            {
                string verificaTipoCliente = "";

                conexion.Consulta(String.Format("EXEC verificaCliente '{0}','{1}'", txtRFID.Text, area));
                if (conexion.result.HasRows)
                {
                    verificaTipoCliente = "cliente";

                    if (conexion.result.Read())
                    {
                        id_cliente = conexion.result["id_cliente"].ToString();
                        nombreCliente = conexion.result["nombre"].ToString();
                        cupo_maximo = Convert.ToInt32(conexion.result["cupo_maximo"].ToString());
                        cupo_actual = Convert.ToInt32(conexion.result["cupo_actual"].ToString());
                    }

                    conexion.con.Close();
                }

                conexion.Consulta(String.Format("EXEC verificaMiembro '{0}','{1}'", txtRFID.Text, area));
                if (conexion.result.HasRows)
                {
                    verificaTipoCliente = "miembro";

                    if (conexion.result.Read())
                    {
                        id_cliente = conexion.result["id_cliente"].ToString();
                        nombreCliente = conexion.result["nombre"].ToString();
                        id_miembro = conexion.result["id_membresia_familiar"].ToString();
                        edad_miembro = Convert.ToBoolean(conexion.result["tipo_edad"]);
                        cupo_maximo = Convert.ToInt32(conexion.result["cupo_maximo"].ToString());
                        cupo_actual = Convert.ToInt32(conexion.result["cupo_actual"].ToString());
                    }

                    conexion.con.Close();
                }

                switch (verificaTipoCliente)
                {
                    case "cliente":
                        if (cupo_actual < cupo_maximo)
                        {
                            Mensajes.Caja("Information", "Acceso", "Bienvenido " + nombreCliente);
                            conexion.Ejecutar(
                                string.Format("exec actualiza_Areas_VisitadasAndCupo '{0}','{1}','{2}','{3}'"));
                            time = 4;
                            timer2.Start();
                        }
                        else
                        {
                            Mensajes.Caja("Warning", "Aviso", "Esta área se encuentra llena.");
                            time = 4;
                            timer2.Start();
                        }
                        break;

                    case "miembro":
                        if (cupo_actual < cupo_maximo)
                        {
                            if (!tipoEdad && !edad_miembro || tipoEdad && !edad_miembro)
                            {
                                Mensajes.Caja("Information","Acceso","Bienvenido "+nombreCliente);
                                time = 4;
                                timer2.Start();
                            }
                            else if(!tipoEdad && edad_miembro)
                            {
                                Mensajes.Caja("Error","Accesibilidad","No puedes acceder a esta área "+ nombreCliente + ", solo adultos.");
                                time = 4;
                                timer2.Start();
                            }
                        }
                        else
                        {
                            Mensajes.Caja("Warning", "Aviso", "Esta área se encuentra llena.");
                        }
                        break;

                    default:
                        Mensajes.Caja("Error", "Accesibilidad", "No tienes permiso para acceder a esta área.");
                        time = 4;
                        timer2.Start();
                        break;
                }
            }
        }

        void conteo()
        {
            if (time == 0)
            {
                time = -1;
                timer2.Stop();
                txtRFID.Text = "";
                codigo = "";
            }
            else
            {
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
            if (codigo != "")
            {
                txtRFID.Text = codigo;
            }            
        }
    }
}
