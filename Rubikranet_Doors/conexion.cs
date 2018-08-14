using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rubikranet_Doors
{
    class conexion
    {
        public static SqlConnection con; //variable de conexión
        public static SqlDataReader result; // variable pública que contendrá los valores devueltos de una consulta del método Consulta().

        private static String cadenaConexion = "Data Source=VAIO-PC;Initial Catalog=membresias_club;Integrated Security=True";


        public static void Consulta(string comando){
            try{
                    con = new SqlConnection(cadenaConexion);
                    con.Open();

                    SqlCommand query = con.CreateCommand();
                    query.CommandText = comando;

                    result = query.ExecuteReader();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de base de datos en Consulta(). "+ e.ToString());
            }

        }

        public class AttrCB
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        public static void CargaCombos(string text0, object o, string value, string text)
        {
            con = new SqlConnection(cadenaConexion);
            con.Open();
            var combo = o as MetroSet_UI.Controls.MetroSetComboBox;

            AttrCB item0 = new AttrCB();
            item0.Value = "0";
            item0.Text = text0;

            combo.Items.Add(item0);

            while (result.Read())
            {
                AttrCB item = new AttrCB();

                item.Value = result[value].ToString();
                item.Text = result[text].ToString();

                combo.Items.Add(item);
            }
           
        }

        public static void Ejecutar(string comando)
        {
            try
            {
                con = new SqlConnection(cadenaConexion);
                con.Open();

                SqlCommand query = con.CreateCommand();
                query.CommandText = comando;

                int AffectedRows = query.ExecuteNonQuery();

                var result = AffectedRows > 0 ? 0 : MessageBox.Show("No se ejecutó correctamente.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Se produjo un error en 'Ejecutar()': " + e.ToString(), "Error de base de datos.");
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }
    }
}
