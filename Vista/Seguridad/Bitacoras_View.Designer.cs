﻿namespace Vista.Seguridad
{
    partial class Bitacoras_View
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.gpbBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbDato = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lbFecha = new System.Windows.Forms.Label();
            this.gbox3 = new System.Windows.Forms.GroupBox();
            this.rdbS = new System.Windows.Forms.RadioButton();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dtgBitacoras = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cmbDato = new System.Windows.Forms.ComboBox();
            this.groupBox.SuspendLayout();
            this.gpbBuscar.SuspendLayout();
            this.gbox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBitacoras)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.gpbBuscar);
            this.groupBox.Controls.Add(this.gbox3);
            this.groupBox.Controls.Add(this.btnAceptar);
            this.groupBox.Controls.Add(this.dtgBitacoras);
            this.groupBox.Controls.Add(this.btnCancelar);
            this.groupBox.Location = new System.Drawing.Point(12, 36);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(891, 468);
            this.groupBox.TabIndex = 86;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Bitacoras";
            // 
            // gpbBuscar
            // 
            this.gpbBuscar.Controls.Add(this.cmbDato);
            this.gpbBuscar.Controls.Add(this.btnBuscar);
            this.gpbBuscar.Controls.Add(this.lbDato);
            this.gpbBuscar.Controls.Add(this.dtpFecha);
            this.gpbBuscar.Controls.Add(this.lbFecha);
            this.gpbBuscar.Location = new System.Drawing.Point(23, 139);
            this.gpbBuscar.Name = "gpbBuscar";
            this.gpbBuscar.Size = new System.Drawing.Size(275, 185);
            this.gpbBuscar.TabIndex = 106;
            this.gpbBuscar.TabStop = false;
            this.gpbBuscar.Text = "Campo de Bitacora";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(14, 144);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 27);
            this.btnBuscar.TabIndex = 107;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbDato
            // 
            this.lbDato.AutoSize = true;
            this.lbDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDato.Location = new System.Drawing.Point(11, 41);
            this.lbDato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDato.Name = "lbDato";
            this.lbDato.Size = new System.Drawing.Size(87, 15);
            this.lbDato.TabIndex = 108;
            this.lbDato.Text = "Buscar  Accion";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(14, 110);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(164, 20);
            this.dtpFecha.TabIndex = 82;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(11, 92);
            this.lbFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(41, 15);
            this.lbFecha.TabIndex = 81;
            this.lbFecha.Text = "Fecha";
            // 
            // gbox3
            // 
            this.gbox3.Controls.Add(this.rdbS);
            this.gbox3.Controls.Add(this.rdbM);
            this.gbox3.Location = new System.Drawing.Point(23, 37);
            this.gbox3.Name = "gbox3";
            this.gbox3.Size = new System.Drawing.Size(275, 76);
            this.gbox3.TabIndex = 105;
            this.gbox3.TabStop = false;
            this.gbox3.Text = "Tipo de Bitacora";
            // 
            // rdbS
            // 
            this.rdbS.AutoSize = true;
            this.rdbS.Location = new System.Drawing.Point(121, 38);
            this.rdbS.Name = "rdbS";
            this.rdbS.Size = new System.Drawing.Size(57, 17);
            this.rdbS.TabIndex = 102;
            this.rdbS.Text = "Sesion";
            this.rdbS.UseVisualStyleBackColor = true;
            this.rdbS.CheckedChanged += new System.EventHandler(this.rdbS_CheckedChanged);
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(14, 38);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(84, 17);
            this.rdbM.TabIndex = 101;
            this.rdbM.Text = "Movimientos";
            this.rdbM.UseVisualStyleBackColor = true;
            this.rdbM.CheckedChanged += new System.EventHandler(this.rdbM_CheckedChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptar.Location = new System.Drawing.Point(652, 409);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 39);
            this.btnAceptar.TabIndex = 64;
            this.btnAceptar.Text = "Exportar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // dtgBitacoras
            // 
            this.dtgBitacoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBitacoras.BackgroundColor = System.Drawing.Color.White;
            this.dtgBitacoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBitacoras.Location = new System.Drawing.Point(323, 37);
            this.dtgBitacoras.Name = "dtgBitacoras";
            this.dtgBitacoras.ReadOnly = true;
            this.dtgBitacoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBitacoras.Size = new System.Drawing.Size(540, 358);
            this.dtgBitacoras.TabIndex = 70;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(754, 409);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 39);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(864, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(48, 24);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.lbTitulo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 30);
            this.panel2.TabIndex = 85;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(31, 2);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(76, 20);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "Bitacoras";
            // 
            // cmbDato
            // 
            this.cmbDato.FormattingEnabled = true;
            this.cmbDato.Items.AddRange(new object[] {
            "INSERT",
            "UPDATE",
            "DELETE",
            "LOGIN",
            "LOGOUT"});
            this.cmbDato.Location = new System.Drawing.Point(14, 59);
            this.cmbDato.Name = "cmbDato";
            this.cmbDato.Size = new System.Drawing.Size(164, 21);
            this.cmbDato.TabIndex = 109;
            // 
            // Bitacoras_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 516);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bitacoras_View";
            this.Text = "Bitacoras_View";
            this.Load += new System.EventHandler(this.Bitacoras_View_Load);
            this.groupBox.ResumeLayout(false);
            this.gpbBuscar.ResumeLayout(false);
            this.gpbBuscar.PerformLayout();
            this.gbox3.ResumeLayout(false);
            this.gbox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBitacoras)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox gpbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbDato;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.GroupBox gbox3;
        private System.Windows.Forms.RadioButton rdbS;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dtgBitacoras;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ComboBox cmbDato;
    }
}