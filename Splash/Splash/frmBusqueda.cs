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
        Escritorio desk;
        Conexion con;
        frmReporte repo;
        

        string tabla = null;
        string query = null;


        public frmBusqueda(Escritorio m)
        {
            InitializeComponent();
            CmbListaBusqueda.SelectedIndex = 0;

            this.desk = m;
            dpInicio.Value = DateTime.Today.AddDays(-365);
            dpFin.Value = DateTime.Today;
            mensaje_error.Clear();
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
            BusquedaGeneral();
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BusquedaParametrizada();
        }

        public void BusquedaParametrizada()
        {
            string id = null;
            string fecha = null;
            switch (CmbListaBusqueda.SelectedIndex)
            {
                case 0:
                    tabla = "ReporteExtravio";
                    id = "re.id_rep_ext";
                    fecha = "re.fecha_perdido";
                    query = "Select " + id + " as 'ID', " + fecha + " as 'Fecha', re.nombre as 'Nombre', re.estado as 'Estatus', re.raza as 'Raza', re.color as 'Color', re.placa as 'Placa', re.caracteristicas as 'Características', re.ciudad as 'Ciudad', re.colonia as 'Colonia', u.nombre as 'Nombre usuario', u.correo as 'Email'  from " + tabla + " re join Usuario u on re.id_usuario = u.id_usuario ";
                    break;
                case 1:
                    tabla = "ReporteEncontrado";
                    id = "re.id_rep_enc";
                    fecha = "re.fecha_enc";
                    query = "select " + id + " as 'ID', " + fecha + " as 'Fecha encontrado', re.estado as 'Estatus', re.raza as 'Raza', re.color as 'Color', re.placa as 'Placa', re.caracteristicas as 'Características', re.ciudad as 'Ciudad', re.colonia as 'Colonia', re.resguardado as 'Resguardado', u.nombre as 'Nombre Usuario', u.correo as 'Email' from  " + tabla + "  re join Usuario u on re.id_usuario = u.id_usuario ";
                    break;
                default:
                    break;
            }

            mensaje_error.Clear();
            if (dpInicio.Value.CompareTo(dpFin.Value) <= 0)
            {
                if (validarVacio())
                {
                    string texto = null;
                    if (TxtBusqueda.Text.Contains("*"))
                    {
                        texto = TxtBusqueda.Text.Replace('*', '%');
                    }
                    else
                    {
                        texto = TxtBusqueda.Text;
                    }
                    switch (CmbParametro.SelectedItem)
                    {
                        case "ID":
                            query += "where " + id + " = '" + texto + "' and " + fecha + " between '" + dpInicio.Value.Date.ToString("yyyyMMdd") + "' and '" + dpFin.Value.Date.ToString("yyyyMMdd") + "'";
                            break;
                        case "Nombre":
                            query += "where re.nombre like '" + texto + "' and " + fecha + " between '" + dpInicio.Value.Date.ToString("yyyyMMdd") + "' and '" + dpFin.Value.Date.ToString("yyyyMMdd") + "'";
                            break;
                        case "Raza":
                            query += "where re.raza like '" + texto + "' and " + fecha + " between '" + dpInicio.Value.Date.ToString("yyyyMMdd") + "' and '" + dpFin.Value.Date.ToString("yyyyMMdd") + "'";
                            break;
                        case "Ciudad":
                            query += "where re.ciudad like '" + texto + "' and " + fecha + " between '" + dpInicio.Value.Date.ToString("yyyyMMdd") + "' and '" + dpFin.Value.Date.ToString("yyyyMMdd") + "'";
                            break;
                        case "Colonia":
                            query += "where re.colonia like '" + texto + "' and " + fecha + " between '" + dpInicio.Value.Date.ToString("yyyyMMdd") + "' and '" + dpFin.Value.Date.ToString("yyyyMMdd") + "'";
                            break;
                        default:
                            break;
                    }
                    ConsultaTabla(tabla, query);
                }
            }
            else
            {
                mensaje_error.SetError(dpFin, "La fecha de fin debe ser igual o mayor a la fecha de inicio");
            }
        }

        public void BusquedaGeneral()
        {
            mensaje_error.Clear();
            if (dpInicio.Value.CompareTo(dpFin.Value) <= 0)
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
                                query = "select re.id_rep_ext as 'ID', re.fecha_perdido as 'Fecha extravío', re.nombre as 'Nombre', re.estado as 'Estatus', re.raza as 'Raza', re.color as 'Color', re.placa as 'Placa', re.caracteristicas as 'Características', re.ciudad as 'Ciudad', re.colonia as 'Colonia', u.nombre as 'Nombre usuario', u.correo as 'Email'  from ReporteExtravio re join Usuario u on re.id_usuario = u.id_usuario where re.fecha_perdido between '" + dpInicio.Value.Date.ToString("yyyyMMdd") + "' and '" + dpFin.Value.Date.ToString("yyyyMMdd") + "'";
                                ConsultaTabla(tabla, query);
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
                                query = "select re.id_rep_enc as 'ID', re.fecha_enc as 'Fecha encontrado', re.estado as 'Estatus', re.raza as 'Raza', re.color as 'Color', re.placa as 'Placa', re.caracteristicas as 'Características', re.ciudad as 'Ciudad', re.colonia as 'Colonia', re.resguardado as 'Resguardado', u.nombre as 'Nombre Usuario', u.correo as 'Email' from ReporteEncontrado re join Usuario u on re.id_usuario = u.id_usuario where re.fecha_enc between '" + dpInicio.Value.Date.ToString("yyyyMMdd") + "' and '" + dpFin.Value.Date.ToString("yyyyMMdd") + "'";
                                ConsultaTabla(tabla, query);
                                break;
                            default:
                                TxtBusqueda.Enabled = true;
                                BtnBuscar.Enabled = true;
                                break;
                        }
                        break;
                }
            }
            else
            {
                mensaje_error.SetError(dpFin, "La fecha de fin debe ser igual o mayor a la fecha de inicio");
            }
        }
        
        public void ConsultaTabla(string tabla, string query)
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

        private void frmBusqueda_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.desk.Show();
        }

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            BusquedaGeneral();
        }

        private void dpInicio_ValueChanged(object sender, EventArgs e)
        {
            if (CmbParametro.SelectedItem.Equals("Todos"))
            {
                BusquedaGeneral();
            }
            else
            {
                if (TxtBusqueda.Text != "")
                {
                    BusquedaParametrizada();
                }
            }
        }

        private void dpFin_ValueChanged(object sender, EventArgs e)
        {
            if (CmbParametro.SelectedItem.Equals("Todos"))
            {
                BusquedaGeneral();
            }
            else
            {
                if (TxtBusqueda.Text != "")
                {
                    BusquedaParametrizada();
                }
            }
        }

        private void TxtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CmbParametro.SelectedItem.Equals("ID") && !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            } else
            {
                if(!Char.IsLetterOrDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '*' && e.KeyChar != '_' && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }

            if(e.KeyChar == 13)
            {
                BusquedaParametrizada();
            }
        }

        private void btnMostrarDetalle_Click(object sender, EventArgs e)
        {
            
        }
    }
}
