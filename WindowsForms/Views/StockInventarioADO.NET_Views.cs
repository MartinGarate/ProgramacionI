using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Models;
using WindowsForms.Services;


namespace WindowsForms.Views
{
    public partial class StockInventarioADOView : Form
    {
        StockInventarioADOService stockInventarioADOService = new StockInventarioADOService();
        StockInventarioADO stockInventarioModificado;
        List<StockInventarioADO> stockInventario;

        public StockInventarioADOView()
        {
            InitializeComponent();
            obtenemosStock();
        }

        private async void obtenemosStock()
        {
            dataGridView_Stock.DataSource = await stockInventarioADOService.GetStockItemsAsync();
        }

        private void dataGridView_Stock_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Stock.RowCount > 0 && dataGridView_Stock.SelectedRows.Count > 0)
            {
                StockInventarioADO stockSeleccionado = (StockInventarioADO)dataGridView_Stock.SelectedRows[0].DataBoundItem;
                pictureBox_Stock.ImageLocation = stockSeleccionado.url_imagen;
            }
        }

        private async void ButtonEliminarProducto_Click(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            if (dataGridView_Stock.RowCount > 0 && dataGridView_Stock.SelectedRows.Count > 0)
            {
                StockInventarioADO stockSeleccionado = (StockInventarioADO)dataGridView_Stock.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea eliminar el producto {stockSeleccionado.nombre}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await stockInventarioADOService.DeleteAsync(stockSeleccionado._id))
                    {
                        MessageBox.Show($"Producto {stockSeleccionado.nombre} eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        obtenemosStock(); // Actualizar la lista de productos
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto para eliminarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarControlesEditar_Agregar()
        {
            textBoxNombre.Clear();
            textBoxPrecio.Clear();
            textBoxProveedor.Clear();
            textBoxUrlImagen.Clear();
            pictureBoxEditar_Crear.Image = null;
            numericUpDown_CantidadStock.Value = 0; // Reiniciar el valor del NumericUpDown
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            limpiarControlesEditar_Agregar();
            TabControl.SelectTab("tabPage_EditarCrear");
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("tabPage_Lista");
            limpiarControlesEditar_Agregar();

        }

        private async void ButtonGuardar_Click(object sender, EventArgs e)
        {
            StockInventarioADO productoAGuardar = new StockInventarioADO
            {
                _id = stockInventarioModificado?._id, // Si es una edición, mantenemos el ID
                nombre = textBoxNombre.Text.Trim(),
                cantidad_stock = (int)numericUpDown_CantidadStock.Value,
                precio = double.TryParse(textBoxPrecio.Text.Trim(), out double precio) ? precio : 0.0,
                proveedor = textBoxProveedor.Text.Trim(),
                url_imagen = textBoxUrlImagen.Text
            };

            bool response;
            if (stockInventarioModificado != null)
            {
                response = await stockInventarioADOService.UpdateAsync(productoAGuardar);
            }
            else
            {
                response = await stockInventarioADOService.AddAsync(productoAGuardar);
            }
            if (response)
            {
                stockInventarioModificado = null;
                MessageBox.Show("Producto guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                obtenemosStock();
                limpiarControlesEditar_Agregar();
                TabControl.SelectTab("tabPage_Lista");
            }
            else
            {
                MessageBox.Show("Error al agregar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            if (dataGridView_Stock.RowCount > 0 && dataGridView_Stock.SelectedRows.Count > 0)
            {
                StockInventarioADO stockSeleccionado = (StockInventarioADO)dataGridView_Stock.SelectedRows[0].DataBoundItem;
                stockInventarioModificado = stockSeleccionado; // Guardamos el producto seleccionado para editar

                // Cargamos los datos del producto en los controles de edición
                textBoxNombre.Text = stockSeleccionado.nombre;
                numericUpDown_CantidadStock.Value = stockSeleccionado.cantidad_stock ?? 0;
                textBoxPrecio.Text = stockSeleccionado.precio.ToString();
                textBoxProveedor.Text = stockSeleccionado.proveedor;
                textBoxUrlImagen.Text = stockSeleccionado.url_imagen;

                pictureBoxEditar_Crear.ImageLocation = stockSeleccionado.url_imagen;
                TabControl.SelectTab("tabPage_EditarCrear");
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto para editarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private async void ButtonBuscar_Click(object sender, EventArgs e)
        {
            // Verificamos si el campo de búsqueda está vacío
            if (string.IsNullOrWhiteSpace(textBoxBuscar.Text))
            {
                // Si está vacío, mostramos todos los productos
                obtenemosStock();
            }
            else
            {
                // Si hay texto, filtramos los productos por nombre
                var filtro = textBoxBuscar.Text.Trim().ToLower();
                var productos = await stockInventarioADOService.GetStockItemsAsync();
                var productosFiltrados = productos
                    .Where(p => p.nombre != null && p.nombre.ToLower().Contains(filtro))
                    .ToList();

                dataGridView_Stock.DataSource = productosFiltrados;
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            ButtonBuscar.PerformClick();
        }

        private void textBoxBuscar_Enter(object sender, EventArgs e)
        {
                ButtonBuscar.PerformClick();
        }
    }
}
