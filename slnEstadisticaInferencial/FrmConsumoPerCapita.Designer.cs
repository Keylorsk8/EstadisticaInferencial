namespace slnEstadisticaInferencial
{
    partial class FrmConsumoPerCapita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsumoPerCapita));
            this.PnlSideBar = new System.Windows.Forms.Panel();
            this.BtnDesviacionEstandar = new System.Windows.Forms.Button();
            this.BtnVarianza = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.carnesDBDataSet = new slnEstadisticaInferencial.carnesDBDataSet();
            this.consumoPerCapitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumoPerCapitaTableAdapter = new slnEstadisticaInferencial.carnesDBDataSetTableAdapters.consumoPerCapitaTableAdapter();
            this.tableAdapterManager = new slnEstadisticaInferencial.carnesDBDataSetTableAdapters.TableAdapterManager();
            this.consumoPerCapitaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlNavBar = new System.Windows.Forms.Panel();
            this.PnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carnesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumoPerCapitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumoPerCapitaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSideBar
            // 
            this.PnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlSideBar.Controls.Add(this.BtnDesviacionEstandar);
            this.PnlSideBar.Controls.Add(this.BtnVarianza);
            this.PnlSideBar.Controls.Add(this.button3);
            this.PnlSideBar.Controls.Add(this.BtnEliminar);
            this.PnlSideBar.Controls.Add(this.BtnModificar);
            this.PnlSideBar.Controls.Add(this.BtnInsertar);
            this.PnlSideBar.Controls.Add(this.BtnVolver);
            this.PnlSideBar.Controls.Add(this.button4);
            this.PnlSideBar.Controls.Add(this.panel1);
            this.PnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.PnlSideBar.Name = "PnlSideBar";
            this.PnlSideBar.Size = new System.Drawing.Size(169, 554);
            this.PnlSideBar.TabIndex = 6;
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
            this.BtnDesviacionEstandar.Size = new System.Drawing.Size(157, 86);
            this.BtnDesviacionEstandar.TabIndex = 17;
            this.BtnDesviacionEstandar.Text = "Calcular\r\nDesviación Estándar\r\n";
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
            this.BtnVarianza.TabIndex = 16;
            this.BtnVarianza.Text = "Calcular\r\n Varianza";
            this.BtnVarianza.UseVisualStyleBackColor = false;
            this.BtnVarianza.Click += new System.EventHandler(this.BtnVarianza_Click);
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
            this.button3.TabIndex = 15;
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
            this.BtnEliminar.TabIndex = 14;
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
            this.BtnModificar.TabIndex = 13;
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
            this.BtnInsertar.TabIndex = 12;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
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
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(14, 512);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.LblTitulo.Location = new System.Drawing.Point(175, 24);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(341, 24);
            this.LblTitulo.TabIndex = 12;
            this.LblTitulo.Text = "Listado de Consumos Per Cápita";
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // carnesDBDataSet
            // 
            this.carnesDBDataSet.DataSetName = "carnesDBDataSet";
            this.carnesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consumoPerCapitaBindingSource
            // 
            this.consumoPerCapitaBindingSource.DataMember = "consumoPerCapita";
            this.consumoPerCapitaBindingSource.DataSource = this.carnesDBDataSet;
            // 
            // consumoPerCapitaTableAdapter
            // 
            this.consumoPerCapitaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carnesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = slnEstadisticaInferencial.carnesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // consumoPerCapitaDataGridView
            // 
            this.consumoPerCapitaDataGridView.AutoGenerateColumns = false;
            this.consumoPerCapitaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.consumoPerCapitaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consumoPerCapitaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.consumoPerCapitaDataGridView.DataSource = this.consumoPerCapitaBindingSource;
            this.consumoPerCapitaDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.consumoPerCapitaDataGridView.Location = new System.Drawing.Point(169, 62);
            this.consumoPerCapitaDataGridView.Name = "consumoPerCapitaDataGridView";
            this.consumoPerCapitaDataGridView.Size = new System.Drawing.Size(906, 492);
            this.consumoPerCapitaDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipo de Carne";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "anio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Año";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // PnlNavBar
            // 
            this.PnlNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PnlNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlNavBar.Location = new System.Drawing.Point(169, 0);
            this.PnlNavBar.Name = "PnlNavBar";
            this.PnlNavBar.Size = new System.Drawing.Size(906, 21);
            this.PnlNavBar.TabIndex = 14;
            // 
            // FrmConsumoPerCapita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 554);
            this.Controls.Add(this.PnlNavBar);
            this.Controls.Add(this.consumoPerCapitaDataGridView);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsumoPerCapita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsumoPerCapita";
            this.Load += new System.EventHandler(this.FrmConsumoPerCapita_Load);
            this.PnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carnesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumoPerCapitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumoPerCapitaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlSideBar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
        private carnesDBDataSet carnesDBDataSet;
        private System.Windows.Forms.BindingSource consumoPerCapitaBindingSource;
        private carnesDBDataSetTableAdapters.consumoPerCapitaTableAdapter consumoPerCapitaTableAdapter;
        private carnesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView consumoPerCapitaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel PnlNavBar;
        private System.Windows.Forms.Button BtnDesviacionEstandar;
        private System.Windows.Forms.Button BtnVarianza;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnInsertar;
    }
}