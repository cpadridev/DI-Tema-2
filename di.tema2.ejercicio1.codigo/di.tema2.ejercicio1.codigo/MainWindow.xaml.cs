using System.Windows.Controls;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Collections.Generic;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;
using Image = System.Windows.Controls.Image;
using System.Data.SqlClient;

namespace di.tema2.ejercicio1.codigo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //********************************* DEFINICIÓN OBJETOS PRIVADOS *********************************
        private const string DATA = "Data";

        private Grid panelSuperior;
        private StackPanel panelIzquierda;
        private Grid panelDerecha;
        private Grid panelCentral;

        private List<string> listaEtiquetasIzquierda = new List<string> { DATA, "Sales", "Marketing", "Distribution", "Costs" };
        private List<string> listaImagenesBotones = new List<string> { "BarChart", "LineChart", "ComboChart", "PieChart", "Location", "Relative" };

        /// <summary>
        /// Método principal de la aplicacion
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            inicializa();
            partePrincipal();
        }

        /// <summary>
        ///  
        /// </summary>
        private void inicializa()
        {
            // Instanciamos los objetos principales
            panelSuperior = new Grid();
            panelIzquierda = new StackPanel();
            panelDerecha = new Grid();
            panelCentral = new Grid();

            //Añadimos los paneles al panel principal
            DockPanel.SetDock(panelSuperior, Dock.Top);
            DockPanel.SetDock(panelIzquierda, Dock.Left);
            DockPanel.SetDock(panelDerecha, Dock.Right);

            panelPrincipal.Children.Add(panelSuperior);
            panelPrincipal.Children.Add(panelIzquierda);
            panelPrincipal.Children.Add(panelDerecha);
            panelPrincipal.Children.Add(panelCentral);
        }

        /// <summary>
        /// Metodo que construye toda la interfaz por código
        /// </summary>

        private void partePrincipal()
        {
            parteSuperior();
            parteIzquierda();
            parteDerecha();
            parteCentral();
        }

        /// <summary>
        /// Metodo que construye la aprte superior de la ventana
        /// </summary>
        private void parteSuperior()
        {
            panelSuperior.Background = Brushes.Blue;
            Button btnCurrent = new Button();
            Button btnProjected = new Button();
            Button btnInterrogante = new Button();

            // Definimos las columnas
            columnas(2, panelSuperior);
            filas(1, panelSuperior);

            // Asignar pripiedades
            btnCurrent.Content = "Current";
            btnCurrent.Margin = new Thickness(10);
            Grid.SetColumn(btnCurrent, 0);
            Grid.SetRow(btnCurrent, 0);
            btnCurrent.Width = 100;
            btnCurrent.Height = 40;

            btnProjected.Content = "Projected";
            btnProjected.Margin = new Thickness(10);
            Grid.SetColumn(btnProjected, 1);
            Grid.SetRow(btnProjected, 0);
            btnProjected.Width = 100;
            btnProjected.Height = 40;
            btnProjected.HorizontalAlignment = HorizontalAlignment.Left;

            btnInterrogante.Content = new Image
            {
                Source = new BitmapImage(new Uri("Iconos/Interrogante.png", UriKind.RelativeOrAbsolute)),
                Height = 32,
                Width = 32
            };
            btnInterrogante.Margin = new Thickness(10);
            btnInterrogante.HorizontalAlignment = HorizontalAlignment.Right;
            panelSuperior.ColumnDefinitions[1].Width = new GridLength(1, GridUnitType.Star);
            Grid.SetColumn(btnInterrogante, 1);
            Grid.SetRow(btnInterrogante, 1);
            //Añadir los objetos al panel
            panelSuperior.Children.Add(btnCurrent);
            panelSuperior.Children.Add(btnProjected);
            panelSuperior.Children.Add(btnInterrogante);
        }

        /// <summary>
        /// Metodo que construye la parte izquierda de la ventana
        /// </summary>
        private void parteIzquierda()
        {
            foreach (string cadena in listaEtiquetasIzquierda)
            {
                TextBlock texto = new TextBlock();
                texto.Text = cadena;
                if (texto.Text.Equals(DATA))
                {
                    texto.Margin = new Thickness(10);
                    texto.FontWeight = FontWeights.Bold;
                    texto.FontSize = 14;
                }
                else
                {
                    texto.Margin = new Thickness(20, 10, 10, 10);
                }
                panelIzquierda.Children.Add(texto);
            }
        }

        /// <summary>
        /// Metodo que construye la parte derecha de la ventana
        /// </summary
        //private void partederecha()
        //{
        //    foreach (string images in listaimagenesbotones)
        //    {
        //        button button = new button();
        //        button.background = new solidcolorbrush(colors.transparent);
        //        button.margin = new thickness(10);
        //        string url = "iconos/" + images + ".png";
        //        button.content = new image
        //        {
        //            source = new bitmapimage(new uri(url, urikind.relativeorabsolute)),
        //            height = 24,
        //            width = 24
        //        };
        //        panelderecha.width = 100;
        //        panelderecha.children.add(button);
        //    }
        //}

        private void parteDerecha()
        {
            panelDerecha.Width = 100;

            columnas(2, panelDerecha);
            filas(3, panelDerecha);

            for (int i = 0; i < listaImagenesBotones.Count; i++)
            {
                Button btnImagen = new Button();
                btnImagen.Background = new SolidColorBrush(Colors.Transparent);
                btnImagen.Margin = new Thickness(10);
                btnImagen.Content = new Image
                {
                    Source = new BitmapImage(new Uri("Iconos/" + listaImagenesBotones[i] + ".png", UriKind.RelativeOrAbsolute)),
                    Height = 24,
                    Width = 24
                };
                Grid.SetColumn(btnImagen, i % 2);
                Grid.SetRow(btnImagen, i / 2);
                panelDerecha.Children.Add(btnImagen);
            }
        }

        /// <summary>
        /// Metodo que construye la parte central de la ventana
        /// </summary>
        private void parteCentral()
        {
            columnas(3, panelCentral);
            filas(6, panelCentral);

            Image imgCasa = new Image
            {
                Source = new BitmapImage(new Uri("Iconos/Casa.png", UriKind.RelativeOrAbsolute)),
                Height = 64,
                Width = 64,
                Margin = new Thickness(10)
            };
            Grid.SetColumn(imgCasa, 0);
            Grid.SetRow(imgCasa, 0);
            Grid.SetRowSpan(imgCasa, 2);

            TextBlock titulo = new TextBlock
            {
                Text = "Sales: Current Year",
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(10, 0, 10, 0),
                FontSize = 18
            };
            Grid.SetColumn(titulo, 1);
            Grid.SetRow(titulo, 0);

            TextBlock textoTop = new TextBlock
            {
                Text = "Goods and Services",
                Margin = new Thickness(10, 0, 10, 0)
            };
            Grid.SetColumn(textoTop, 1);
            Grid.SetRow(textoTop, 1);

            TextBlock textoRight = new TextBlock
            {
                Text = "Services 20%",
                Margin = new Thickness(10),
                HorizontalAlignment = HorizontalAlignment.Right
            };
            Grid.SetColumn(textoRight, 2);
            Grid.SetRow(textoRight, 2);

            Image imgPrincipal = new Image
            {
                Source = new BitmapImage(new Uri("Iconos/Principal.png", UriKind.RelativeOrAbsolute))
            };
            Grid.SetColumn(imgPrincipal, 1);
            Grid.SetRow(imgPrincipal, 3);

            TextBlock textoLeft = new TextBlock
            {
                Text = "Goods 80%",
                Margin = new Thickness(10),
            };
            Grid.SetColumn(textoLeft, 0);
            Grid.SetRow(textoLeft, 4);

            Button btnSave = new Button
            {
                Content = "Save",
                HorizontalAlignment = HorizontalAlignment.Right,
                Width = 70,
                Margin = new Thickness(10, 10, 10, 20)
            };
            Grid.SetColumn(btnSave, 1);
            Grid.SetRow(btnSave, 5);

            Button btnCancel = new Button
            {
                Content = "Cancel",
                HorizontalAlignment = HorizontalAlignment.Right,
                Width = 70,
                Margin = new Thickness(10, 10, 10, 20)
            };
            Grid.SetColumn(btnCancel, 2);
            Grid.SetRow(btnCancel, 5);

            panelCentral.Children.Add(imgCasa);
            panelCentral.Children.Add(titulo);
            panelCentral.Children.Add(textoTop);
            panelCentral.Children.Add(textoLeft);
            panelCentral.Children.Add(imgPrincipal);
            panelCentral.Children.Add(textoRight);
            panelCentral.Children.Add(btnSave);
            panelCentral.Children.Add(btnCancel);
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