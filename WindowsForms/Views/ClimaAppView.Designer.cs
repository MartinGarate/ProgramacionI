namespace WindowsForms
{
    partial class ClimaAppView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClimaAppView));
            labelTituloApp = new Label();
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            NosotrosIconMenu = new FontAwesome.Sharp.IconMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirDeLaAppToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            NostrosIcon = new FontAwesome.Sharp.IconToolStripButton();
            IconSalir = new FontAwesome.Sharp.IconToolStripButton();
            pictureBox1 = new PictureBox();
            buttonObtenerClima = new Button();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTituloApp
            // 
            labelTituloApp.AutoSize = true;
            labelTituloApp.Font = new Font("Plus Jakarta Sans Light", 10F);
            labelTituloApp.Location = new Point(174, 340);
            labelTituloApp.Name = "labelTituloApp";
            labelTituloApp.Size = new Size(272, 23);
            labelTituloApp.TabIndex = 0;
            labelTituloApp.Text = "App Del Clima - ISP N°20 - 2Do año TSDS";
            labelTituloApp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(623, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { NosotrosIconMenu });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(87, 20);
            iconMenuItem1.Text = "Acerca de";
            // 
            // NosotrosIconMenu
            // 
            NosotrosIconMenu.IconChar = FontAwesome.Sharp.IconChar.None;
            NosotrosIconMenu.IconColor = Color.Black;
            NosotrosIconMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            NosotrosIconMenu.Name = "NosotrosIconMenu";
            NosotrosIconMenu.Size = new Size(164, 22);
            NosotrosIconMenu.Text = "Quienes somos...";
            NosotrosIconMenu.Click += NosotrosIconMenu_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDeLaAppToolStripMenuItem });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDeLaAppToolStripMenuItem
            // 
            salirDeLaAppToolStripMenuItem.Name = "salirDeLaAppToolStripMenuItem";
            salirDeLaAppToolStripMenuItem.Size = new Size(147, 22);
            salirDeLaAppToolStripMenuItem.Text = "Salir de la app";
            salirDeLaAppToolStripMenuItem.Click += salirDeLaAppToolStripMenuItem_Click_1;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { NostrosIcon, IconSalir });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(623, 37);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // NostrosIcon
            // 
            NostrosIcon.DisplayStyle = ToolStripItemDisplayStyle.Image;
            NostrosIcon.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            NostrosIcon.IconColor = Color.Black;
            NostrosIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            NostrosIcon.IconSize = 30;
            NostrosIcon.ImageScaling = ToolStripItemImageScaling.None;
            NostrosIcon.ImageTransparentColor = Color.Magenta;
            NostrosIcon.Name = "NostrosIcon";
            NostrosIcon.Size = new Size(34, 34);
            NostrosIcon.Text = "iconToolStripButton1";
            NostrosIcon.Click += NostrosIcon_Click;
            // 
            // IconSalir
            // 
            IconSalir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            IconSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            IconSalir.IconColor = Color.Black;
            IconSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconSalir.IconSize = 30;
            IconSalir.ImageScaling = ToolStripItemImageScaling.None;
            IconSalir.ImageTransparentColor = Color.Magenta;
            IconSalir.Name = "IconSalir";
            IconSalir.Size = new Size(34, 34);
            IconSalir.Text = "iconToolStripButton2";
            IconSalir.Click += IconSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(253, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // buttonObtenerClima
            // 
            buttonObtenerClima.Location = new Point(244, 201);
            buttonObtenerClima.Name = "buttonObtenerClima";
            buttonObtenerClima.Size = new Size(125, 23);
            buttonObtenerClima.TabIndex = 4;
            buttonObtenerClima.Text = "Obtener Clima";
            buttonObtenerClima.UseVisualStyleBackColor = true;
            buttonObtenerClima.Click += buttonObtenerClima_Click;
            // 
            // ClimaAppView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 372);
            Controls.Add(buttonObtenerClima);
            Controls.Add(labelTituloApp);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ClimaAppView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClimaAppView";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTituloApp;
        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem NosotrosIconMenu;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirDeLaAppToolStripMenuItem;
        private FontAwesome.Sharp.IconToolStripButton NostrosIcon;
        private FontAwesome.Sharp.IconToolStripButton IconSalir;
        private PictureBox pictureBox1;
        private Button buttonObtenerClima;
    }
}