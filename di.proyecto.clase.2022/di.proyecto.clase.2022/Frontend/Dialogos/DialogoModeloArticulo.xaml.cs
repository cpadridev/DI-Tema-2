using di.proyecto.clase._2022.Backend.Modelos;
using di.proyecto.clase._2022.Servicios;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows;

namespace di.proyecto.clase._2022.Frontend.Dialogos
{
    /// <summary>
    /// Lógica de interacción para DialogoModeloArticulo.xaml
    /// </summary>
    public partial class DialogoModeloArticulo : MetroWindow
    {
        /// <summary>
        /// Contexto para la conexión a la base de datos
        /// </summary>
        private inventarioEntities invEnt;
        /// <summary>
        /// Clase servicio que nos permite trabajar con la tabla TipoArtículo
        /// </summary>
        private TipoArticuloServicio tipoServ;
        /// <summary>
        /// Clase servicio que nos permite trabajar con la tabla ModeloArtículo
        /// </summary>
        private ModeloArticuloServicio modeloServ;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public DialogoModeloArticulo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="ent">Contexto de la base de datos. Viene del programa principal</param>
        public DialogoModeloArticulo(inventarioEntities ent)
        {
            invEnt = ent;
            InitializeComponent();
            inicializa();
        }
        /// <summary>
        /// Método que instancia los objetos necesarios
        /// </summary>
        private void inicializa()
        {
            tipoServ = new TipoArticuloServicio(invEnt);
            modeloServ = new ModeloArticuloServicio(invEnt);
            cbxTipoModelo.ItemsSource = tipoServ.getAll().ToList();
        }
        
        private async void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            modeloServ.add(recogerDatos());
            try
            {
                modeloServ.save();
                await this.ShowMessageAsync("GESTIÓN MODELO ARTÍCULO", "TODO CORRECTO. El objeto se ha guardado en la base de datos");
                DialogResult = true;
            }
            catch(DbUpdateException dbex)
            {
                System.Console.WriteLine(dbex.Message);
                await this.ShowMessageAsync("GESTIÓN MODELO ARTÍCULO", "ERROR!!! NO SE PUEDE GUARDAR EL OBJETO EN LA BASE DE DATOS");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            // Cierra el diálogo
            DialogResult = false;
        }

        private modeloarticulo recogerDatos()
        {
            modeloarticulo modelo = new modeloarticulo();
            modelo.nombre = txtNombre.Text;
            modelo.marca = txtMarca.Text;
            modelo.modelo = txtModelo.Text;
            modelo.descripcion = txtDescripcion.Text;
            modelo.tipoarticulo = (tipoarticulo)cbxTipoModelo.SelectedItem;
            return modelo;
        }
    }
}
