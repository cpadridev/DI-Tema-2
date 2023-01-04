using di.repaso.navidad._2021.Backend.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di.repaso.navidad._2021.Backend.Servicios
{
    public class PedidosServicio : ServicioGenerico<pedidos>
    {
        private DbContext contexto;
        private List<string> estados = new List<string> {"Entregado", "Rechazado", "Pendiente" };

        public PedidosServicio(DbContext context) : base(context)
        {
            contexto = context;
        }

        public List<string> listaEstados
        {
            get
            {
                return estados;
            }
        }

        public int getLastId()
        {
            pedidos pedido = contexto.Set<pedidos>().OrderByDescending(p => p.CodigoPedido).FirstOrDefault();
            return pedido.CodigoPedido;
        }
    }
}
