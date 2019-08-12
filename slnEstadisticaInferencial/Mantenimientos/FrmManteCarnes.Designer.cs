namespace slnEstadisticaInferencial.Mantenimientos
{
    partial class FrmManteCarnes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManteCarnes));
            this.PnlSideBar = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnAccion = new System.Windows.Forms.Button();
            this.PnlSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSideBar
            // 
            this.PnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlSideBar.Controls.Add(this.maskedTextBox1);
            this.PnlSideBar.Controls.Add(this.label4);
            this.PnlSideBar.Controls.Add(this.BtnVolver);
            this.PnlSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.PnlSideBar.Name = "PnlSideBar";
            this.PnlSideBar.Size = new System.Drawing.Size(314, 130);
            this.PnlSideBar.TabIndex = 25;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(155, 67);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nombre";
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
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click_1);
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
            this.BtnAccion.Location = new System.Drawing.Point(0, 130);
            this.BtnAccion.Name = "BtnAccion";
            this.BtnAccion.Size = new System.Drawing.Size(314, 60);
            this.BtnAccion.TabIndex = 24;
            this.BtnAccion.Text = "Agregar";
            this.BtnAccion.UseVisualStyleBackColor = false;
            this.BtnAccion.Click += new System.EventHandler(this.BtnAccion_Click);
            // 
            // FrmManteCarnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 190);
            this.Controls.Add(this.PnlSideBar);
            this.Controls.Add(this.BtnAccion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManteCarnes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmManteCarnes_Load);
            this.PnlSideBar.ResumeLayout(false);
            this.PnlSideBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSideBar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnAccion;
    }
}