namespace slnEstadisticaInferencial.Procedimientos
{
    partial class FrmConfianza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfianza));
            this.PnlSideBar = new System.Windows.Forms.Panel();
            this.cmbAnio1 = new System.Windows.Forms.ComboBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnConfianza = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPromedioX = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDesviacion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmuestra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRespuesta = new System.Windows.Forms.Panel();
            this.rTxtRespuesta = new System.Windows.Forms.RichTextBox();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblTStudent = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PnlSideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlRespuesta.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSideBar
            // 
            this.PnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlSideBar.Controls.Add(this.cmbAnio1);
            this.PnlSideBar.Controls.Add(this.LblTitulo);
            this.PnlSideBar.Controls.Add(this.BtnVolver);
            this.PnlSideBar.Controls.Add(this.BtnConfianza);
            this.PnlSideBar.Controls.Add(this.panel1);
            this.PnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.PnlSideBar.Name = "PnlSideBar";
            this.PnlSideBar.Size = new System.Drawing.Size(169, 378);
            this.PnlSideBar.TabIndex = 10;
            // 
            // cmbAnio1
            // 
            this.cmbAnio1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnio1.FormattingEnabled = true;
            this.cmbAnio1.Location = new System.Drawing.Point(3, 95);
            this.cmbAnio1.Name = "cmbAnio1";
            this.cmbAnio1.Size = new System.Drawing.Size(163, 21);
            this.cmbAnio1.TabIndex = 16;
            this.cmbAnio1.SelectedIndexChanged += new System.EventHandler(this.cmbAnio1_SelectedIndexChanged);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(3, 68);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(57, 24);
            this.LblTitulo.TabIndex = 17;
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
            // BtnConfianza
            // 
            this.BtnConfianza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnConfianza.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConfianza.FlatAppearance.BorderSize = 0;
            this.BtnConfianza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfianza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfianza.ForeColor = System.Drawing.Color.White;
            this.BtnConfianza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfianza.Location = new System.Drawing.Point(0, 319);
            this.BtnConfianza.Name = "BtnConfianza";
            this.BtnConfianza.Size = new System.Drawing.Size(169, 59);
            this.BtnConfianza.TabIndex = 15;
            this.BtnConfianza.Text = "Calcular Intervalo Confianza 98%";
            this.BtnConfianza.UseVisualStyleBackColor = false;
            this.BtnConfianza.Click += new System.EventHandler(this.BtnConfianza_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(183, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPromedioX);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblDesviacion);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblmuestra);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(183, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 51);
            this.panel2.TabIndex = 42;
            // 
            // lblPromedioX
            // 
            this.lblPromedioX.AutoSize = true;
            this.lblPromedioX.BackColor = System.Drawing.Color.Transparent;
            this.lblPromedioX.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioX.ForeColor = System.Drawing.Color.Black;
            this.lblPromedioX.Location = new System.Drawing.Point(417, 18);
            this.lblPromedioX.Name = "lblPromedioX";
            this.lblPromedioX.Size = new System.Drawing.Size(0, 24);
            this.lblPromedioX.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(377, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(114, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "n :";
            // 
            // lblDesviacion
            // 
            this.lblDesviacion.AutoSize = true;
            this.lblDesviacion.BackColor = System.Drawing.Color.Transparent;
            this.lblDesviacion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesviacion.ForeColor = System.Drawing.Color.Black;
            this.lblDesviacion.Location = new System.Drawing.Point(297, 18);
            this.lblDesviacion.Name = "lblDesviacion";
            this.lblDesviacion.Size = new System.Drawing.Size(0, 24);
            this.lblDesviacion.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(250, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 24);
            this.label8.TabIndex = 40;
            this.label8.Text = "Sx :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(511, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Confianza : 0.98";
            // 
            // lblmuestra
            // 
            this.lblmuestra.AutoSize = true;
            this.lblmuestra.BackColor = System.Drawing.Color.Transparent;
            this.lblmuestra.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmuestra.ForeColor = System.Drawing.Color.Black;
            this.lblmuestra.Location = new System.Drawing.Point(154, 18);
            this.lblmuestra.Name = "lblmuestra";
            this.lblmuestra.Size = new System.Drawing.Size(0, 24);
            this.lblmuestra.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Datos:";
            // 
            // pnlRespuesta
            // 
            this.pnlRespuesta.Controls.Add(this.rTxtRespuesta);
            this.pnlRespuesta.Controls.Add(this.lblMenor);
            this.pnlRespuesta.Controls.Add(this.lblTStudent);
            this.pnlRespuesta.Controls.Add(this.label9);
            this.pnlRespuesta.Controls.Add(this.label10);
            this.pnlRespuesta.Controls.Add(this.lblMayor);
            this.pnlRespuesta.Controls.Add(this.label6);
            this.pnlRespuesta.Location = new System.Drawing.Point(183, 74);
            this.pnlRespuesta.Name = "pnlRespuesta";
            this.pnlRespuesta.Size = new System.Drawing.Size(809, 298);
            this.pnlRespuesta.TabIndex = 41;
            // 
            // rTxtRespuesta
            // 
            this.rTxtRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtRespuesta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtRespuesta.Location = new System.Drawing.Point(67, 225);
            this.rTxtRespuesta.Name = "rTxtRespuesta";
            this.rTxtRespuesta.Size = new System.Drawing.Size(721, 67);
            this.rTxtRespuesta.TabIndex = 50;
            this.rTxtRespuesta.Text = "";
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.BackColor = System.Drawing.Color.Transparent;
            this.lblMenor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor.ForeColor = System.Drawing.Color.Black;
            this.lblMenor.Location = new System.Drawing.Point(213, 133);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(0, 24);
            this.lblMenor.TabIndex = 49;
            // 
            // lblTStudent
            // 
            this.lblTStudent.AutoSize = true;
            this.lblTStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblTStudent.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTStudent.ForeColor = System.Drawing.Color.Black;
            this.lblTStudent.Location = new System.Drawing.Point(86, 59);
            this.lblTStudent.Name = "lblTStudent";
            this.lblTStudent.Size = new System.Drawing.Size(63, 24);
            this.lblTStudent.TabIndex = 48;
            this.lblTStudent.Text = "3,747";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(48, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "t : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(24, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 24);
            this.label10.TabIndex = 45;
            this.label10.Text = "R/:";
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.BackColor = System.Drawing.Color.Transparent;
            this.lblMayor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayor.ForeColor = System.Drawing.Color.Black;
            this.lblMayor.Location = new System.Drawing.Point(388, 133);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(0, 24);
            this.lblMayor.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(306, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "< m <";
            // 
            // FrmConfianza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 378);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlRespuesta);
            this.Controls.Add(this.PnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfianza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfianza";
            this.Load += new System.EventHandler(this.FrmConfianza_Load);
            this.PnlSideBar.ResumeLayout(false);
            this.PnlSideBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlRespuesta.ResumeLayout(false);
            this.pnlRespuesta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSideBar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnConfianza;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbAnio1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDesviacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmuestra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlRespuesta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPromedioX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTStudent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.RichTextBox rTxtRespuesta;
    }
}