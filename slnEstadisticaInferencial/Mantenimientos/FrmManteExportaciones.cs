using System;
using System.Collections.Generic;
using slnEstadisticaInferencial.CRUD;
using slnEstadisticaInferencial.Models;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnEstadisticaInferencial.Mantenimientos
{
    public partial class FrmManteExportaciones : Form
    {
        Models.CarnesContexto contexto = new Models.CarnesContexto();
        exportacionesLN expLN = new exportacionesLN();
        public int accion = 0;
        public int id = 0;

        public FrmManteExportaciones()
        {
            InitializeComponent();
        }

        private void FrmManteExportaciones_Load(object sender, EventArgs e)
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
                BtnAccion.Text = "Agregar exportación";
            }
            else
            {
                if (accion == 2)
                {
                    exportaciones expo = contexto.exportaciones.Where(x => x.id == id).FirstOrDefault<exportaciones>();
                    carnes carnes1 = contexto.carnes.Where(x => x.id == expo.idCarne).FirstOrDefault<carnes>();

                    BtnAccion.Text = "Actualizar exportación";
                    cmbCarne.SelectedItem = carnes1;
                    cmbAnio1.SelectedItem = expo.anio;
                    maskedTextBox1.Text = expo.cantidad.ToString();
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
                expLN.GuardarExportacion((int)cmbCarne.SelectedValue, Convert.ToDouble(maskedTextBox1.Text), (int)cmbAnio1.SelectedValue);
                MessageBox.Show("Se guardo su exportación correctamente");
            }
            else
            {
                if (accion == 2)
                {
                    expLN.actualizaExportacion(id, (int)cmbCarne.SelectedValue, Convert.ToDouble(maskedTextBox1.Text), (int)cmbAnio1.SelectedValue);
                    MessageBox.Show("Se actualizo su exportación con exito!");
                }
            }
            this.Close();
        }

    }
}
