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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormatoTextoView));
            pictureBox1 = new PictureBox();
            TextBoxEscribeAlgoAqui = new TextBox();
            trackBarTamañoFuente = new TrackBar();
            numericUpDownTamañoFuente = new NumericUpDown();
            comboBoxFamiliaFuente = new ComboBox();
            comboBoxFuente = new ComboBox();
            checkBoxCentradoCentro = new CheckBox();
            checkBoxCentradoIzquierda = new CheckBox();
            checkBoxCentradoDerecha = new CheckBox();
            btnBold = new Button();
            btnItalic = new Button();
            btnUnderline = new Button();
            colorDialog1 = new ColorDialog();
            SeleccionarColorImagen = new PictureBox();
            labelResultado = new Label();
            btnLimpiarTodo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTamañoFuente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTamañoFuente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SeleccionarColorImagen).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TextBoxEscribeAlgoAqui
            // 
            TextBoxEscribeAlgoAqui.BackColor = Color.FromArgb(233, 238, 246);
            TextBoxEscribeAlgoAqui.BorderStyle = BorderStyle.None;
            TextBoxEscribeAlgoAqui.Font = new Font("Segoe UI", 13F);
            TextBoxEscribeAlgoAqui.ForeColor = SystemColors.ControlDark;
            TextBoxEscribeAlgoAqui.Location = new Point(186, 54);
            TextBoxEscribeAlgoAqui.Multiline = true;
            TextBoxEscribeAlgoAqui.Name = "TextBoxEscribeAlgoAqui";
            TextBoxEscribeAlgoAqui.PlaceholderText = "Escribe algo aqui...";
            TextBoxEscribeAlgoAqui.ScrollBars = ScrollBars.Vertical;
            TextBoxEscribeAlgoAqui.Size = new Size(418, 81);
            TextBoxEscribeAlgoAqui.TabIndex = 1;
            // 
            // trackBarTamañoFuente
            // 
            trackBarTamañoFuente.Location = new Point(255, 170);
            trackBarTamañoFuente.Name = "trackBarTamañoFuente";
            trackBarTamañoFuente.Size = new Size(349, 45);
            trackBarTamañoFuente.TabIndex = 5;
            // 
            // numericUpDownTamañoFuente
            // 
            numericUpDownTamañoFuente.BackColor = Color.FromArgb(233, 238, 246);
            numericUpDownTamañoFuente.BorderStyle = BorderStyle.None;
            numericUpDownTamañoFuente.Font = new Font("Segoe UI", 11F);
            numericUpDownTamañoFuente.ForeColor = Color.FromArgb(70, 73, 72);
            numericUpDownTamañoFuente.Location = new Point(186, 170);
            numericUpDownTamañoFuente.Name = "numericUpDownTamañoFuente";
            numericUpDownTamañoFuente.Size = new Size(63, 23);
            numericUpDownTamañoFuente.TabIndex = 4;
            // 
            // comboBoxFamiliaFuente
            // 
            comboBoxFamiliaFuente.FormattingEnabled = true;
            comboBoxFamiliaFuente.Location = new Point(402, 141);
            comboBoxFamiliaFuente.Name = "comboBoxFamiliaFuente";
            comboBoxFamiliaFuente.Size = new Size(202, 23);
            comboBoxFamiliaFuente.TabIndex = 3;
            // 
            // comboBoxFuente
            // 
            comboBoxFuente.FormattingEnabled = true;
            comboBoxFuente.Location = new Point(186, 141);
            comboBoxFuente.Name = "comboBoxFuente";
            comboBoxFuente.Size = new Size(198, 23);
            comboBoxFuente.TabIndex = 2;
            // 
            // checkBoxCentradoCentro
            // 
            checkBoxCentradoCentro.Appearance = Appearance.Button;
            checkBoxCentradoCentro.AutoSize = true;
            checkBoxCentradoCentro.BackColor = Color.FromArgb(233, 238, 246);
            checkBoxCentradoCentro.FlatStyle = FlatStyle.Flat;
            checkBoxCentradoCentro.ForeColor = Color.FromArgb(248, 254, 254);
            checkBoxCentradoCentro.Image = (Image)resources.GetObject("checkBoxCentradoCentro.Image");
            checkBoxCentradoCentro.Location = new Point(226, 208);
            checkBoxCentradoCentro.Name = "checkBoxCentradoCentro";
            checkBoxCentradoCentro.Size = new Size(34, 34);
            checkBoxCentradoCentro.TabIndex = 7;
            checkBoxCentradoCentro.UseVisualStyleBackColor = false;
            // 
            // checkBoxCentradoIzquierda
            // 
            checkBoxCentradoIzquierda.Appearance = Appearance.Button;
            checkBoxCentradoIzquierda.AutoSize = true;
            checkBoxCentradoIzquierda.BackColor = Color.FromArgb(233, 238, 246);
            checkBoxCentradoIzquierda.BackgroundImageLayout = ImageLayout.None;
            checkBoxCentradoIzquierda.FlatStyle = FlatStyle.Flat;
            checkBoxCentradoIzquierda.ForeColor = Color.FromArgb(248, 254, 254);
            checkBoxCentradoIzquierda.Image = (Image)resources.GetObject("checkBoxCentradoIzquierda.Image");
            checkBoxCentradoIzquierda.Location = new Point(186, 208);
            checkBoxCentradoIzquierda.Name = "checkBoxCentradoIzquierda";
            checkBoxCentradoIzquierda.Size = new Size(34, 34);
            checkBoxCentradoIzquierda.TabIndex = 6;
            checkBoxCentradoIzquierda.UseVisualStyleBackColor = false;
            // 
            // checkBoxCentradoDerecha
            // 
            checkBoxCentradoDerecha.Appearance = Appearance.Button;
            checkBoxCentradoDerecha.AutoSize = true;
            checkBoxCentradoDerecha.BackColor = Color.FromArgb(233, 238, 246);
            checkBoxCentradoDerecha.FlatStyle = FlatStyle.Flat;
            checkBoxCentradoDerecha.ForeColor = Color.FromArgb(248, 254, 254);
            checkBoxCentradoDerecha.Image = (Image)resources.GetObject("checkBoxCentradoDerecha.Image");
            checkBoxCentradoDerecha.Location = new Point(266, 208);
            checkBoxCentradoDerecha.Name = "checkBoxCentradoDerecha";
            checkBoxCentradoDerecha.Size = new Size(34, 34);
            checkBoxCentradoDerecha.TabIndex = 8;
            checkBoxCentradoDerecha.UseVisualStyleBackColor = false;
            // 
            // btnBold
            // 
            btnBold.BackColor = Color.FromArgb(233, 238, 246);
            btnBold.FlatStyle = FlatStyle.Flat;
            btnBold.ForeColor = Color.FromArgb(248, 254, 254);
            btnBold.Image = (Image)resources.GetObject("btnBold.Image");
            btnBold.Location = new Point(324, 208);
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(38, 34);
            btnBold.TabIndex = 9;
            btnBold.UseVisualStyleBackColor = false;
            // 
            // btnItalic
            // 
            btnItalic.BackColor = Color.FromArgb(233, 238, 246);
            btnItalic.FlatStyle = FlatStyle.Flat;
            btnItalic.ForeColor = Color.FromArgb(248, 254, 254);
            btnItalic.Image = (Image)resources.GetObject("btnItalic.Image");
            btnItalic.Location = new Point(368, 208);
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(38, 34);
            btnItalic.TabIndex = 10;
            btnItalic.UseVisualStyleBackColor = false;
            // 
            // btnUnderline
            // 
            btnUnderline.BackColor = Color.FromArgb(233, 238, 246);
            btnUnderline.FlatStyle = FlatStyle.Flat;
            btnUnderline.ForeColor = Color.FromArgb(248, 254, 254);
            btnUnderline.Image = (Image)resources.GetObject("btnUnderline.Image");
            btnUnderline.Location = new Point(412, 208);
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(38, 34);
            btnUnderline.TabIndex = 11;
            btnUnderline.UseVisualStyleBackColor = false;
            // 
            // SeleccionarColorImagen
            // 
            SeleccionarColorImagen.Image = (Image)resources.GetObject("SeleccionarColorImagen.Image");
            SeleccionarColorImagen.Location = new Point(471, 208);
            SeleccionarColorImagen.Name = "SeleccionarColorImagen";
            SeleccionarColorImagen.Size = new Size(41, 34);
            SeleccionarColorImagen.SizeMode = PictureBoxSizeMode.Zoom;
            SeleccionarColorImagen.TabIndex = 15;
            SeleccionarColorImagen.TabStop = false;
            // 
            // labelResultado
            // 
            labelResultado.FlatStyle = FlatStyle.Flat;
            labelResultado.Location = new Point(12, 264);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(725, 113);
            labelResultado.TabIndex = 16;
            // 
            // btnLimpiarTodo
            // 
            btnLimpiarTodo.BackColor = Color.FromArgb(248, 254, 254);
            btnLimpiarTodo.FlatAppearance.BorderColor = Color.FromArgb(233, 238, 246);
            btnLimpiarTodo.FlatStyle = FlatStyle.Flat;
            btnLimpiarTodo.Font = new Font("Segoe UI", 10F);
            btnLimpiarTodo.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiarTodo.Image = (Image)resources.GetObject("btnLimpiarTodo.Image");
            btnLimpiarTodo.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarTodo.Location = new Point(186, 14);
            btnLimpiarTodo.Name = "btnLimpiarTodo";
            btnLimpiarTodo.Size = new Size(114, 34);
            btnLimpiarTodo.TabIndex = 0;
            btnLimpiarTodo.Text = "Limpiar Todo";
            btnLimpiarTodo.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiarTodo.UseVisualStyleBackColor = false;
            btnLimpiarTodo.MouseEnter += btnLimpiarTodo_MouseEnter;
            btnLimpiarTodo.MouseLeave += btnLimpiarTodo_MouseLeave;
            // 
            // FormatoTextoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 254, 254);
            ClientSize = new Size(749, 386);
            Controls.Add(btnLimpiarTodo);
            Controls.Add(labelResultado);
            Controls.Add(SeleccionarColorImagen);
            Controls.Add(btnUnderline);
            Controls.Add(btnItalic);
            Controls.Add(btnBold);
            Controls.Add(checkBoxCentradoDerecha);
            Controls.Add(checkBoxCentradoIzquierda);
            Controls.Add(checkBoxCentradoCentro);
            Controls.Add(comboBoxFuente);
            Controls.Add(comboBoxFamiliaFuente);
            Controls.Add(numericUpDownTamañoFuente);
            Controls.Add(trackBarTamañoFuente);
            Controls.Add(TextBoxEscribeAlgoAqui);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormatoTextoView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formato Texto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTamañoFuente).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTamañoFuente).EndInit();
            ((System.ComponentModel.ISupportInitialize)SeleccionarColorImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox TextBoxEscribeAlgoAqui;
        private TrackBar trackBarTamañoFuente;
        private NumericUpDown numericUpDownTamañoFuente;
        private ComboBox comboBoxFamiliaFuente;
        private ComboBox comboBoxFuente;
        private CheckBox checkBoxCentradoCentro;
        private CheckBox checkBoxCentradoIzquierda;
        private CheckBox checkBoxCentradoDerecha;
        private Button btnBold;
        private Button btnItalic;
        private Button btnUnderline;
        private ColorDialog colorDialog1;
        private PictureBox SeleccionarColorImagen;
        private Label labelResultado;
        private Button btnLimpiarTodo;
    }
}