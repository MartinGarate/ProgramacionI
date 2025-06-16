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
        Pelicula peliculaModificada;
        List<Pelicula> peliculas;

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
                peliculas = await response.Content.ReadFromJsonAsync<List<Pelicula>>();
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
            if (dataGridViewFilm.RowCount > 0 && dataGridViewFilm.SelectedRows.Count > 0)
            {
                Pelicula peliculaSeleccionada = (Pelicula)dataGridViewFilm.SelectedRows[0].DataBoundItem;
                pictureBoxFilm.ImageLocation = peliculaSeleccionada.portada;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControlAgregar();
            tabControl.SelectTab("tabPageAgregar_Editar");
        }
        private void LimpiarControlAgregar()
        {
            textBoxPortada.Text = string.Empty;
            numericCalificacion.Value = 0;
            textBoxTitulo.Text = string.Empty;
            pictureBoxFilm.ImageLocation = null;
            numericDuracion.Value = 0;
        }

        private async void iconButtonGuardar_Click_1(object sender, EventArgs e)
        {
            Pelicula PeliculaAGuardar = new Pelicula
            {
                titulo = textBoxTitulo.Text,
                duracion = (int)numericDuracion.Value,
                portada = textBoxPortada.Text,
                calificacion = (double)numericCalificacion.Value
            };
            HttpResponseMessage response;
            if (peliculaModificada != null)
            {
                var url = $"https://movies-3d7f.restdb.io/rest/peliculas/{peliculaModificada._id}?apikey=9f40398ea9906d975b1e35adf4cf48f07b028";
                response = await clientHttp.PostAsJsonAsync(url, PeliculaAGuardar);
            }
            else
            {
                response = await clientHttp.PostAsJsonAsync(url,
                   PeliculaAGuardar);
            }
            if (response.IsSuccessStatusCode)
            {
                peliculaModificada = null;
                MessageBox.Show("Pelicula se guardo correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenemosPeliculas();
                tabControl.SelectTab("TabPageLista");
            }
            else
            {
                MessageBox.Show("Error al modificar la pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarControlAgregar();
        }


        private void iconButtonCancelar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tabPageLista");
            LimpiarControlAgregar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewFilm.RowCount > 0 && dataGridViewFilm.SelectedRows.Count > 0)
            {
                peliculaModificada = (Pelicula)dataGridViewFilm.SelectedRows[0].DataBoundItem;
                textBoxTitulo.Text = peliculaModificada.titulo;
                numericDuracion.Value = peliculaModificada.duracion;
                textBoxPortada.Text = peliculaModificada.portada;
                numericCalificacion.Value = (decimal)peliculaModificada.calificacion;
                tabControl.SelectTab("tabPageAgregar_Editar");
            }

            LimpiarControlAgregar();
        }


        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBuscar.Text))
            {
                MessageBox.Show("Por favor, ingrese un título para buscar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (peliculas.Where(p => p.titulo.ToLower().Contains(textBoxBuscar.Text.ToLower())).Count() == 0)
            {
                MessageBox.Show("No se encontraron resultados para la búsqueda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewFilm.DataSource = null;
            }

            else if (peliculas.Where(p => p.titulo.ToLower().Contains(textBoxBuscar.Text.ToLower())).Count() >= 1)
            {
                dataGridViewFilm.DataSource = peliculas.Where(p => p.titulo.ToLower().Contains(textBoxBuscar.Text.ToLower()))
                    .ToList(); 
             
            }


        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxBuscar.Text))
            {
                iconButtonBuscar.PerformClick();
            }
            
        }
    }
}
