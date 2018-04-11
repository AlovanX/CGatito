namespace Splash
{
    partial class frmReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CrViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrViewer
            // 
            this.CrViewer.ActiveViewIndex = -1;
            this.CrViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrViewer.Location = new System.Drawing.Point(0, 0);
            this.CrViewer.Name = "CrViewer";
            this.CrViewer.Size = new System.Drawing.Size(834, 430);
            this.CrViewer.TabIndex = 0;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 430);
            this.Controls.Add(this.CrViewer);
            this.Name = "frmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReporte_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrViewer;
    }
}