using System.Data.Entity;
using di.proyecto.clase._2022.Backend.Servicios.Base;
using di.proyecto.clase._2022.Backend.Modelos;

namespace di.proyecto.clase._2022.Servicios
{
    public class DptoServicio : ServicioGenerico<departamento>
    {

        public DptoServicio(DbContext context) : base(context)
        {
        }
    }
}
