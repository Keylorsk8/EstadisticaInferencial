using slnEstadisticaInferencial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnEstadisticaInferencial.CRUD
{
    class ProduccionesLN
    {
       
        public void GuardarProduccion(int idCarne, double cantidad,int anio)
        {
            CarnesContexto db = new CarnesContexto();
            var miProduccion = new producciones();
          
            miProduccion.cantidad = cantidad;
            miProduccion.anio = anio;
            miProduccion.idCarne = idCarne;
            db.producciones.Add(miProduccion);
            db.SaveChanges();

                }
        public void actualizaProduccion(int id,int idCarne, double cantidad, int anio)
        {

            CarnesContexto db = new CarnesContexto();
            var miProduccion = new producciones();
            miProduccion = db.producciones.Where(p => p.id == id).First<producciones>();
            miProduccion.cantidad = cantidad;
            miProduccion.anio = anio;
            miProduccion.idCarne = idCarne;
            db.SaveChanges();
            
        }
        public void eliminaProduccion(int id)
        {

            CarnesContexto db = new CarnesContexto();
            var miProduccion = new producciones();
            miProduccion = db.producciones.Where(p => p.id == id).First<producciones>();
            db.producciones.Remove(miProduccion);
            db.SaveChanges();

        }
    }

    }

    

