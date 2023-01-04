using di.proyecto.clase._2022.Backend.Modelos;
using di.proyecto.clase._2022.Backend.Servicios.Base;
using di.proyecto.clase._2022.MVVM.Base;
using di.proyecto.clase._2022.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di.proyecto.clase._2022.MVVM
{
    internal class MVUsuario : MVBaseCRUD<usuario>
    {
        /// <summary>
        /// Contexto para acceder a la BD
        /// </summary>
        private inventarioEntities invEnt;
        /// <summary>
        /// Guardamos los datos de la interfaz
        /// </summary>
        private usuario usu;
        private DptoServicio dptoServ;
        private RolServicio rolServ;
        private GrupoServicio grpServ;
        private ServicioGenerico<tipousuario> tipoServ;
        private UsuarioServicio usuarioServ;

        public MVUsuario(inventarioEntities ent)
        {
            invEnt = ent;
            inicializa();
        }

        private void inicializa()
        {
            dptoServ = new DptoServicio(invEnt);
            usuarioServ = new UsuarioServicio(invEnt);
            rolServ = new RolServicio(invEnt);
            grpServ = new GrupoServicio(invEnt);
            tipoServ = new ServicioGenerico<tipousuario>(invEnt);
            servicio = new UsuarioServicio(invEnt);
            usu = new usuario();
        }

        public usuario usuarioNuevo
        {
            get { return usu; }
            set { usu = value; NotifyPropertyChanged(nameof(usuarioNuevo)); }
        }

        public List<departamento> listaDepartamentos { get { return dptoServ.getAll().ToList(); } }
        public List<grupo> listaGrupos { get { return grpServ.getAll().ToList(); } }
        public List<rol> listaRoles { get { return rolServ.getAll().ToList(); } }
        public List<tipousuario> listaTipoUsuarios { get { return tipoServ.getAll().ToList(); } }
        public List<usuario> listaUsuarios { get { return usuarioServ.getAll().ToList(); } }

        public bool guarda
        {
            get
            {
                if (usuarioServ.usuarioUnico(usuarioNuevo.username))
                {
                    return add(usuarioNuevo);
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
