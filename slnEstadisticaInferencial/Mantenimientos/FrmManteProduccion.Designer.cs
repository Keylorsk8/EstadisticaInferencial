namespace slnEstadisticaInferencial.Mantenimientos
{
    partial class FrmManteProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManteProduccion));
            this.BtnAccion = new System.Windows.Forms.Button();
            this.PnlSideBar = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cmbCarne = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAnio1 = new System.Windows.Forms.ComboBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.PnlSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAccion
            // 
            this.BtnAccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnAccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAccion.FlatAppearance.BorderSize = 0;
            this.BtnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccion.ForeColor = System.Drawing.Color.White;
            this.BtnAccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAccion.Location = new System.Drawing.Point(0, 229);
            this.BtnAccion.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAccion.Name = "BtnAccion";
            this.BtnAccion.Size = new System.Drawing.Size(429, 74);
            this.BtnAccion.TabIndex = 16;
            this.BtnAccion.Text = "Agregar Producción";
            this.BtnAccion.UseVisualStyleBackColor = false;
            this.BtnAccion.Click += new System.EventHandler(this.BtnAccion_Click);
            // 
            // PnlSideBar
            // 
            this.PnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlSideBar.Controls.Add(this.maskedTextBox1);
            this.PnlSideBar.Controls.Add(this.cmbCarne);
            this.PnlSideBar.Controls.Add(this.label5);
            this.PnlSideBar.Controls.Add(this.label4);
            this.PnlSideBar.Controls.Add(this.cmbAnio1);
            this.PnlSideBar.Controls.Add(this.LblTitulo);
            this.PnlSideBar.Controls.Add(this.BtnVolver);
            this.PnlSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.PnlSideBar.Margin = new System.Windows.Forms.Padding(4);
            this.PnlSideBar.Name = "PnlSideBar";
            this.PnlSideBar.Size = new System.Drawing.Size(429, 229);
            this.PnlSideBar.TabIndex = 23;
            this.PnlSideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSideBar_Paint);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(164, 69);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(132, 22);
            this.maskedTextBox1.TabIndex = 23;
            // 
            // cmbCarne
            // 
            this.cmbCarne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarne.FormattingEnabled = true;
            this.cmbCarne.Location = new System.Drawing.Point(164, 172);
            this.cmbCarne.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCarne.Name = "cmbCarne";
            this.cmbCarne.Size = new System.Drawing.Size(216, 24);
            this.cmbCarne.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 33);
            this.label5.TabIndex = 21;
            this.label5.Text = "Carne";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cantidad";
            // 
            // cmbAnio1
            // 
            this.cmbAnio1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnio1.FormattingEnabled = true;
            this.cmbAnio1.Location = new System.Drawing.Point(164, 121);
            this.cmbAnio1.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAnio1.Name = "cmbAnio1";
            this.cmbAnio1.Size = new System.Drawing.Size(216, 24);
            this.cmbAnio1.TabIndex = 8;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(16, 117);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(75, 33);
            this.LblTitulo.TabIndex = 13;
            this.LblTitulo.Text = "Año:";
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
            // FrmManteProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 303);
            this.Controls.Add(this.PnlSideBar);
            this.Controls.Add(this.BtnAccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManteProduccion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmManteProduccion_Load);
            this.PnlSideBar.ResumeLayout(false);
            this.PnlSideBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAccion;
        private System.Windows.Forms.Panel PnlSideBar;
        private System.Windows.Forms.ComboBox cmbAnio1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCarne;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}