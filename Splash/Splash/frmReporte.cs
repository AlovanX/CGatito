using System;
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
    public partial class frmReporte : Form
    {
        Escritorio m;
        frmBusqueda finder;
        byte arrancador;
        public frmReporte(Escritorio m)
        {
            InitializeComponent();
            this.m  = m;
            arrancador = 1;
        }
        public frmReporte(frmBusqueda find)
        {
            InitializeComponent();
            this.finder = find;
            arrancador = 2;
        }

        private void frmReporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (arrancador)
            {
                case 1:
                    m.Show();
                    break;
                case 2:
                    finder.Show();
                    break;
            }
        }
    }
}
