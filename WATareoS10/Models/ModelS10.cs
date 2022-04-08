namespace WATareoS10.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelS10 : DbContext
    {
        public ModelS10()
            : base("name=ModelS10")
        {
        }

        public virtual DbSet<Listar_Personal_S10> Listar_Personal_S10 { get; set; }
        public virtual DbSet<MARCACION_PERSONAL> MARCACION_PERSONAL { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Listar_Personal_S10>()
                .Property(e => e.CodObrero)
                .IsUnicode(false);

            modelBuilder.Entity<Listar_Personal_S10>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Listar_Personal_S10>()
                .Property(e => e.DNI)
                .IsUnicode(false);

            modelBuilder.Entity<Listar_Personal_S10>()
                .Property(e => e.CodProyecto)
                .IsUnicode(false);

            modelBuilder.Entity<Listar_Personal_S10>()
                .Property(e => e.CodIdentificador)
                .IsUnicode(false);

            modelBuilder.Entity<Listar_Personal_S10>()
                .Property(e => e.CodInsumo)
                .IsUnicode(false);

            modelBuilder.Entity<Listar_Personal_S10>()
                .Property(e => e.CodOcupacion)
                .IsUnicode(false);

            modelBuilder.Entity<MARCACION_PERSONAL>()
                .Property(e => e.ID_TAREADOR)
                .IsUnicode(false);

            modelBuilder.Entity<MARCACION_PERSONAL>()
                .Property(e => e.PROYECTO)
                .IsUnicode(false);

            modelBuilder.Entity<MARCACION_PERSONAL>()
                .Property(e => e.CODOBRERO)
                .IsUnicode(false);

            modelBuilder.Entity<MARCACION_PERSONAL>()
                .Property(e => e.PERSONAL)
                .IsUnicode(false);

            modelBuilder.Entity<MARCACION_PERSONAL>()
                .Property(e => e.DNI)
                .IsUnicode(false);

            modelBuilder.Entity<MARCACION_PERSONAL>()
                .Property(e => e.HORA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MARCACION_PERSONAL>()
                .Property(e => e.TOKEN)
                .IsUnicode(false);

            modelBuilder.Entity<MARCACION_PERSONAL>()
                .Property(e => e.ID_SUCURSAL)
                .IsUnicode(false);
        }
    }
}
