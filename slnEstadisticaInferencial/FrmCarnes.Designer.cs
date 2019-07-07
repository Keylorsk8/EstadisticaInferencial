namespace slnEstadisticaInferencial
{
    partial class FrmCarnesCopia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarnesCopia));
            this.BtnVolver = new System.Windows.Forms.Button();
            this.PnlSideBar = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.carnesDBDataSet = new slnEstadisticaInferencial.carnesDBDataSet();
            this.carnesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carnesTableAdapter = new slnEstadisticaInferencial.carnesDBDataSetTableAdapters.carnesTableAdapter();
            this.tableAdapterManager = new slnEstadisticaInferencial.carnesDBDataSetTableAdapters.TableAdapterManager();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PnlNavBar = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnesDataGridView = new System.Windows.Forms.DataGridView();
            this.PnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carnesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesDataGridView)).BeginInit();
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
            this.PnlSideBar.Controls.Add(this.BtnVolver);
            this.PnlSideBar.Controls.Add(this.button4);
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
            // BtnEliminar
            // 
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(14, 249);
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
            this.BtnModificar.Location = new System.Drawing.Point(14, 162);
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(183, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
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
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(175, 24);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(192, 24);
            this.LblTitulo.TabIndex = 10;
            this.LblTitulo.Text = "Listado de Carnes";
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // carnesDataGridView
            // 
            this.carnesDataGridView.AllowUserToAddRows = false;
            this.carnesDataGridView.AllowUserToDeleteRows = false;
            this.carnesDataGridView.AllowUserToOrderColumns = true;
            this.carnesDataGridView.AutoGenerateColumns = false;
            this.carnesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.carnesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carnesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.carnesDataGridView.DataSource = this.carnesBindingSource;
            this.carnesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.carnesDataGridView.Location = new System.Drawing.Point(169, 75);
            this.carnesDataGridView.Name = "carnesDataGridView";
            this.carnesDataGridView.ReadOnly = true;
            this.carnesDataGridView.Size = new System.Drawing.Size(906, 479);
            this.carnesDataGridView.TabIndex = 6;
            // 
            // FrmCarnesCopia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 554);
            this.Controls.Add(this.PnlNavBar);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.carnesDataGridView);
            this.Controls.Add(this.PnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCarnesCopia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCarnes";
            this.Load += new System.EventHandler(this.FrmCarnes_Load);
            this.PnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carnesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Panel PnlSideBar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Panel panel1;
        private carnesDBDataSet carnesDBDataSet;
        private System.Windows.Forms.BindingSource carnesBindingSource;
        private carnesDBDataSetTableAdapters.carnesTableAdapter carnesTableAdapter;
        private carnesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel PnlNavBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView carnesDataGridView;
    }
}