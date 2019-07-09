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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            PnlSidePanel.Height = BtnInicio.Height;
            PnlSidePanel.Top = BtnInicio.Top;
            ctluInicio1.BringToFront();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            PnlSidePanel.Height = BtnInicio.Height;
            PnlSidePanel.Top = BtnInicio.Top;
            ctluInicio1.BringToFront();
        }

        private void BtnTablas_Click(object sender, EventArgs e)
        {
            PnlSidePanel.Height = BtnTablas.Height;
            PnlSidePanel.Top = BtnTablas.Top;
            ctlUTablas1.BringToFront();
        }

        private void carnesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carnesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carnesDBDataSet);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frm = new FrmAcercaDe();
            frm.ShowDialog();
        }
    }
}
