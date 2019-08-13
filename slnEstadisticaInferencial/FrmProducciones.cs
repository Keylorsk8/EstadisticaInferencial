using System;
using System.Windows.Forms;
using slnEstadisticaInferencial.Procedimientos;
using slnEstadisticaInferencial.Models;
using slnEstadisticaInferencial.Mantenimientos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using slnEstadisticaInferencial.CRUD;

namespace slnEstadisticaInferencial
{
    public partial class FrmProducciones : Form
    {
        public FrmProducciones()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProducciones_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        private void Refrescar()
        {
            // TODO: esta línea de código carga datos en la tabla 'carnesDBDataSet.producciones' Puede moverla o quitarla según sea necesario.
            Models.CarnesContexto contexto = new Models.CarnesContexto();
            List<Models.producciones> producciones1 = contexto.producciones.ToList();

           // this.produccionesTableAdapter.Fill(this.carnesDBDataSet.producciones);
           produccionesDataGridView.DataSource = producciones1;
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAcercaDe acerca = new FrmAcercaDe();
            acerca.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Procedimientos.FrmMedia media = new Procedimientos.FrmMedia(2);
            media.ShowDialog();
        }

        private void BtnVarianza_Click(object sender, EventArgs e)
        {
            FrmVarianza varianza = new FrmVarianza(2);
            varianza.ShowDialog();
        }

        private void BtnDesviacionEstandar_Click(object sender, EventArgs e)
        {
            FrmDesviacion desviacion = new FrmDesviacion(2);
            desviacion.ShowDialog();
        }

        private void btnHipotesis_Click(object sender, EventArgs e)
        {
            FrmHipotesis hipotesis = new FrmHipotesis();
            hipotesis.ShowDialog();
        }

        private void btnIntervalo_Click(object sender, EventArgs e)
        {
            FrmConfianza confianza = new FrmConfianza();
            confianza.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmManteProduccion produccion = new FrmManteProduccion();
            produccion.accion = 1;
            produccion.ShowDialog();
            Refrescar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmManteProduccion produccion = new FrmManteProduccion();
            produccion.accion = 2;
            producciones pro = ((producciones)produccionesDataGridView.SelectedRows[0].DataBoundItem);
            produccion.id= pro.id;
            produccion.ShowDialog();
            Refrescar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            producciones pro = ((producciones)produccionesDataGridView.SelectedRows[0].DataBoundItem);
            ProduccionesLN proln = new ProduccionesLN();
            proln.eliminaProduccion(pro.id);
            MessageBox.Show("Se eliminó correctamente la producción");
            Refrescar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}
