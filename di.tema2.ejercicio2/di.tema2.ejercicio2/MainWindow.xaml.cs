using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace di.tema2.ejercicio2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void chkRememberMe_Checked(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("¿Está seguro?", "RECORDATORIO", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (res == MessageBoxResult.Yes)
            {
                MessageBox.Show("Os recordaremos", "RECORDATORIO", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else 
            { 
                Application.Current.Shutdown();
            }
        }

        private void btnSignGoogle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Chrome.exe", "https://ieshenrimatisse.es");
            } catch 
            {
                
            }
        }

        private void btnGetStart_Click(object sender, RoutedEventArgs e)
        {
            gridPrincipal.Background = Brushes.DarkGray;
        }
    }
}

