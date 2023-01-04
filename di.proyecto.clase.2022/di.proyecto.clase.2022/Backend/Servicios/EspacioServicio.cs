using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using di.proyecto.clase._2022.Backend.Servicios.Base;
using di.proyecto.clase._2022.Backend.Modelos;

namespace di.proyecto.clase._2022.Servicios
{
    public class EspacioServicio : ServicioGenerico<espacio>
    {
        public EspacioServicio(DbContext context) : base(context)
        {
        }
    }
}
