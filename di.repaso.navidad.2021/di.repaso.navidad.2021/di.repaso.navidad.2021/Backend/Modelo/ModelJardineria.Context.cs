//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace di.repaso.navidad._2021.Backend.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class jardineriaEntities : DbContext
    {
        public jardineriaEntities()
            : base("name=jardineriaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<detallepedidos> detallepedidos { get; set; }
        public virtual DbSet<empleados> empleados { get; set; }
        public virtual DbSet<gamasproductos> gamasproductos { get; set; }
        public virtual DbSet<oficinas> oficinas { get; set; }
        public virtual DbSet<pagos> pagos { get; set; }
        public virtual DbSet<pedidos> pedidos { get; set; }
        public virtual DbSet<productos> productos { get; set; }
    }
}
