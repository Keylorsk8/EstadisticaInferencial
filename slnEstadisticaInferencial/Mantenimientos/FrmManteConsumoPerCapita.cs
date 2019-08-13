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
    public partial class FrmManteConsumoPerCapita : Form
    {
        Models.CarnesContexto contexto = new Models.CarnesContexto();
        ConsumoPerCapitaLN cpcLN = new ConsumoPerCapitaLN();
        public int accion = 0;
        public int id = 0;
        public FrmManteConsumoPerCapita()
        {
            InitializeComponent();
        }

        private void FrmManteConsumoPerCapita_Load(object sender, EventArgs e)
        {
            List<int> anios = new List<int>();
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
                BtnAccion.Text = "Agregar Consumo Per Cápita";
            }
            else
            {
                if (accion == 2)
                {
                    consumoPerCapita cpc = contexto.consumoPerCapita.Where(x => x.id == id).FirstOrDefault<consumoPerCapita>();

                    carnes carnes1 = contexto.carnes.Where(x => x.id == cpc.idCarne).FirstOrDefault<carnes>();

                    BtnAccion.Text = "Actualizar Consumo Per Cápita";
                    cmbCarne.SelectedItem = carnes1;
                    cmbAnio1.SelectedItem = cpc.anio;
                    textBox1.Text = cpc.cantidad.ToString();
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
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    for (int j = 0; j < cadena.Length; j++)
                    {
                        if (textBox1.Text[i].Equals(cadena[j]))
                        {
                            dontWork = true;
                        }
                    }
                }
                if (dontWork)
                {
                    MessageBox.Show(null,"Solo se aceptan valores enteros y decimales","Error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    cpcLN.GuardarConsumoPerCapita((int)cmbCarne.SelectedValue, Convert.ToDouble(textBox1.Text), (int)cmbAnio1.SelectedValue);
                    MessageBox.Show("Se guardó la Consumo Per Cápita correctamente");
                    this.Close();
                } 
                
            }
            else
            {
                if (accion == 2)
                {
                    for (int i = 0; i < textBox1.Text.Length; i++)
                    {
                        for (int j = 0; j < cadena.Length; j++)
                        {
                            if (textBox1.Text[i].Equals(cadena[j]))
                            {
                                dontWork = true;
                            }
                        }
                    }
                    if (dontWork)
                    {
                        MessageBox.Show(null, "Solo se aceptan valores enteros y decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else { 
                    cpcLN.actualizaConsumoPerCapita(id, (int)cmbCarne.SelectedValue, Convert.ToDouble(textBox1.Text), (int)cmbAnio1.SelectedValue);
                    MessageBox.Show("Se actualizó la Consumo Per Cápita con éxito!");
                    this.Close();
                    }
                }
            }
        }
    }
}
