using MagicVillaUI.MVVM.Model;
using MagicVillaUI.MVVM.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace MagicVillaUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HttpClient client = new HttpClient();
        public MainWindow()
        {
            client.BaseAddress = new Uri("https://localhost:7100/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );
            InitializeComponent();
        }

        //POST
        private void btnGuardarVilla_Click(object sender, RoutedEventArgs e)
        {
            var villa = new Villa()
            {
                Id = Convert.ToInt32(txtID.Text),
                Nombre = txtNombreVilla.Text,
                Detalle = txtDetalle.Text,
                Tarifa = Convert.ToDouble(txtTarifa.Text),
                Ocupantes = Convert.ToInt32(txtOcupantes.Text),
                MetrosCuadrados = Convert.ToDouble(txtm2.Text),
                ImagenUrl = txtImagen.Text,
                Amenidad = txtAmenidad.Text
            };

            if (villa.Id == 0)
            {
                this.PostVilla(villa);
                lblMensaje.Content = "Villa Guardada.";
            }
            else
            {
                this.PutVilla(villa);
                lblMensaje.Content = "Villa Actualizada.";
            }
            txtID.Text = 0.ToString();
            txtNombreVilla.Text = "";
            txtDetalle.Text = "";
            txtTarifa.Text = "";
            txtOcupantes.Text = "";
            txtm2.Text = "";
            txtImagen.Text = "";
            txtAmenidad.Text = "";
        }

        private async void PostVilla(Villa villa)
        {
            try
            {
                await client.PostAsJsonAsync("Villa", villa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
        }

        //GET
        private void btnCargarVillas_Click(object sender, RoutedEventArgs e)
        {
            this.GetVillas();
        }

        private async void GetVillas()
        {
            try
            {
                lblMensaje.Content = "";
                var respuesta = await client.GetStringAsync("Villa");
                var villas = JsonConvert.DeserializeObject<List<Villa>>(respuesta);
                dgVilla.DataContext = villas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
        }


        //PUT
        private void btnEditarVilla(object sender, RoutedEventArgs e)
        {
            Villa? villa = ((FrameworkElement)sender).DataContext as Villa;
            txtID.Text = villa.Id.ToString();
            txtNombreVilla.Text = villa.Nombre;
            txtDetalle.Text = villa.Detalle;
            txtTarifa.Text = villa.Tarifa.ToString();
            txtOcupantes.Text = villa.Ocupantes.ToString();
            txtm2.Text = villa.MetrosCuadrados.ToString();
            txtImagen.Text = villa.ImagenUrl;
            txtAmenidad.Text = villa.Amenidad;
        }

        private async void PutVilla(Villa villa)
        {
            try
            {
                await client.PutAsJsonAsync("Villa/" + villa.Id, villa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }

        }

        //DELETE
        private void btnBorrarVilla(object sender, RoutedEventArgs e)
        {
            Villa? villa = ((FrameworkElement)sender).DataContext as Villa;
            this.DeleteVilla(villa.Id);
        }

        private async void DeleteVilla(int villaId)
        {
            try
            {
                await client.DeleteAsync("Villa/id?id=" + villaId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
        }

        //GET
        private void btnMostrarVillaID(object sender, RoutedEventArgs e)
        {
            txtID.Visibility = Visibility.Visible;
            if(txtID.Text != (0).ToString())
            {
                var id = int.Parse(txtID.Text);
                this.GetVilla(id);
            }
            else { MessageBox.Show("El ID no puede ser 0."); };
        }

        private async void GetVilla(int villaId)
        {
            Villa villaporId = new Villa();
            try
            {
                lblMensaje.Content = "";
                var respuesta = await client.GetStringAsync("Villa/id?id=" + villaId);
                var villa = JsonConvert.DeserializeObject<Villa>(respuesta);
                dgVilla.DataContext = villa;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
        }
    }
}
