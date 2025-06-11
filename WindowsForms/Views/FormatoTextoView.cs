using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Views;



namespace WindowsForms.Views
{
    public partial class FormatoTextoView : Form
    {
        List<string> estilos = new();

        public FormatoTextoView()
        {
            
            InitializeComponent();
            CargarFuentes();
            CambiarTamañoFuente(13); // Asegura que el label arranque con tamaño 13

            checkBoxBold.CheckedChanged += checkBoxBold_CheckedChanged;
            checkBoxItalic.CheckedChanged += checkBoxItalic_CheckedChanged;
            checkBoxUnderline.CheckedChanged += checkBoxUnderline_CheckedChanged;

        }



        // Evento para cambiar el texto del label al escribir en el TextBox
        private void TextBoxEscribeAlgoAqui_TextChanged(object sender, EventArgs e)
        {
            richTextBoxResultado.Text = TextBoxEscribeAlgoAqui.Text;
        }

        // Metodo para cambiar el estilo de la fuente al hacer clic en los botones de formato
        private void CargarFuentes()
        {
            // Carga las fuentes instaladas en el sistema y las agrega al ComboBox de fuentes
            comboBoxFuente.DrawMode = DrawMode.OwnerDrawFixed;
            // Configura el evento DrawItem para personalizar la apariencia de los elementos del ComboBox
            comboBoxFuente.DrawItem += comboBoxFuente_DrawItem;
            InstalledFontCollection fuentes = new InstalledFontCollection();
            // Limpia el ComboBox de fuentes antes de agregar las nuevas
            comboBoxFuente.Items.Clear();
            // Recorre todas las fuentes instaladas y las agrega al ComboBox
            foreach (FontFamily fuente in fuentes.Families)
            {
                // Verifica que la fuente no sea una fuente de sistema o de tipo no deseado
                comboBoxFuente.Items.Add(fuente.Name);
            }
            // Si hay fuentes disponibles, selecciona la primera automáticamente
            if (comboBoxFuente.Items.Count > 0)
                comboBoxFuente.SelectedIndex = 0;
        }

        // Evento que se dispara al seleccionar una fuente en el ComboBox de fuentes
        private void comboBoxFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia el segundo ComboBox que contiene las variantes
            comboBoxFamiliaFuente.Items.Clear();

            // Obtiene el nombre de la fuente seleccionada por el usuario
            string fuenteSeleccionada = comboBoxFuente.SelectedItem?.ToString();

            // Si no hay fuente seleccionada, salir del método
            if (string.IsNullOrEmpty(fuenteSeleccionada))
                return;

            // Accede a todas las fuentes instaladas en el sistema
            InstalledFontCollection fuentes = new InstalledFontCollection();

            // Filtra todas las fuentes cuyo nombre comienza con la fuente seleccionada
            var variantes = fuentes.Families
                .Where(f => f.Name.StartsWith(fuenteSeleccionada, StringComparison.InvariantCultureIgnoreCase))
                .Select(f => f.Name) // solo el nombre
                .Distinct() // elimina duplicados
                .ToList();  // convierte el resultado en una lista

            // Si hay más de una variante encontrada
            if (variantes.Count > 1)
            {
                // Las agrega al ComboBox de variantes
                foreach (var variante in variantes)
                    comboBoxFamiliaFuente.Items.Add(variante);
            }

            // Si se agregaron variantes, selecciona la primera automáticamente
            if (comboBoxFamiliaFuente.Items.Count > 0)
                comboBoxFamiliaFuente.SelectedIndex = 0;

            // Actualiza el label con la fuente seleccionada
            CambiarFuenteLabel();
        }


        // Evento para visualizar y diferenciar las fuentes en el ComboBox de fuentes
        private void comboBoxFuente_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Verifica si hay un índice válido
            if (e.Index < 0) return;

