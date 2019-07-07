using slnEstadisticaInferencial.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace slnEstadisticaInferencial
{
    public partial class FrmExportaciones : Form
    {
        CarnesContexto contexto = new CarnesContexto();
        public FrmExportaciones()
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

        private void exportacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.exportacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carnesDBDataSet);

        }

        private void FrmExportaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'carnesDBDataSet1.exportaciones' Puede moverla o quitarla según sea necesario.
            this.exportacionesTableAdapter.Fill(this.carnesDBDataSet1.exportaciones);
            // TODO: esta línea de código carga datos en la tabla 'carnesDBDataSet.exportaciones' Puede moverla o quitarla según sea necesario.
            //this.exportacionesTableAdapter.Fill(this.carnesDBDataSet.exportaciones);


        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Procedimientos.FrmMedia media = new Procedimientos.FrmMedia(1);
            media.ShowDialog();
        }
    }
}
