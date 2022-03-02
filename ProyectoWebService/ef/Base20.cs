using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProyectoWebService.ef
{
    public partial class Base20 : DbContext
    {
        public Base20()
            : base("name=Base20")
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
