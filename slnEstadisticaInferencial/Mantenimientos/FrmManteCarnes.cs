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
          
            if (accion == 1)
            {
                carneLN.GuardarCarne(maskedTextBox1.Text);
                MessageBox.Show("Se creo su carne correctamente");
            }
            else
            {
                if (accion == 2)
                {
                    carneLN.actualizaCarne(id, maskedTextBox1.Text);
                    MessageBox.Show("Se actualizo su carne con exito!");
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
