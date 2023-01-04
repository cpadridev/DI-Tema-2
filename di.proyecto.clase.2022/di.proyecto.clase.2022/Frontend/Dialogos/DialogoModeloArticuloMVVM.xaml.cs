using di.proyecto.clase._2022.Backend.Modelos;
using di.proyecto.clase._2022.MVVM;
using di.proyecto.clase._2022.Servicios;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows;

namespace di.proyecto.clase._2022.Frontend.Dialogos
{
    /// <summary>
    /// Lógica de interacción para DialogoModeloArticuloMVVM.xaml
    /// </summary>
    public partial class DialogoModeloArticuloMVVM : MetroWindow
    {
        /// <summary>
        /// Contexto para la conexión a la base de datos
        /// </summary>
        private inventarioEntities invEnt;
        private MVModeloArticulo mvModelo;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public DialogoModeloArticuloMVVM(inventarioEntities ent)
        {
            InitializeComponent();
            invEnt = ent;
            mvModelo = new MVModeloArticulo(invEnt);
            DataContext = mvModelo;
        }

        private async void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (mvModelo.guarda)
            {
                await this.ShowMessageAsync("GESTIÓN MODELO ARTÍCULO", "TODO CORRECTO. El modelo se guardo correctamente en la BD");
                DialogResult = true;
            }
            else
            {
                await this.ShowMessageAsync("GESTIÓN MODELO ARTÍCULO", "ERROR!!!. PROBLEMAS PARA GUARDAR EN LA BASE DE DATOS");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            // Cierra el diálogo
            DialogResult = false;
        }
    }
}
