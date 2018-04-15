namespace Splash
{
    partial class frmBusqueda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dpFin = new System.Windows.Forms.DateTimePicker();
            this.dpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFin = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.CmbParametro = new System.Windows.Forms.ComboBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.CmbListaBusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridBusqueda = new System.Windows.Forms.DataGridView();
            this.mensaje_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensaje_error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dpFin);
            this.panel1.Controls.Add(this.dpInicio);
            this.panel1.Controls.Add(this.lblFin);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.TxtBusqueda);
            this.panel1.Controls.Add(this.lblInicio);
            this.panel1.Controls.Add(this.CmbParametro);
            this.panel1.Controls.Add(this.lblLista);
            this.panel1.Controls.Add(this.CmbListaBusqueda);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 36);
            this.panel1.TabIndex = 0;
            // 
            // dpFin
            // 
            this.dpFin.Location = new System.Drawing.Point(1007, 8);
            this.dpFin.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dpFin.Name = "dpFin";
            this.dpFin.Size = new System.Drawing.Size(200, 20);
            this.dpFin.TabIndex = 13;
            this.dpFin.ValueChanged += new System.EventHandler(this.dpFin_ValueChanged);
            // 
            // dpInicio
            // 
            this.dpInicio.Location = new System.Drawing.Point(763, 8);
            this.dpInicio.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dpInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dpInicio.Name = "dpInicio";
            this.dpInicio.Size = new System.Drawing.Size(200, 20);
            this.dpInicio.TabIndex = 11;
            this.dpInicio.ValueChanged += new System.EventHandler(this.dpInicio_ValueChanged);
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(969, 7);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(32, 18);
            this.lblFin.TabIndex = 10;
            this.lblFin.Text = "Fin:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(575, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(133, 28);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusqueda.Location = new System.Drawing.Point(385, 6);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(182, 24);
            this.TxtBusqueda.TabIndex = 6;
            this.TxtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBusqueda_KeyPress);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(711, 8);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(46, 18);
            this.lblInicio.TabIndex = 9;
            this.lblInicio.Text = "Inicio:";
            // 
            // CmbParametro
            // 
            this.CmbParametro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbParametro.FormattingEnabled = true;
            this.CmbParametro.Location = new System.Drawing.Point(255, 7);
            this.CmbParametro.Name = "CmbParametro";
            this.CmbParametro.Size = new System.Drawing.Size(121, 23);
            this.CmbParametro.TabIndex = 1;
            this.CmbParametro.SelectedIndexChanged += new System.EventHandler(this.CmbParametro_SelectedIndexChanged);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(6, 10);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(43, 18);
            this.lblLista.TabIndex = 3;
            this.lblLista.Text = "Lista:";
            // 
            // CmbListaBusqueda
            // 
            this.CmbListaBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbListaBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbListaBusqueda.FormattingEnabled = true;
            this.CmbListaBusqueda.Items.AddRange(new object[] {
            "Extraviado",
            "Encontrado"});
            this.CmbListaBusqueda.Location = new System.Drawing.Point(54, 7);
            this.CmbListaBusqueda.Name = "CmbListaBusqueda";
            this.CmbListaBusqueda.Size = new System.Drawing.Size(107, 23);
            this.CmbListaBusqueda.TabIndex = 2;
            this.CmbListaBusqueda.SelectedIndexChanged += new System.EventHandler(this.CmbListaBusqueda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar por:";
            // 
            // datagridBusqueda
            // 
            this.datagridBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridBusqueda.Location = new System.Drawing.Point(12, 50);
            this.datagridBusqueda.Name = "datagridBusqueda";
            this.datagridBusqueda.Size = new System.Drawing.Size(1246, 473);
            this.datagridBusqueda.TabIndex = 1;
            // 
            // mensaje_error
            // 
            this.mensaje_error.ContainerControl = this;
            // 
            // frmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1269, 566);
            this.Controls.Add(this.datagridBusqueda);
            this.Controls.Add(this.panel1);
            this.Name = "frmBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar registros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBusqueda_FormClosing);
            this.Load += new System.EventHandler(this.frmBusqueda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensaje_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.ComboBox CmbListaBusqueda;
        private System.Windows.Forms.ComboBox CmbParametro;
        private System.Windows.Forms.DateTimePicker dpInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dpFin;
        private System.Windows.Forms.DataGridView datagridBusqueda;
        private System.Windows.Forms.ErrorProvider mensaje_error;
    }
}