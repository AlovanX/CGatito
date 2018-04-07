using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace Splash
{

    public partial class Form2 : Form
    {
        Usuario us = new Usuario();
        
        public Form2()
        {
            InitializeComponent();
            //Obtenemos imagen principal
            String rutaHuellas = Environment.CurrentDirectory + "\\huellas.png";
            pbHuella1.Image = Image.FromFile(rutaHuellas);
            pbHuella2.Image = Image.FromFile(rutaHuellas);

            //Hilo para iniciar splashscreen
            Thread hilo = new Thread(mostrarSplash);
            hilo.Start();
            Thread.Sleep(2000);
            hilo.Abort();

            txtCorreo.Focus();

        }

        void mostrarSplash()
        {
            Form1 sps = new Form1();
            sps.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Confirmar salida del programa
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Salir",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();

            }
            else
            {
                txtCorreo.Focus();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            login();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            //Abrir nuevo formulario de captura de usuarios
            new VentanaRegistroUsuario().Show();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evento al presionar tecla
            if (e.KeyChar == 13)
            {
                teclaEnter();
            }
        }

        private void teclaEnter()
        {
            if (txtCorreo.Text != "" && txtContraseña.Text != "")
            {
                login();
            }
            else if (txtCorreo.Text != "")
            {
                txtContraseña.Focus();
            }
            else if (txtContraseña.Text != "")
            {
                txtCorreo.Focus();
            }
        }

        public void login()
        {
            if (validarCajas())
            {
                
                if (us.IniciarSesion(txtCorreo.Text, txtContraseña.Text))
                {

                    //MessageBox.Show("Bienvenido");
                    this.Hide();
                }
                else
                {
                    //MessageBox.Show("Usuario o Contraseña incorrecta");
                }
            }
        }
        private bool validarCajas()
        {
            //Verificamos que los campos para el login no esten vacios
            mensajeError.Clear();
            Boolean error = false;
            if (txtCorreo.Text == "")
            {
                mensajeError.SetError(txtCorreo, "Escribe tu nombre de usuario");
                txtCorreo.Focus();
                error = true;
            }
            if (txtContraseña.Text == "")
            {
                mensajeError.SetError(txtContraseña, "Escribe tu contraseña");
                txtContraseña.Focus();
                error = true;
            }

            if (error)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                teclaEnter();
            }
        }
    }
    
}
