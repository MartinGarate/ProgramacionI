using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Models;

namespace WindowsForms.Views
{
    public partial class AutoStockView : Form
    {

        //Creamos campos / propiedades
        HttpClient clientHttp = new HttpClient();
        string url = "https://autostock-c2a0.restdb.io/rest/autostock?apikey=d600303563746b80ed362976592e68879b394";
        Autos autoModificado;
        List<Autos> autos;
        public AutoStockView()
        {
            InitializeComponent();
            ObtenemosAutos();
            textBoxFiltrarAuto.ContextMenuStrip = contextMenuStripLimpiar;
        }

        private void ConfigurarDataGridView()
        {
            // Ocultar la columna "_id"
            if (dataGridViewAutos.Columns["_id"] != null)
                dataGridViewAutos.Columns["_id"].Visible = false;
            // Ocultar la columna "imagen"
            if (dataGridViewAutos.Columns["imagen"] != null)
                dataGridViewAutos.Columns["imagen"].Visible = false;
            // Cambiar el encabezado de la columna "anio" a "año"
            if (dataGridViewAutos.Columns["anio"] != null)
                dataGridViewAutos.Columns["anio"].HeaderText = "año";
        }

        private async void ObtenemosAutos()
        {
            var response = await clientHttp.GetAsync(url);
            if (response != null)
            {
                autos = await response.Content.ReadFromJsonAsync<List<Autos>>();
                dataGridViewAutos.DataSource = autos;
                ConfigurarDataGridView();
            }
        }

        private async void ButtonEliminarAuto_Click(object sender, EventArgs e)
        {
            //checkeamos que haya autos seleccionados
            if (dataGridViewAutos.RowCount > 0 && dataGridViewAutos.SelectedRows.Count > 0)
            {
                Autos autoSeleccionado = (Autos)dataGridViewAutos.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que quieres borrar el auto {autoSeleccionado.marca} {autoSeleccionado.modelo} ?", "Borrar Auto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    // Corregido: falta una barra diagonal antes del id
                    string url = $"https://autostock-c2a0.restdb.io/rest/autostock/{autoSeleccionado._id}?apikey=d600303563746b80ed362976592e68879b394";
                    var response = await clientHttp.DeleteAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"El {autoSeleccionado.marca + " " + autoSeleccionado.modelo} ha sido borrado correctamente", "Auto borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ObtenemosAutos();
                    }
                    else
                    {
                        MessageBox.Show("Error al borrar el auto", "Borrar Auto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay auto seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAutos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAutos.RowCount > 0 && dataGridViewAutos.SelectedRows.Count > 0)
            {
                Autos autoSeleccionado = (Autos)dataGridViewAutos.SelectedRows[0].DataBoundItem;
                pictureBoxAuto.ImageLocation = autoSeleccionado.imagen;
            }
        }

        private void ButtonBuscarAuto_Click(object sender, EventArgs e)
        {
            string filtro = textBoxFiltrarAuto.Text?.Trim().ToLower() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(filtro))
            {
                dataGridViewAutos.DataSource = null;
                dataGridViewAutos.DataSource = autos;
                ConfigurarDataGridView();
                return;
            }

            var autosFiltrados = autos
                .Where(p =>
                    (!string.IsNullOrEmpty(p.modelo) && p.modelo.ToLower().Contains(filtro)) ||
                    (!string.IsNullOrEmpty(p.marca) && p.marca.ToLower().Contains(filtro)) ||
                    p.anio.ToString().Contains(filtro)
                )
                .ToList();

            dataGridViewAutos.DataSource = null;
            dataGridViewAutos.DataSource = autosFiltrados;
            ConfigurarDataGridView();
        }

        private void LimpiarCampos()
        {
            textBoxFiltrarAuto.Clear();
            pictureBoxAuto.Image = null;
            pictureBoxImagenAuto.Image = null;
            dataGridViewAutos.ClearSelection();
            textBoxImagenAuto.Clear();
            textBoxMarcaAuto.Clear();
            numericAnioAuto.Value = numericAnioAuto.Minimum;
            textBoxModeloAuto.Clear();
            numericPrecioAuto.Value = numericPrecioAuto.Minimum;
            checkBoxUsado.Checked = false;
        }

        public void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void textBoxFiltrarAuto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFiltrarAuto.Text))
            {
                ButtonBuscarAuto.PerformClick();
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tabPageLista");
            LimpiarCampos();
        }

        private void ButtonEditarAuto_Click(object sender, EventArgs e)
        {

            if (dataGridViewAutos.RowCount > 0 && dataGridViewAutos.SelectedRows.Count > 0)
            {
                autoModificado = (Autos)dataGridViewAutos.SelectedRows[0].DataBoundItem;
                textBoxImagenAuto.Text = autoModificado.imagen;
                textBoxMarcaAuto.Text = autoModificado.marca;
                numericAnioAuto.Value = autoModificado.anio;
                textBoxModeloAuto.Text = autoModificado.modelo;
                numericPrecioAuto.Value = (decimal)autoModificado.precio;
                checkBoxUsado.Checked = autoModificado.usado;
                tabControl.SelectTab("tabPageAgregar_Editar");
            }
            else
            {
                MessageBox.Show("No hay auto seleccionado para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Autos autoAGuardar = new Autos
            {
                imagen = textBoxImagenAuto.Text,
                marca = textBoxMarcaAuto.Text,
                anio = (int)numericAnioAuto.Value,
                modelo = textBoxModeloAuto.Text,
                precio = (double)numericPrecioAuto.Value,
                usado = checkBoxUsado.Checked
            };
            HttpResponseMessage response;
            if (autoModificado != null)
            {
                var urlEditar = $"https://autostock-c2a0.restdb.io/rest/autostock/{autoModificado._id}?apikey=d600303563746b80ed362976592e68879b394";
                response = await clientHttp.PutAsJsonAsync(urlEditar, autoAGuardar);
            }
            else
            {
                response = await clientHttp.PostAsJsonAsync(url, autoAGuardar);
            }
            if (response.IsSuccessStatusCode)
            {
                autoModificado = null;
                MessageBox.Show("El auto se guardó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenemosAutos();
                tabControl.SelectTab("tabPageLista");
            }
            else
            {
                MessageBox.Show("Error al guardar el auto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCampos();
        }

        private void textBoxImagenAuto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxImagenAuto.Text))
            {
                pictureBoxImagenAuto.ImageLocation = textBoxImagenAuto.Text;
            }
        }

        private void ButtonAgregarAuto_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tabPageAgregar_Editar");
            LimpiarCampos();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

