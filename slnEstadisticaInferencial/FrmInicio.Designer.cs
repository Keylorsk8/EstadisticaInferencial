namespace slnEstadisticaInferencial
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.PnlSideBar = new System.Windows.Forms.Panel();
            this.PnlSidePanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnTablas = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlNavBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblProyecto = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.carnesDBDataSet = new slnEstadisticaInferencial.carnesDBDataSet();
            this.carnesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carnesTableAdapter = new slnEstadisticaInferencial.carnesDBDataSetTableAdapters.carnesTableAdapter();
            this.tableAdapterManager = new slnEstadisticaInferencial.carnesDBDataSetTableAdapters.TableAdapterManager();
            this.ctluInicio1 = new slnEstadisticaInferencial.CtluInicio();
            this.ctlUTablas1 = new slnEstadisticaInferencial.CtlUTablas();
            this.PnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSideBar
            // 
            this.PnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlSideBar.Controls.Add(this.PnlSidePanel);
            this.PnlSideBar.Controls.Add(this.button4);
            this.PnlSideBar.Controls.Add(this.button3);
            this.PnlSideBar.Controls.Add(this.button2);
            this.PnlSideBar.Controls.Add(this.BtnSalir);
            this.PnlSideBar.Controls.Add(this.BtnTablas);
            this.PnlSideBar.Controls.Add(this.BtnInicio);
            this.PnlSideBar.Controls.Add(this.panel1);
            this.PnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.PnlSideBar.Name = "PnlSideBar";
            this.PnlSideBar.Size = new System.Drawing.Size(169, 554);
            this.PnlSideBar.TabIndex = 4;
            // 
            // PnlSidePanel
            // 
            this.PnlSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PnlSidePanel.Location = new System.Drawing.Point(3, 75);
            this.PnlSidePanel.Name = "PnlSidePanel";
            this.PnlSidePanel.Size = new System.Drawing.Size(10, 59);
            this.PnlSidePanel.TabIndex = 0;
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
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(14, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 59);
            this.button3.TabIndex = 9;
            this.button3.Text = "xxxxxx";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(14, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 59);
            this.button2.TabIndex = 8;
            this.button2.Text = "xxxxxx";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(4, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(39, 38);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnTablas
            // 
            this.BtnTablas.FlatAppearance.BorderSize = 0;
            this.BtnTablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTablas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTablas.ForeColor = System.Drawing.Color.White;
            this.BtnTablas.Image = ((System.Drawing.Image)(resources.GetObject("BtnTablas.Image")));
            this.BtnTablas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTablas.Location = new System.Drawing.Point(14, 162);
            this.BtnTablas.Name = "BtnTablas";
            this.BtnTablas.Size = new System.Drawing.Size(157, 59);
            this.BtnTablas.TabIndex = 7;
            this.BtnTablas.Text = "Datos";
            this.BtnTablas.UseVisualStyleBackColor = true;
            this.BtnTablas.Click += new System.EventHandler(this.BtnTablas_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.White;
            this.BtnInicio.Image = ((System.Drawing.Image)(resources.GetObject("BtnInicio.Image")));
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(14, 75);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(157, 59);
            this.BtnInicio.TabIndex = 6;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(183, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // PnlNavBar
            // 
            this.PnlNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PnlNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlNavBar.Location = new System.Drawing.Point(169, 0);
            this.PnlNavBar.Name = "PnlNavBar";
            this.PnlNavBar.Size = new System.Drawing.Size(906, 21);
            this.PnlNavBar.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LblProyecto
            // 
            this.LblProyecto.AutoSize = true;
            this.LblProyecto.BackColor = System.Drawing.Color.White;
            this.LblProyecto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProyecto.Location = new System.Drawing.Point(331, 39);
            this.LblProyecto.Name = "LblProyecto";
            this.LblProyecto.Size = new System.Drawing.Size(327, 24);
            this.LblProyecto.TabIndex = 8;
            this.LblProyecto.Text = "Proyecto Estadística Inferencial";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(331, 87);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(297, 21);
            this.LblTitulo.TabIndex = 9;
            this.LblTitulo.Text = "Estadísticas mundiales sobre la carne";
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
            // ctluInicio1
            // 
            this.ctluInicio1.Location = new System.Drawing.Point(169, 142);
            this.ctluInicio1.Name = "ctluInicio1";
            this.ctluInicio1.Size = new System.Drawing.Size(906, 412);
            this.ctluInicio1.TabIndex = 11;
            // 
            // ctlUTablas1
            // 
            this.ctlUTablas1.Location = new System.Drawing.Point(169, 131);
            this.ctlUTablas1.Name = "ctlUTablas1";
            this.ctlUTablas1.Size = new System.Drawing.Size(906, 423);
            this.ctlUTablas1.TabIndex = 10;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 554);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblProyecto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PnlNavBar);
            this.Controls.Add(this.PnlSideBar);
            this.Controls.Add(this.ctluInicio1);
            this.Controls.Add(this.ctlUTablas1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicio";
            this.PnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlSideBar;
        private System.Windows.Forms.Panel PnlSidePanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnTablas;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlNavBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblProyecto;
        private System.Windows.Forms.Label LblTitulo;
        private carnesDBDataSet carnesDBDataSet;
        private System.Windows.Forms.BindingSource carnesBindingSource;
        private carnesDBDataSetTableAdapters.carnesTableAdapter carnesTableAdapter;
        private carnesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CtlUTablas ctlUTablas1;
        private CtluInicio ctluInicio1;
    }
}