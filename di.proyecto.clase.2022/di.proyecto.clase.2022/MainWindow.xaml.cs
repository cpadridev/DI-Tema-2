using di.proyecto.clase._2022.Backend.Modelos;
using di.proyecto.clase._2022.Frontend.Dialogos;
using MahApps.Metro.Controls;
using System.Windows;

namespace di.proyecto.clase._2022
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        /// <summary>
        /// Objeto del contexto de la base de datos para Entity Framework
        /// </summary>
        private inventarioEntities invEnt;
        /// <summary>
        /// Usuario que ha iniciado sesión
        /// </summary>
        private usuario usuLogin;
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(inventarioEntities ent, usuario usu)
        {
            invEnt = ent;
            usuLogin = usu;
            InitializeComponent();
        }

        private void menuItemModeloArticuloNuevo_Click(object sender, RoutedEventArgs e)
        {
            DialogoModeloArticulo diag = new DialogoModeloArticulo(invEnt);
            diag.ShowDialog();
        }

        private void menuItemModeloArticuloNuevoMVVM_Click(object sender, RoutedEventArgs e)
        {
            DialogoModeloArticuloMVVM diag = new DialogoModeloArticuloMVVM(invEnt);
            diag.ShowDialog();
        }

        private void menuItemArticuloNuevo_Click(object sender, RoutedEventArgs e)
        {
            DialogoArticulo diag = new DialogoArticulo(invEnt, usuLogin);
            diag.ShowDialog();
        }

        private void menuItemArticuloNuevoMVVM_Click(object sender, RoutedEventArgs e)
        {
            DialogoArticuloMVVM diag = new DialogoArticuloMVVM(invEnt, usuLogin);
            diag.ShowDialog();
        }

        private void menuItemUsuarioNuevo_Click(object sender, RoutedEventArgs e)
        {
            DialogoUsuario diag = new DialogoUsuario(invEnt);
            diag.ShowDialog();
        }

        private void menuItemUsuarioNuevoMVVM_Click(object sender, RoutedEventArgs e)
        {
            DialogoUsuarioMVVM diag = new DialogoUsuarioMVVM(invEnt);
            diag.ShowDialog();
        }
    }
}
