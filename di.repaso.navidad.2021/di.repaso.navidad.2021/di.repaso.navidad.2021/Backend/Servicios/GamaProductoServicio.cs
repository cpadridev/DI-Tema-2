using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using di.repaso.navidad._2021.Backend.Modelo;

namespace di.repaso.navidad._2021.Backend.Servicios
{ 
    public class GamaProductoServicio : ServicioGenerico<gamasproductos>
    {
        public GamaProductoServicio(DbContext context) : base(context)
        {
        }
    }
}
