﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Obtenemos imagen principal
            String rutaPerros = Environment.CurrentDirectory + "\\perros.jpg";
            pbPerros.Image = Image.FromFile(rutaPerros);
            //Obtenemos imagen secundarias
            String rutaHuellas = Environment.CurrentDirectory + "\\huellas.png";
            pbHuellas.Image = Image.FromFile(rutaHuellas);
            Console.WriteLine(rutaHuellas);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbPerros_Click(object sender, EventArgs e)
        {

        }
    }
}