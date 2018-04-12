namespace Splash
{
    partial class Escritorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escritorio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reporteExtravioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteEncontradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbHuella2 = new System.Windows.Forms.PictureBox();
            this.pbHuella1 = new System.Windows.Forms.PictureBox();
            this.pbHuellasMain = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuellasMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteExtravioToolStripMenuItem,
            this.reporteEncontradoToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reporteExtravioToolStripMenuItem
            // 
            this.reporteExtravioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem});
            this.reporteExtravioToolStripMenuItem.Name = "reporteExtravioToolStripMenuItem";
            this.reporteExtravioToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.reporteExtravioToolStripMenuItem.Text = "Reporte Extravío";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.registrarToolStripMenuItem.Text = "Consultas y Registros";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // reporteEncontradoToolStripMenuItem
            // 
            this.reporteEncontradoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registarToolStripMenuItem});
            this.reporteEncontradoToolStripMenuItem.Name = "reporteEncontradoToolStripMenuItem";
            this.reporteEncontradoToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.reporteEncontradoToolStripMenuItem.Text = "Reporte Encontrado";
            // 
            // registarToolStripMenuItem
            // 
            this.registarToolStripMenuItem.Name = "registarToolStripMenuItem";
            this.registarToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.registarToolStripMenuItem.Text = "Consultas y Registros";
            this.registarToolStripMenuItem.Click += new System.EventHandler(this.registarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.buscarToolStripMenuItem.Text = "Buscar registros";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // nombreUser
            // 
            this.nombreUser.AutoSize = true;
            this.nombreUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.nombreUser.Location = new System.Drawing.Point(618, 4);
            this.nombreUser.Name = "nombreUser";
            this.nombreUser.Size = new System.Drawing.Size(52, 17);
            this.nombreUser.TabIndex = 4;
            this.nombreUser.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(539, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bienvenido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(439, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 45);
            this.label6.TabIndex = 15;
            this.label6.Text = "DOGS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(164, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 45);
            this.label3.TabIndex = 13;
            this.label3.Text = "Encontra";
            // 
            // pbHuella2
            // 
            this.pbHuella2.Location = new System.Drawing.Point(44, 55);
            this.pbHuella2.Name = "pbHuella2";
            this.pbHuella2.Size = new System.Drawing.Size(46, 39);
            this.pbHuella2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHuella2.TabIndex = 21;
            this.pbHuella2.TabStop = false;
            // 
            // pbHuella1
            // 
            this.pbHuella1.Location = new System.Drawing.Point(628, 223);
            this.pbHuella1.Name = "pbHuella1";
            this.pbHuella1.Size = new System.Drawing.Size(46, 39);
            this.pbHuella1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHuella1.TabIndex = 20;
            this.pbHuella1.TabStop = false;
            // 
            // pbHuellasMain
            // 
            this.pbHuellasMain.Location = new System.Drawing.Point(316, 120);
            this.pbHuellasMain.Name = "pbHuellasMain";
            this.pbHuellasMain.Size = new System.Drawing.Size(121, 78);
            this.pbHuellasMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHuellasMain.TabIndex = 14;
            this.pbHuellasMain.TabStop = false;
            // 
            // Escritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 301);
            this.Controls.Add(this.pbHuella2);
            this.Controls.Add(this.pbHuella1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbHuellasMain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreUser);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Escritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Escritorio_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuella1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuellasMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reporteExtravioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteEncontradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registarToolStripMenuItem;
        private System.Windows.Forms.Label nombreUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbHuellasMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbHuella1;
        private System.Windows.Forms.PictureBox pbHuella2;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
    }
}