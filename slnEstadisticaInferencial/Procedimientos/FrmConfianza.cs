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
    public partial class FrmConfianza : Form
    {
        Models.CarnesContexto contexto = new Models.CarnesContexto();
        List<int> anios = new List<int>();

        public FrmConfianza()
        {
            InitializeComponent();
        }
        private void FrmConfianza_Load(object sender, EventArgs e)
        {
            llenarCombo();

            pnlRespuesta.Visible = false;
        }

        public void llenarCombo()
        {
            bool esta = false;

            List<Models.producciones> producciones = contexto.producciones.ToList();
            foreach (var ex in producciones)
            {
                if (anios.Count == 0)
                {
                    anios.Add(ex.anio);
                }
                else
                {
                    foreach (var anio in anios)
                    {
                        if (anio == ex.anio)
                        {
                            esta = true;
                        }
                    }
                    if (esta == false)
                    {
                        esta = false;
                        anios.Add(ex.anio);
                    }
                    else
                    {
                        esta = false;
                    }
                }
            }
            cmbAnio1.DataSource = anios;
        }

        public void datos()
        {
            IQueryable<Models.producciones> export = contexto.producciones;
            List<Models.producciones> exportaciones = new List<Models.producciones>();

            foreach (var ex in export)
            {
                if (ex.anio.Equals(cmbAnio1.SelectedValue))
                {
                    exportaciones.Add(ex);
                }
            }

            double media = 0.0;

            foreach (Models.producciones ex in exportaciones)
            {
                media += ex.cantidad;
            }
            media = media / exportaciones.Count();



            lblPromedioX.Text = media.ToString("N2");

            lblmuestra.Text = exportaciones.Count().ToString();

            double sumatoria = 0.0;

            foreach (var ex in exportaciones)
            {
                sumatoria += Math.Pow((ex.cantidad - media), 2);
            }

            double varianza = sumatoria / (exportaciones.Count - 1);

            double desviacion = Math.Sqrt(varianza);


            lblDesviacion.Text = desviacion.ToString("N2");
        }

        

        private void cmbAnio1_SelectedIndexChanged(object sender, EventArgs e)
        {
            datos();
        }

        private void BtnConfianza_Click(object sender, EventArgs e)
        {
            double X = Convert.ToDouble(lblPromedioX.Text);
            double O = Convert.ToDouble(lblDesviacion.Text);
            int n = Convert.ToInt32(lblmuestra.Text);
            double t = Convert.ToDouble(lblTStudent.Text);
            double menor = 0;
        
            menor = X - ((t) * (O / Math.Sqrt(n)));
            lblMenor.Text = menor.ToString("N4");

            double mayor = 0;

            mayor = X + ((t) * (O / Math.Sqrt(n)));

            lblMayor.Text = mayor.ToString("N4");
            
            rTxtRespuesta.Text = "La producción de carne del año " + cmbAnio1.SelectedValue +  " puede tener un 98% de " +
                "confianza en que el promedio de todos los tipos de carnes está entre " + Math.Round(Convert.ToDouble(lblMenor.Text),2) + " y " + Math.Round(Convert.ToDouble(lblMayor.Text), 2);
            
            pnlRespuesta.Visible = true;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
