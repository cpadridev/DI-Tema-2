using di.proyecto.clase._2022.Backend.Modelos;
using di.proyecto.clase._2022.Servicios;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;

namespace di.proyecto.clase._2022.Frontend.Dialogos
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : MetroWindow
    {
        /// <summary>
        /// Objeto que nos permite interactuar con la base de datos
        /// </summary>
        private inventarioEntities invEnt;
        /// <summary>
        /// Objeto que nos permite realizar operaciones con la tabla Usuario
        /// </summary>
        private UsuarioServicio servUsu;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Login()
        {
            InitializeComponent();
            inicializa();
        }

        /// <summary>
        /// Método que inicializa los objetos
        /// </summary>
        private void inicializa()
        {
            invEnt = new inventarioEntities();
            servUsu = new UsuarioServicio(invEnt);
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string usu = txtUsername.Text;
            string pass = passClave.Password;
            if(string.IsNullOrEmpty(usu))
            {
                txtUsername.Focus();
                await this.ShowMessageAsync("LOGIN", "El usuario está vacío");
            }
            else if(string.IsNullOrEmpty(pass))
            {
                passClave.Focus();
                await this.ShowMessageAsync("LOGIN", "La contraseña está vacía");
            }
            else if (servUsu.login(txtUsername.Text, passClave.Password))
            {
                MainWindow ventanaPrincipal = new MainWindow(invEnt, servUsu.usuLogin);
                ventanaPrincipal.Show();
                this.Close();
            }
            else
            {
                await this.ShowMessageAsync("LOGIN", "El usuario y/o la contraseña no coinciden");
                //MessageBox.Show("El usuario y/o la contraseña no coinciden", "LOGIN", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
