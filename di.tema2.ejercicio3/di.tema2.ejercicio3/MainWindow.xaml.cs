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

namespace di.tema2.ejercicio3
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

        public void chkRememberMe_UnChecked(object sender, RoutedEventArgs e)
        {
            var fade = new DoubleAnimation()
            {
                From = 0,
                To = 1,
                Duration = TimeSpan.FromSeconds(5),
            };
            Storyboard.SetTarget(fade, btnSign);
            Storyboard.SetTargetProperty(fade, new PropertyPath(Button.OpacityProperty));
            Storyboard sb = new Storyboard();
            sb.Children.Add(fade);
            sb.Begin();
        }

        private void btnForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation(0.0, 300.0, TimeSpan.FromMilliseconds(500));
            btnFacebook.BeginAnimation(FrameworkElement.WidthProperty, da);
        }
        private void MetroWindow_Activated(object sender, EventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation(0.0, 30.0, TimeSpan.FromMilliseconds(1000));
            btnGoogle.BeginAnimation(FrameworkElement.HeightProperty, da);

        }

        private void btnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;
            da.To = 360;
            da.Duration = new Duration(TimeSpan.FromSeconds(3));
            da.RepeatBehavior = RepeatBehavior.Forever;
            RotateTransform rt = new RotateTransform();
            rt.CenterX = 10;
            rt.CenterY = 10;
            txtOr.RenderTransform = rt;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);
        }
    }
}
