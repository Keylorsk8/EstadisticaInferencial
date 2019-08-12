using slnEstadisticaInferencial.CRUD;
using slnEstadisticaInferencial.Mantenimientos;
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

namespace slnEstadisticaInferencial
{
    public partial class FrmCarnesCopia : Form
    {
        public FrmCarnesCopia()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAcercaDe acerca = new FrmAcercaDe();
            acerca.ShowDialog();
        }

        private void carnesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.carnesBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.carnesDBDataSet);

        }
       
    
         private void FrmCarnes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'carnesDBDataSet.carnes' Puede moverla o quitarla según sea necesario.
            Refrescar();

        }
        private void Refrescar()
        {
            Models.CarnesContexto contexto = new Models.CarnesContexto();
            List<Models.carnes> carnes = contexto.carnes.ToList();

            // this.produccionesTableAdapter.Fill(this.carnesDBDataSet.producciones);
            carnesDataGridView.DataSource = carnes;
            //this.carnesTableAdapter.Fill(this.carnesDBDataSet.carnes);
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            FrmManteCarnes carnes = new FrmManteCarnes();
            carnes.accion = 1;
            carnes.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmManteCarnes carnes1 = new FrmManteCarnes();
            carnes1.accion = 2;
            carnes carnes = ((carnes)carnesDataGridView.SelectedRows[0].DataBoundItem);
            carnes1.id = carnes.id;
            carnes1.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            carnes car = ((carnes)carnesDataGridView.SelectedRows[0].DataBoundItem);
            CarneLN carln = new CarneLN();
            carln.eliminaCarne(car.id);
            Refrescar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}
