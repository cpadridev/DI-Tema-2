using MahApps.Metro.Controls;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace di.tema2.ejercicio4
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

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txbEmail.Text) || String.IsNullOrEmpty(pxbPassword.Password))
            {
                errorEmail.Visibility = Visibility.Visible;
                errorPassword.Visibility = Visibility.Visible;
                errorText.Visibility = Visibility.Visible;
            }
            else
            {
                errorEmail.Visibility = Visibility.Hidden;
                errorPassword.Visibility = Visibility.Hidden;
                errorText.Visibility = Visibility.Hidden;

                if (txbEmail.Text.Equals("dam@hola.es") && pxbPassword.Password.Equals("segundo"))
                {
                    MessageBox.Show("Fenomenal, todo correcto!!!", "LOGIN", MessageBoxButton.OK, MessageBoxImage.Information);
                    Application.Current.Shutdown();
                } else
                {
                    MessageBox.Show("Alguno de los valores no son correctos", "LOGIN", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
