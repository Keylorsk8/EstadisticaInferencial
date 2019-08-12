using slnEstadisticaInferencial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnEstadisticaInferencial.CRUD
{
    class exportacionesLN
    {
        public void GuardarExportacion(int idCarne, double cantidad, int anio)
        {
            CarnesContexto db = new CarnesContexto();
            var miExportacion = new exportaciones();

            miExportacion.cantidad = cantidad;
            miExportacion.anio = anio;
            miExportacion.idCarne = idCarne;
            db.exportaciones.Add(miExportacion);
            db.SaveChanges();

        }
        public void actualizaExportacion(int id, int idCarne, double cantidad, int anio)
        {

            CarnesContexto db = new CarnesContexto();
            var miExportacion = new exportaciones();
            miExportacion = db.exportaciones.Where(p => p.id == id).First<exportaciones>();
            miExportacion.cantidad = cantidad;
            miExportacion.anio = anio;
            miExportacion.idCarne = idCarne;
            db.SaveChanges();

        }
        public void eliminaExportacion(int id)
        {

            CarnesContexto db = new CarnesContexto();
            var miExportacion = new exportaciones();
            miExportacion = db.exportaciones.Where(p => p.id == id).First<exportaciones>();
            db.exportaciones.Remove(miExportacion);
            db.SaveChanges();

        }
    }
}
