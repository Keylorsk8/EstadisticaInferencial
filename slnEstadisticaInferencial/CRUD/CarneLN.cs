using slnEstadisticaInferencial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnEstadisticaInferencial.CRUD
{
    class CarneLN
    {
        public void GuardarCarne(string nombre)
        {
            CarnesContexto db = new CarnesContexto();
            var miCarne = new carnes();

            miCarne.nombre = nombre;         
            db.carnes.Add(miCarne);
            db.SaveChanges();

        }
        public void actualizaCarne(int id, string nombre)
        {

            CarnesContexto db = new CarnesContexto();
            var miCarne = new carnes();
            miCarne = db.carnes.Where(p => p.id == id).First<carnes>();
            miCarne.nombre = nombre;
            db.SaveChanges();

        }
        public void eliminaCarne(int id)
        {

            CarnesContexto db = new CarnesContexto();
            var miCarne = new carnes();
            miCarne = db.carnes.Where(p => p.id == id).First<carnes>();
            db.carnes.Remove(miCarne);
            db.SaveChanges();

        }
    }
}
