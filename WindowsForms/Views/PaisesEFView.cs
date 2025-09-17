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
using WindowsForms.Services;

namespace WindowsForms.Views
{
    public partial class PaisesEFView : Form
    {


        PaisEFService paisEFService = new PaisEFService();
        Pais paisCurrent;
        List<Pais>? paises;
        public PaisesEFView()
        {
            InitializeComponent();
            obtenemosPaises();

        }

        private async void obtenemosPaises()
        {

            paises = await paisEFService.GetAllAsync();
            GridPais.DataSource = paises;
            GridPais.Columns["Eliminado"].Visible = false; // Ocultamos la columna eliminar
            GridPais.Columns["Id"].Visible = false;

        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            //checkeamos que haya peliculas seleccionadas
            if (GridPais.RowCount > 0 && GridPais.SelectedRows.Count > 0)
            {
                Pais paisSelected = (Pais)GridPais.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que quieres borrar el pais seleccionada?{paisSelected.Nombre}", "Borrar Pelicula", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {

                    if (await paisEFService.DeleteAsync(paisSelected.id))
                    {
                        LabelStatusMessage.Text = $"Pais {paisSelected.Nombre} eliminado correctamente";
                        TimerStatusBar.Start();
                        obtenemosPaises();
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



        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControlAgregar();
            TabControl.SelectTab("tabPageAgregar");
        }
        private void LimpiarControlAgregar()
        {
           TxtPais.Text = string.Empty;

        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("tabPageLista");
        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {
            Pais paisAguardar = new Pais
            {
                id = paisCurrent?.id ?? 0,
                Nombre = TxtPais.Text
               ,
                // Asignamos el PaisId del combo seleccionado

            };
            bool response;
            if (paisCurrent != null)
            {
                response = await paisEFService.UpdateAsync(paisAguardar);
            }
            else
            {
                response = await paisEFService.AddAsync(
                   paisAguardar);
            }
            if (response)
            {
                paisCurrent = null;
                MessageBox.Show("Paìs se guardo correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                obtenemosPaises();
                TabControl.SelectTab("TabPageLista");
            }
            else
            {
                MessageBox.Show("Error al modificar el Paìs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (GridPais.RowCount > 0 && GridPais.SelectedRows.Count > 0)
            {
                paisCurrent = (Pais)GridPais.SelectedRows[0].DataBoundItem;
                TxtPais.Text = paisCurrent.Nombre;


            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            GridPais.DataSource = paises.Where(p => p.Nombre.ToUpper().Contains(TxtBuscar.Text.ToUpper())).ToList();

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TxtBuscar.Text))
            {
                BtnBuscar.PerformClick();
            }

        }

        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            LabelStatusMessage.Text = string.Empty;
            TimerStatusBar.Stop();
        }
    }
}