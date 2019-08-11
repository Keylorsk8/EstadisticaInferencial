namespace slnEstadisticaInferencial
{
    partial class FrmExportaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExportaciones));
            this.BtnVolver = new System.Windows.Forms.Button();
            this.PnlSideBar = new System.Windows.Forms.Panel();
            this.BtnDesviacionEstandar = new System.Windows.Forms.Button();
            this.BtnVarianza = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.exportacionesDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportacionesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.carnesDBDataSet1 = new slnEstadisticaInferencial.carnesDBDataSet();
            this.carnesDBDataSet = new slnEstadisticaInferencial.carnesDBDataSet();
            this.carnesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carnesTableAdapter = new slnEstadisticaInferencial.carnesDBDataSetTableAdapters.carnesTableAdapter();
            this.tableAdapterManager = new slnEstadisticaInferencial.carnesDBDataSetTableAdapters.TableAdapterManager();
            this.exportacionesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.exportacionesTableAdapter = new slnEstadisticaInferencial.carnesDBDataSetTableAdapters.exportacionesTableAdapter();
            this.PnlNavBar = new System.Windows.Forms.Panel();
            this.exportacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exportacionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportacionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportacionesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportacionesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportacionesBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.BtnVolver.Location = new System.Drawing.Point(14, 12);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(116, 31);
            this.BtnVolver.TabIndex = 0;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // PnlSideBar
            // 
            this.PnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlSideBar.Controls.Add(this.BtnDesviacionEstandar);
            this.PnlSideBar.Controls.Add(this.BtnVarianza);
            this.PnlSideBar.Controls.Add(this.BtnVolver);
            this.PnlSideBar.Controls.Add(this.button4);
            this.PnlSideBar.Controls.Add(this.button3);
            this.PnlSideBar.Controls.Add(this.BtnEliminar);
            this.PnlSideBar.Controls.Add(this.BtnModificar);
            this.PnlSideBar.Controls.Add(this.BtnInsertar);
            this.PnlSideBar.Controls.Add(this.panel1);
            this.PnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.PnlSideBar.Name = "PnlSideBar";
            this.PnlSideBar.Size = new System.Drawing.Size(169, 554);
            this.PnlSideBar.TabIndex = 5;
            // 
            // BtnDesviacionEstandar
            // 
            this.BtnDesviacionEstandar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDesviacionEstandar.FlatAppearance.BorderSize = 0;
            this.BtnDesviacionEstandar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesviacionEstandar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesviacionEstandar.ForeColor = System.Drawing.Color.White;
            this.BtnDesviacionEstandar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDesviacionEstandar.Location = new System.Drawing.Point(14, 400);
            this.BtnDesviacionEstandar.Name = "BtnDesviacionEstandar";
            this.BtnDesviacionEstandar.Size = new System.Drawing.Size(157, 59);
            this.BtnDesviacionEstandar.TabIndex = 11;
            this.BtnDesviacionEstandar.Text = "Calcular\r\nDesviación Estandar\r\n";
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
            this.BtnVarianza.Location = new System.Drawing.Point(14, 335);
            this.BtnVarianza.Name = "BtnVarianza";
            this.BtnVarianza.Size = new System.Drawing.Size(157, 59);
            this.BtnVarianza.TabIndex = 10;
            this.BtnVarianza.Text = "Calcular\r\n Varianza";
            this.BtnVarianza.UseVisualStyleBackColor = false;
            this.BtnVarianza.Click += new System.EventHandler(this.BtnVarianza_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(14, 521);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(14, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 59);
            this.button3.TabIndex = 9;
            this.button3.Text = "Calcular Media";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(14, 205);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(157, 59);
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
            this.BtnModificar.Location = new System.Drawing.Point(14, 140);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(157, 59);
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
            this.BtnInsertar.Location = new System.Drawing.Point(14, 75);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(157, 59);
            this.BtnInsertar.TabIndex = 6;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(183, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(179, 24);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(262, 24);
            this.LblTitulo.TabIndex = 10;
            this.LblTitulo.Text = "Listado de Exportaciones";
            // 
            // exportacionesDataGridView
            // 
            this.exportacionesDataGridView.AllowUserToAddRows = false;
            this.exportacionesDataGridView.AllowUserToDeleteRows = false;
            this.exportacionesDataGridView.AutoGenerateColumns = false;
            this.exportacionesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.exportacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exportacionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.anioDataGridViewTextBoxColumn});
            this.exportacionesDataGridView.DataSource = this.exportacionesBindingSource3;
            this.exportacionesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exportacionesDataGridView.Location = new System.Drawing.Point(169, 75);
            this.exportacionesDataGridView.Name = "exportacionesDataGridView";
            this.exportacionesDataGridView.ReadOnly = true;
            this.exportacionesDataGridView.Size = new System.Drawing.Size(906, 479);
            this.exportacionesDataGridView.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Tipo de Carne";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anioDataGridViewTextBoxColumn
            // 
            this.anioDataGridViewTextBoxColumn.DataPropertyName = "anio";
            this.anioDataGridViewTextBoxColumn.HeaderText = "Año";
            this.anioDataGridViewTextBoxColumn.Name = "anioDataGridViewTextBoxColumn";
            this.anioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exportacionesBindingSource3
            // 
            this.exportacionesBindingSource3.DataMember = "exportaciones";
            this.exportacionesBindingSource3.DataSource = this.carnesDBDataSet1;
            // 
            // carnesDBDataSet1
            // 
            this.carnesDBDataSet1.DataSetName = "carnesDBDataSet";
            this.carnesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carnesDBDataSet
            // 
            this.carnesDBDataSet.DataSetName = "carnesDBDataSet";
            this.carnesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carnesBindingSource
            // 
            this.carnesBindingSource.DataMember = "carnes";
            this.carnesBindingSource.DataSource = this.carnesDBDataSet;
            // 
            // carnesTableAdapter
            // 
            this.carnesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carnesTableAdapter = this.carnesTableAdapter;
            this.tableAdapterManager.UpdateOrder = slnEstadisticaInferencial.carnesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // exportacionesBindingSource2
            // 
            this.exportacionesBindingSource2.DataMember = "exportaciones";
            this.exportacionesBindingSource2.DataSource = this.carnesDBDataSet;
            // 
            // exportacionesTableAdapter
            // 
            this.exportacionesTableAdapter.ClearBeforeFill = true;
            // 
            // PnlNavBar
            // 
            this.PnlNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PnlNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlNavBar.Location = new System.Drawing.Point(169, 0);
            this.PnlNavBar.Name = "PnlNavBar";
            this.PnlNavBar.Size = new System.Drawing.Size(906, 21);
            this.PnlNavBar.TabIndex = 11;
            // 
            // FrmExportaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 554);
            this.Controls.Add(this.PnlNavBar);
            this.Controls.Add(this.exportacionesDataGridView);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExportaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCarnes";
            this.Load += new System.EventHandler(this.FrmExportaciones_Load);
            this.PnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exportacionesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportacionesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportacionesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportacionesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Panel PnlSideBar;
        private System.Windows.Forms.Button BtnVarianza;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Panel panel1;
        private carnesDBDataSet carnesDBDataSet;
        private System.Windows.Forms.BindingSource carnesBindingSource;
        private carnesDBDataSetTableAdapters.carnesTableAdapter carnesTableAdapter;
        private carnesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.BindingSource exportacionesBindingSource;
        private System.Windows.Forms.BindingSource exportacionesBindingSource1;
        private System.Windows.Forms.BindingSource exportacionesBindingSource2;
        private carnesDBDataSetTableAdapters.exportacionesTableAdapter exportacionesTableAdapter;
        private System.Windows.Forms.DataGridView exportacionesDataGridView;
        private carnesDBDataSet carnesDBDataSet1;
        private System.Windows.Forms.BindingSource exportacionesBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel PnlNavBar;
        private System.Windows.Forms.Button BtnDesviacionEstandar;
    }
}