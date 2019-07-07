using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnEstadisticaInferencial.Procedimientos
{
    public partial class FrmMedia : Form
    {
        public int opcion = 0;
        Models.CarnesContexto contexto = new Models.CarnesContexto();

        public FrmMedia(int op)
        {
            InitializeComponent();
            opcion = op;
            List<int> anios = new List<int>();
            List<int> aniosComparar = new List<int>();
            bool esta = false;
             
            switch (opcion)
            {
                case 1:
                    this.Text = "Exportaciones";
                    List<Models.exportaciones> exportaciones = contexto.exportaciones.ToList();
                    foreach (var ex in exportaciones)
                    {
                        if(anios.Count == 0)
                        {
                            anios.Add(ex.anio);
                        }else
                        {
                            foreach (var anio in anios)
                            {
                                if(anio == ex.anio)
                                {
                                    esta = true;
                                }
                            }
                            if (esta == false)
                            {
                                esta = false;
                                anios.Add(ex.anio);
                            }else
                            {
                                esta = false;
                            }
                        }
                    }
                    aniosComparar = anios;
                    llenarCombos(anios,aniosComparar);

                break;
                case 2:
                    this.Text = "Producciones";
                    List<Models.producciones> producciones = contexto.producciones.ToList();
                    foreach (var pro in producciones)
                    {
                        if (anios.Count == 0)
                        {
                            anios.Add(pro.anio);
                        }
                        else
                        {
                            foreach (var anio in anios)
                            {
                                if (anio == pro.anio)
                                {
                                    esta = true;
                                }
                            }
                            if (!esta)
                            {
                                esta = false;
                                anios.Add(pro.anio);
                            }
                        }
                    }
                    aniosComparar = anios;
                    llenarCombos(anios, aniosComparar);
                    break;
                case 3:
                    this.Text = "Consumo Per Capita";
                    List<Models.consumoPerCapita> consumoPerCapita = contexto.consumoPerCapita.ToList();
                    foreach (var con in consumoPerCapita)
                    {
                        if (anios.Count == 0)
                        {
                            anios.Add(con.anio);
                        }
                        else
                        {
                            foreach (var anio in anios)
                            {
                                if (anio == con.anio)
                                {
                                    esta = true;
                                }
                            }
                            if (!esta)
                            {
                                esta = false;
                                anios.Add(con.anio);
                            }
                        }
                    }
                    aniosComparar = anios;
                    llenarCombos(anios,aniosComparar);
                    break;
            }
        }

        private void llenarCombos(List<int> anios,List<int> aniosComparar)
        {
            cmbAnio1.DataSource = anios;
            cmbAnioComparar.DataSource = aniosComparar;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMedia_Load(object sender, EventArgs e)
        {
            chkComparar.Checked = false;
            this.cmbAnioComparar.Enabled = false;
            this.cmbAnioComparar.Visible = false;
            this.lblComparar.Visible = false;
        }

        private void chkComparar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkComparar.Checked)
            {
                this.cmbAnioComparar.Enabled = true;
                this.cmbAnioComparar.Visible = true;
                this.lblComparar.Visible = true;
            }else
            {
                this.cmbAnioComparar.Enabled = false;
                this.cmbAnioComparar.Visible = false;
                this.lblComparar.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case 1:
                    List<Models.exportaciones> exportaciones = new List<Models.exportaciones>();
                        
                    break;
                case 2:
                    List<Models.producciones> producciones = new List<Models.producciones>();

                    break;
                case 3:
                    List<Models.consumoPerCapita> consumoPerCapita = new List<Models.consumoPerCapita>();

                    break;
            }
        }
    }
}
