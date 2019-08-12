using slnEstadisticaInferencial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnEstadisticaInferencial.CRUD
{
    class ConsumoPerCapitaLN
    {
        public void GuardarConsumoPerCapita(int idCarne, double cantidad, int anio)
        {
            CarnesContexto db = new CarnesContexto();
            var miConsumoPerCapita = new consumoPerCapita();

            miConsumoPerCapita.cantidad = cantidad;
            miConsumoPerCapita.anio = anio;
            miConsumoPerCapita.idCarne = idCarne;
            db.consumoPerCapita.Add(miConsumoPerCapita);
            db.SaveChanges();

        }
        public void actualizaConsumoPerCapita(int id, int idCarne, double cantidad, int anio)
        {

            CarnesContexto db = new CarnesContexto();
            var miConsumoPerCapita = new consumoPerCapita();
            miConsumoPerCapita = db.consumoPerCapita.Where(p => p.id == id).First<consumoPerCapita>();
            miConsumoPerCapita.cantidad = cantidad;
            miConsumoPerCapita.anio = anio;
            miConsumoPerCapita.idCarne = idCarne;
            db.SaveChanges();

        }
        public void eliminaConsumoPerCapita(int id)
        {

            CarnesContexto db = new CarnesContexto();
            var miConsumoPerCapita = new consumoPerCapita();
            miConsumoPerCapita = db.consumoPerCapita.Where(p => p.id == id).First<consumoPerCapita>();
            db.consumoPerCapita.Remove(miConsumoPerCapita);
            db.SaveChanges();

        }
    }
}
