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
    using System.Collections.Generic;
    
    public partial class empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empleados()
        {
            this.clientes = new HashSet<clientes>();
            this.empleados1 = new HashSet<empleados>();
        }
    
        public int CodigoEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
        public string CodigoOficina { get; set; }
        public Nullable<int> CodigoJefe { get; set; }
        public string Puesto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<clientes> clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<empleados> empleados1 { get; set; }
        public virtual empleados empleados2 { get; set; }
        public virtual oficinas oficinas { get; set; }
    }
}