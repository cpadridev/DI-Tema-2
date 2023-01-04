using di.examen.nov._2021.bis.Backend.Modelo;
using di.examen.nov._2021.bis.Frontend.Dialogos;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace di.examen.nov._2021.bis
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        // Declaración de variables -----------------------------------------------------------------------------------------
        /// <summary>
        /// Lista con los nombres de los campos del grid central
        /// </summary>
        private List<string> listaCampos = new List<string> { "Clase Avión", "Nombre Fabricante", "Peso del Avión", "Alcance", "Número de Asientos", "Longitud" };
        /// <summary>
        /// Varable para guardar el contexto de la base de datos
        /// </summary>
        private aerolineasEntities aerEnt;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            conectar();
            if(!conectar())
            {
                this.ShowMessageAsync("CONEXIÓN", "Hay un error en la conexión de la base de datos. Llama al profesor");
            }
        }

        private bool conectar()
        {
            bool conectado = true;
            aerEnt = new aerolineasEntities();
            try
            {
                aerEnt.Database.Connection.Open();
            } catch(Exception ex)
            {
                conectado = false;
                System.Console.WriteLine(ex.StackTrace);
            }
            return conectado;
        }

        private void listViewItemNuevoVuelo_Selected(object sender, RoutedEventArgs e)
        {
            DialogoVuelo diag = new DialogoVuelo(aerEnt);
            diag.ShowDialog();
        }

        private void listViewItemTipoAvion_Selected(object sender, RoutedEventArgs e)
        {
            gridCentral.HorizontalAlignment = HorizontalAlignment.Center;

            columnas(2, gridCentral);
            filas(4, gridCentral);

            TextBlock txtTitulo = new TextBlock
            {
                Text = "NUEVO TIPO AVIÓN",
                FontSize = 32,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(50, 25, 50, 25)
            };

            Grid.SetColumn(txtTitulo, 0);
            Grid.SetColumnSpan(txtTitulo, 2);
            Grid.SetRow(txtTitulo, 0);

            gridCentral.Children.Add(txtTitulo);

            for (int i = 0; i < listaCampos.Count; i++)
            {
                TextBlock txt = new TextBlock
                {
                    Text = listaCampos[i],
                    FontWeight = FontWeights.Bold
                };

                TextBox txb = new TextBox
                {
                    Width = 300
                };

                StackPanel panel = new StackPanel
                {
                    Margin = new Thickness(20, 10, 20, 10)
                };
                panel.Children.Add(txt);
                panel.Children.Add(txb);

                Grid.SetColumn(panel, i % 2);
                Grid.SetRow(panel, i / 2 + 1);

                gridCentral.Children.Add(panel);
            }
        }

        /// <summary>
        /// Metodo que instancia el numero de columnas
        /// </summary>
        /// <param name="numCols">Numero de columnas a generar</param>
        /// <param name="panel">Panel donde las añadimos</param>
        private void columnas(int numCols, Grid panel)
        {
            for (int i = 0; i < numCols; i++)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                colDef.Width = GridLength.Auto;
                panel.ColumnDefinitions.Add(colDef);
            }
        }

        private void filas(int numRows, Grid panel)
        {
            for (int i = 0; i < numRows; i++)
            {
                RowDefinition rowDef = new RowDefinition();
                rowDef.Height = GridLength.Auto;
                panel.RowDefinitions.Add(rowDef);
            }
        }
    }
}
