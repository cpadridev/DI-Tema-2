using di.proyecto.clase._2022.Backend.Modelos;
using di.proyecto.clase._2022.MVVM;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace di.proyecto.clase._2022.Frontend.Dialogos
{
    /// <summary>
    /// Lógica de interacción para DialogoUsuarioMVVM.xaml
    /// </summary>
    public partial class DialogoUsuarioMVVM : MetroWindow
    {
        /// <summary>
        /// Objeto del contexto de la base de datos para Entity Framework
        /// </summary>
        private inventarioEntities invEnt;
        private MVUsuario mvUsuario;

        public DialogoUsuarioMVVM(inventarioEntities ent)
        {
            invEnt = ent;
            InitializeComponent();
            mvUsuario = new MVUsuario(invEnt);
            DataContext = mvUsuario;
        }

        private async void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(pwdPassword.Password))
            {
                mvUsuario.usuarioNuevo.password = pwdPassword.Password;

                if (mvUsuario.guarda)
                {
                    await this.ShowMessageAsync("GESTIÓN USUARIO", "TODO CORRECTO. El artículo se guardo correctamente en la BD");
                    DialogResult = true;
                }
                else
                {
                    await this.ShowMessageAsync("GESTIÓN USUARIO", "ERROR!!!. PROBLEMAS PARA GUARDAR EN LA BASE DE DATOS");
                }
            }
        }
        
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            // Cierra el diálogo
            DialogResult = false;
        }
    }
}
