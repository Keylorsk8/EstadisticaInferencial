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
    public partial class FrmManteProduccion : Form
    {
        Models.CarnesContexto contexto = new Models.CarnesContexto();

        ProduccionesLN produccionesLN = new ProduccionesLN();
        public int accion = 0;
        public int id = 0;
        public FrmManteProduccion()
        {
            InitializeComponent();
        }
        private void FrmManteProduccion_Load(object sender, EventArgs e)
        {
            List<int> anios= new List<int>();
            List<string> nombres = new List<string>();
            List<carnes> carnes = new List<carnes>();
            anios.Add(2003);
            anios.Add(2004);
            anios.Add(2005);
            List<Models.carnes> producciones1 = contexto.carnes.ToList();
            foreach (var ex in producciones1)
            {
                carnes.Add(ex);
            }
            cmbCarne.DataSource = carnes;
            cmbCarne.DisplayMember = "nombre";
            cmbCarne.ValueMember = "id";
            cmbAnio1.DataSource = anios;


            if (accion == 1)
            {
                BtnAccion.Text = "Agregar producción";
            }
            else
            {
                if (accion == 2) {
                    producciones produc = contexto.producciones.Where(x => x.id == id).FirstOrDefault<producciones>();

                    carnes carnes1 = contexto.carnes.Where(x => x.id == produc.idCarne).FirstOrDefault<carnes>();

                    BtnAccion.Text = "Actualizar producción";
                    cmbCarne.SelectedItem = carnes1;
                    cmbAnio1.SelectedItem = produc.anio;
                    maskedTextBox1.Text = produc.cantidad.ToString();
                }
            }
        }


        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAccion_Click(object sender, EventArgs e)
        {
            string cadena = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()_+-}{[]'/.;";
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
                    MessageBox.Show(null, "Solo se aceptan valores enteros y decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    produccionesLN.GuardarProduccion((int)cmbCarne.SelectedValue, Convert.ToDouble(maskedTextBox1.Text), (int)cmbAnio1.SelectedValue);
                    MessageBox.Show("Se creo su producción correctamente");
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
                        MessageBox.Show(null, "Solo se aceptan valores enteros y decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        produccionesLN.actualizaProduccion(id, (int)cmbCarne.SelectedValue, Convert.ToDouble(maskedTextBox1.Text), (int)cmbAnio1.SelectedValue);
                        MessageBox.Show("Se actualizó su producción con éxito!");
                    }
                }
            }
            this.Close();
        }


        private void PnlSideBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
