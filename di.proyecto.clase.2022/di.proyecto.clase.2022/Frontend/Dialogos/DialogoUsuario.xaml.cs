using di.proyecto.clase._2022.Backend.Modelos;
using di.proyecto.clase._2022.Backend.Servicios.Base;
using di.proyecto.clase._2022.Servicios;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace di.proyecto.clase._2022.Frontend.Dialogos
{
    /// <summary>
    /// Interaction logic for DialogoUsuario.xaml
    /// </summary>
    
    public partial class DialogoUsuario : MetroWindow
    {
        /// <summary>
        /// Contexto para la conexion a la base de datos
        /// </summary>
        private inventarioEntities invEnt;
        private UsuarioServicio usrServicio;
        private RolServicio rolServicio;
        private GrupoServicio grpServicio;
        private DptoServicio dptoServicio;
        private ServicioGenerico<tipousuario> tipoServ;
        
        public DialogoUsuario()
        {
            InitializeComponent();
        }
        public DialogoUsuario(inventarioEntities ent)
        {
            invEnt = ent;
            InitializeComponent();
            inicializa();
        }

        public void inicializa()
        {
            usrServicio = new UsuarioServicio(invEnt);
            rolServicio = new RolServicio(invEnt);
            grpServicio = new GrupoServicio(invEnt);
            dptoServicio = new DptoServicio(invEnt);
            tipoServ = new ServicioGenerico<tipousuario>(invEnt);
            cbxDepartamento.ItemsSource = dptoServicio.getAll().ToList();
            cbxGrupo.ItemsSource = grpServicio.getAll().ToList();
            cbxRol.ItemsSource = rolServicio.getAll().ToList();
            cbxTipoUsuario.ItemsSource = tipoServ.getAll().ToList();

            
        }

        private async void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido1.Text) || String.IsNullOrEmpty(txtUsername.Text) || 
                String.IsNullOrEmpty(pwdPassword.Password) || cbxTipoUsuario.SelectedIndex == -1 || cbxRol.SelectedIndex == -1)
            {
                await this.ShowMessageAsync("ERROR!!!","NO PUEDEN QUEDAR CAMPOS OBLIGATORIOS VACIOS!!!");

            } else if (!usrServicio.usuarioUnico(txtUsername.Text))
            {
                await this.ShowMessageAsync("ERROR!!!", "EL USUARIO YA EXISTE!!!");
            } else
            {
                usrServicio.add(recogeDatos());
                try
                {
                    usrServicio.save();
                    await this.ShowMessageAsync("GESTIÓN ARTICULO", "TODO CORRECTO. El objeto se ha guardado en la base de datos.");
                }
                catch (DbUpdateException dbex)
                {
                    System.Console.WriteLine(dbex.StackTrace);
                    await this.ShowMessageAsync("GESTIÓN ARTICULO", "ERROR!!! NO SE PUEDE GUARDAR EL OBJETO EN LA BASE DE DATOS");
                }
            }
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void cbxTipoUsuario_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbxTipoUsuario.SelectedItem == tipoServ.getAll().ToList()[2])
            {
                cbxDepartamento.IsEnabled = true;
                cbxGrupo.IsEnabled = false;
                cbxGrupo.SelectedIndex = -1;
            }
            else
            {
                cbxDepartamento.IsEnabled = false;
                cbxDepartamento.SelectedIndex = -1;
                cbxGrupo.IsEnabled = true;                
            }
        }

        private usuario recogeDatos()
        {
            usuario usr = new usuario();
            if (cbxDepartamento.SelectedIndex != -1)
            {
                usr.departamento = ((departamento)cbxDepartamento.SelectedItem).iddepartamento;
            }
            if(cbxGrupo.SelectedIndex != -1)
            {
                usr.grupo = ((grupo)cbxGrupo.SelectedItem).idgrupo;
            }
            usr.username = txtUsername.Text;
            usr.password = pwdPassword.Password;
            usr.tipo = ((tipousuario)cbxTipoUsuario.SelectedItem).idtipousuario;
            usr.rol = ((rol)cbxRol.SelectedItem).idrol;
            usr.nombre = txtNombre.Text;
            usr.apellido1 = txtApellido1.Text;
            usr.apellido2 = txtApellido2.Text;
            usr.domicilio = txtDomicilio.Text;
            usr.telefono = txtTelefono.Text;
            usr.poblacion = txtPoblacion.Text;
            usr.codpostal = txtCodPostal.Text;
            usr.email = txtEmail.Text;
            usr.telefono = txtTelefono.Text;
            return usr;
        }
    }
}
