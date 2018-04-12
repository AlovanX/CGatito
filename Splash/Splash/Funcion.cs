using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Splash
{
    interface Funcion
    {

        //Método para editar tablas
        int ABM(string query);

        //Método para consultas
        DataSet Consulta(string tabla, string campo);
    }
}

