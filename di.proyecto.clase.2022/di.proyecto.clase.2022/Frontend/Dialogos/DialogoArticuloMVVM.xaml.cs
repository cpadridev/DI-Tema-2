using di.proyecto.clase._2022.Backend.Modelos;
using di.proyecto.clase._2022.MVVM;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Windows;

namespace di.proyecto.clase._2022.Frontend.Dialogos
{
    /// <summary>
    /// Lógica de interacción para DialogoArticuloMVVM.xaml
    /// </summary>
    public partial class DialogoArticuloMVVM : MetroWindow
    {
        /// <summary>
        /// Objeto del contexto de la base de datos para Entity Framework
        /// </summary>
        private inventarioEntities invEnt;
        private usuario usuLogin;
        private MVArticulo mvArticulo;

        public DialogoArticuloMVVM(inventarioEntities ent, usuario usu)
        {
            invEnt = ent;
            usuLogin = usu;
            InitializeComponent(); 
            mvArticulo = new MVArticulo(invEnt, usuLogin);
            DataContext = mvArticulo;
        }

        private async void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (mvArticulo.guarda)
            {
                await this.ShowMessageAsync("GESTIÓN ARTÍCULO", "TODO CORRECTO. El artículo se guardo correctamente en la BD");
                DialogResult = true;
            }
            else
            {
                await this.ShowMessageAsync("GESTIÓN ARTÍCULO", "ERROR!!!. PROBLEMAS PARA GUARDAR EN LA BASE DE DATOS");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            // Cierra el diálogo
            DialogResult = false;
        }
    }
}
