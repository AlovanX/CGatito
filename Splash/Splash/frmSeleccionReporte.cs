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
    public partial class s : Form
    {
        Escritorio desk;
        Perro p;
        dtReporteador dtRepo;
        int tipoReporte = -1;

        public s(Escritorio desk)
        {
            InitializeComponent();

            this.desk = desk;
            gbTipoReporte.Controls.Add(rbtnEncontrado);
            gbTipoReporte.Controls.Add(rbtnExtravio);


            

            
        }

        private void s_FormClosing(object sender, FormClosingEventArgs e)
        {
            desk.Show();
        }



        private void btnGenerar_Click(object sender, EventArgs e)
        {
            mensaje_error.Clear();
            if (dpInicio.Value.CompareTo(dpFin.Value) == -1)
            {
                p = new Perro();
                dtRepo = new dtReporteador();
                DataSet DS = new DataSet();

                switch (tipoReporte)
                {
                    case 0:
                        try
                        {
                            DS = p.ConsultaParametrizada("ReporteExtravio", "Select id_rep_ext as 'ID', fecha_perdido as 'Fecha',Estado,Raza,Placa,Ciudad from ReporteExtravio where fecha_perdido between '"+ dpInicio.Value.Date.ToString("yyyyMMdd")+"' and '"+ dpFin.Value.Date.ToString("yyyyMMdd") + "'");
                            if (DS.Tables[0].Rows.Count == 0)
                            {
                                MessageBox.Show("No se encontró ningún resultado", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                foreach (DataRow fila in DS.Tables["ReporteExtravio"].Rows)
                                {
                                    
                                        dtRepo.DTExtraviado.Rows.Add(
                                        fila["Fecha"].ToString(),
                                        fila["Estado"].ToString(),
                                        fila["Raza"].ToString(),
                                        fila["Placa"].ToString(),
                                        fila["Ciudad"].ToString(),
                                        fila["ID"].ToString()
                                        );
                                }
                                
                                frmReporte rep = new frmReporte(dtRepo.DTExtraviado,0);
                                rep.WindowState = FormWindowState.Maximized;
                                rep.ShowDialog();
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            throw;
                        }
                        finally
                        {
                            p.CerrarConexion();
                        }
                        break;
                    case 1:
                        try
                        {
                            DS = p.ConsultaParametrizada("ReporteEncontrado", "Select id_rep_enc as 'ID', fecha_enc as 'Fecha',Estado,Raza,Placa,Ciudad from ReporteEncontrado where estado = 'encontrado' and fecha_enc between '" + dpInicio.Value.Date.ToString("yyyyMMdd") + "' and '" + dpFin.Value.Date.ToString("yyyyMMdd") + "'");
                            if (DS.Tables[0].Rows.Count == 0)
                            {
                                MessageBox.Show("No se encontró ningún resultado", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                foreach (DataRow fila in DS.Tables["ReporteEncontrado"].Rows)
                                {

                                    dtRepo.DTExtraviado.Rows.Add(
                                    fila["Fecha"].ToString(),
                                    fila["Estado"].ToString(),
                                    fila["Raza"].ToString(),
                                    fila["Placa"].ToString(),
                                    fila["Ciudad"].ToString(),
                                    fila["ID"].ToString()
                                    );
                                }

                                frmReporte rep = new frmReporte(dtRepo.DTExtraviado,1);
                                rep.WindowState = FormWindowState.Maximized;
                                rep.ShowDialog();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            throw;
                        }
                        finally
                        {
                            p.CerrarConexion();
                        }
                        break;
                    default:
                        MessageBox.Show("Selcciona un tipo de reporte", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
            }
            else
            {
                
                //mensaje_error.SetError(dpFin, "La fecha de fin debe ser igual o mayor a la fecha de inicio");
            }


        }

        private void rbtnExtravio_CheckedChanged(object sender, EventArgs e)
        {
            tipoReporte = 0;
        }

        private void rbtnEncontrado_CheckedChanged(object sender, EventArgs e)
        {
            tipoReporte = 1;
        }
    }
}
