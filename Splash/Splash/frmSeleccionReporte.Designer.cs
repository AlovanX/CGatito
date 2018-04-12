namespace Splash
{
    partial class s
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
            this.components = new System.ComponentModel.Container();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.dpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.dpFin = new System.Windows.Forms.DateTimePicker();
            this.rbtnExtravio = new System.Windows.Forms.RadioButton();
            this.rbtnEncontrado = new System.Windows.Forms.RadioButton();
            this.gbTipoReporte = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.mensaje_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbTipoReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensaje_error)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.Location = new System.Drawing.Point(12, 9);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(228, 21);
            this.lblLeyenda.TabIndex = 0;
            this.lblLeyenda.Text = "Selecciona el tipo de reporte";
            // 
            // dpInicio
            // 
            this.dpInicio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpInicio.Location = new System.Drawing.Point(198, 42);
            this.dpInicio.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dpInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dpInicio.Name = "dpInicio";
            this.dpInicio.Size = new System.Drawing.Size(231, 22);
            this.dpInicio.TabIndex = 1;
            this.dpInicio.Value = new System.DateTime(2000, 2, 1, 0, 0, 0, 0);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(135, 43);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(57, 21);
            this.lblInicio.TabIndex = 2;
            this.lblInicio.Text = "Inicio:";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(135, 71);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(37, 21);
            this.lblFin.TabIndex = 4;
            this.lblFin.Text = "Fin:";
            // 
            // dpFin
            // 
            this.dpFin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFin.Location = new System.Drawing.Point(198, 70);
            this.dpFin.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dpFin.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dpFin.Name = "dpFin";
            this.dpFin.Size = new System.Drawing.Size(231, 22);
            this.dpFin.TabIndex = 3;
            // 
            // rbtnExtravio
            // 
            this.rbtnExtravio.AutoSize = true;
            this.rbtnExtravio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnExtravio.Location = new System.Drawing.Point(6, 19);
            this.rbtnExtravio.Name = "rbtnExtravio";
            this.rbtnExtravio.Size = new System.Drawing.Size(70, 17);
            this.rbtnExtravio.TabIndex = 5;
            this.rbtnExtravio.TabStop = true;
            this.rbtnExtravio.Text = "Extravíos";
            this.rbtnExtravio.UseVisualStyleBackColor = true;
            this.rbtnExtravio.CheckedChanged += new System.EventHandler(this.rbtnExtravio_CheckedChanged);
            // 
            // rbtnEncontrado
            // 
            this.rbtnEncontrado.AutoSize = true;
            this.rbtnEncontrado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEncontrado.Location = new System.Drawing.Point(6, 42);
            this.rbtnEncontrado.Name = "rbtnEncontrado";
            this.rbtnEncontrado.Size = new System.Drawing.Size(90, 17);
            this.rbtnEncontrado.TabIndex = 5;
            this.rbtnEncontrado.TabStop = true;
            this.rbtnEncontrado.Text = "Encontrados";
            this.rbtnEncontrado.UseVisualStyleBackColor = true;
            this.rbtnEncontrado.CheckedChanged += new System.EventHandler(this.rbtnEncontrado_CheckedChanged);
            // 
            // gbTipoReporte
            // 
            this.gbTipoReporte.Controls.Add(this.rbtnExtravio);
            this.gbTipoReporte.Controls.Add(this.rbtnEncontrado);
            this.gbTipoReporte.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoReporte.Location = new System.Drawing.Point(16, 33);
            this.gbTipoReporte.Name = "gbTipoReporte";
            this.gbTipoReporte.Size = new System.Drawing.Size(99, 71);
            this.gbTipoReporte.TabIndex = 6;
            this.gbTipoReporte.TabStop = false;
            this.gbTipoReporte.Text = "Resumen";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerar.Location = new System.Drawing.Point(310, 98);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(119, 30);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // mensaje_error
            // 
            this.mensaje_error.ContainerControl = this;
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 140);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.gbTipoReporte);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.dpFin);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.dpInicio);
            this.Controls.Add(this.lblLeyenda);
            this.Name = "s";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selector de reportes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.s_FormClosing);
            this.gbTipoReporte.ResumeLayout(false);
            this.gbTipoReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensaje_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.DateTimePicker dpInicio;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dpFin;
        private System.Windows.Forms.RadioButton rbtnExtravio;
        private System.Windows.Forms.RadioButton rbtnEncontrado;
        private System.Windows.Forms.GroupBox gbTipoReporte;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ErrorProvider mensaje_error;
    }
}