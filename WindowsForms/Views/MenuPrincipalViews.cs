using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Views
{
    public partial class MenuPrincipalViews : Form
    {
        public MenuPrincipalViews()
        {
            InitializeComponent();
        }

        private void salirToolStripSubMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void appClima_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClimaAppView climaAppView = new ClimaAppView();
            climaAppView.ShowDialog();
        }

        private void CRUDPeliculasAPI_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeliculasViews peliculasViews = new PeliculasViews();
            peliculasViews.ShowDialog();
        }

        private void CRUDPeliculasADO_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeliculasADOViews peliculasADOViews = new PeliculasADOViews();
            peliculasADOViews.ShowDialog();
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            NosotrosViews nosotrosViews = new NosotrosViews();
            nosotrosViews.ShowDialog();
        }

        private void formularioFuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatoTextoView formatoTextoView = new FormatoTextoView();
            formatoTextoView.ShowDialog();
        }

        private void tareaADOStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockInventarioADOView stockInventarioADOView = new StockInventarioADOView();
            stockInventarioADOView.ShowDialog();
        }

        private void peliculasEntityFrameworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeliculasEFViews peliculasEFViews = new PeliculasEFViews();
            peliculasEFViews.ShowDialog();
        }
    }
}
