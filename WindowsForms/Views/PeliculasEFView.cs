using System.Data;
using WindowsForms.Models;
using WindowsForms.Services;

namespace WindowsForms.Views
{
    public partial class PeliculasEFView : Form
    {
        PeliculaEFService peliculaService = new PeliculaEFService();
        PaisEFService paisEFService = new PaisEFService();
        Pelicula peliculaModificada;
        List<Pelicula>? peliculas;

        public PeliculasEFView()
        {
            InitializeComponent();
            ObtenemosPeliculas();
            CargarComboPaises();
        }

        private async void CargarComboPaises()
        {
            ComboPaises.DataSource = await paisEFService.GetAllAsync();
            ComboPaises.ValueMember = "Id";
            ComboPaises.DisplayMember = "Nombre";
        }

        private async void ObtenemosPeliculas()
        {
            peliculas = await peliculaService.GetAllAsync();
            GridPais.DataSource = peliculas;
            GridPais.Columns["Id"].Visible = false; // Ocultar la columna de ID de película
            GridPais.Columns["_id"].Visible = false;
            GridPais.Columns["PaisId"].Visible = false;
            GridPais.Columns["Eliminado"].Visible = false;
            GridPais.Columns["Portada"].Visible = false;
        }

        private void GridPeliculas_SelectionChanged_1(object sender, EventArgs e)
        {
            if (GridPais.RowCount > 0 && GridPais.SelectedRows.Count > 0)
            {
                Pelicula peliSeleccionada = (Pelicula)GridPais.SelectedRows[0].DataBoundItem;
                FilmPicture.ImageLocation = peliSeleccionada.portada;
            }
        }

        private async void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            if (GridPais.RowCount > 0 && GridPais.SelectedRows.Count > 0)
            {
                Pelicula peliSeleccionada = (Pelicula)GridPais.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea eliminar la película {peliSeleccionada.titulo}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await peliculaService.DeleteAsync(peliSeleccionada.id))
                    {
                        LabelStatusMessage.Text = $"Película {peliSeleccionada.titulo} eliminada correctamente";
                        TimerStatusBar.Start();
                        ObtenemosPeliculas();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una película para eliminarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControlesAgregarEditar();
            TabControl.SelectTab("TabPageAgregarEditar");
        }

        private void LimpiarControlesAgregarEditar()
        {
            TxtTitulo.Clear();
            NumericDuracion.Value = 0;
            TxtPortada.Clear();
            ComboPaises.SelectedIndex = -1;
            NumericCalificacion.Value = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageLista");
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Pelicula peliculaAGuardar = new Pelicula
            {
                id = peliculaModificada?.id ?? 0,
                titulo = TxtTitulo.Text,
                duracion = (int)NumericDuracion.Value,
                portada = TxtPortada.Text,
                calificacion = (double)NumericCalificacion.Value,
                PaisId = (int?)ComboPaises.SelectedValue,
                Eliminado = false
            };

            bool response;
            if (peliculaModificada != null)
            {
                response = await peliculaService.UpdateAsync(peliculaAGuardar);
            }
            else
            {
                response = await peliculaService.AddAsync(peliculaAGuardar);
            }
            if (response)
            {
                peliculaModificada = null;
                LabelStatusMessage.Text = "Película guardada correctamente";
                TimerStatusBar.Start();
                ObtenemosPeliculas();
                LimpiarControlesAgregarEditar();
                TabControl.SelectTab("TabPageLista");
            }
            else
            {
                MessageBox.Show("Error al agregar la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (GridPais.RowCount > 0 && GridPais.SelectedRows.Count > 0)
            {
                peliculaModificada = (Pelicula)GridPais.SelectedRows[0].DataBoundItem;
                TxtTitulo.Text = peliculaModificada.titulo;
                NumericDuracion.Value = peliculaModificada.duracion;
                TxtPortada.Text = peliculaModificada.portada;
                NumericCalificacion.Value = (decimal)peliculaModificada.calificacion;
                if (peliculaModificada.PaisId != null)
                {
                    ComboPaises.SelectedValue = peliculaModificada.PaisId;
                }
                else
                {
                    ComboPaises.SelectedIndex = -1;
                }
                TabControl.SelectTab("TabPageAgregarEditar");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridPais.DataSource = peliculas.Where(p => p.titulo.ToUpper().Contains(TxtBuscar.Text.ToUpper()))
                .ToList();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BtnBuscar.PerformClick();
        }

        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            LabelStatusMessage.Text = string.Empty;
            TimerStatusBar.Stop();
        }

        private void AgregarPaisButton_Click(object sender, EventArgs e)
        {
            PaisesEFView paisesEFView = new PaisesEFView();
            paisesEFView.ShowDialog();
        }
    }
}