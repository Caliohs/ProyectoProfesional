﻿namespace HouseSystemFood.Vista
{
    partial class Ordenes_View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.lbPrducto = new System.Windows.Forms.Label();
            this.txtProductoSelecionado = new System.Windows.Forms.TextBox();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.lbMesa = new System.Windows.Forms.Label();
            this.cmbMesa = new System.Windows.Forms.ComboBox();
            this.lbProducto = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbMontoT = new System.Windows.Forms.Label();
            this.gBox4 = new System.Windows.Forms.GroupBox();
            this.gBox3 = new System.Windows.Forms.GroupBox();
            this.lbCat = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.gBox2 = new System.Windows.Forms.GroupBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbCont = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.dtgOrdenes = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbox.SuspendLayout();
            this.gBox3.SuspendLayout();
            this.gBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Location = new System.Drawing.Point(1121, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 24);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(31, 6);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(152, 20);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "Gestion de Ordenes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.lbTitulo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 30);
            this.panel2.TabIndex = 41;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(985, 529);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 39);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Firebrick;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(616, 529);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(354, 39);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Ejecutar Orden";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtgProductos
            // 
            this.dtgProductos.AllowUserToAddRows = false;
            this.dtgProductos.AllowUserToResizeColumns = false;
            this.dtgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProductos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Location = new System.Drawing.Point(23, 146);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.ReadOnly = true;
            this.dtgProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductos.Size = new System.Drawing.Size(575, 422);
            this.dtgProductos.TabIndex = 9;
            this.dtgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductos_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEliminar});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // toolStripEliminar
            // 
            this.toolStripEliminar.Name = "toolStripEliminar";
            this.toolStripEliminar.Size = new System.Drawing.Size(117, 22);
            this.toolStripEliminar.Text = "Eliminar";
            this.toolStripEliminar.Click += new System.EventHandler(this.toolStripEliminar_Click);
            // 
            // lbPrducto
            // 
            this.lbPrducto.AutoSize = true;
            this.lbPrducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrducto.Location = new System.Drawing.Point(13, 52);
            this.lbPrducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrducto.Name = "lbPrducto";
            this.lbPrducto.Size = new System.Drawing.Size(134, 15);
            this.lbPrducto.TabIndex = 83;
            this.lbPrducto.Text = "Producto Seleccionado";
            // 
            // txtProductoSelecionado
            // 
            this.txtProductoSelecionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtProductoSelecionado.Enabled = false;
            this.txtProductoSelecionado.Location = new System.Drawing.Point(16, 69);
            this.txtProductoSelecionado.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductoSelecionado.Name = "txtProductoSelecionado";
            this.txtProductoSelecionado.Size = new System.Drawing.Size(200, 21);
            this.txtProductoSelecionado.TabIndex = 9;
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.lbMesa);
            this.gbox.Controls.Add(this.cmbMesa);
            this.gbox.Controls.Add(this.lbProducto);
            this.gbox.Controls.Add(this.lbTotal);
            this.gbox.Controls.Add(this.lbMontoT);
            this.gbox.Controls.Add(this.gBox4);
            this.gbox.Controls.Add(this.gBox3);
            this.gbox.Controls.Add(this.gBox2);
            this.gbox.Controls.Add(this.dtgOrdenes);
            this.gbox.Controls.Add(this.btnCancelar);
            this.gbox.Controls.Add(this.btnAceptar);
            this.gbox.Controls.Add(this.dtgProductos);
            this.gbox.Location = new System.Drawing.Point(12, 36);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(1126, 582);
            this.gbox.TabIndex = 84;
            this.gbox.TabStop = false;
            this.gbox.Text = "Ordenes";
            // 
            // lbMesa
            // 
            this.lbMesa.AutoSize = true;
            this.lbMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMesa.Location = new System.Drawing.Point(613, 483);
            this.lbMesa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMesa.Name = "lbMesa";
            this.lbMesa.Size = new System.Drawing.Size(103, 15);
            this.lbMesa.TabIndex = 97;
            this.lbMesa.Text = "Numero de Mesa";
            // 
            // cmbMesa
            // 
            this.cmbMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMesa.FormattingEnabled = true;
            this.cmbMesa.ItemHeight = 18;
            this.cmbMesa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbMesa.Location = new System.Drawing.Point(616, 499);
            this.cmbMesa.Name = "cmbMesa";
            this.cmbMesa.Size = new System.Drawing.Size(100, 26);
            this.cmbMesa.TabIndex = 96;
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducto.Location = new System.Drawing.Point(20, 128);
            this.lbProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(187, 15);
            this.lbProducto.TabIndex = 95;
            this.lbProducto.Text = "Seleccione el Producto  deseado";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(753, 497);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(79, 25);
            this.lbTotal.TabIndex = 94;
            this.lbTotal.Text = "Total: ";
            // 
            // lbMontoT
            // 
            this.lbMontoT.AutoSize = true;
            this.lbMontoT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontoT.ForeColor = System.Drawing.Color.Red;
            this.lbMontoT.Location = new System.Drawing.Point(831, 497);
            this.lbMontoT.Name = "lbMontoT";
            this.lbMontoT.Size = new System.Drawing.Size(25, 25);
            this.lbMontoT.TabIndex = 91;
            this.lbMontoT.Text = "0";
            // 
            // gBox4
            // 
            this.gBox4.Location = new System.Drawing.Point(396, 20);
            this.gBox4.Name = "gBox4";
            this.gBox4.Size = new System.Drawing.Size(202, 105);
            this.gBox4.TabIndex = 93;
            this.gBox4.TabStop = false;
            this.gBox4.Text = "Cobros";
            // 
            // gBox3
            // 
            this.gBox3.Controls.Add(this.lbCat);
            this.gBox3.Controls.Add(this.cmbCategorias);
            this.gBox3.Location = new System.Drawing.Point(23, 20);
            this.gBox3.Name = "gBox3";
            this.gBox3.Size = new System.Drawing.Size(295, 105);
            this.gBox3.TabIndex = 92;
            this.gBox3.TabStop = false;
            this.gBox3.Text = "Seleccione la categoria";
            // 
            // lbCat
            // 
            this.lbCat.AutoSize = true;
            this.lbCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCat.Location = new System.Drawing.Point(17, 31);
            this.lbCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCat.Name = "lbCat";
            this.lbCat.Size = new System.Drawing.Size(66, 15);
            this.lbCat.TabIndex = 85;
            this.lbCat.Text = "Categorias";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.ItemHeight = 15;
            this.cmbCategorias.Location = new System.Drawing.Point(20, 49);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(213, 23);
            this.cmbCategorias.TabIndex = 4;
            this.cmbCategorias.SelectedIndexChanged += new System.EventHandler(this.cmbCategorias_SelectedIndexChanged);
            // 
            // gBox2
            // 
            this.gBox2.Controls.Add(this.btnIncluir);
            this.gBox2.Controls.Add(this.btnLimpiar);
            this.gBox2.Controls.Add(this.lbPrducto);
            this.gBox2.Controls.Add(this.lbCont);
            this.gBox2.Controls.Add(this.txtProductoSelecionado);
            this.gBox2.Controls.Add(this.btnMin);
            this.gBox2.Controls.Add(this.btnMax);
            this.gBox2.Location = new System.Drawing.Point(616, 20);
            this.gBox2.Name = "gBox2";
            this.gBox2.Size = new System.Drawing.Size(489, 105);
            this.gBox2.TabIndex = 91;
            this.gBox2.TabStop = false;
            this.gBox2.Text = "Agregar producto";
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.ForeColor = System.Drawing.Color.White;
            this.btnIncluir.Location = new System.Drawing.Point(365, 56);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(106, 37);
            this.btnIncluir.TabIndex = 88;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(365, 19);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(106, 33);
            this.btnLimpiar.TabIndex = 90;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbCont
            // 
            this.lbCont.AutoSize = true;
            this.lbCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCont.ForeColor = System.Drawing.Color.Red;
            this.lbCont.Location = new System.Drawing.Point(329, 65);
            this.lbCont.Name = "lbCont";
            this.lbCont.Size = new System.Drawing.Size(25, 25);
            this.lbCont.TabIndex = 89;
            this.lbCont.Text = "0";
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(220, 56);
            this.btnMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 37);
            this.btnMin.TabIndex = 85;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(274, 56);
            this.btnMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(50, 37);
            this.btnMax.TabIndex = 87;
            this.btnMax.Text = "+";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // dtgOrdenes
            // 
            this.dtgOrdenes.AllowUserToAddRows = false;
            this.dtgOrdenes.AllowUserToDeleteRows = false;
            this.dtgOrdenes.AllowUserToResizeColumns = false;
            this.dtgOrdenes.AllowUserToResizeRows = false;
            this.dtgOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgOrdenes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgOrdenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrdenes.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgOrdenes.Location = new System.Drawing.Point(616, 146);
            this.dtgOrdenes.Name = "dtgOrdenes";
            this.dtgOrdenes.ReadOnly = true;
            this.dtgOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgOrdenes.Size = new System.Drawing.Size(489, 334);
            this.dtgOrdenes.TabIndex = 86;
            // 
            // Ordenes_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 630);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ordenes_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.Ordenes_View_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            this.gBox3.ResumeLayout(false);
            this.gBox3.PerformLayout();
            this.gBox2.ResumeLayout(false);
            this.gBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.Label lbPrducto;
        private System.Windows.Forms.TextBox txtProductoSelecionado;
        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.Label lbCat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripEliminar;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label lbMesa;
        private System.Windows.Forms.ComboBox cmbMesa;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbMontoT;
        private System.Windows.Forms.GroupBox gBox4;
        private System.Windows.Forms.GroupBox gBox3;
        private System.Windows.Forms.GroupBox gBox2;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lbCont;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.DataGridView dtgOrdenes;
    }
}