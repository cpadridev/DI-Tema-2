using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using di.repaso.navidad._2021.Backend.Modelo;

namespace di.repaso.navidad._2021.Backend.Servicios
{
    public class ClienteServicio : ServicioGenerico<clientes>
    {
        private jardineriaEntities contexto;
        public ClienteServicio(jardineriaEntities context) : base(context)
        {
            contexto = context;
        }

        /*
         * Obtiene el último id de la tabla articulo
         * La clave primaria no es autoincrementable y debemos gestionarla nosotros
         */
        public int getLastId()
        {
            clientes cliente = contexto.Set<clientes>().OrderByDescending(c => c.CodigoCliente).FirstOrDefault();
            return cliente.CodigoCliente;
        }

        public List<string> getCiudades()
        {
            var ciu = from cli in contexto.clientes
                      group cli by cli.Ciudad into c
                      select c.Key;
            return ciu.ToList();
        }
    }
}
