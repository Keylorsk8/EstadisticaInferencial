﻿namespace slnEstadisticaInferencial
{
    partial class FrmProducciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducciones));
            this.PnlSideBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDesviacionEstandar = new System.Windows.Forms.Button();
            this.BtnVarianza = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHipotesis = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.carnesDBDataSet = new slnEstadisticaInferencial.carnesDBDataSet();
            this.produccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produccionesTableAdapter = new slnEstadisticaInferencial.carnesDBDataSetTableAdapters.produccionesTableAdapter();
            this.tableAdapterManager = new slnEstadisticaInferencial.carnesDBDataSetTableAdapters.TableAdapterManager();
            this.produccionesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlNavBar = new System.Windows.Forms.Panel();
            this.btnIntervalo = new System.Windows.Forms.Button();
            this.PnlSideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carnesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produccionesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSideBar
            // 
            this.PnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlSideBar.Controls.Add(this.panel2);
            this.PnlSideBar.Controls.Add(this.BtnVolver);
            this.PnlSideBar.Controls.Add(this.button4);
            this.PnlSideBar.Controls.Add(this.BtnEliminar);
            this.PnlSideBar.Controls.Add(this.BtnModificar);
            this.PnlSideBar.Controls.Add(this.BtnInsertar);
            this.PnlSideBar.Controls.Add(this.panel1);
            this.PnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.PnlSideBar.Margin = new System.Windows.Forms.Padding(4);
            this.PnlSideBar.Name = "PnlSideBar";
            this.PnlSideBar.Size = new System.Drawing.Size(225, 682);
            this.PnlSideBar.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.BtnDesviacionEstandar);
            this.panel2.Controls.Add(this.BtnVarianza);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 682);
            this.panel2.TabIndex = 10;
            // 
            // BtnDesviacionEstandar
            // 
            this.BtnDesviacionEstandar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDesviacionEstandar.FlatAppearance.BorderSize = 0;
            this.BtnDesviacionEstandar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesviacionEstandar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesviacionEstandar.ForeColor = System.Drawing.Color.White;
            this.BtnDesviacionEstandar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDesviacionEstandar.Location = new System.Drawing.Point(19, 492);
            this.BtnDesviacionEstandar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDesviacionEstandar.Name = "BtnDesviacionEstandar";
            this.BtnDesviacionEstandar.Size = new System.Drawing.Size(209, 108);
            this.BtnDesviacionEstandar.TabIndex = 17;
            this.BtnDesviacionEstandar.Text = "Calcular \r\nDesviación Estándar\r\n";
            this.BtnDesviacionEstandar.UseVisualStyleBackColor = false;
            this.BtnDesviacionEstandar.Click += new System.EventHandler(this.BtnDesviacionEstandar_Click);
            // 
            // BtnVarianza
            // 
            this.BtnVarianza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnVarianza.FlatAppearance.BorderSize = 0;
            this.BtnVarianza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVarianza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVarianza.ForeColor = System.Drawing.Color.White;
            this.BtnVarianza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVarianza.Location = new System.Drawing.Point(19, 412);
            this.BtnVarianza.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVarianza.Name = "BtnVarianza";
            this.BtnVarianza.Size = new System.Drawing.Size(209, 73);
            this.BtnVarianza.TabIndex = 16;
            this.BtnVarianza.Text = "Calcular\r\n Varianza";
            this.BtnVarianza.UseVisualStyleBackColor = false;
            this.BtnVarianza.Click += new System.EventHandler(this.BtnVarianza_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(19, 332);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 73);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calcular Media";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(19, 252);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 73);
            this.button5.TabIndex = 14;
            this.button5.Text = "Eliminar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(19, 172);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(209, 73);
            this.button6.TabIndex = 13;
            this.button6.Text = "Modificar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(19, 92);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(209, 73);
            this.button7.TabIndex = 12;
            this.button7.Text = "Insertar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(19, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(13, 503);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(244, 137);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 123);
            this.panel3.TabIndex = 4;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolver.Image")));
            this.BtnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolver.Location = new System.Drawing.Point(19, 15);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(155, 38);
            this.BtnVolver.TabIndex = 0;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(19, 630);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 37);
            this.button4.TabIndex = 9;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(19, 306);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(209, 73);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(19, 199);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(209, 73);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.FlatAppearance.BorderSize = 0;
            this.BtnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsertar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertar.ForeColor = System.Drawing.Color.White;
            this.BtnInsertar.Image = ((System.Drawing.Image)(resources.GetObject("BtnInsertar.Image")));
            this.BtnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInsertar.Location = new System.Drawing.Point(19, 92);
            this.BtnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(209, 73);
            this.BtnInsertar.TabIndex = 6;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(244, 137);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 123);
            this.panel1.TabIndex = 4;
            // 
            // btnHipotesis
            // 
            this.btnHipotesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHipotesis.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHipotesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHipotesis.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHipotesis.ForeColor = System.Drawing.Color.White;
            this.btnHipotesis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHipotesis.Location = new System.Drawing.Point(1124, 32);
            this.btnHipotesis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHipotesis.Name = "btnHipotesis";
            this.btnHipotesis.Size = new System.Drawing.Size(232, 48);
            this.btnHipotesis.TabIndex = 18;
            this.btnHipotesis.Text = "Prueba de Hipótesis";
            this.btnHipotesis.UseVisualStyleBackColor = false;
            this.btnHipotesis.Click += new System.EventHandler(this.btnHipotesis_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(233, 30);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(338, 33);
            this.LblTitulo.TabIndex = 11;
            this.LblTitulo.Text = "Listado de Producciones";
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // carnesDBDataSet
            // 
            this.carnesDBDataSet.DataSetName = "carnesDBDataSet";
            this.carnesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produccionesBindingSource
            // 
            this.produccionesBindingSource.DataMember = "producciones";
            this.produccionesBindingSource.DataSource = this.carnesDBDataSet;
            // 
            // produccionesTableAdapter
            // 
            this.produccionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carnesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = slnEstadisticaInferencial.carnesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produccionesDataGridView
            // 
            this.produccionesDataGridView.AllowUserToAddRows = false;
            this.produccionesDataGridView.AutoGenerateColumns = false;
            this.produccionesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.produccionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produccionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.produccionesDataGridView.DataSource = this.produccionesBindingSource;
            this.produccionesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.produccionesDataGridView.Location = new System.Drawing.Point(225, 106);
            this.produccionesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.produccionesDataGridView.MultiSelect = false;
            this.produccionesDataGridView.Name = "produccionesDataGridView";
            this.produccionesDataGridView.ReadOnly = true;
            this.produccionesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produccionesDataGridView.Size = new System.Drawing.Size(1208, 576);
            this.produccionesDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "anio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Año";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // PnlNavBar
            // 
            this.PnlNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PnlNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlNavBar.Location = new System.Drawing.Point(225, 0);
            this.PnlNavBar.Margin = new System.Windows.Forms.Padding(4);
            this.PnlNavBar.Name = "PnlNavBar";
            this.PnlNavBar.Size = new System.Drawing.Size(1208, 26);
            this.PnlNavBar.TabIndex = 13;
            // 
            // btnIntervalo
            // 
            this.btnIntervalo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIntervalo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIntervalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntervalo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntervalo.ForeColor = System.Drawing.Color.White;
            this.btnIntervalo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntervalo.Location = new System.Drawing.Point(887, 32);
            this.btnIntervalo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIntervalo.Name = "btnIntervalo";
            this.btnIntervalo.Size = new System.Drawing.Size(232, 48);
            this.btnIntervalo.TabIndex = 18;
            this.btnIntervalo.Text = "Intervalo Confianza";
            this.btnIntervalo.UseVisualStyleBackColor = false;
            this.btnIntervalo.Click += new System.EventHandler(this.btnIntervalo_Click);
            // 
            // FrmProducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1433, 682);
            this.Controls.Add(this.btnIntervalo);
            this.Controls.Add(this.btnHipotesis);
            this.Controls.Add(this.PnlNavBar);
            this.Controls.Add(this.produccionesDataGridView);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProducciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProducciones";
            this.Load += new System.EventHandler(this.FrmProducciones_Load);
            this.PnlSideBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carnesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produccionesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlSideBar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
        private carnesDBDataSet carnesDBDataSet;
        private System.Windows.Forms.BindingSource produccionesBindingSource;
        private carnesDBDataSetTableAdapters.produccionesTableAdapter produccionesTableAdapter;
        private carnesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView produccionesDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PnlNavBar;
        private System.Windows.Forms.Button BtnDesviacionEstandar;
        private System.Windows.Forms.Button BtnVarianza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnHipotesis;
        private System.Windows.Forms.Button btnIntervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}