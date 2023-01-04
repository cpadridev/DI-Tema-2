using di.proyecto.clase._2022.Backend.Modelos;
using di.proyecto.clase._2022.MVVM.Base;
using di.proyecto.clase._2022.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace di.proyecto.clase._2022.MVVM
{
    internal class MVArticulo : MVBaseCRUD<articulo>
    {
        /// <summary>
        /// Contexto para acceder a la BD
        /// </summary>
        private inventarioEntities invEnt;
        private usuario usuLogin;
        /// <summary>
        /// Guardamos los datos de la interfaz
        /// </summary>
        private articulo art;
        private ArticuloServicio artServ;
        private DptoServicio dptoServ;
        private EspacioServicio espacioServ;
        private ModeloArticuloServicio modArtServ;
        private UsuarioServicio usuarioServ;

        private List<String> estados = new List<String>() { "operativo", "mantenimiento", "obsoleto", "retirado" };

        public MVArticulo(inventarioEntities ent, usuario usu)
        {
            invEnt = ent;
            usuLogin = usu;
            inicializa();
        }

        private void inicializa()
        {
            artServ = new ArticuloServicio(invEnt);
            dptoServ = new DptoServicio(invEnt);
            espacioServ = new EspacioServicio(invEnt);
            usuarioServ = new UsuarioServicio(invEnt);
            modArtServ = new ModeloArticuloServicio(invEnt);
            servicio = new ArticuloServicio(invEnt);
            art = new articulo();
            art.fechaalta = DateTime.Now;
            art.usuario = usuLogin;
        }

        public articulo articuloNuevo
        {
            get { return art; }
            set { art = value; NotifyPropertyChanged(nameof(articuloNuevo)); }
        }

        public List<departamento> listaDepartamentos { get { return dptoServ.getAll().ToList(); } }
        public List<espacio> listaEspacios { get { return espacioServ.getAll().ToList(); } }
        public List<modeloarticulo> listaModelos { get { return modArtServ.getAll().ToList(); } }
        public List<usuario> listaUsuarios { get { return usuarioServ.getAll().ToList(); } }
        public List<String> listaEstados { get { return estados; } }

        public bool guarda { get { art.idarticulo = artServ.getLastId() + 1; return add(articuloNuevo); } }
    }
}
