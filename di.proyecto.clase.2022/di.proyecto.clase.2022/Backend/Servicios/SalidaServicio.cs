using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections.ObjectModel;
using di.proyecto.clase._2022.Backend.Servicios.Base;
using di.proyecto.clase._2022.Backend.Modelos;

namespace di.proyecto.clase._2022.Servicios
{
    public class SalidaServicio : ServicioGenerico<salida>
    {
        private inventarioEntities contexto;

        public SalidaServicio(inventarioEntities context) : base(context)
        {
            contexto = context;
        }

        public List<salida> getSalidasUsuario(int usu)
        {
            return contexto.Set<salida>().Where(s => s.usuario == usu).ToList();
        }

        public void GetPrestamosPorCurso()
        {
            /*List<Tupla> lista = contexto.Database.SqlQuery<Tupla>("select year(fechasalida) as temporada, count(fechasalida) as prestamos " +
                "from salida group by year(fechasalida); ").ToList();*/
           

            //return query2.ToList();
        }
    }
}
