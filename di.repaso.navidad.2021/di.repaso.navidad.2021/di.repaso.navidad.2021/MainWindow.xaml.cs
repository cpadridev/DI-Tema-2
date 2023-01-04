using di.repaso.navidad._2021.Backend.Modelo;
using di.repaso.navidad._2021.Frontend.ControlUsuario;
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

namespace di.repaso.navidad._2021
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private jardineriaEntities jarEnt;
        public MainWindow()
        {
            if (conectar())
            {
                InitializeComponent();
            }
            else
            {
                MessageBox.Show("No se puede conectar con la base de datos", "ERROR EN LA BASE DE DATOS", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void hamMenuPrincipal_ItemClick(object sender, ItemClickEventArgs args)
        {
            HamburgerMenuIconItem hm = args.ClickedItem as HamburgerMenuIconItem;
            if (hm != null)
            {
                UserControl uc = new UserControl();
                switch (hm.Tag)
                {
                    case "GESTION PEDIDOS":
                        uc = new UCPedidos(jarEnt);
                        break;
                    case "GESTION PRODUCTOS":
                        uc = new UCProductos(jarEnt);
                        break;
                    case "GESTION OFICINAS":
                        uc = new UCOficinas(jarEnt);
                        break;
                    case "GESTION CLIENTES":
                        uc = new UCClientes(jarEnt);
                        break;
                    case "GESTION EMPLEADOS":
                        uc = new UCEmpleados(jarEnt);
                        break;
                }
                hm.Tag = uc;
                hamMenuPrincipal.Content = hm;
            }
            hamMenuPrincipal.IsPaneOpen = false;
        }

        private bool conectar()
        {
            bool correcto = true;
            jarEnt = new jardineriaEntities();
            try
            {
                jarEnt.Database.Connection.Open();
            }
            catch (Exception ex)
            {
                correcto = false;
            }
            return correcto;
        }
    }
}
