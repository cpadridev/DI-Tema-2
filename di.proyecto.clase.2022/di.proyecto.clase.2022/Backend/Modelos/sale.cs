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
    
    public partial class sale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sale()
        {
            this.sale_has_product = new HashSet<sale_has_product>();
        }
    
        public int idSale { get; set; }
        public double iva { get; set; }
        public System.DateTime date { get; set; }
        public string payment { get; set; }
        public double total { get; set; }
        public string message { get; set; }
        public int idCustomer { get; set; }
        public int idUser { get; set; }
    
        public virtual customer customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sale_has_product> sale_has_product { get; set; }
        public virtual user user { get; set; }
    }
}
