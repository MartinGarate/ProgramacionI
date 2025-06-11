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
        //Creamos campos / propiedades
        HttpClient clientHttp = new HttpClient();
        string url = "https://netflisp-77fe.restdb.io/rest/peliculas?apikey=7e3b2f3b47495345da5617567d822a55dfd7f";

        public PeliculasViews()
        {
            InitializeComponent();
            ObtenemosPeliculas();
        }

        private async void ObtenemosPeliculas()
        {
            var response = await clientHttp.GetAsync(url);
            if (response != null)
            {
                List<Pelicula> peliculas = await response.Content.ReadFromJsonAsync<List<Pelicula>>();
                dataGridViewFilm.DataSource = peliculas;
            }
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            //checkeamos que haya peliculas seleccionadas
            if (dataGridViewFilm.RowCount > 0 && dataGridViewFilm.SelectedRows.Count > 0)
            {
                Pelicula peliculaSeleccionada = (Pelicula)dataGridViewFilm.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que quieres borrar la pelicula seleccionada?{peliculaSeleccionada.titulo}", "Borrar Pelicula", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    //obtenemos el id de la pelicula seleccionada
                    string url = $"https://netflisp-77fe.restdb.io/rest/peliculas/{peliculaSeleccionada._id}?apikey=7e3b2f3b47495345da5617567d822a55dfd7f";
                    var response = await clientHttp.DeleteAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Pelicula {peliculaSeleccionada.titulo} borrada correctamente", "Borrar Pelicula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ObtenemosPeliculas();
                    }
                    else
                    {
                        MessageBox.Show("Error al borrar la pelicula", "Borrar Pelicula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No hay peliculas seleccionadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //private void dataGridViewFilm_CellEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dataGridViewFilm.SelectedRows.Count > 0 && dataGridViewFilm.SelectedRows.Count > 0)
        //    {
        //        MessageBox.Show($"Has seleccionado la pelicula");
        //    }
        //}

        private void dataGridViewFilm_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewFilm.RowCount > 0 && dataGridViewFilm.SelectedRows.Count >0)
            {
                Pelicula peliculaSeleccionada = (Pelicula)dataGridViewFilm.SelectedRows[0].DataBoundItem;
                pictureBoxFilm.ImageLocation = peliculaSeleccionada.portada;
            }
        }
    }
}
