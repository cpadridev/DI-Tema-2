//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace di.proyecto.clase._2022.Backend.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class offer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public offer()
        {
            this.product = new HashSet<product>();
            this.customer = new HashSet<customer>();
        }
    
        public int idOffer { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public System.DateTime period { get; set; }
        public byte[] file { get; set; }
        public Nullable<double> discount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product> product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<customer> customer { get; set; }
    }
}