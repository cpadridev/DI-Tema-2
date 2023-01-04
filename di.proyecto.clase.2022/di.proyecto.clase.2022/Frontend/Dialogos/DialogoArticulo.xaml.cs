using di.proyecto.clase._2022.Backend.Modelos;
using di.proyecto.clase._2022.Servicios;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace di.proyecto.clase._2022.Frontend.Dialogos
{
    /// <summary>
    /// Lógica de interacción para DialogoArticulo.xaml
    /// </summary>
    public partial class DialogoArticulo : MetroWindow
    {
        /// <summary>
        /// Contexto para la conexión a la base de datos
        /// </summary>
        private inventarioEntities invEnt;
        /// <summary>
        /// Usuario que ha iniciado sesión
        /// </summary>
        private usuario usuLogin;
        /// <summary>
        /// Clase servicio que nos permite trabajar con la tabla Articulo
        /// </summary>
        private ArticuloServicio articuloServ;
        /// <summary>
        /// Clase servicio que nos permite trabajar con la tabla ModeloArticulo
        /// </summary>
        private ModeloArticuloServicio modeloServ;
        /// <summary>
        /// Clase servicio que nos permite trabajar con la tabla Espacio
        /// </summary>
        private EspacioServicio espacioServ;
        /// <summary>
        /// Clase servicio que nos permite trabajar con la tabla Departamento
        /// </summary>
        private DptoServicio dptoServ;
        /// <summary>
        /// Clase servicio que nos permite trabajar con la tabla Departamento
        /// </summary>
        private UsuarioServicio usuarioServ;
        /// <summary>
        /// Lista con los estados de un artículo
        /// </summary>
        private List<String> listaEstados = new List<string>() { "operativo", "mantenimiento", "obsoleto", "retirado" };
        private Brush colorInicial;
        public DialogoArticulo()
        {
            InitializeComponent();
        }

        public DialogoArticulo(inventarioEntities ent, usuario usu)
        {
            invEnt = ent;
            usuLogin = usu;
            InitializeComponent();
            inicializa();
        }

        private void inicializa()
        {
            articuloServ = new ArticuloServicio(invEnt);
            modeloServ = new ModeloArticuloServicio(invEnt);
            espacioServ = new EspacioServicio(invEnt);
            dptoServ = new DptoServicio(invEnt);
            usuarioServ = new UsuarioServicio(invEnt);
            cbxModelo.ItemsSource = modeloServ.getAll().ToList();
            cbxEspacio.ItemsSource = espacioServ.getAll().ToList();
            cbxDpto.ItemsSource = dptoServ.getAll().ToList();
            cbxEstado.ItemsSource = listaEstados;
            cbxUsuario.ItemsSource = usuarioServ.getAll().ToList();

            cbxEstado.SelectedItem = listaEstados[0];
            cbxUsuario.SelectedItem = usuLogin;
            dtpFecha.SelectedDate = DateTime.Now;
            colorInicial = cbxDpto.BorderBrush;
        }

        private async void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if(validarDatos())
            {
                articulo articulo = recogerDatos();
                if (articuloServ.numserieUnico(articulo.numserie))
                {
                    articuloServ.add(articulo);
                    try
                    {
                        articuloServ.save();
                        await this.ShowMessageAsync("GESTIÓN ARTÍCULO", "TODO CORRECTO. El objeto se ha guardado en la base de datos");
                        DialogResult = true;
                    }
                    catch (DbUpdateException dbex)
                    {
                        System.Console.WriteLine(dbex.Message);
                        await this.ShowMessageAsync("GESTIÓN ARTÍCULO", "ERROR!!! NO SE PUEDE GUARDAR EL OBJETO EN LA BASE DE DATOS");
                    }
                }
                else
                {
                    mostrarError(txtNumSerie, true);
                    txtCamposObligatorios.Text = "El número de serie no puede estar repetido";
                    txtNumSerie.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            // Cierra el diálogo
            DialogResult = false;
        }

        private articulo recogerDatos()
        {
            articulo articulo = new articulo();
            articulo.idarticulo = articuloServ.getLastId() + 1;
            articulo.numserie = txtNumSerie.Text;
            articulo.estado = cbxEstado.SelectedItem.ToString();
            articulo.fechaalta = dtpFecha.SelectedDate;
            articulo.usuarioalta = ((usuario)cbxUsuario.SelectedItem).idusuario;
            articulo.modelo = ((modeloarticulo) cbxModelo.SelectedItem).idmodeloarticulo;
            articulo.departamento = ((departamento)cbxDpto.SelectedItem).iddepartamento;
            articulo.espacio = ((espacio)cbxEspacio.SelectedItem).idespacio;
            return articulo;
        }

        private bool validarDatos()
        {
            bool correcto = true;
            if(cbxDpto.SelectedItem == null)
            {
                correcto = false;
                mostrarError(cbxDpto, true);
            }
            else
            {
                mostrarError(cbxDpto, false);
            }
            if (cbxModelo.SelectedItem == null)
            {
                correcto = false;
                mostrarError(cbxModelo, true);
            }
            else
            {
                mostrarError(cbxModelo, false);
            }
            if (cbxEspacio.SelectedItem == null)
            {
                correcto = false;
                mostrarError(cbxEspacio, true);
            }
            else
            {
                mostrarError(cbxEspacio, false);
            }
            if (string.IsNullOrEmpty(txtNumSerie.Text))
            {
                correcto = false;
                mostrarError(txtNumSerie, true);
            }
            else
            {
                mostrarError(txtNumSerie, false);
            }

            if(correcto)
            {
                txtCamposObligatorios.Text = "";
            }
            else
            {
                txtCamposObligatorios.Text = "Hay campos obligatorios sin rellenar";
            }

            return correcto;
        }

        private void mostrarError(Control componente, bool error)
        {
            if(error)
            {
                componente.BorderBrush = Brushes.DarkRed;
            } 
            else
            {
                componente.BorderBrush = colorInicial;
            }
            
        }
    }
}
