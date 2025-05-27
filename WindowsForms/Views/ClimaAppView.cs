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

namespace WindowsForms
{
    public partial class ClimaAppView : Form
    {
        public ClimaAppView()
        {
            InitializeComponent();
        }


        private void salirDeLaAppToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void IconSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NostrosIcon_Click(object sender, EventArgs e)
        {
            NosotrosViews nosotrosView = new NosotrosViews();
            nosotrosView.ShowDialog();
        }

        private void NosotrosIconMenu_Click(object sender, EventArgs e)
        {
            NostrosIcon_Click(sender, e);
        }
    }
}
