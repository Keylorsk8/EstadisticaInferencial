using slnEstadisticaInferencial.CRUD;
using slnEstadisticaInferencial.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnEstadisticaInferencial.Mantenimientos
{
    public partial class FrmManteCarnes : Form
    {
        Models.CarnesContexto contexto = new Models.CarnesContexto();

        CarneLN carneLN = new CarneLN();
        public int accion = 0;
        public int id = 0;
        public FrmManteCarnes()
        {
            InitializeComponent();
        }
        private void FrmManteCarnes_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            if (accion == 1)
            {
                BtnAccion.Text = "Agregar carne";
            }
            else
            {
                if (accion == 2)
                {
                    carnes carnes1 = contexto.carnes.Where(x => x.id == id).FirstOrDefault<carnes>();
                    BtnAccion.Text = "Actualizar carne";
                    maskedTextBox1.Text = carnes1.nombre;
                }
            }
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAccion_Click(object sender, EventArgs e)
        {
            string cadena = "0123456789!@#$%^&*()_+-}{[]'/.;";
            bool dontWork = false;

            if (accion == 1)
            {
                for (int i = 0; i < maskedTextBox1.Text.Length; i++)
                {
                    for (int j = 0; j < cadena.Length; j++)
                    {
                        if (maskedTextBox1.Text[i].Equals(cadena[j]))
                        {
                            dontWork = true;
                        }
                    }
                }
                if (dontWork)
                {
                    MessageBox.Show(null, "Solo se aceptan letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    carneLN.GuardarCarne(maskedTextBox1.Text);
                    MessageBox.Show("Se creó la carne correctamente");
                }
            }
            else
            {
                if (accion == 2)
                {
                        for (int i = 0; i < maskedTextBox1.Text.Length; i++)
                        {
                            for (int j = 0; j < cadena.Length; j++)
                            {
                                if (maskedTextBox1.Text[i].Equals(cadena[j]))
                                {
                                    dontWork = true;
                                }
                            }
                        }
                        if (dontWork)
                        {
                            MessageBox.Show(null, "Solo se aceptan letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            carneLN.actualizaCarne(id, maskedTextBox1.Text);
                            MessageBox.Show("Se actualizó la carne con éxito!");
                        }
                    
                }
            }
            this.Close();
        }

        private void BtnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
