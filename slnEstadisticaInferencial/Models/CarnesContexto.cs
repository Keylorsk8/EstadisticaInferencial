namespace slnEstadisticaInferencial.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CarnesContexto : DbContext
    {
        public CarnesContexto()
            : base("data source=carnesDB.mssql.somee.com;initial catalog=carnesDB;persist security info=True;user id=keylorsk8_SQLLogin_1;password=k88r6uger9;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }


        public virtual DbSet<carnes> carnes { get; set; }
        public virtual DbSet<consumoPerCapita> consumoPerCapita { get; set; }
        public virtual DbSet<exportaciones> exportaciones { get; set; }
        public virtual DbSet<producciones> producciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<carnes>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<carnes>()
                .HasMany(e => e.consumoPerCapita)
                .WithRequired(e => e.carnes)
                .HasForeignKey(e => e.idCarne)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<carnes>()
                .HasMany(e => e.exportaciones)
                .WithRequired(e => e.carnes)
                .HasForeignKey(e => e.idCarne)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<carnes>()
                 .HasMany(e => e.producciones)
                 .WithRequired(e => e.carnes)
                 .HasForeignKey(e => e.idCarne)
                 .WillCascadeOnDelete(false);           
        }
    }
}
