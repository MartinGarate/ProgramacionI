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

namespace WindowsForms.Views
{
    public partial class PeliculasViews : Form
    {
        public PeliculasViews()
        {
            InitializeComponent();
            ObtenemosPeliculas(); 
        }

        private async void ObtenemosPeliculas()
        {
            string url = "https://netflisp-77fe.restdb.io/rest/peliculas?apikey=7e3b2f3b47495345da5617567d822a55dfd7f";

            var clientHttp = new HttpClient();
            var response = await clientHttp.GetAsync(url);
            if (response != null)
            {
                List <Pelicula> peliculas = await response.Content.ReadFromJsonAsync<List<Pelicula>>();
                dataGridView1.DataSource = peliculas;

            }
        }
    }
}
