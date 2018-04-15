using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Splash
{
    abstract class Conexion
    {
        //Conexion ivan
        public static SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS; AttachDbFilename =" + Environment.CurrentDirectory
        + "\\DB\\Perros.mdf; Integrated Security=True; Connect Timeout=30; User Instance = True");

        //public static SqlConnection conn = new SqlConnection("Server = SAVE-PC\\ALLICE; AttachDbFilename =" + Environment.CurrentDirectory
        //+ "\\Perros.mdf; Trusted_Connection=True");



        //Conexion save
        //public static SqlConnection conn =
        //new SqlConnection("Server = SAVE-PC\\ALLICE;AttachDbFilename =" + Environment.CurrentDirectory + "\\Perros.mdf;Trusted_Connection=True");
        //new SqlConnection("Server = localhost\\sqlexpress;Database=Perros;Trusted_Connection=True");
        public void CerrarConexion()
        {
            conn.Close();
        }

    }
}





