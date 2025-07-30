using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using WindowsForms.Models;
using WindowsForms.Services;

namespace WindowsForms.Views
{
    public partial class PeliculasADOViews : Form
    {
        
        PeliculaADOService peliculaService = new PeliculaADOService();
        Pais peliculaModificada;
        List<Pais> peliculas;

        public PeliculasADOViews()
        {
            InitializeComponent();
            ObtenemosPeliculas();
        }

        private async void ObtenemosPeliculas()
        {
            peliculas = await peliculaService.GetAllAsync();
            dataGridViewFilm.DataSource = peliculas;
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            //checkeamos que haya peliculas seleccionadas
            if (dataGridViewFilm.RowCount > 0 && dataGridViewFilm.SelectedRows.Count > 0)
            {
                
                Pais peliculaSeleccionada = (Pais)dataGridViewFilm.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que quieres borrar la pelicula seleccionada?{peliculaSeleccionada.titulo}", "Borrar Pelicula", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    //obtenemos el id de la pelicula seleccionada

                    if (await peliculaService.DeleteAsync(peliculaSeleccionada.id))
                    {
                        LabelStatusMessage.Text = $"Pelicula {peliculaSeleccionada.titulo} borrada correctamente";
                        ObtenemosPeliculas();
                        TimerStatusBar.Start();
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

        private void dataGridViewFilm_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewFilm.RowCount > 0 && dataGridViewFilm.SelectedRows.Count > 0)
            {
                Pais peliculaSeleccionada = (Pais)dataGridViewFilm.SelectedRows[0].DataBoundItem;
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
            Pais PeliculaAGuardar = new Pais
            {
                _id = peliculaModificada?._id??null,
                titulo = textBoxTitulo.Text,
                duracion = (int)numericDuracion.Value,
                portada = textBoxPortada.Text,
                calificacion = (double)numericCalificacion.Value
            };
            bool response;
            if (peliculaModificada != null)
            {
                response = await peliculaService.UpdateAsync(peliculaModificada);
            }
            else
            {
                response = await peliculaService.AddAsync(PeliculaAGuardar);
            }
            if (response)
            {
                peliculaModificada = null;
                LabelStatusMessage.Text = "Pelicula guardada correctamente";
                TimerStatusBar.Start();
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
                peliculaModificada = (Pais)dataGridViewFilm.SelectedRows[0].DataBoundItem;
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
                dataGridViewFilm.DataSource = peliculas.Where(p => p.titulo.ToLower().Contains(textBoxBuscar.Text.ToLower()))
                    .ToList();

        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBuscar.Text))
            {
                iconButtonBuscar.PerformClick();
            }

        }

        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            LabelStatusMessage.Text = string.Empty;
            TimerStatusBar.Stop();
        }
    }
}
