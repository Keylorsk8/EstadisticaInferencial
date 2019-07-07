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
            this.consumoPerCapitaTableAdapter.Fill(this.carnesDBDataSet.consumoPerCapita);

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
    }
}