            // Obtiene el nombre de la fuente del índice seleccionado
            string fontName = comboBoxFuente.Items[e.Index].ToString();
            // Dibuja el fondo del elemento
            e.DrawBackground();
            // Crea una nueva fuente con el nombre seleccionado y el tamaño de la fuente del ComboBox
            using (Font font = new Font(fontName, e.Font.Size))
            {
                // Dibuja el nombre de la fuente en el ComboBox
                e.Graphics.DrawString(fontName, font, Brushes.Black, e.Bounds);
            }
            // Dibuja el rectángulo de enfoque si es necesario
            e.DrawFocusRectangle();
        }

        // Evento para visualizar y diferenciar las fuentes en el ComboBox de las familias de las fuentes
        private void comboBoxFamiliaFuente_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Verifica si hay un índice válido
            if (e.Index < 0) return;

            // Obtiene el nombre de la variante de fuente del índice seleccionado
            string variante = comboBoxFamiliaFuente.Items[e.Index].ToString();
            // Dibuja el fondo del elemento
            e.DrawBackground();

            // usa una nueva fuente con el nombre de la variante y el tamaño de la fuente
            using (Font font = new Font(variante, e.Font.Size, FontStyle.Regular))
            {
                // Dibuja el nombre de la variante de fuente en el ComboBox
                e.Graphics.DrawString(variante, font, Brushes.Black, e.Bounds);
            }
            // Dibuja el rectángulo de enfoque si es necesario
            e.DrawFocusRectangle();
        }

        // Metodo para cambiar fuente y tamaño del label
        private void CambiarFuenteLabel()
        {
            // Obtiene la fuente y familia seleccionadas en los ComboBoxes
            string fuente = comboBoxFuente.SelectedItem?.ToString();
            // Si no hay familia de la fuente seleccionada, usa la fuente por defecto
            string familia = comboBoxFamiliaFuente.SelectedItem?.ToString();
            // Obtiene el tamaño de fuente del NumericUpDown
            int tamaño = (int)numericUpDownTamañoFuente.Value;

            // Usa la familia si está seleccionada, si no, usa la fuente base
            string fuenteFinal = !string.IsNullOrEmpty(familia) ? familia : fuente;

            // Si la fuente final es nula o vacía, no se cambia la fuente del label
            if (!string.IsNullOrEmpty(fuenteFinal) && tamaño > 0)
            {
                try
                {
                    // Muestra la fuente con la familia y tamaño seleccionados en el label
                    richTextBoxResultado.Font = new Font(fuenteFinal, tamaño, richTextBoxResultado.Font.Style);
                }
                catch
                {
                    // Si la fuente no es válida muestra un mensaje
                    MessageBox.Show("La fuente seleccionada no es válida. Por favor, elige otra fuente.", "Error de Fuente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TextBoxEscribeAlgoAqui.ContextMenuStrip = contextMenuStrip1;
        }

        // Evento que detecta cambios seleccionados en el Combo box de familias de fuentes
        private void comboBoxFamiliaFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cambia la fuente del label al seleccionar una familia de fuente
            CambiarFuenteLabel();
        }


        // Evento que detecta cambios en el numericUpDownTamañoFuente y actualiza el tamaño de la fuente del label
        private void numericUpDownTamañoFuente_ValueChanged(object sender, EventArgs e)
        {
            // Asegura que el valor del NumericUpDown y el TrackBar estén sincronizados
            int nuevoTamaño = (int)numericUpDownTamañoFuente.Value;
            // Si el valor del TrackBar no coincide con el nuevo tamaño, lo actualiza
            if (trackBarTamañoFuente.Value != nuevoTamaño)
                trackBarTamañoFuente.Value = nuevoTamaño;
            // Cambia el tamaño de la fuente del label
            CambiarTamañoFuente(nuevoTamaño);
            ActualizarFuenteYEstilo();

        }

        // Evento que detecta cambios en el trackBarTamañoFuente y actualiza el tamaño de la fuente del label
        private void trackBarTamañoFuente_ValueChanged(object sender, EventArgs e)
        {
            // Asegura que el valor del TrackBar y el NumericUpDown estén sincronizados
            int nuevoTamaño = trackBarTamañoFuente.Value;
            // Si el valor del NumericUpDown no coincide con el nuevo tamaño, lo actualiza
            if (numericUpDownTamañoFuente.Value != nuevoTamaño)
                numericUpDownTamañoFuente.Value = nuevoTamaño;
            // Cambia el tamaño de la fuente del label
            CambiarTamañoFuente(nuevoTamaño);
            ActualizarFuenteYEstilo();

        }

        //Metodo para cambiar el tamaño de la fuente del label
        private void CambiarTamañoFuente(int tamaño)
        {
            // Asegura que el tamaño de fuente sea válido antes de aplicarlo
            if (tamaño <= 1) return; // Prevent invalid font size
            // Cambia el tamaño de la fuente del label
            richTextBoxResultado.Font = new Font(richTextBoxResultado.Font.FontFamily, tamaño, richTextBoxResultado.Font.Style);
        }

        // Evento para centrar el texto del label al hacer clic en el checkbox
        private void checkBoxCentradoCentro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCentradoCentro.Checked)
            {

                richTextBoxResultado.SelectionAlignment = HorizontalAlignment.Center;
                checkBoxCentradoIzquierda.Checked = false;
                checkBoxCentradoDerecha.Checked = false;
            }
        }

        private void checkBoxCentradoIzquierda_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCentradoIzquierda.Checked)
            {
                richTextBoxResultado.SelectionAlignment = HorizontalAlignment.Left;
                checkBoxCentradoCentro.Checked = false;
                checkBoxCentradoDerecha.Checked = false;
            }
        }


        private void checkBoxCentradoDerecha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCentradoDerecha.Checked)
            {
                richTextBoxResultado.SelectionAlignment = HorizontalAlignment.Right;
                checkBoxCentradoCentro.Checked = false;
                checkBoxCentradoIzquierda.Checked = false;
            }
        }

        // Este método aplica todos los estilos activos
        public void AplicarEstilos(IEnumerable<CheckBox> estiloCheckBoxes)
        {
            // Si no hay selección, se aplica a la posición del cursor (opcional)
            if (richTextBoxResultado.SelectionLength == 0)
                return;

            // Obtener fuente actual (fallback si SelectionFont es null)
            Font fuenteActual = richTextBoxResultado.SelectionFont ?? richTextBoxResultado.Font;

            // Armar nuevo estilo combinando todos los CheckBox activos
            FontStyle nuevoEstilo = FontStyle.Regular;
            foreach (var check in estiloCheckBoxes)
            {
                if (check.Checked && check.Tag is FontStyle estilo)
                {
                    nuevoEstilo |= estilo;
                }
            }

            // Aplicar estilo a la selección
            try
            {
                richTextBoxResultado.SelectionFont = new Font(fuenteActual.FontFamily, fuenteActual.Size, nuevoEstilo);
            }
            catch
            {
                MessageBox.Show("No se pudo aplicar el estilo seleccionado. Puede que la fuente no soporte ese estilo.", "Error de fuente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        // Evento para aplicar o quitar negrita al texto seleccionado en el TextBox
        private void checkBoxBold_CheckedChanged(object sender, EventArgs e)
        {
            // Asegura que el Tag esté configurado
            checkBoxBold.Tag = FontStyle.Bold;
            checkBoxItalic.Tag = FontStyle.Italic;
            checkBoxUnderline.Tag = FontStyle.Underline;
            AplicarEstilos(new List<CheckBox> { checkBoxBold, checkBoxItalic, checkBoxUnderline });
        }

        // Evento para aplicar o quitar cursiva al texto seleccionado en el TextBox
        private void checkBoxItalic_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxBold.Tag = FontStyle.Bold;
            checkBoxItalic.Tag = FontStyle.Italic;
            checkBoxUnderline.Tag = FontStyle.Underline;
            AplicarEstilos(new List<CheckBox> { checkBoxBold, checkBoxItalic, checkBoxUnderline });
        }

        // Evento para aplicar o quitar subrayado al texto seleccionado en el TextBox
        private void checkBoxUnderline_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxBold.Tag = FontStyle.Bold;
            checkBoxItalic.Tag = FontStyle.Italic;
            checkBoxUnderline.Tag = FontStyle.Underline;
            AplicarEstilos(new List<CheckBox> { checkBoxBold, checkBoxItalic, checkBoxUnderline });
        }

        // Pseudocódigo detallado:
        // 1. Crear un método para obtener el FontStyle actual según los CheckBox de estilo (Bold, Italic, Underline).
        // 2. Crear un método para aplicar el estilo y tamaño a la selección o al texto actual, reutilizable para cambios de fuente/tamaño/estilo.
        // 3. Modificar los eventos de cambio de tamaño y fuente para que mantengan el estilo actual.
        // 4. Simplificar la lógica de los eventos de los CheckBox para que solo llamen al método centralizado.

        private FontStyle ObtenerEstiloActual()
        {
            FontStyle estilo = FontStyle.Regular;
            if (checkBoxBold.Checked) estilo |= FontStyle.Bold;
            if (checkBoxItalic.Checked) estilo |= FontStyle.Italic;
            if (checkBoxUnderline.Checked) estilo |= FontStyle.Underline;
            return estilo;
        }

        private void AplicarFuenteYEstilo(FontFamily familia, float tamaño, FontStyle estilo)
        {
            // Si hay selección, aplica a la selección; si no, aplica al texto actual
            if (richTextBoxResultado.SelectionLength > 0)
            {
                try
                {
                    richTextBoxResultado.SelectionFont = new Font(familia, tamaño, estilo);
                }
                catch
                {
                    MessageBox.Show("No se pudo aplicar el estilo seleccionado. Puede que la fuente no soporte ese estilo.", "Error de fuente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Aplica a todo el texto si no hay selección
                richTextBoxResultado.Font = new Font(familia, tamaño, estilo);
            }
        }

        // Llama este método cada vez que cambie fuente, tamaño o estilo
        private void ActualizarFuenteYEstilo()
        {
            var familia = richTextBoxResultado.SelectionFont?.FontFamily ?? richTextBoxResultado.Font.FontFamily;
            float tamaño = (float)numericUpDownTamañoFuente.Value;
            FontStyle estilo = ObtenerEstiloActual();

            // Si hay selección, intenta mantener la fuente seleccionada en el ComboBox
            if (comboBoxFamiliaFuente.SelectedItem != null)
            {
                try
                {
                    familia = new FontFamily(comboBoxFamiliaFuente.SelectedItem.ToString());
                }
                catch { }
            }
            else if (comboBoxFuente.SelectedItem != null)
            {
                try
                {
                    familia = new FontFamily(comboBoxFuente.SelectedItem.ToString());
                }
                catch { }
            }

            AplicarFuenteYEstilo(familia, tamaño, estilo);
        }

        // Eventos de los CheckBox de estilo
        private void checkBoxBold_CheckedChanged(object sender, EventArgs e) => ActualizarFuenteYEstilo();
        private void checkBoxItalic_CheckedChanged(object sender, EventArgs e) => ActualizarFuenteYEstilo();
        private void checkBoxUnderline_CheckedChanged(object sender, EventArgs e) => ActualizarFuenteYEstilo();

        

        private void comboBoxFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFamiliaFuente.Items.Clear();
            string fuenteSeleccionada = comboBoxFuente.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(fuenteSeleccionada)) return;

            InstalledFontCollection fuentes = new InstalledFontCollection();
            var variantes = fuentes.Families
                .Where(f => f.Name.StartsWith(fuenteSeleccionada, StringComparison.InvariantCultureIgnoreCase))
                .Select(f => f.Name)
                .Distinct()
                .ToList();

            if (variantes.Count > 1)
                foreach (var variante in variantes)
                    comboBoxFamiliaFuente.Items.Add(variante);

            if (comboBoxFamiliaFuente.Items.Count > 0)
                comboBoxFamiliaFuente.SelectedIndex = 0;

            ActualizarFuenteYEstilo();
        }

        private void comboBoxFamiliaFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarFuenteYEstilo();
        }


        // Evento cuando se le haga click en la imagen SeleccionarColorImagen se deberá abrir un cuadro de diálogo para seleccionar un color y cambiarlo en el label
        private void SeleccionarColorImagen_Click(object sender, EventArgs e)
        {
            // Crea un nuevo cuadro de diálogo de selección de color
            using (ColorDialog colorDialog = new ColorDialog())
            {
                // Si el usuario selecciona un color y hace clic en Aceptar
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Cambia el color del texto del label al color seleccionado
                    richTextBoxResultado.ForeColor = colorDialog.Color;
                }
            }
        }

        // campo limpiar todo
        public void limpiarTodo()
        {
                    // Limpia el TextBox, el label y los ComboBoxes
            TextBoxEscribeAlgoAqui.Clear();
            richTextBoxResultado.Text = string.Empty;

            // Restablece la selección de fuente a la primera opción si hay fuentes disponibles
            if (comboBoxFuente.Items.Count > 0)
                comboBoxFuente.SelectedIndex = 0;
            else
                comboBoxFuente.SelectedIndex = -1;

            comboBoxFamiliaFuente.Items.Clear();

            numericUpDownTamañoFuente.Value = 13; // Resetea el tamaño de fuente a 13
            trackBarTamañoFuente.Value = 13; // Resetea el tamaño de fuente del TrackBar a 13

            checkBoxCentradoCentro.Checked = false;
            checkBoxCentradoIzquierda.Checked = true;
            checkBoxCentradoDerecha.Checked = false;
            checkBoxBold.Checked = false;
            checkBoxItalic.Checked = false;
            checkBoxUnderline.Checked = false;
            richTextBoxResultado.ForeColor = Color.Black; // Cambia el color del texto a negro por defecto

            // Coloca el cursor al inicio del TextBox
            TextBoxEscribeAlgoAqui.SelectionStart = 0;
            TextBoxEscribeAlgoAqui.SelectionLength = 0;
            TextBoxEscribeAlgoAqui.Focus();
        }

        // metodo para limpiar todo con el button
        public void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }
        private void limpiarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarTodo();
        }

        private void LogoIspPictureBox_Click(object sender, EventArgs e)
        {
            // Abre el formulario NosotrosViews al hacer clic en el logo
            NosotrosViews nosotrosForm = new NosotrosViews();
            nosotrosForm.ShowDialog();
        }

        


        private void FormatoTextoView_Load(object sender, EventArgs e)
        {
         
        }
    }
}

