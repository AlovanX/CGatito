using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Splash
{
    public partial class frmBusqueda : Form
    {
        Perro perro = new Perro();
        Conexion con;
        string tabla = null;
        string query = null;

        public frmBusqueda()
        {
            InitializeComponent();
            CmbListaBusqueda.SelectedIndex = 0;
            
        }

        private void CmbListaBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbListaBusqueda.SelectedIndex)
            {
                case 0:
                    CmbParametro.Items.Clear();
                    CmbParametro.Items.Add("Todos");
                    CmbParametro.Items.Add("ID");
                    CmbParametro.Items.Add("Nombre");
                    CmbParametro.Items.Add("Raza");
                    CmbParametro.Items.Add("Ciudad");
                    CmbParametro.Items.Add("Colonia");
                    break;
                case 1:
                    CmbParametro.Items.Clear();
                    CmbParametro.Items.Add("Todos");
                    CmbParametro.Items.Add("ID");
                    CmbParametro.Items.Add("Raza");
                    CmbParametro.Items.Add("Ciudad");
                    CmbParametro.Items.Add("Colonia");
                    break;
                default:
                    break;
            }
            CmbParametro.SelectedIndex = 0;
        }

        private void CmbParametro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (CmbListaBusqueda.SelectedIndex)
            {
                case 0:
                    switch (CmbParametro.SelectedItem)
                    {
                        case "Todos":
                            TxtBusqueda.Enabled = false;
                            BtnBuscar.Enabled = false;
                            tabla = "ReporteExtravio";
                            query = "select re.id_rep_ext as 'ID', re.fecha_perdido as 'Fecha extravío', re.nombre as 'Nombre', re.estado as 'Estatus', re.raza as 'Raza', re.color as 'Color', re.placa as 'Placa', re.caracteristicas as 'Características', re.ciudad as 'Ciudad', re.colonia as 'Colonia', u.nombre as 'Nombre usuario', u.correo as 'Email'  from ReporteExtravio re join Usuario u on re.id_usuario = u.id_usuario";
                            BusquedaGeneral(tabla, query);
                            break;
                        default:
                            TxtBusqueda.Enabled = true;
                            BtnBuscar.Enabled = true;
                            break;
                    }
                    break;
                case 1:
                    switch (CmbParametro.SelectedItem)
                    {
                        case "Todos":
                            TxtBusqueda.Enabled = false;
                            BtnBuscar.Enabled = false;
                            tabla = "ReporteEncontrado";
                            query = "select re.id_rep_enc as 'ID', re.fecha_enc as 'Fecha encontrado', re.estado as 'Estatus', re.raza as 'Raza', re.color as 'Color', re.placa as 'Placa', re.caracteristicas as 'Características', re.ciudad as 'Ciudad', re.colonia as 'Colonia', re.resguardado as 'Resguardado', u.nombre as 'Nombre Usuario', u.correo as 'Email' from ReporteEncontrado re join Usuario u on re.id_usuario = u.id_usuario";
                            BusquedaGeneral(tabla, query);
                            break;
                        default:
                            TxtBusqueda.Enabled = true;
                            BtnBuscar.Enabled = true;
                            break;
                    }
                    break;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string id = null;
            string fecha = null;
            switch (CmbListaBusqueda.SelectedIndex)
            {
                case 0:
                    tabla = "ReporteExtravio";
                    id = "re.id_rep_ext";
                    fecha = "re.fecha_perdido";
                    query = "Select " + id + " as 'ID', " + fecha + " as 'Fecha', re.nombre as 'Nombre', re.estado as 'Estatus', re.raza as 'Raza', re.color as 'Color', re.placa as 'Placa', re.caracteristicas as 'Características', re.ciudad as 'Ciudad', re.colonia as 'Colonia', u.nombre as 'Nombre usuario', u.correo as 'Email'  from " + tabla + " re join Usuario u on re.id_usuario = u.id_usuario where ";
                    break;
                case 1:
                    tabla = "ReporteEncontrado";
                    id = "re.id_rep_enc";
                    fecha = "re.fecha_enc";
                    query = "select "+id+ " as 'ID', " + fecha + " as 'Fecha encontrado', re.estado as 'Estatus', re.raza as 'Raza', re.color as 'Color', re.placa as 'Placa', re.caracteristicas as 'Características', re.ciudad as 'Ciudad', re.colonia as 'Colonia', re.resguardado as 'Resguardado', u.nombre as 'Nombre Usuario', u.correo as 'Email' from  " + tabla + "  re join Usuario u on re.id_usuario = u.id_usuario where ";
                    break;
                default:
                    break;
            }

            if (validarVacio())
            {
                switch (CmbParametro.SelectedItem)
                {
                    case "ID":
                         query += id+"=" + TxtBusqueda.Text;
                        break;
                    case "Nombre":
                        query += "re.nombre like '%" + TxtBusqueda.Text + "%'";
                        break;
                    case "Raza":
                        query += "re.raza like '%" + TxtBusqueda.Text + "%'";
                        break;
                    case "Ciudad":
                        query += "re.ciudad like '%" + TxtBusqueda.Text + "%'";
                        break;
                    case "Colonia":
                        query += "re.colonia like '%" + TxtBusqueda.Text + "%'";
                        break;
                    default:
                        break;
                }
                BusquedaGeneral(tabla, query);
            }
        }
        
        public void BusquedaGeneral(string tabla, string query)
        {
            try
            {
                DataSet data = new DataSet();
                data = perro.ConsultaParametrizada(tabla, query);
                datagridBusqueda.DataSource = data.Tables[tabla];
                
            }
            catch (Exception)
            {
                
            }
            
            
            
        }

        public bool validarVacio()
        {
            if (TxtBusqueda.Text == "" || TxtBusqueda.Text == ".")
            {
                mensaje_error.Clear();
                mensaje_error.SetError(TxtBusqueda, "Ingresa un parámetro para iniciar la búsqueda");
                TxtBusqueda.Text = "";
                TxtBusqueda.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        
    }
}
