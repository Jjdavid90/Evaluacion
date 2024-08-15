using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.Common;


namespace Gestion_de_Hoteles.config
{
    internal class ConexionBDD
    {
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-684TDNM;Database=Gestion_de_hoteles;User Id=sa;Password=1234;");
        

        public SqlConnection AbrirConexion()
        {

            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexion" + ex.ToString());

            }

            return conexion;


        }

        public SqlConnection CerrarConexion()
        {

            try
            {

                if (conexion.State == ConnectionState.Open)
                    conexion.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror al cerrar la conexion: " + ex.ToString());

            }

            return conexion;
        }






    }
}