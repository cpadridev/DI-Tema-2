using di.examen.nov._2021.bis.Backend.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di.examen.nov._2021.bis.Backend.Servicios
{
    public class ServicioAvion : ServicioGenerico<avion>
    {
        private DbContext contexto;

        public ServicioAvion (DbContext context) : base(context)
        {
            contexto = context;
        }
    }
}
