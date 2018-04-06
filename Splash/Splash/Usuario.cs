using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Splash
{
    class Usuario : Conexion, Funcion
    {
        //Recuerda que este metodo se puede usar para altas, bajas y modificaciones.
        public int ABM(string query)
        {
            int respuesta = -1;

            try
            {
                //Asigna al comando la instruccion SQL y la conexion
                SqlCommand comando = new SqlCommand(query, conn);

                //Abre la conexion a la base de datos
                conn.Open();

                //Ejecuta la instruccion sql y ésta devuelve la respuesta 1 exito, 0 error
                respuesta = comando.ExecuteNonQuery();

            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                //Cierra la conexion SQL
                CerrarConexion();
            }

            return respuesta;

        }

        //Método de consulta general de usuarios, regresa un DataSet para usar en una tabla
        public DataSet Consulta(string tabla, string campo)
        {
            try
            {
                // DataSet es un almacén de información en memoria, está desconectado de la base de datos
                DataSet DatSet = new DataSet();

                // SQLDataAdatpter es la herramienta que se utiliza para realizar operaciones fisicas en la base de datos (Select, Insert, etc).
                SqlDataAdapter adaptador = new SqlDataAdapter();

                // Se agrega el query
                String consulta = "Select * from " + tabla + " order by " + campo + " ASC";

                // SqlCommand permite ejecutar el query utilizando la información de conexión a la base de datos.
                SqlCommand comando = new SqlCommand(consulta, conn);

                // se le asigna el comando escrito al adaptador
                adaptador.SelectCommand = comando;

                // Se establece la conexión a la BD
                conn.Open();

                // Se ejecuta el comando y se llena la tabla almacenada en la memoria
                adaptador.Fill(DatSet, tabla);

                //Regresa los datos obtenidos por la consulta
                return DatSet;
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                CerrarConexion();
            }
        }

        //Busca el usuario y contraseña que le envies por parametro, devuelve true o false
        public bool IniciarSesion(string user, string pass)
        {


            try
            {

                //string query = "Select * from usuario where correo = " + user + " and contraseña='" + pass + "'";


                //SqlCommand comando = new SqlCommand(query, conn);
                conn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT id_usuario, nombre FROM Usuario WHERE correo='"
                    + user + "' AND contraseña='" + pass + "'", conn);
            //Creando una tabla virtual
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //if (dt.Rows[0][1].ToString() == "1")
            if (dt.Rows.Count > 0)
            {
                string id_user = dt.Rows[0][0].ToString();  //Guardamos id y nombre de usuario
                string nombre_user = dt.Rows[0][1].ToString();
                //Si el login es exitoso se redirecciona al la pagina de inicio
                //this.Hide();
                new Escritorio(id_user, nombre_user).Show();
                    return true;
            }
            else

                MessageBox.Show("Usuario o contraseña invalida");
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }


        }
    }


}