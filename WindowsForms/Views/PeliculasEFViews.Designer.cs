namespace WindowsForms.Views
{
    partial class PeliculasEFViews
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
            dataGridViewFilm = new DataGridView();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            btnBorrar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            pictureBoxFilm = new PictureBox();
            tabControl = new TabControl();
            TabPageLista = new TabPage();
            statusStrip1 = new StatusStrip();
            LabelStatusMessage = new ToolStripStatusLabel();
            iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            textBoxBuscar = new TextBox();
            label1 = new Label();
            tabPageAgregar_Editar = new TabPage();
            iconButtonCancelar = new FontAwesome.Sharp.IconButton();
            iconButtonGuardar = new FontAwesome.Sharp.IconButton();
            numericCalificacion = new NumericUpDown();
            numericDuracion = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            textBoxPortada = new TextBox();
            label3 = new Label();
            textBoxTitulo = new TextBox();
            label2 = new Label();
            LabelPeliculas = new Label();
            panel1 = new Panel();
            TimerStatusBar = new System.Windows.Forms.Timer(components);
            label6 = new Label();
            comboBoxPais = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFilm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilm).BeginInit();
            tabControl.SuspendLayout();
            TabPageLista.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabPageAgregar_Editar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCalificacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDuracion).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewFilm
            // 
            dataGridViewFilm.AllowUserToAddRows = false;
            dataGridViewFilm.AllowUserToDeleteRows = false;
            dataGridViewFilm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewFilm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFilm.BackgroundColor = Color.FromArgb(237, 237, 237);
            dataGridViewFilm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFilm.Location = new Point(22, 66);
            dataGridViewFilm.MultiSelect = false;
            dataGridViewFilm.Name = "dataGridViewFilm";
            dataGridViewFilm.ReadOnly = true;
            dataGridViewFilm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFilm.Size = new Size(713, 314);
            dataGridViewFilm.TabIndex = 0;
            dataGridViewFilm.SelectionChanged += dataGridViewFilm_SelectionChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(30, 386);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Bottom;
            btnBorrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBorrar.IconColor = Color.Black;
            btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrar.Location = new Point(192, 386);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "&Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(111, 386);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.Location = new Point(660, 386);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBoxFilm
            // 
            pictureBoxFilm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxFilm.Location = new Point(741, 66);
            pictureBoxFilm.Name = "pictureBoxFilm";
            pictureBoxFilm.Size = new Size(213, 314);
            pictureBoxFilm.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFilm.TabIndex = 5;
            pictureBoxFilm.TabStop = false;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(TabPageLista);
            tabControl.Controls.Add(tabPageAgregar_Editar);
            tabControl.Location = new Point(-1, 78);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1004, 471);
            tabControl.TabIndex = 6;
            // 
            // TabPageLista
            // 
            TabPageLista.BackColor = Color.FromArgb(237, 237, 237);
            TabPageLista.Controls.Add(statusStrip1);
            TabPageLista.Controls.Add(iconButtonBuscar);
            TabPageLista.Controls.Add(textBoxBuscar);
            TabPageLista.Controls.Add(dataGridViewFilm);
            TabPageLista.Controls.Add(pictureBoxFilm);
            TabPageLista.Controls.Add(btnAgregar);
            TabPageLista.Controls.Add(btnSalir);
            TabPageLista.Controls.Add(btnBorrar);
            TabPageLista.Controls.Add(btnEditar);
            TabPageLista.Controls.Add(label1);
            TabPageLista.Location = new Point(4, 24);
            TabPageLista.Name = "TabPageLista";
            TabPageLista.Padding = new Padding(3);
            TabPageLista.Size = new Size(996, 443);
            TabPageLista.TabIndex = 0;
            TabPageLista.Text = "Lista";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.LightGray;
            statusStrip1.Items.AddRange(new ToolStripItem[] { LabelStatusMessage });
            statusStrip1.Location = new Point(3, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(990, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // LabelStatusMessage
            // 
            LabelStatusMessage.Name = "LabelStatusMessage";
            LabelStatusMessage.Size = new Size(0, 17);
            // 
            // iconButtonBuscar
            // 
            iconButtonBuscar.Anchor = AnchorStyles.Bottom;
            iconButtonBuscar.BackColor = Color.FromArgb(253, 83, 92);
            iconButtonBuscar.FlatStyle = FlatStyle.Flat;
            iconButtonBuscar.ForeColor = Color.FromArgb(253, 83, 92);
            iconButtonBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButtonBuscar.IconColor = Color.FromArgb(41, 32, 35);
            iconButtonBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonBuscar.IconSize = 20;
            iconButtonBuscar.Location = new Point(695, 37);
            iconButtonBuscar.Name = "iconButtonBuscar";
            iconButtonBuscar.Size = new Size(40, 23);
            iconButtonBuscar.TabIndex = 10;
            iconButtonBuscar.UseVisualStyleBackColor = false;
            iconButtonBuscar.Click += iconButtonBuscar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(96, 37);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(600, 23);
            textBoxBuscar.TabIndex = 9;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Plus Jakarta Sans SemiBold", 13F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 32, 35);
            label1.Location = new Point(22, 31);
            label1.Name = "label1";
            label1.Size = new Size(79, 29);
            label1.TabIndex = 8;
            label1.Text = "Buscar:";
            // 
            // tabPageAgregar_Editar
            // 
            tabPageAgregar_Editar.Controls.Add(comboBoxPais);
            tabPageAgregar_Editar.Controls.Add(label6);
            tabPageAgregar_Editar.Controls.Add(iconButtonCancelar);
            tabPageAgregar_Editar.Controls.Add(iconButtonGuardar);
            tabPageAgregar_Editar.Controls.Add(numericCalificacion);
            tabPageAgregar_Editar.Controls.Add(numericDuracion);
            tabPageAgregar_Editar.Controls.Add(label5);
            tabPageAgregar_Editar.Controls.Add(label4);
            tabPageAgregar_Editar.Controls.Add(textBoxPortada);
            tabPageAgregar_Editar.Controls.Add(label3);
            tabPageAgregar_Editar.Controls.Add(textBoxTitulo);
            tabPageAgregar_Editar.Controls.Add(label2);
            tabPageAgregar_Editar.Location = new Point(4, 24);
            tabPageAgregar_Editar.Name = "tabPageAgregar_Editar";
            tabPageAgregar_Editar.Padding = new Padding(3);
            tabPageAgregar_Editar.Size = new Size(996, 443);
            tabPageAgregar_Editar.TabIndex = 1;
            tabPageAgregar_Editar.Text = "Agregar/Editar";
            tabPageAgregar_Editar.UseVisualStyleBackColor = true;
            // 
            // iconButtonCancelar
            // 
            iconButtonCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonCancelar.IconColor = Color.Black;
            iconButtonCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonCancelar.Location = new Point(333, 255);
            iconButtonCancelar.Name = "iconButtonCancelar";
            iconButtonCancelar.Size = new Size(75, 23);
            iconButtonCancelar.TabIndex = 19;
            iconButtonCancelar.Text = "&Cancelar";
            iconButtonCancelar.UseVisualStyleBackColor = true;
            iconButtonCancelar.Click += iconButtonCancelar_Click;
            // 
            // iconButtonGuardar
            // 
            iconButtonGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonGuardar.IconColor = Color.Black;
            iconButtonGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonGuardar.Location = new Point(252, 255);
            iconButtonGuardar.Name = "iconButtonGuardar";
            iconButtonGuardar.Size = new Size(75, 23);
            iconButtonGuardar.TabIndex = 18;
            iconButtonGuardar.Text = "&Guardar";
            iconButtonGuardar.UseVisualStyleBackColor = true;
            iconButtonGuardar.Click += iconButtonGuardar_Click_1;
            // 
            // numericCalificacion
            // 
            numericCalificacion.DecimalPlaces = 2;
            numericCalificacion.Location = new Point(261, 177);
            numericCalificacion.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericCalificacion.Name = "numericCalificacion";
            numericCalificacion.Size = new Size(316, 23);
            numericCalificacion.TabIndex = 17;
            // 
            // numericDuracion
            // 
            numericDuracion.Location = new Point(261, 148);
            numericDuracion.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericDuracion.Name = "numericDuracion";
            numericDuracion.Size = new Size(316, 23);
            numericDuracion.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Plus Jakarta Sans SemiBold", 13F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(41, 32, 35);
            label5.Location = new Point(134, 166);
            label5.Name = "label5";
            label5.Size = new Size(121, 29);
            label5.TabIndex = 15;
            label5.Text = "Calificación:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Plus Jakarta Sans SemiBold", 13F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(41, 32, 35);
            label4.Location = new Point(58, 142);
            label4.Name = "label4";
            label4.Size = new Size(197, 29);
            label4.TabIndex = 13;
            label4.Text = "Duración en minutos:";
            // 
            // textBoxPortada
            // 
            textBoxPortada.Location = new Point(261, 120);
            textBoxPortada.Name = "textBoxPortada";
            textBoxPortada.Size = new Size(316, 23);
            textBoxPortada.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Plus Jakarta Sans SemiBold", 13F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(41, 32, 35);
            label3.Location = new Point(166, 113);
            label3.Name = "label3";
            label3.Size = new Size(89, 29);
            label3.TabIndex = 11;
            label3.Text = "Portada:";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(261, 90);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(316, 23);
            textBoxTitulo.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Plus Jakarta Sans SemiBold", 13F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(41, 32, 35);
            label2.Location = new Point(188, 84);
            label2.Name = "label2";
            label2.Size = new Size(67, 29);
            label2.TabIndex = 9;
            label2.Text = "Titulo:";
            // 
            // LabelPeliculas
            // 
            LabelPeliculas.AutoSize = true;
            LabelPeliculas.Font = new Font("Plus Jakarta Sans ExtraBold", 40F, FontStyle.Bold);
            LabelPeliculas.ForeColor = Color.FromArgb(253, 83, 92);
            LabelPeliculas.Location = new Point(0, 0);
            LabelPeliculas.Name = "LabelPeliculas";
            LabelPeliculas.Size = new Size(271, 89);
            LabelPeliculas.TabIndex = 7;
            LabelPeliculas.Text = "Peliculas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(237, 237, 237);
            panel1.Controls.Add(LabelPeliculas);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1004, 142);
            panel1.TabIndex = 8;
            // 
            // TimerStatusBar
            // 
            TimerStatusBar.Interval = 6000;
            TimerStatusBar.Tick += TimerStatusBar_Tick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Plus Jakarta Sans SemiBold", 13F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(41, 32, 35);
            label6.Location = new Point(202, 200);
            label6.Name = "label6";
            label6.Size = new Size(53, 29);
            label6.TabIndex = 20;
            label6.Text = "País:";
            // 
            // comboBoxPais
            // 
            comboBoxPais.FormattingEnabled = true;
            comboBoxPais.Location = new Point(261, 206);
            comboBoxPais.Name = "comboBoxPais";
            comboBoxPais.Size = new Size(316, 23);
            comboBoxPais.TabIndex = 21;
            // 
            // PeliculasEFViews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 544);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Name = "PeliculasEFViews";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFilm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilm).EndInit();
            tabControl.ResumeLayout(false);
            TabPageLista.ResumeLayout(false);
            TabPageLista.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabPageAgregar_Editar.ResumeLayout(false);
            tabPageAgregar_Editar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericCalificacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDuracion).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewFilm;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private PictureBox pictureBoxFilm;
        private TabControl tabControl;
        private TabPage TabPageLista;
        private TabPage tabPageAgregar_Editar;
        private Label LabelPeliculas;
        private Panel panel1;
        private TextBox textBoxBuscar;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private Label label5;
        private Label label4;
        private TextBox textBoxPortada;
        private Label label3;
        private TextBox textBoxTitulo;
        private Label label2;
        private NumericUpDown numericCalificacion;
        private NumericUpDown numericDuracion;
        private FontAwesome.Sharp.IconButton iconButtonCancelar;
        private FontAwesome.Sharp.IconButton iconButtonGuardar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LabelStatusMessage;
        private System.Windows.Forms.Timer TimerStatusBar;
        private ComboBox comboBoxPais;
        private Label label6;
    }
}