using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Models;
using WindowsForms.Views;
using static System.Net.WebRequestMethods;

namespace WindowsForms
{
    public partial class ClimaAppView : Form
    {
        public ClimaAppView()
        {
            InitializeComponent();
        }


        private void salirDeLaAppToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void IconSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NostrosIcon_Click(object sender, EventArgs e)
        {
            NosotrosViews nosotrosView = new NosotrosViews();
            nosotrosView.ShowDialog();
        }

        private void NosotrosIconMenu_Click(object sender, EventArgs e)
        {
            NostrosIcon_Click(sender, e);
        }

        private async void buttonObtenerClima_Click(object sender, EventArgs e)
        {
            string url = "https://api.open-meteo.com/v1/forecast?latitude=-30.7891&longitude=-60.5919&hourly=temperature_2m,cloud_cover_high&current=temperature_2m";
            
            var clientHttp = new HttpClient();
            var response = await clientHttp.GetAsync(url);
            if (response != null)
            {
                QueryTemp queryTemp = await response.Content.ReadFromJsonAsync<QueryTemp>();
                MessageBox.Show($"Temperatura actual: {queryTemp.current.temperature_2m}°C\n" +
                                $"Latitud: {queryTemp.latitude}\n" +
                                $"Longitud: {queryTemp.longitude}",
                                "Información del Clima",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
