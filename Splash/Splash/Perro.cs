using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Splash
{
    class Perro : Conexion, Funcion
    {
        //Método para altas bajas y modificaciones
        public int ABM(string query)
        {
            int respuesta = -1;

            try
            {
                //Asigna al comando la instruccion SQL y la conexion
                SqlCommand comando = new SqlCommand(query, conn);

                //Abre la conexion a la base de datos
                conn.Open();

                //Ejecuta la instruccion sql y devuelve 1 si se ejecutó con éxito o 0 si falló
                respuesta = comando.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //Cierra la conexion SQL
                CerrarConexion();
            }

            return respuesta;
        }

        //Método de consulta general de perros, regresa un DataSet para usar en una tabla
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

        //Método de consulta general de perros, regresa un DataSet para usar en una tabla
        public DataSet ConsultaParametrizada(string tabla, string query)
        {
            try
            {
                // DataSet es un almacén de información en memoria, está desconectado de la base de datos
                DataSet DatSet = new DataSet();

                // SQLDataAdatpter es la herramienta que se utiliza para realizar operaciones fisicas en la base de datos (Select, Insert, etc).
                SqlDataAdapter adaptador = new SqlDataAdapter();

                // Se agrega el query
                String consulta = query;

                // SqlCommand permite ejecutar el query utilizando la información de conexión a la base de datos.
                SqlCommand comando = new SqlCommand(consulta, conn);

                // se le asigna el comando escrito al adaptador
                adaptador.SelectCommand = comando;

                // Se establece la conexión a la BD
                conn.Open();

                // Se ejecuta el comando y se llena la tabla almacenada en la memoria
                adaptador.Fill(DatSet,tabla);

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

        public SqlDataReader consultaId(string codConsulta)
        {
            try
            {
                SqlCommand command = new SqlCommand(codConsulta, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                return reader;
            }
            catch (Exception)
            {
                return null;
            }

            
        }


    }
}