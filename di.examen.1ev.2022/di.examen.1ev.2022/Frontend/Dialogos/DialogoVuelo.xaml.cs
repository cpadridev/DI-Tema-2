using di.examen.nov._2021.bis.Backend.Modelo;
using di.examen.nov._2021.bis.Backend.Servicios;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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

namespace di.examen.nov._2021.bis.Frontend.Dialogos
{
    /// <summary>
    /// Lógica de interacción para DialogoVuelo.xaml
    /// </summary>
    public partial class DialogoVuelo : MetroWindow
    {
        /// <summary>
        /// Variable para guardar el contexto de la base de datos
        /// </summary>
        private aerolineasEntities aerEnt;
        /// <summary>
        /// Clase servicio que nos permite trabajar con la tabla Vuelo
        /// </summary>
        private ServicioVuelos vueloServ;
        /// <summary>
        /// Clase servicio que nos permite trabajar con la tabla Avion
        /// </summary>
        private ServicioAvion avionServ;
        /// <summary>
        /// Clase servicio que nos permite trabajar con la tabla Ciudad
        /// </summary>
        private ServicioCiudades ciudadServ;
        public DialogoVuelo()
        {
            InitializeComponent();
        }

        public DialogoVuelo(aerolineasEntities ent)
        {
            aerEnt = ent;
            InitializeComponent();
            inicializa();
        }

        private void inicializa()
        {
            vueloServ = new ServicioVuelos(aerEnt);
            avionServ = new ServicioAvion(aerEnt);
            ciudadServ = new ServicioCiudades(aerEnt);
            cbxAvion.ItemsSource = avionServ.getAll().ToList();
            cbxCiudadPartida.ItemsSource = ciudadServ.getAll().ToList();
            cbxCiudadLlegada.ItemsSource = ciudadServ.getAll().ToList();

            calDiaVuelo.SelectedDate = DateTime.Now;
        }

        private async void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if(validarDatos())
            {
                vueloServ.add(recogerDatos());
                try
                {
                    vueloServ.save();
                    await this.ShowMessageAsync("GESTIÓN VUELO", "TODO CORRECTO. El objeto se ha guardado en la base de datos");
                    DialogResult = true;
                }
                catch (DbUpdateException dbex)
                {
                    System.Console.WriteLine(dbex.Message);
                    await this.ShowMessageAsync("GESTIÓN VUELO", "ERROR!!! NO SE PUEDE GUARDAR EL OBJETO EN LA BASE DE DATOS");
                }
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            // Cierra el diálogo
            DialogResult = false;
        }

        private vuelos recogerDatos()
        {
            vuelos vuelo = new vuelos();
            if(cbxAvion.SelectedItem != null)
            {
                vuelo.avion = (avion)cbxAvion.SelectedItem;
            }
            vuelo.ciudades = (ciudades)cbxCiudadPartida.SelectedItem;
            vuelo.ciudades1 = (ciudades)cbxCiudadPartida.SelectedItem;
            vuelo.Dia = (DateTime)calDiaVuelo.SelectedDate;
            vuelo.duracion = TimeSpan.Parse(txbDuracion.Text);
            if (!string.IsNullOrEmpty(txbReserva.Text))
            {
                vuelo.Reservas = int.Parse(txbReserva.Text);
            }
            return vuelo;
        }

        private bool validarDatos()
        {
            if (string.IsNullOrEmpty(txbDuracion.Text))
            {
                txbMensajeError.Text = "Hay campos obligatorios sin rellenar";
                return false;
            }

            if (cbxCiudadPartida.SelectedItem != null && cbxCiudadLlegada != null)
            {
                if (cbxCiudadPartida.SelectedItem == cbxCiudadLlegada.SelectedItem)
                {
                    txbMensajeError.Text = "La ciudad de salida no puede ser la misma que la de llegada";
                    return false;
                }
            }

            txbMensajeError.Text = "";

            return true;
        }
    }
}
