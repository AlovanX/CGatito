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

        public frmReporte(DataTable dt, int opcion)
        {
            InitializeComponent();

            switch (opcion)
            {
                case 0:
                    rptReporteExtravios repo = new rptReporteExtravios();
                    repo.SetDataSource(dt);
                    CrViewer.ReportSource = repo;
                    break;
                case 1:
                    rptReporteEncontrados repo1 = new rptReporteEncontrados();
                    repo1.SetDataSource(dt);
                    CrViewer.ReportSource = repo1;
                    break;
                default:
                    break;
            }

        }


        private void frmReporte_FormClosing(object sender, FormClosingEventArgs e)
        {

        }



    }
}
