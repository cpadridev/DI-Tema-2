using di.repaso.navidad._2021.Backend.Modelo;
using di.repaso.navidad._2021.Frontend.Dialogos;
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

namespace di.repaso.navidad._2021.Frontend.ControlUsuario
{
    /// <summary>
    /// Lógica de interacción para UCEmpleados.xaml
    /// </summary>
    public partial class UCEmpleados : UserControl
    {
        private jardineriaEntities jarEnt;

        public UCEmpleados(jardineriaEntities ent)
        {
            InitializeComponent();
        }

        private void btnAddEmpleado_Click(object sender, RoutedEventArgs e)
        {
            DialogoEmpleados diag = new DialogoEmpleados();
            diag.ShowDialog();
        }
    }
}
