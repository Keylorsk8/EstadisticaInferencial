namespace slnEstadisticaInferencial
{
    partial class CtlUTablas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtlUTablas));
            this.carnesDBDataSet = new slnEstadisticaInferencial.carnesDBDataSet();
            this.carnesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carnesTableAdapter = new slnEstadisticaInferencial.carnesDBDataSetTableAdapters.carnesTableAdapter();
            this.tableAdapterManager = new slnEstadisticaInferencial.carnesDBDataSetTableAdapters.TableAdapterManager();
            this.carnesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnConsumoPerCapita = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnCarnes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnExportaciones = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnProducciones = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carnesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
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
            // carnesBindingSource1
            // 
            this.carnesBindingSource1.DataMember = "carnes";
            this.carnesBindingSource1.DataSource = this.carnesDBDataSet;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.BtnConsumoPerCapita);
            this.panel1.Location = new System.Drawing.Point(903, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 356);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(4, 4);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(256, 171);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // BtnConsumoPerCapita
            // 
            this.BtnConsumoPerCapita.BackColor = System.Drawing.Color.Brown;
            this.BtnConsumoPerCapita.FlatAppearance.BorderSize = 0;
            this.BtnConsumoPerCapita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsumoPerCapita.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsumoPerCapita.ForeColor = System.Drawing.Color.White;
            this.BtnConsumoPerCapita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsumoPerCapita.Location = new System.Drawing.Point(4, 281);
            this.BtnConsumoPerCapita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnConsumoPerCapita.Name = "BtnConsumoPerCapita";
            this.BtnConsumoPerCapita.Size = new System.Drawing.Size(256, 70);
            this.BtnConsumoPerCapita.TabIndex = 10;
            this.BtnConsumoPerCapita.Text = "Consumo Per Cápita";
            this.BtnConsumoPerCapita.UseVisualStyleBackColor = false;
            this.BtnConsumoPerCapita.Click += new System.EventHandler(this.BtnConsumoPerCapita_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.BtnCarnes);
            this.panel4.Location = new System.Drawing.Point(43, 75);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 356);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // BtnCarnes
            // 
            this.BtnCarnes.BackColor = System.Drawing.Color.Brown;
            this.BtnCarnes.FlatAppearance.BorderSize = 0;
            this.BtnCarnes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarnes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarnes.ForeColor = System.Drawing.Color.White;
            this.BtnCarnes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCarnes.Location = new System.Drawing.Point(4, 281);
            this.BtnCarnes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCarnes.Name = "BtnCarnes";
            this.BtnCarnes.Size = new System.Drawing.Size(256, 70);
            this.BtnCarnes.TabIndex = 9;
            this.BtnCarnes.Text = "Carnes";
            this.BtnCarnes.UseVisualStyleBackColor = false;
            this.BtnCarnes.Click += new System.EventHandler(this.BtnCarnes_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.BtnExportaciones);
            this.panel2.Location = new System.Drawing.Point(329, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 356);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // BtnExportaciones
            // 
            this.BtnExportaciones.BackColor = System.Drawing.Color.Brown;
            this.BtnExportaciones.FlatAppearance.BorderSize = 0;
            this.BtnExportaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportaciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportaciones.ForeColor = System.Drawing.Color.White;
            this.BtnExportaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExportaciones.Location = new System.Drawing.Point(4, 281);
            this.BtnExportaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExportaciones.Name = "BtnExportaciones";
            this.BtnExportaciones.Size = new System.Drawing.Size(256, 70);
            this.BtnExportaciones.TabIndex = 10;
            this.BtnExportaciones.Text = "Exportaciones";
            this.BtnExportaciones.UseVisualStyleBackColor = false;
            this.BtnExportaciones.Click += new System.EventHandler(this.BtnExportaciones_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.BtnProducciones);
            this.panel3.Location = new System.Drawing.Point(616, 75);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 356);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(256, 171);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // BtnProducciones
            // 
            this.BtnProducciones.BackColor = System.Drawing.Color.Brown;
            this.BtnProducciones.FlatAppearance.BorderSize = 0;
            this.BtnProducciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducciones.ForeColor = System.Drawing.Color.White;
            this.BtnProducciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProducciones.Location = new System.Drawing.Point(4, 281);
            this.BtnProducciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnProducciones.Name = "BtnProducciones";
            this.BtnProducciones.Size = new System.Drawing.Size(256, 70);
            this.BtnProducciones.TabIndex = 10;
            this.BtnProducciones.Text = "Producciones";
            this.BtnProducciones.UseVisualStyleBackColor = false;
            this.BtnProducciones.Click += new System.EventHandler(this.BtnProducciones_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(37, 25);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(235, 33);
            this.LblTitulo.TabIndex = 9;
            this.LblTitulo.Text = "Listado de Datos";
            // 
            // CtlUTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CtlUTablas";
            this.Size = new System.Drawing.Size(1208, 521);
            this.Load += new System.EventHandler(this.CtlUTablas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carnesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carnesBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource carnesBindingSource;
        private carnesDBDataSet carnesDBDataSet;
        private carnesDBDataSetTableAdapters.carnesTableAdapter carnesTableAdapter;
        private carnesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource carnesBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnConsumoPerCapita;
        private System.Windows.Forms.Button BtnCarnes;
        private System.Windows.Forms.Button BtnExportaciones;
        private System.Windows.Forms.Button BtnProducciones;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
