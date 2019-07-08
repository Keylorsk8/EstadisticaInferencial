namespace slnEstadisticaInferencial.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class producciones
    {
        public int id { get; set; }

        public int idCarne { get; set; }

        public double cantidad { get; set; }

        public int anio { get; set; }

        public virtual carnes carnes { get; set; }
    }
}
