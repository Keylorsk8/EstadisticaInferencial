namespace Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("consumoPerCapita")]
    public partial class consumoPerCapita
    {
        public int id { get; set; }

        public int idCarne { get; set; }

        public double cantidad { get; set; }

        public int anio { get; set; }

        public virtual carnes carnes { get; set; }
    }
}
