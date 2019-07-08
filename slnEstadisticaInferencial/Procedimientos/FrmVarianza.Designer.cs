namespace slnEstadisticaInferencial.Procedimientos
{
    partial class FrmVarianza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVarianza));
            this.PnlSideBar = new System.Windows.Forms.Panel();
            this.cmbAnioComparar = new System.Windows.Forms.ComboBox();
            this.chkComparar = new System.Windows.Forms.CheckBox();
            this.cmbAnio1 = new System.Windows.Forms.ComboBox();
            this.lblComparar = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnVarianza = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DvgVarianzas = new System.Windows.Forms.DataGridView();
            this.PnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgVarianzas)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSideBar
            // 
            this.PnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlSideBar.Controls.Add(this.cmbAnioComparar);
            this.PnlSideBar.Controls.Add(this.chkComparar);
            this.PnlSideBar.Controls.Add(this.cmbAnio1);
            this.PnlSideBar.Controls.Add(this.lblComparar);
            this.PnlSideBar.Controls.Add(this.LblTitulo);
            this.PnlSideBar.Controls.Add(this.BtnVolver);
            this.PnlSideBar.Controls.Add(this.BtnVarianza);
            this.PnlSideBar.Controls.Add(this.panel1);
            this.PnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.PnlSideBar.Name = "PnlSideBar";
            this.PnlSideBar.Size = new System.Drawing.Size(169, 378);
            this.PnlSideBar.TabIndex = 9;
            // 
            // cmbAnioComparar
            // 
            this.cmbAnioComparar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnioComparar.FormattingEnabled = true;
            this.cmbAnioComparar.Location = new System.Drawing.Point(3, 229);
            this.cmbAnioComparar.Name = "cmbAnioComparar";
            this.cmbAnioComparar.Size = new System.Drawing.Size(163, 21);
            this.cmbAnioComparar.TabIndex = 16;
            // 
            // chkComparar
            // 
            this.chkComparar.AutoSize = true;
            this.chkComparar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComparar.ForeColor = System.Drawing.Color.White;
            this.chkComparar.Location = new System.Drawing.Point(7, 180);
            this.chkComparar.Name = "chkComparar";
            this.chkComparar.Size = new System.Drawing.Size(84, 19);
            this.chkComparar.TabIndex = 9;
            this.chkComparar.Text = "Comparar";
            this.chkComparar.UseVisualStyleBackColor = true;
            this.chkComparar.CheckedChanged += new System.EventHandler(this.chkComparar_CheckedChanged);
            // 
            // cmbAnio1
            // 
            this.cmbAnio1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnio1.FormattingEnabled = true;
            this.cmbAnio1.Location = new System.Drawing.Point(3, 111);
            this.cmbAnio1.Name = "cmbAnio1";
            this.cmbAnio1.Size = new System.Drawing.Size(163, 21);
            this.cmbAnio1.TabIndex = 8;
            // 
            // lblComparar
            // 
            this.lblComparar.AutoSize = true;
            this.lblComparar.BackColor = System.Drawing.Color.Transparent;
            this.lblComparar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComparar.ForeColor = System.Drawing.Color.White;
            this.lblComparar.Location = new System.Drawing.Point(3, 202);
            this.lblComparar.Name = "lblComparar";
            this.lblComparar.Size = new System.Drawing.Size(107, 24);
            this.lblComparar.TabIndex = 14;
            this.lblComparar.Text = "Con Año:";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(3, 84);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(57, 24);
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
            this.BtnVolver.Location = new System.Drawing.Point(14, 12);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(116, 31);
            this.BtnVolver.TabIndex = 0;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnVarianza
            // 
            this.BtnVarianza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnVarianza.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnVarianza.FlatAppearance.BorderSize = 0;
            this.BtnVarianza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVarianza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVarianza.ForeColor = System.Drawing.Color.White;
            this.BtnVarianza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVarianza.Location = new System.Drawing.Point(0, 319);
            this.BtnVarianza.Name = "BtnVarianza";
            this.BtnVarianza.Size = new System.Drawing.Size(169, 59);
            this.BtnVarianza.TabIndex = 15;
            this.BtnVarianza.Text = "Calcular Varianza";
            this.BtnVarianza.UseVisualStyleBackColor = false;
            this.BtnVarianza.Click += new System.EventHandler(this.BtnVarianza_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(183, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // DvgVarianzas
            // 
            this.DvgVarianzas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DvgVarianzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgVarianzas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DvgVarianzas.Location = new System.Drawing.Point(169, 58);
            this.DvgVarianzas.Name = "DvgVarianzas";
            this.DvgVarianzas.Size = new System.Drawing.Size(833, 320);
            this.DvgVarianzas.TabIndex = 18;
            // 
            // FrmVarianza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 378);
            this.Controls.Add(this.DvgVarianzas);
            this.Controls.Add(this.PnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVarianza";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmVarianza_Load);
            this.PnlSideBar.ResumeLayout(false);
            this.PnlSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgVarianzas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSideBar;
        private System.Windows.Forms.ComboBox cmbAnioComparar;
        private System.Windows.Forms.CheckBox chkComparar;
        private System.Windows.Forms.ComboBox cmbAnio1;
        private System.Windows.Forms.Label lblComparar;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnVarianza;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DvgVarianzas;
    }
}