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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace di.tema2.ejercicio5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private System.Windows.Media.Brush btnBackgroundColor = null;
        private System.Windows.Media.Brush btnBorderBrush = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            txbEmail.Text = txbName.Text;
        }

        private void btnRegisterNow_MouseEnter(object sender, MouseEventArgs e)
        {
            btnBackgroundColor = btnRegisterNow.Background;
            btnBorderBrush = btnRegisterNow.BorderBrush;
            btnRegisterNow.Background = (Brush)new BrushConverter().ConvertFrom("#555");
            btnRegisterNow.BorderBrush = (Brush)new BrushConverter().ConvertFrom("#555");
        }

        private void btnRegisterNow_MouseLeave(object sender, MouseEventArgs e)
        {
            btnRegisterNow.Background = btnBackgroundColor;
            btnRegisterNow.BorderBrush = btnBorderBrush;
        }
    }
}
