using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash
{
    public partial class Escritorio : Form
    {   

        //variable global para almacenar id de usuario logeado
        string id_user;

        public Escritorio(string id_user_p, string nombre_user_p)
        {
            InitializeComponent();

            //imagen principal
            String rutaHuellas = Environment.CurrentDirectory + "\\huellas.png";
            pbHuellasMain.Image = Image.FromFile(rutaHuellas);
            pbHuella1.Image = Image.FromFile(rutaHuellas);
            pbHuella2.Image = Image.FromFile(rutaHuellas);


            //obtenemos y almacenamos id de usuario 
            nombreUser.Text = nombre_user_p;
            id_user = id_user_p;
        }


        private void Escritorio_Load(object sender, EventArgs e)
        {

        }

        private void reporteExtravioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir formulario de reportes de extravio
            new VentanaExtravio(id_user).Show();
        }

          private void reporteEncontradoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir formulario de reportes de encontrado
            new VentanaEncontrado(id_user).Show();
        }


        private void Escritorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Verificar salida del programa
            if (MessageBox.Show("Salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
            {
                e.Cancel = true;
            }

        }
    }
}
