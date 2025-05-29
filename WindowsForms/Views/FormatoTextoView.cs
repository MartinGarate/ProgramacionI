using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Views;

namespace WindowsForms.Views
{
    public partial class FormatoTextoView : Form
    {
        public FormatoTextoView()
        {
            InitializeComponent();
        }

        // Cambiar colores del fondo del botón "btnLimpiarTodo" al hacer hover
        private void btnLimpiarTodo_MouseEnter(object sender, EventArgs e)
        {
            btnLimpiarTodo.BackColor = Color.LightCoral;        
        }

        private void btnLimpiarTodo_MouseLeave(object sender, EventArgs e)
        {
            // Opcional: vuelve a los colores originales
            btnLimpiarTodo.BackColor = SystemColors.Control;
        }
        
    }
}

