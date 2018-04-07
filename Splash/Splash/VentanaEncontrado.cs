using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash
{
    public partial class VentanaEncontrado : Form
    {

        Perro perro = new Perro();
        int res = -1;

        int ImageID = 0;
        String strFilePath = "";
        Image DefaultImage;
        Byte[] ImageByteArray;
        byte[] imagen;

        public void mostrarDatos()
        {
            try
            {
                DataSet data = new DataSet();
                data = perro.ConsultaParametrizada("ReporteEncontrado", "select re.id_rep_enc as 'ID', re.fecha_enc as 'Fecha encontrado', re.estado as 'Estado', re.raza as 'Raza', re.color as 'Color', re.placa as 'Placa', re.caracteristicas as 'Características', re.ciudad as 'Ciudad', re.colonia as 'Colonia', re.calle as 'Calle', re.resguardado as 'Resguardado', u.nombre as 'Nombre Usuario', u.correo as 'Email' from ReporteEncontrado re join Usuario u on re.id_usuario = u.id_usuario");
                dataGridView.DataSource = data.Tables["ReporteEncontrado"];
            }
            catch (Exception ex)
            {

            }

        }
        public VentanaEncontrado(string id_user)
        {
            InitializeComponent();
            txt_id_usuario.Text = id_user;
            DefaultImage = pb_imagen.Image;


            String rutaHuellas = Environment.CurrentDirectory + "\\huellas.png";
            pbHuella2.Image = Image.FromFile(rutaHuellas);
            pbHuella3.Image = Image.FromFile(rutaHuellas);
            pbHuella4.Image = Image.FromFile(rutaHuellas);

            //Agregar imagen de borrador
            String rutaEraser = Environment.CurrentDirectory + "\\eraser.png";
            pb_limpiar.Image = Image.FromFile(rutaEraser);

            //Agregar imagen de guardar
            String rutaAdd = Environment.CurrentDirectory + "\\plus.png";
            pb_guardar.Image = Image.FromFile(rutaAdd);

            //Agregar imagen de eliminar
            String rutaDelete = Environment.CurrentDirectory + "\\delete.png";
            pb_eliminar.Image = Image.FromFile(rutaDelete);

            //Agregar imagen de actualizar
            String rutaUpdate = Environment.CurrentDirectory + "\\update.png";
            pb_actualizar.Image = Image.FromFile(rutaUpdate);

            //Agregar imagen de mostrar
            String rutaShow = Environment.CurrentDirectory + "\\show.png";
            pb_mostrar.Image = Image.FromFile(rutaShow);

            //Agregar imagen de salir
            String rutaExit = Environment.CurrentDirectory + "\\exit.png";
            pb_exit.Image = Image.FromFile(rutaExit);

            //Agregar imagen de buscar
            String rutaSearch = Environment.CurrentDirectory + "\\search.png";
            pb_buscar.Image = Image.FromFile(rutaSearch);

            mostrarDatos();

        }


        public void limpiar()

        {
            cboxResguardo.SelectedIndex = -1;
            txt_raza.Text = "";
            txt_color.Text = "";
            cboxPlaca.SelectedIndex = -1;
            txt_caracteristicas.Text = "";
            txt_calle.Text = "";
            txt_colonia.Text = "";
            txt_ciudad.Text = "";
            cboxEstatus.SelectedIndex = -1;
            txt_id_reporte_encontrado.Text = "";
            strFilePath = "";
            pb_imagen.Image = null;
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            buscarPorID();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                int iduser = Int32.Parse(txt_id_usuario.Text);

                //Validacion en caso de que no se guarde ninguna imagen seleccionamos una por defecto
                if (strFilePath == "")
                {
                    //Agregar imagen de avatar
                    String rutaAvatar = Environment.CurrentDirectory + "\\avatar.png";
                    pb_imagen.Image = Image.FromFile(rutaAvatar);

                }

                if (cboxResguardo.SelectedIndex != -1 && cboxEstatus.SelectedIndex != -1 && txt_raza.Text != "" && txt_color.Text != "" && txt_caracteristicas.Text != "" && txt_ciudad.Text != "" && txt_colonia.Text != "" &&
                    txt_calle.Text != "")
                {
                    string insert = "INSERT INTO ReporteEncontrado (fecha_enc, estado, raza, color, placa, caracteristicas, ciudad, colonia, calle, id_usuario, resguardado, foto) values('"
                    //+ picker_fecha.Value.Date + "','"
                    + picker_fecha.Value.Date.ToString("yyyyMMdd") + "','"
                    + cboxEstatus.SelectedItem + "','"
                    + txt_raza.Text + "','"
                    + txt_color.Text + "','"
                    + cboxPlaca.SelectedItem + "','"
                    + txt_caracteristicas.Text + "','"
                    + txt_ciudad.Text + "','"
                    + txt_colonia.Text + "','"
                    + txt_calle.Text + "',"
                    + iduser + ",'"
                    + cboxResguardo.SelectedItem + "','"
                    + strFilePath + "')";

                    res = perro.ABM(insert);
                    if (res == 1)
                    {
                        MessageBox.Show("Se ha agregado un registro", "Altas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrarDatos();
                        limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese todos los datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                Perro.conn.Close();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (txt_id_reporte_encontrado.Text == "" || txt_id_reporte_encontrado.Text == ".")
            {
                mensaje_error.Clear();
                mensaje_error.SetError(txt_id_reporte_encontrado, "Ingresar Id Reporte Encontrado");
                txt_id_reporte_encontrado.Text = "";
                txt_id_reporte_encontrado.Focus();

            }
            else
            {

                try
                {
                    string modificar = "UPDATE ReporteEncontrado set estado = '" + cboxEstatus.SelectedItem + "', raza = '" + txt_raza.Text + 
                        "', color = '" + txt_color.Text + "', placa = '" + cboxPlaca.SelectedItem + "', caracteristicas = '" + txt_caracteristicas.Text +
                        "', ciudad = '" + txt_ciudad.Text + "', colonia = '" + txt_colonia.Text + "', calle = '" + txt_calle.Text +
                         "', foto = '" + txt_path.Text + "', resguardado = '" + cboxResguardo.SelectedItem +
                        "' WHERE id_rep_enc = " + txt_id_reporte_encontrado.Text;

                    res = perro.ABM(modificar);
                    if (res == 1)
                    {
                        MessageBox.Show("Se ha modificado el registro correctamente", "Modificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    mostrarDatos();
                    Perro.conn.Close();

                }


            }


        }

        private void button7_Click_1(object sender, EventArgs e)
        {


            if (txt_id_reporte_encontrado.Text == "" || txt_id_reporte_encontrado.Text == ".")
            {
                mensaje_error.Clear();
                mensaje_error.SetError(txt_id_reporte_encontrado, "Ingresar Id Reporte Encontrado");
                txt_id_reporte_encontrado.Text = "";
                txt_id_reporte_encontrado.Focus();
            }
            else
            {
                try
                {
                    string delete = "DELETE FROM ReporteEncontrado WHERE id_rep_enc = " + txt_id_reporte_encontrado.Text;
                    res = perro.ABM(delete);

                    if (res == 1)
                    {
                        MessageBox.Show("Se ha eliminado un registro", "Bajas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    mostrarDatos();
                    limpiar();
                    Perro.conn.Close();

                }
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strFilePath = ofd.FileName;
                txt_path.Text = strFilePath;
                pb_imagen.Image = new Bitmap(strFilePath);
            }
        }

        private void dataGridView_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = true;
            e.Cancel = true;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_id_reporte_encontrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                teclaEnter();
            }
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == 46) && !(txt_id_reporte_encontrado.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void teclaEnter()
        {
            if (txt_id_reporte_encontrado.Text != "")
            {
                buscarPorID();
            }
            else
                txt_id_reporte_encontrado.Focus();


        }

        public void buscarPorID()
        {
            
            if (txt_id_reporte_encontrado.Text == "" || txt_id_reporte_encontrado.Text == ".")
            {
                mensaje_error.Clear();
                mensaje_error.SetError(txt_id_reporte_encontrado, "Capturar Id Reporte Encontrado");
                txt_id_reporte_encontrado.Text = "";
                txt_id_reporte_encontrado.Focus();


            }
            else
            {

                try
                {
                    string id = txt_id_reporte_encontrado.Text;
                    SqlDataReader ResConsul;
                    string query = "SELECT * FROM ReporteEncontrado WHERE id_rep_enc = " + txt_id_reporte_encontrado.Text;
                    limpiar();
                    ResConsul = perro.consultaId(query);

                    if (ResConsul.Read())
                    {
                        txt_id_reporte_encontrado.Text = id;  //id
                        cboxEstatus.SelectedItem = ResConsul.GetString(2).ToString(); //estado
                        txt_raza.Text = ResConsul.GetString(3).ToString(); //raza
                        txt_color.Text = ResConsul.GetString(4).ToString(); //color
                        cboxPlaca.SelectedItem = ResConsul.GetString(5).ToString(); //placa
                        txt_caracteristicas.Text = ResConsul.GetString(6).ToString(); //caracteristicas
                        txt_ciudad.Text = ResConsul.GetString(7).ToString(); //ciudad
                        txt_colonia.Text = ResConsul.GetString(8).ToString(); //colonia
                        txt_calle.Text = ResConsul.GetString(9).ToString(); //calle
                        cboxResguardo.SelectedItem = ResConsul.GetString(5).ToString(); //Resguardado
                        pb_imagen.Image = new Bitmap(ResConsul.GetString(11).ToString());
                        

                        txt_path.Text = ResConsul.GetString(11).ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro ningun registro con esas especificaciones", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch
                {

                }
                finally
                {
                    Perro.conn.Close();

                }
            }
        }
    }
}
