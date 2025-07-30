namespace WindowsForms.Views
{
    partial class MenuPrincipalViews
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            iconMenuItem_Principal = new FontAwesome.Sharp.IconMenuItem();
            Proyectos_ToolStripSubMenu = new FontAwesome.Sharp.IconMenuItem();
            appClima_ToolStripMenuItem = new ToolStripMenuItem();
            CRUDPeliculasAPI_ToolStripMenuItem = new ToolStripMenuItem();
            CRUDPeliculasADO_ToolStripMenuItem = new ToolStripMenuItem();
            tareasToolStripMenuItem = new ToolStripMenuItem();
            formularioFuentesToolStripMenuItem = new ToolStripMenuItem();
            tareaADOStockToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripSubMenu = new ToolStripMenuItem();
            peliculasEntityFrameworkToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem_Principal });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem_Principal
            // 
            iconMenuItem_Principal.DropDownItems.AddRange(new ToolStripItem[] { Proyectos_ToolStripSubMenu, tareasToolStripMenuItem, toolStripSeparator2, iconMenuItem1, toolStripSeparator1, salirToolStripSubMenu });
            iconMenuItem_Principal.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem_Principal.IconColor = Color.Black;
            iconMenuItem_Principal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem_Principal.Name = "iconMenuItem_Principal";
            iconMenuItem_Principal.Size = new Size(81, 20);
            iconMenuItem_Principal.Text = "Principal";
            // 
            // Proyectos_ToolStripSubMenu
            // 
            Proyectos_ToolStripSubMenu.DropDownItems.AddRange(new ToolStripItem[] { appClima_ToolStripMenuItem, CRUDPeliculasAPI_ToolStripMenuItem, CRUDPeliculasADO_ToolStripMenuItem, peliculasEntityFrameworkToolStripMenuItem });
            Proyectos_ToolStripSubMenu.IconChar = FontAwesome.Sharp.IconChar.None;
            Proyectos_ToolStripSubMenu.IconColor = Color.Black;
            Proyectos_ToolStripSubMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Proyectos_ToolStripSubMenu.Name = "Proyectos_ToolStripSubMenu";
            Proyectos_ToolStripSubMenu.Size = new Size(180, 22);
            Proyectos_ToolStripSubMenu.Text = "Proyectos";
            // 
            // appClima_ToolStripMenuItem
            // 
            appClima_ToolStripMenuItem.Name = "appClima_ToolStripMenuItem";
            appClima_ToolStripMenuItem.Size = new Size(217, 22);
            appClima_ToolStripMenuItem.Text = "App Clima";
            appClima_ToolStripMenuItem.Click += appClima_ToolStripMenuItem_Click;
            // 
            // CRUDPeliculasAPI_ToolStripMenuItem
            // 
            CRUDPeliculasAPI_ToolStripMenuItem.Name = "CRUDPeliculasAPI_ToolStripMenuItem";
            CRUDPeliculasAPI_ToolStripMenuItem.Size = new Size(217, 22);
            CRUDPeliculasAPI_ToolStripMenuItem.Text = "CRUD Peliculas (API)";
            CRUDPeliculasAPI_ToolStripMenuItem.Click += CRUDPeliculasAPI_ToolStripMenuItem_Click;
            // 
            // CRUDPeliculasADO_ToolStripMenuItem
            // 
            CRUDPeliculasADO_ToolStripMenuItem.Name = "CRUDPeliculasADO_ToolStripMenuItem";
            CRUDPeliculasADO_ToolStripMenuItem.Size = new Size(217, 22);
            CRUDPeliculasADO_ToolStripMenuItem.Text = "CRUD Peliculas (ADO .NET)";
            CRUDPeliculasADO_ToolStripMenuItem.Click += CRUDPeliculasADO_ToolStripMenuItem_Click;
            // 
            // tareasToolStripMenuItem
            // 
            tareasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formularioFuentesToolStripMenuItem, tareaADOStockToolStripMenuItem });
            tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            tareasToolStripMenuItem.Size = new Size(180, 22);
            tareasToolStripMenuItem.Text = "Tareas...";
            // 
            // formularioFuentesToolStripMenuItem
            // 
            formularioFuentesToolStripMenuItem.Name = "formularioFuentesToolStripMenuItem";
            formularioFuentesToolStripMenuItem.Size = new Size(176, 22);
            formularioFuentesToolStripMenuItem.Text = "Formulario Fuentes";
            formularioFuentesToolStripMenuItem.Click += formularioFuentesToolStripMenuItem_Click;
            // 
            // tareaADOStockToolStripMenuItem
            // 
            tareaADOStockToolStripMenuItem.Name = "tareaADOStockToolStripMenuItem";
            tareaADOStockToolStripMenuItem.Size = new Size(176, 22);
            tareaADOStockToolStripMenuItem.Text = "Tarea ADO Stock";
            tareaADOStockToolStripMenuItem.Click += tareaADOStockToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(180, 22);
            iconMenuItem1.Text = "Acerca de";
            iconMenuItem1.Click += iconMenuItem1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // salirToolStripSubMenu
            // 
            salirToolStripSubMenu.Name = "salirToolStripSubMenu";
            salirToolStripSubMenu.Size = new Size(180, 22);
            salirToolStripSubMenu.Text = "Salir";
            salirToolStripSubMenu.Click += salirToolStripSubMenu_Click;
            // 
            // peliculasEntityFrameworkToolStripMenuItem
            // 
            peliculasEntityFrameworkToolStripMenuItem.Name = "peliculasEntityFrameworkToolStripMenuItem";
            peliculasEntityFrameworkToolStripMenuItem.Size = new Size(217, 22);
            peliculasEntityFrameworkToolStripMenuItem.Text = "Peliculas Entity Framework";
            peliculasEntityFrameworkToolStripMenuItem.Click += peliculasEntityFrameworkToolStripMenuItem_Click;
            // 
            // MenuPrincipalViews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "MenuPrincipalViews";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prueba varias en Programacion I";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem_Principal;
        private ToolStripMenuItem salirToolStripSubMenu;
        private FontAwesome.Sharp.IconMenuItem Proyectos_ToolStripSubMenu;
        private ToolStripMenuItem tareasToolStripMenuItem;
        private ToolStripMenuItem formularioFuentesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem appClima_ToolStripMenuItem;
        private ToolStripMenuItem CRUDPeliculasAPI_ToolStripMenuItem;
        private ToolStripMenuItem CRUDPeliculasADO_ToolStripMenuItem;
        private ToolStripMenuItem tareaADOStockToolStripMenuItem;
        private ToolStripMenuItem peliculasEntityFrameworkToolStripMenuItem;
    }
}