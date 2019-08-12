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
    public partial class FrmVarianza : Form
    {
        public int opcion = 0;
        Models.CarnesContexto contexto = new Models.CarnesContexto();
        public FrmVarianza(int op)
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
                        if (anios.Count == 0)
                        {
                            anios.Add(ex.anio);
                            aniosComparar.Add(ex.anio);
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
                                aniosComparar.Add(ex.anio);
                            }
                            else
                            {
                                esta = false;
                            }
                        }
                    }
                    llenarCombos(anios, aniosComparar);

                    break;
                case 2:
                    this.Text = "Producciones";
                    List<Models.producciones> producciones = contexto.producciones.ToList();
                    foreach (var ex in producciones)
                    {
                        if (anios.Count == 0)
                        {
                            anios.Add(ex.anio);
                            aniosComparar.Add(ex.anio);
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
                                aniosComparar.Add(ex.anio);
                            }
                            else
                            {
                                esta = false;
                            }
                        }
                    }
                    llenarCombos(anios, aniosComparar);
                    break;
                case 3:
                    this.Text = "Consumo Per Cápita";
                    List<Models.consumoPerCapita> consumoPerCapita = contexto.consumoPerCapita.ToList();
                    foreach (var ex in consumoPerCapita)
                    {
                        if (anios.Count == 0)
                        {
                            anios.Add(ex.anio);
                            aniosComparar.Add(ex.anio);
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
                                aniosComparar.Add(ex.anio);
                            }
                            else
                            {
                                esta = false;
                            }
                        }
                    }
                    llenarCombos(anios, aniosComparar);
                    break;
            }

        }

        private void llenarCombos(List<int> anios, List<int> aniosComparar)
        {
            cmbAnio1.DataSource = anios;
            cmbAnioComparar.DataSource = aniosComparar;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVarianza_Load(object sender, EventArgs e)
        {
            chkComparar.Checked = false;
            this.cmbAnioComparar.Enabled = false;
            this.cmbAnioComparar.Visible = false;
            this.lblComparar.Visible = false;
        }

        private void BtnVarianza_Click(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case 1:
                    if (!chkComparar.Checked)
                    {
                        IQueryable<Models.exportaciones> export = contexto.exportaciones;
                        List<Models.exportaciones> exportaciones = new List<Models.exportaciones>();

                        foreach (var ex in export)
                        {
                            if (ex.anio.Equals(cmbAnio1.SelectedValue))
                            {
                                exportaciones.Add(ex);
                            }
                        }

                        double media = 0.0;

                        foreach (Models.exportaciones ex in exportaciones)
                        {
                            media += ex.cantidad;
                        }
                        media = media / exportaciones.Count();

                        double sumatoria = 0.0;

                        foreach (var ex in exportaciones)
                        {
                            sumatoria += Math.Pow((ex.cantidad - media), 2);
                        }

                        double varianzaSinReedondear = sumatoria / (exportaciones.Count - 1);

                        double varianza = Math.Round(varianzaSinReedondear,2);

                        DataTable table = new DataTable();
                        table.Columns.Add("Descripción");
                        table.Columns.Add("Año");
                        table.Columns.Add("Varianza");

                        DataRow row = table.NewRow();
                        row["Descripción"] = "Varianza de Exportaciones";
                        row["Año"] = cmbAnio1.SelectedValue.ToString();
                        row["Varianza"] = varianza;

                        table.Rows.Add(row);

                        DvgVarianzas.DataSource = table;
                    }
                    else
                    {
                        IQueryable<Models.exportaciones> export = contexto.exportaciones;
                        List<Models.exportaciones> exportaciones = new List<Models.exportaciones>();

                        foreach (var ex in export)
                        {
                            if (ex.anio.Equals(cmbAnio1.SelectedValue))
                            {
                                exportaciones.Add(ex);
                            }
                        }

                        double media = 0.0;

                        foreach (Models.exportaciones ex in exportaciones)
                        {
                            media += ex.cantidad;
                        }
                        media = media / exportaciones.Count();

                        double sumatoria = 0.0;

                        foreach (var ex in exportaciones)
                        {
                            sumatoria += Math.Pow((ex.cantidad - media), 2);
                        }

                        double varianzaSinReedondear = sumatoria / (exportaciones.Count - 1);

                        double varianza = Math.Round(varianzaSinReedondear,2);


                        //Año a comparar: Las variables deben terminar en 2
                        List<Models.exportaciones> exportaciones2 = new List<Models.exportaciones>();

                        foreach (var ex in export)
                        {
                            if (ex.anio.Equals(cmbAnioComparar.SelectedValue))
                            {
                                exportaciones2.Add(ex);
                            }
                        }

                        double media2 = 0.0;

                        foreach (Models.exportaciones ex in exportaciones2)
                        {
                            media2 += ex.cantidad;
                        }
                        media2 = media2 / exportaciones2.Count();

                        double sumatoria2 = 0.0;

                        foreach (var ex in exportaciones2)
                        {
                            sumatoria2 += Math.Pow((ex.cantidad - media2), 2);
                        }

                        double varianzaSinReedondear2 = sumatoria2 / (exportaciones.Count - 1);

                        double varianza2 = Math.Round(varianzaSinReedondear2);

                        DataTable table = new DataTable();
                        table.Columns.Add("Descripción");
                        table.Columns.Add("Año");
                        table.Columns.Add("Varianza");
                        table.Columns.Add("Año 2");
                        table.Columns.Add("Varianza 2");

                        DataRow row = table.NewRow();
                        row["Descripción"] = "Comparación de Exportaciones";
                        row["Año"] = cmbAnio1.SelectedValue.ToString();
                        row["Varianza"] = varianza;
                        row["Año 2"] = cmbAnioComparar.SelectedValue.ToString();
                        row["Varianza 2"] = varianza2;

                        table.Rows.Add(row);

                        DvgVarianzas.DataSource = table;

                    }
                    break;
                case 2:
                    if (!chkComparar.Checked)
                    {
                        IQueryable<Models.producciones> produc = contexto.producciones;
                        List<Models.producciones> producciones = new List<Models.producciones>();

                        foreach (var ex in produc)
                        {
                            if (ex.anio.Equals(cmbAnio1.SelectedValue))
                            {
                                producciones.Add(ex);
                            }
                        }

                        double media = 0.0;

                        foreach (Models.producciones pro in producciones)
                        {
                            media += pro.cantidad;
                        }
                        media = media / producciones.Count();

                        double sumatoria = 0.0;

                        foreach (var ex in producciones)
                        {
                            sumatoria += Math.Pow((ex.cantidad - media), 2);
                        }

                        double varianzaSinReedondear = sumatoria / (producciones.Count - 1);

                        double varianza = Math.Round(varianzaSinReedondear,2);

                        DataTable table = new DataTable();
                        table.Columns.Add("Descripción");
                        table.Columns.Add("Año");
                        table.Columns.Add("Varianza");

                        DataRow row = table.NewRow();
                        row["Descripción"] = "Varianza de Producciones";
                        row["Año"] = cmbAnio1.SelectedValue.ToString();
                        row["Varianza"] = varianza;

                        table.Rows.Add(row);

                        DvgVarianzas.DataSource = table;
                    }
                    else
                    {
                        IQueryable<Models.producciones> produc = contexto.producciones;
                        List<Models.producciones> producciones = new List<Models.producciones>();

                        foreach (var ex in produc)
                        {
                            if (ex.anio.Equals(cmbAnio1.SelectedValue))
                            {
                                producciones.Add(ex);
                            }
                        }

                        double media = 0.0;

                        foreach (Models.producciones ex in producciones)
                        {
                            media += ex.cantidad;
                        }
                        media = media / producciones.Count();

                        double sumatoria = 0.0;

                        foreach (var ex in producciones)
                        {
                            sumatoria += Math.Pow((ex.cantidad - media), 2);
                        }

                        double varianzaSinReedondear = sumatoria / (producciones.Count - 1);

                        double varianza = Math.Round(varianzaSinReedondear,2);


                        //Calcular segundo año: Las variables deben terminar en 2
                        List<Models.producciones> producciones2 = new List<Models.producciones>();

                        foreach (var pro in produc)
                        {
                            if (pro.anio.Equals(cmbAnioComparar.SelectedValue))
                            {
                                producciones2.Add(pro);
                            }
                        }

                        double media2 = 0.0;

                        foreach (Models.producciones pro in producciones2)
                        {
                            media2 += pro.cantidad;
                        }
                        media2 = media2 / producciones2.Count();

                        double sumatoria2 = 0.0;

                        foreach (var ex in producciones2)
                        {
                            sumatoria2 += Math.Pow((ex.cantidad - media2), 2);
                        }

                        double varianzaSinReedondear2 = sumatoria2 / (producciones2.Count - 1);

                        double varianza2 = Math.Round(varianzaSinReedondear2,2);

                        DataTable table = new DataTable();
                        table.Columns.Add("Descripción");
                        table.Columns.Add("Año");
                        table.Columns.Add("Varianza");
                        table.Columns.Add("Año 2");
                        table.Columns.Add("Varianza 2");

                        DataRow row = table.NewRow();
                        row["Descripción"] = "Comparación de Producciones";
                        row["Año"] = cmbAnio1.SelectedValue.ToString();
                        row["Varianza"] = varianza;
                        row["Año 2"] = cmbAnioComparar.SelectedValue.ToString();
                        row["Varianza 2"] = varianza2;

                        table.Rows.Add(row);

                        DvgVarianzas.DataSource = table;

                    }
                    break;
                case 3:
                    if (!chkComparar.Checked)
                    {
                        IQueryable<Models.consumoPerCapita> consu = contexto.consumoPerCapita;
                        List<Models.consumoPerCapita> consumoPerCapita = new List<Models.consumoPerCapita>();

                        foreach (var ex in consu)
                        {
                            if (ex.anio.Equals(cmbAnio1.SelectedValue))
                            {
                                consumoPerCapita.Add(ex);
                            }
                        }

                        double media = 0.0;

                        foreach (Models.consumoPerCapita con in consumoPerCapita)
                        {
                            media += con.cantidad;
                        }
                        media = media / consumoPerCapita.Count();

                        double sumatoria = 0.0;

                        foreach (var ex in consumoPerCapita)
                        {
                            sumatoria += Math.Pow((ex.cantidad - media), 2);
                        }

                        double varianzaSinReedondear = sumatoria / (consumoPerCapita.Count - 1);

                        double varianza = Math.Round(varianzaSinReedondear,2);

                        DataTable table = new DataTable();
                        table.Columns.Add("Descripción");
                        table.Columns.Add("Año");
                        table.Columns.Add("Varianza");

                        DataRow row = table.NewRow();
                        row["Descripción"] = "Varianza de Consumo Per Capita";
                        row["Año"] = cmbAnio1.SelectedValue.ToString();
                        row["Varianza"] = varianza;

                        table.Rows.Add(row);

                        DvgVarianzas.DataSource = table;
                    }
                    else
                    {
                        IQueryable<Models.consumoPerCapita> consu = contexto.consumoPerCapita;
                        List<Models.consumoPerCapita> consumoPerCapita = new List<Models.consumoPerCapita>();

                        foreach (var ex in consu)
                        {
                            if (ex.anio.Equals(cmbAnio1.SelectedValue))
                            {
                                consumoPerCapita.Add(ex);
                            }
                        }

                        double media = 0.0;

                        foreach (Models.consumoPerCapita ex in consumoPerCapita)
                        {
                            media += ex.cantidad;
                        }
                        media = media / consumoPerCapita.Count();

                        double sumatoria = 0.0;

                        foreach (var ex in consumoPerCapita)
                        {
                            sumatoria += Math.Pow((ex.cantidad - media), 2);
                        }

                        double varianzaSinReedondear = sumatoria / (consumoPerCapita.Count - 1);

                        double varianza = Math.Round(varianzaSinReedondear,2);

                        //Calculo de segundo año: Las variables deben terminar en 2
                        List<Models.consumoPerCapita> consumoPerCapita2 = new List<Models.consumoPerCapita>();

                        foreach (var con in consu)
                        {
                            if (con.anio.Equals(cmbAnioComparar.SelectedValue))
                            {
                                consumoPerCapita2.Add(con);
                            }
                        }

                        double media2 = 0.0;

                        foreach (Models.consumoPerCapita con in consumoPerCapita2)
                        {
                            media2 += con.cantidad;
                        }
                        media2 = media2 / consumoPerCapita2.Count();

                        double sumatoria2 = 0.0;

                        foreach (var ex in consumoPerCapita2)
                        {
                            sumatoria2 += Math.Pow((ex.cantidad - media2), 2);
                        }

                        double varianzaSinReedondear2 = sumatoria2 / (consumoPerCapita2.Count - 1);

                        double varianza2 = Math.Round(varianzaSinReedondear,2);

                        DataTable table = new DataTable();
                        table.Columns.Add("Descripción");
                        table.Columns.Add("Año");
                        table.Columns.Add("Varianza");
                        table.Columns.Add("Año 2");
                        table.Columns.Add("Varianza 2");

                        DataRow row = table.NewRow();
                        row["Descripción"] = "Comparación de Consumo Per Cápita";
                        row["Año"] = cmbAnio1.SelectedValue.ToString();
                        row["Varianza"] = varianza;
                        row["Año 2"] = cmbAnioComparar.SelectedValue.ToString();
                        row["Varianza 2"] = varianza2;

                        table.Rows.Add(row);

                        DvgVarianzas.DataSource = table;

                    }

                    break;
            }
        }

        private void chkComparar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkComparar.Checked)
            {
                this.cmbAnioComparar.Enabled = true;
                this.cmbAnioComparar.Visible = true;
                this.lblComparar.Visible = true;
            }
            else
            {
                this.cmbAnioComparar.Enabled = false;
                this.cmbAnioComparar.Visible = false;
                this.lblComparar.Visible = false;
            }
        }
    }
}
