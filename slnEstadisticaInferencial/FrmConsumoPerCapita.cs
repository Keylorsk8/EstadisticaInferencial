using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using slnEstadisticaInferencial.Procedimientos;
using slnEstadisticaInferencial.Models;
using slnEstadisticaInferencial.Mantenimientos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using slnEstadisticaInferencial.CRUD;
namespace slnEstadisticaInferencial
{
    public partial class FrmConsumoPerCapita : Form
    {
        public FrmConsumoPerCapita()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsumoPerCapita_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'carnesDBDataSet.consumoPerCapita' Puede moverla o quitarla según sea necesario.
            //this.consumoPerCapitaTableAdapter.Fill(this.carnesDBDataSet.consumoPerCapita);
            Refrescar();
        }
        private void Refrescar()
        {
            // TODO: esta línea de código carga datos en la tabla 'carnesDBDataSet.producciones' Puede moverla o quitarla según sea necesario.
            Models.CarnesContexto contexto = new Models.CarnesContexto();
            List<Models.consumoPerCapita> conPerCap = contexto.consumoPerCapita.ToList();
            consumoPerCapitaDataGridView.DataSource = conPerCap;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            FrmAcercaDe acerca = new FrmAcercaDe();
            acerca.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Procedimientos.FrmMedia media = new Procedimientos.FrmMedia(3);
            media.ShowDialog();
        }

        private void BtnVarianza_Click(object sender, EventArgs e)
        {
            FrmVarianza varianza = new FrmVarianza(3);
            varianza.ShowDialog();
        }

        private void BtnDesviacionEstandar_Click(object sender, EventArgs e)
        {
            FrmDesviacion desviacion = new FrmDesviacion(3);
            desviacion.ShowDialog();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            FrmManteConsumoPerCapita conP = new FrmManteConsumoPerCapita();
            conP.accion = 1;
            conP.ShowDialog();
            Refrescar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmManteConsumoPerCapita conP = new FrmManteConsumoPerCapita();
            conP.accion = 2;
            consumoPerCapita cpc = ((consumoPerCapita)consumoPerCapitaDataGridView.SelectedRows[0].DataBoundItem);
            conP.id = cpc.id;
            conP.ShowDialog();
            Refrescar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            consumoPerCapita cpc = ((consumoPerCapita)consumoPerCapitaDataGridView.SelectedRows[0].DataBoundItem);
            ConsumoPerCapitaLN cpcln = new ConsumoPerCapitaLN();
            cpcln.eliminaConsumoPerCapita(cpc.id);
            MessageBox.Show("Se eliminó correctamente el Consumo Per Cápita");
            Refrescar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Refrescar();
        }
    }
}
