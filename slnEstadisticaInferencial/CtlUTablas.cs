using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnEstadisticaInferencial.Models;

namespace slnEstadisticaInferencial
{
    public partial class CtlUTablas : UserControl
    {
        public CtlUTablas()
        {
            InitializeComponent();
        }

        private void BtnCarnes_Click(object sender, EventArgs e)
        {
            FrmCarnesCopia carnes = new FrmCarnesCopia();
            carnes.ShowDialog();
        }

        private void BtnExportaciones_Click(object sender, EventArgs e)
        {
            FrmExportaciones exportaciones = new FrmExportaciones();
            exportaciones.ShowDialog();
        }

        private void CtlUTablas_Load(object sender, EventArgs e)
        {

        }

        private void BtnProducciones_Click(object sender, EventArgs e)
        {
            FrmProducciones producciones = new FrmProducciones();
            producciones.ShowDialog();
        }

        private void BtnConsumoPerCapita_Click(object sender, EventArgs e)
        {
            FrmConsumoPerCapita consumo = new FrmConsumoPerCapita();
            consumo.ShowDialog();
        }
    }
}
