using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProyectoWebServiceREST.Models
{
    public partial class ConexionEF : DbContext
    {
        public ConexionEF()
            : base("name=ConexionEF")
        {
        }

        public virtual DbSet<Productos> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);
        }
    }
}
