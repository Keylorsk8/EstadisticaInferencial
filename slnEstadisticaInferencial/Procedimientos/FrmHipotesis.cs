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
    public partial class FrmHipotesis : Form
    {
        Models.CarnesContexto contexto = new Models.CarnesContexto();
        public FrmHipotesis()
        {
            InitializeComponent();
            
        }

        private void FrmHipotesis_Load(object sender, EventArgs e)
        {
            datos();
            pnlRespuesta.Visible = false;
        }


        public void datos()
        {
            IQueryable<Models.producciones> export = contexto.producciones;
            List<Models.producciones> exportaciones = new List<Models.producciones>();
            List<Models.producciones> exportaciones2 = new List<Models.producciones>();

            foreach (var ex in export)
            {
                if (ex.anio.Equals(2005))
                {
                    exportaciones2.Add(ex);
                }
            }

            double prom = 0.0;

            foreach (Models.producciones ex in exportaciones2)
            {
                prom += ex.cantidad;
            }
            prom = prom / exportaciones2.Count();
            lblPromedioX.Text = prom.ToString("N2");

            foreach (var ex in export)
            {
                if (ex.anio.Equals(2003))
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

           

            lblMedia.Text = media.ToString("N2");
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

        private void BtnDesviacion_Click(object sender, EventArgs e)
        {
            double media = Convert.ToDouble(lblMedia.Text);
            double promedio = Convert.ToDouble(lblPromedioX.Text);
            double desviacion = Convert.ToDouble(lblDesviacion.Text);
            int muestra = Convert.ToInt32(lblmuestra.Text);

            double z = 0;

            z = (promedio - media) / (desviacion / Math.Sqrt(muestra));
            lblZ.Text = z.ToString("N4");

            if (z < Convert.ToDouble(lblTStudent.Text))
            {
                lblRespuesta.Text = "Se acepta H0 con una significancia del 0,1";
            }else
            {
                lblRespuesta.Text = "Se rechaza H0 con una significancia del 0,1";
            }
            pnlRespuesta.Visible = true;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
