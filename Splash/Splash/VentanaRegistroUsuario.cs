using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash
{
    public partial class VentanaRegistroUsuario : Form
    {
        Usuario usuario = new Usuario();
        int res = -1;

        public VentanaRegistroUsuario()
        {
            InitializeComponent();
            //Obtenemos imagen principal
            String rutaHuellas = Environment.CurrentDirectory + "\\huellas.png";
            pbHuella2.Image = Image.FromFile(rutaHuellas);
            pbHuella3.Image = Image.FromFile(rutaHuellas);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void VentanaRegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Regresar pantalla anterior
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           limpiar();
        }

        //Borrar texto 
        public void limpiar()
        {
            txt_nombre.Text = "";
            txt_correo.Text = "";
            txt_telefono.Text = "";
            txt_contrasena.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {   
                //Validamos que no esten vacios los campos necesarios previos al registro
                if (txt_nombre.Text != "" && txt_correo.Text != "" && txt_telefono.Text != "" && txt_contrasena.Text != "")
                {
                    //Creamos nuestro query 
                    string insert = "INSERT INTO usuario (nombre, correo, telefono, contraseña) values('" + txt_nombre.Text + "','" + txt_correo.Text + "','" +
                    txt_telefono.Text + "','" + txt_contrasena.Text + "')";

                    //Invocamos el metodo ABM para insertar el registro
                    res = usuario.ABM(insert);

                    if (res == 1)
                    {
                        //Mensaje de confirmacion si es exitoso el registro
                        MessageBox.Show("Registro Exitoso, ahora puede ingresar", "Altas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                }
                else
                {   
                    //Si faltan datos se solicitan
                    MessageBox.Show("Ingrese todos los datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)

            {
            }
            finally
            {
                Usuario.conn.Close();

            }

            
        }
    }
}
