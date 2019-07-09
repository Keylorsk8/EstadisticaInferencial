using System;
using System.Windows.Forms;
using slnEstadisticaInferencial.Procedimientos;
using slnEstadisticaInferencial.Models;

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
            // TODO: esta línea de código carga datos en la tabla 'carnesDBDataSet.producciones' Puede moverla o quitarla según sea necesario.
            this.produccionesTableAdapter.Fill(this.carnesDBDataSet.producciones);

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
    }
}
