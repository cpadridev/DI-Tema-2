using di.proyecto.clase._2022.Backend.Modelos;
using di.proyecto.clase._2022.MVVM.Base;
using di.proyecto.clase._2022.Servicios;
using System.Collections.Generic;
using System.Linq;

namespace di.proyecto.clase._2022.MVVM
{
    internal class MVModeloArticulo : MVBaseCRUD<modeloarticulo>
    {
        /// <summary>
        /// Contexto para acceder a la BD
        /// </summary>
        private inventarioEntities invEnt;
        /// <summary>
        /// Guardamos los datos de la interfaz
        /// </summary>
        private modeloarticulo modArt;
        private TipoArticuloServicio tipoServ;

        public MVModeloArticulo(inventarioEntities ent)
        {
            invEnt = ent;
            tipoServ = new TipoArticuloServicio(invEnt);
            servicio = new ModeloArticuloServicio(invEnt);
            modArt = new modeloarticulo();
        }

        public modeloarticulo modeloArticulo
        {
            get { return modArt; }
            set { modArt = value; NotifyPropertyChanged(nameof(modeloArticulo)); }
        }

        public List<tipoarticulo> listaTipos { get { return tipoServ.getAll().ToList(); } }

        public bool guarda { get { return add(modeloArticulo); } }
    }
}
