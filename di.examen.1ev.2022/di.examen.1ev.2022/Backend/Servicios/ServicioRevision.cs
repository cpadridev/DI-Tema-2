using di.examen.nov._2021.bis.Backend.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di.examen.nov._2021.bis.Backend.Servicios
{
    public class ServicioRevision : ServicioGenerico<revisiones>
    {
        private DbContext contexto;

        public ServicioRevision (DbContext context) : base(context)
        {
            contexto = context;
        }

        public DateTime primeraFecha()
        {
            revisiones rev = contexto.Set<revisiones>().OrderBy(x => x.Fecha_Revision).First();
            return (DateTime)rev.Fecha_Revision;
        }

        public DateTime ultimaFecha()
        {
            revisiones rev = contexto.Set<revisiones>().OrderByDescending(x => x.Fecha_Revision).First();
            return (DateTime)rev.Fecha_Revision;
        }
    }
}
