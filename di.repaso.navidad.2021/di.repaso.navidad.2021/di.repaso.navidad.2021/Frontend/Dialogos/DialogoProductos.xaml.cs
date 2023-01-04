using di.repaso.navidad._2021.Backend.Modelo;
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
using System.Windows.Shapes;

namespace di.repaso.navidad._2021.Frontend.Dialogos
{
    /// <summary>
    /// Lógica de interacción para DialogoProductos.xaml
    /// </summary>
    public partial class DialogoProductos : MetroWindow
    {
        private jardineriaEntities jarEnt;

        public DialogoProductos(jardineriaEntities ent)
        {
            jarEnt = ent;
            InitializeComponent();
            inicializa();
        }

        private void inicializa()
        {

        }
    }
}
