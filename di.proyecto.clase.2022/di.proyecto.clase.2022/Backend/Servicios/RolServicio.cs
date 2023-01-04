using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using di.proyecto.clase._2022.Backend.Servicios.Base;
using di.proyecto.clase._2022.Backend.Modelos;

namespace di.proyecto.clase._2022.Servicios
{
    public class RolServicio : ServicioGenerico<rol>
    {
        public RolServicio(DbContext context) : base(context)
        {
        }
    }
}
