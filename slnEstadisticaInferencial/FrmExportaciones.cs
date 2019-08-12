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
            //this.Validate();
            //this.exportacionesBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.carnesDBDataSet);
        }

        private void FrmExportaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'carnesDBDataSet1.exportaciones' Puede moverla o quitarla según sea necesario.
           // this.exportacionesTableAdapter.Fill(this.carnesDBDataSet1.exportaciones);
            Refrescar();
        }
        private void Refrescar()
        {
            // TODO: esta línea de código carga datos en la tabla 'carnesDBDataSet.producciones' Puede moverla o quitarla según sea necesario.
            Models.CarnesContexto contexto = new Models.CarnesContexto();
            List<Models.exportaciones> producciones1 = contexto.exportaciones.ToList();           
            exportacionesDataGridView.DataSource = producciones1;

        }
        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            FrmManteExportaciones exp = new FrmManteExportaciones();
            exp.accion = 1;
            exp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMedia media = new FrmMedia(1);
            media.ShowDialog();
        }

        private void BtnVarianza_Click(object sender, EventArgs e)
        {
            FrmVarianza varianza = new FrmVarianza(1);
            varianza.ShowDialog();
        }

        private void BtnDesviacionEstandar_Click(object sender, EventArgs e)
        {
            FrmDesviacion desviacion = new FrmDesviacion(1);
            desviacion.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHipotesis hipotesis = new FrmHipotesis();
            hipotesis.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmManteExportaciones exp = new FrmManteExportaciones();
            exp.accion = 2;
            exportaciones ex = ((exportaciones)exportacionesDataGridView.SelectedRows[0].DataBoundItem);
            exp.id = ex.id;
            exp.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            exportaciones ex = ((exportaciones)exportacionesDataGridView.SelectedRows[0].DataBoundItem);
            exportacionesLN exln = new exportacionesLN();
            exln.eliminaExportacion(ex.id);
            MessageBox.Show("Se elimino correctamente su exportación");
            Refrescar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Refrescar();
        }
    }
}
