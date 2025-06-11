namespace WindowsForms.Views
{
    partial class FormatoTextoView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormatoTextoView));
            LogoIspPictureBox = new PictureBox();
            TextBoxEscribeAlgoAqui = new TextBox();
            trackBarTamañoFuente = new TrackBar();
            numericUpDownTamañoFuente = new NumericUpDown();
            comboBoxFamiliaFuente = new ComboBox();
            comboBoxFuente = new ComboBox();
            checkBoxCentradoCentro = new CheckBox();
            checkBoxCentradoIzquierda = new CheckBox();
            checkBoxCentradoDerecha = new CheckBox();
            colorDialog1 = new ColorDialog();
            SeleccionarColorImagen = new PictureBox();
            btnLimpiarTodo = new Button();
            checkBoxBold = new CheckBox();
            checkBoxItalic = new CheckBox();
            checkBoxUnderline = new CheckBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            limpiarTodoToolStripMenuItem = new ToolStripMenuItem();
            richTextBoxResultado = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)LogoIspPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTamañoFuente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTamañoFuente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SeleccionarColorImagen).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LogoIspPictureBox
            // 
            LogoIspPictureBox.Image = (Image)resources.GetObject("LogoIspPictureBox.Image");
            LogoIspPictureBox.Location = new Point(12, 12);
            LogoIspPictureBox.Name = "LogoIspPictureBox";
            LogoIspPictureBox.Size = new Size(84, 81);
            LogoIspPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoIspPictureBox.TabIndex = 0;
            LogoIspPictureBox.TabStop = false;
            LogoIspPictureBox.Click += LogoIspPictureBox_Click;
            // 
            // TextBoxEscribeAlgoAqui
            // 
            TextBoxEscribeAlgoAqui.BackColor = Color.FromArgb(233, 238, 246);
            TextBoxEscribeAlgoAqui.BorderStyle = BorderStyle.None;
            TextBoxEscribeAlgoAqui.Font = new Font("Segoe UI", 13F);
            TextBoxEscribeAlgoAqui.ForeColor = SystemColors.ActiveCaptionText;
            TextBoxEscribeAlgoAqui.Location = new Point(186, 54);
            TextBoxEscribeAlgoAqui.Multiline = true;
            TextBoxEscribeAlgoAqui.Name = "TextBoxEscribeAlgoAqui";
            TextBoxEscribeAlgoAqui.PlaceholderText = "Escribe algo aqui...";
            TextBoxEscribeAlgoAqui.ScrollBars = ScrollBars.Vertical;
            TextBoxEscribeAlgoAqui.Size = new Size(418, 81);
            TextBoxEscribeAlgoAqui.TabIndex = 1;
            TextBoxEscribeAlgoAqui.TextChanged += TextBoxEscribeAlgoAqui_TextChanged;
            // 
            // trackBarTamañoFuente
            // 
            trackBarTamañoFuente.Location = new Point(255, 170);
            trackBarTamañoFuente.Maximum = 100;
            trackBarTamañoFuente.Minimum = 1;
            trackBarTamañoFuente.Name = "trackBarTamañoFuente";
            trackBarTamañoFuente.Size = new Size(349, 45);
            trackBarTamañoFuente.SmallChange = 5;
            trackBarTamañoFuente.TabIndex = 5;
            trackBarTamañoFuente.Value = 13;
            trackBarTamañoFuente.ValueChanged += trackBarTamañoFuente_ValueChanged;
            // 
            // numericUpDownTamañoFuente
            // 
            numericUpDownTamañoFuente.BackColor = Color.FromArgb(233, 238, 246);
            numericUpDownTamañoFuente.BorderStyle = BorderStyle.None;
            numericUpDownTamañoFuente.Font = new Font("Segoe UI", 11F);
            numericUpDownTamañoFuente.ForeColor = Color.FromArgb(70, 73, 72);
            numericUpDownTamañoFuente.Location = new Point(186, 170);
            numericUpDownTamañoFuente.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownTamañoFuente.Name = "numericUpDownTamañoFuente";
            numericUpDownTamañoFuente.Size = new Size(63, 23);
            numericUpDownTamañoFuente.TabIndex = 4;
            numericUpDownTamañoFuente.Value = new decimal(new int[] { 13, 0, 0, 0 });
            numericUpDownTamañoFuente.ValueChanged += numericUpDownTamañoFuente_ValueChanged;
            // 
            // comboBoxFamiliaFuente
            // 
            comboBoxFamiliaFuente.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxFamiliaFuente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFamiliaFuente.FormattingEnabled = true;
            comboBoxFamiliaFuente.Location = new Point(402, 141);
            comboBoxFamiliaFuente.Name = "comboBoxFamiliaFuente";
            comboBoxFamiliaFuente.Size = new Size(202, 24);
            comboBoxFamiliaFuente.TabIndex = 3;
            comboBoxFamiliaFuente.DrawItem += comboBoxFamiliaFuente_DrawItem;
            comboBoxFamiliaFuente.SelectedIndexChanged += comboBoxFamiliaFuente_SelectedIndexChanged;
            // 
            // comboBoxFuente
            // 
            comboBoxFuente.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxFuente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFuente.FormattingEnabled = true;
            comboBoxFuente.Location = new Point(186, 141);
            comboBoxFuente.Name = "comboBoxFuente";
            comboBoxFuente.Size = new Size(198, 24);
            comboBoxFuente.TabIndex = 2;
            comboBoxFuente.DrawItem += comboBoxFuente_DrawItem;
            comboBoxFuente.SelectedIndexChanged += comboBoxFuente_SelectedIndexChanged;
            // 
            // checkBoxCentradoCentro
            // 
            checkBoxCentradoCentro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxCentradoCentro.Appearance = Appearance.Button;
            checkBoxCentradoCentro.AutoSize = true;
            checkBoxCentradoCentro.BackColor = Color.FromArgb(233, 238, 246);
            checkBoxCentradoCentro.BackgroundImageLayout = ImageLayout.None;
            checkBoxCentradoCentro.FlatAppearance.BorderColor = Color.CornflowerBlue;
            checkBoxCentradoCentro.FlatAppearance.BorderSize = 0;
            checkBoxCentradoCentro.FlatAppearance.CheckedBackColor = Color.Silver;
            checkBoxCentradoCentro.FlatStyle = FlatStyle.Flat;
            checkBoxCentradoCentro.ForeColor = Color.FromArgb(248, 254, 254);
            checkBoxCentradoCentro.Image = (Image)resources.GetObject("checkBoxCentradoCentro.Image");
            checkBoxCentradoCentro.Location = new Point(416, 208);
            checkBoxCentradoCentro.Name = "checkBoxCentradoCentro";
            checkBoxCentradoCentro.Size = new Size(34, 34);
            checkBoxCentradoCentro.TabIndex = 7;
            checkBoxCentradoCentro.UseVisualStyleBackColor = false;
            checkBoxCentradoCentro.CheckedChanged += checkBoxCentradoCentro_CheckedChanged;
            // 
            // checkBoxCentradoIzquierda
            // 
            checkBoxCentradoIzquierda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxCentradoIzquierda.Appearance = Appearance.Button;
            checkBoxCentradoIzquierda.AutoSize = true;
            checkBoxCentradoIzquierda.BackColor = Color.FromArgb(233, 238, 246);
            checkBoxCentradoIzquierda.BackgroundImageLayout = ImageLayout.None;
            checkBoxCentradoIzquierda.Checked = true;
            checkBoxCentradoIzquierda.CheckState = CheckState.Checked;
            checkBoxCentradoIzquierda.FlatAppearance.BorderColor = Color.CornflowerBlue;
            checkBoxCentradoIzquierda.FlatAppearance.BorderSize = 0;
            checkBoxCentradoIzquierda.FlatAppearance.CheckedBackColor = Color.Silver;
            checkBoxCentradoIzquierda.FlatStyle = FlatStyle.Flat;
            checkBoxCentradoIzquierda.ForeColor = Color.FromArgb(248, 254, 254);
            checkBoxCentradoIzquierda.Image = (Image)resources.GetObject("checkBoxCentradoIzquierda.Image");
            checkBoxCentradoIzquierda.Location = new Point(376, 208);
            checkBoxCentradoIzquierda.Name = "checkBoxCentradoIzquierda";
            checkBoxCentradoIzquierda.Size = new Size(34, 34);
            checkBoxCentradoIzquierda.TabIndex = 6;
            checkBoxCentradoIzquierda.UseVisualStyleBackColor = false;
            checkBoxCentradoIzquierda.CheckedChanged += checkBoxCentradoIzquierda_CheckedChanged;
            // 
            // checkBoxCentradoDerecha
            // 
            checkBoxCentradoDerecha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxCentradoDerecha.Appearance = Appearance.Button;
            checkBoxCentradoDerecha.AutoSize = true;
            checkBoxCentradoDerecha.BackColor = Color.FromArgb(233, 238, 246);
            checkBoxCentradoDerecha.BackgroundImageLayout = ImageLayout.None;
            checkBoxCentradoDerecha.FlatAppearance.BorderColor = Color.CornflowerBlue;
            checkBoxCentradoDerecha.FlatAppearance.BorderSize = 0;
            checkBoxCentradoDerecha.FlatAppearance.CheckedBackColor = Color.Silver;
            checkBoxCentradoDerecha.FlatStyle = FlatStyle.Flat;
            checkBoxCentradoDerecha.ForeColor = Color.FromArgb(248, 254, 254);
            checkBoxCentradoDerecha.Image = (Image)resources.GetObject("checkBoxCentradoDerecha.Image");
            checkBoxCentradoDerecha.Location = new Point(456, 208);
            checkBoxCentradoDerecha.Name = "checkBoxCentradoDerecha";
            checkBoxCentradoDerecha.Size = new Size(34, 34);
            checkBoxCentradoDerecha.TabIndex = 8;
            checkBoxCentradoDerecha.UseVisualStyleBackColor = false;
            checkBoxCentradoDerecha.CheckedChanged += checkBoxCentradoDerecha_CheckedChanged;
            // 
            // SeleccionarColorImagen
            // 
            SeleccionarColorImagen.Image = (Image)resources.GetObject("SeleccionarColorImagen.Image");
            SeleccionarColorImagen.Location = new Point(563, 208);
            SeleccionarColorImagen.Name = "SeleccionarColorImagen";
            SeleccionarColorImagen.Size = new Size(41, 34);
            SeleccionarColorImagen.SizeMode = PictureBoxSizeMode.Zoom;
            SeleccionarColorImagen.TabIndex = 15;
            SeleccionarColorImagen.TabStop = false;
            SeleccionarColorImagen.Click += SeleccionarColorImagen_Click;
            // 
            // btnLimpiarTodo
            // 
            btnLimpiarTodo.BackColor = Color.FromArgb(248, 254, 254);
            btnLimpiarTodo.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnLimpiarTodo.FlatStyle = FlatStyle.Flat;
            btnLimpiarTodo.Font = new Font("Segoe UI", 10F);
            btnLimpiarTodo.ForeColor = SystemColors.ControlDarkDark;
            btnLimpiarTodo.Image = (Image)resources.GetObject("btnLimpiarTodo.Image");
            btnLimpiarTodo.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarTodo.Location = new Point(186, 14);
            btnLimpiarTodo.Name = "btnLimpiarTodo";
            btnLimpiarTodo.Size = new Size(114, 34);
            btnLimpiarTodo.TabIndex = 0;
            btnLimpiarTodo.Text = "Limpiar Todo";
            btnLimpiarTodo.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarTodo.UseVisualStyleBackColor = false;
            btnLimpiarTodo.Click += btnLimpiarTodo_Click;
            // 
            // checkBoxBold
            // 
            checkBoxBold.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxBold.Appearance = Appearance.Button;
            checkBoxBold.AutoSize = true;
            checkBoxBold.BackColor = Color.FromArgb(233, 238, 246);
            checkBoxBold.BackgroundImageLayout = ImageLayout.None;
            checkBoxBold.FlatAppearance.BorderColor = Color.CornflowerBlue;
            checkBoxBold.FlatAppearance.BorderSize = 0;
            checkBoxBold.FlatAppearance.CheckedBackColor = Color.Silver;
            checkBoxBold.FlatStyle = FlatStyle.Flat;
            checkBoxBold.ForeColor = Color.FromArgb(248, 254, 254);
            checkBoxBold.Image = (Image)resources.GetObject("checkBoxBold.Image");
            checkBoxBold.Location = new Point(186, 208);
            checkBoxBold.Name = "checkBoxBold";
            checkBoxBold.Size = new Size(34, 34);
            checkBoxBold.TabIndex = 17;
            checkBoxBold.UseVisualStyleBackColor = false;
            checkBoxBold.CheckedChanged += checkBoxBold_CheckedChanged;
            // 
            // checkBoxItalic
            // 
            checkBoxItalic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxItalic.Appearance = Appearance.Button;
            checkBoxItalic.AutoSize = true;
            checkBoxItalic.BackColor = Color.FromArgb(233, 238, 246);
            checkBoxItalic.BackgroundImageLayout = ImageLayout.None;
            checkBoxItalic.FlatAppearance.BorderColor = Color.CornflowerBlue;
            checkBoxItalic.FlatAppearance.BorderSize = 0;
            checkBoxItalic.FlatAppearance.CheckedBackColor = Color.Silver;
            checkBoxItalic.FlatStyle = FlatStyle.Flat;
            checkBoxItalic.ForeColor = Color.FromArgb(248, 254, 254);
            checkBoxItalic.Image = (Image)resources.GetObject("checkBoxItalic.Image");
            checkBoxItalic.Location = new Point(226, 208);
            checkBoxItalic.Name = "checkBoxItalic";
            checkBoxItalic.Size = new Size(34, 34);
            checkBoxItalic.TabIndex = 18;
            checkBoxItalic.UseVisualStyleBackColor = false;
            checkBoxItalic.CheckedChanged += checkBoxItalic_CheckedChanged;
            // 
            // checkBoxUnderline
            // 
            checkBoxUnderline.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxUnderline.Appearance = Appearance.Button;
            checkBoxUnderline.AutoSize = true;
            checkBoxUnderline.BackColor = Color.FromArgb(233, 238, 246);
            checkBoxUnderline.BackgroundImageLayout = ImageLayout.None;
            checkBoxUnderline.FlatAppearance.BorderColor = Color.CornflowerBlue;
            checkBoxUnderline.FlatAppearance.BorderSize = 0;
            checkBoxUnderline.FlatAppearance.CheckedBackColor = Color.Silver;
            checkBoxUnderline.FlatStyle = FlatStyle.Flat;
            checkBoxUnderline.ForeColor = Color.FromArgb(248, 254, 254);
            checkBoxUnderline.Image = (Image)resources.GetObject("checkBoxUnderline.Image");
            checkBoxUnderline.Location = new Point(266, 208);
            checkBoxUnderline.Name = "checkBoxUnderline";
            checkBoxUnderline.Size = new Size(34, 34);
            checkBoxUnderline.TabIndex = 19;
            checkBoxUnderline.UseVisualStyleBackColor = false;
            checkBoxUnderline.CheckedChanged += checkBoxUnderline_CheckedChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { limpiarTodoToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(143, 26);
            // 
            // limpiarTodoToolStripMenuItem
            // 
            limpiarTodoToolStripMenuItem.Name = "limpiarTodoToolStripMenuItem";
            limpiarTodoToolStripMenuItem.Size = new Size(142, 22);
            limpiarTodoToolStripMenuItem.Text = "Limpiar todo";
            limpiarTodoToolStripMenuItem.Click += limpiarTodoToolStripMenuItem_Click;
            // 
            // richTextBoxResultado
            // 
            richTextBoxResultado.BackColor = Color.FromArgb(233, 238, 246);
            richTextBoxResultado.BorderStyle = BorderStyle.None;
            richTextBoxResultado.Font = new Font("Segoe UI", 13F);
            richTextBoxResultado.Location = new Point(186, 248);
            richTextBoxResultado.Name = "richTextBoxResultado";
            richTextBoxResultado.ReadOnly = true;
            richTextBoxResultado.Size = new Size(418, 101);
            richTextBoxResultado.TabIndex = 20;
            richTextBoxResultado.Text = "";
            // 
            // FormatoTextoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 254, 254);
            ClientSize = new Size(749, 356);
            Controls.Add(richTextBoxResultado);
            Controls.Add(checkBoxUnderline);
            Controls.Add(checkBoxItalic);
            Controls.Add(checkBoxBold);
            Controls.Add(btnLimpiarTodo);
            Controls.Add(SeleccionarColorImagen);
            Controls.Add(checkBoxCentradoDerecha);
            Controls.Add(checkBoxCentradoIzquierda);
            Controls.Add(checkBoxCentradoCentro);
            Controls.Add(comboBoxFuente);
            Controls.Add(comboBoxFamiliaFuente);
            Controls.Add(numericUpDownTamañoFuente);
            Controls.Add(trackBarTamañoFuente);
            Controls.Add(TextBoxEscribeAlgoAqui);
            Controls.Add(LogoIspPictureBox);
            ForeColor = SystemColors.ControlDark;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormatoTextoView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formato Texto";
            Load += FormatoTextoView_Load;
            ((System.ComponentModel.ISupportInitialize)LogoIspPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTamañoFuente).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTamañoFuente).EndInit();
            ((System.ComponentModel.ISupportInitialize)SeleccionarColorImagen).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LogoIspPictureBox;
        private TextBox TextBoxEscribeAlgoAqui;
        private TrackBar trackBarTamañoFuente;
        private NumericUpDown numericUpDownTamañoFuente;
        private ComboBox comboBoxFamiliaFuente;
        private ComboBox comboBoxFuente;
        private CheckBox checkBoxCentradoCentro;
        private CheckBox checkBoxCentradoIzquierda;
        private CheckBox checkBoxCentradoDerecha;
        private ColorDialog colorDialog1;
        private PictureBox SeleccionarColorImagen;
        private Button btnLimpiarTodo;
        private CheckBox checkBoxBold;
        private CheckBox checkBoxItalic;
        private CheckBox checkBoxUnderline;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem limpiarTodoToolStripMenuItem;
        private RichTextBox richTextBoxResultado;
    }
}