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
            this.Validate();
            this.carnesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carnesDBDataSet);

        }

        private void FrmCarnes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'carnesDBDataSet.carnes' Puede moverla o quitarla según sea necesario.
            this.carnesTableAdapter.Fill(this.carnesDBDataSet.carnes);

        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
