namespace WindowsForms.Views
{
    partial class PeliculasViews
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
            dataGridViewFilm = new DataGridView();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            btnBorrar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            pictureBoxFilm = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFilm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilm).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFilm
            // 
            dataGridViewFilm.AllowUserToAddRows = false;
            dataGridViewFilm.AllowUserToDeleteRows = false;
            dataGridViewFilm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewFilm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFilm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFilm.Location = new Point(12, 12);
            dataGridViewFilm.MultiSelect = false;
            dataGridViewFilm.Name = "dataGridViewFilm";
            dataGridViewFilm.ReadOnly = true;
            dataGridViewFilm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFilm.Size = new Size(568, 277);
            dataGridViewFilm.TabIndex = 0;
            dataGridViewFilm.SelectionChanged += dataGridViewFilm_SelectionChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(12, 324);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Bottom;
            btnBorrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBorrar.IconColor = Color.Black;
            btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrar.Location = new Point(174, 324);
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
            btnEditar.Location = new Point(93, 324);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.Location = new Point(724, 324);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFilm
            // 
            pictureBoxFilm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxFilm.Location = new Point(586, 12);
            pictureBoxFilm.Name = "pictureBoxFilm";
            pictureBoxFilm.Size = new Size(213, 277);
            pictureBoxFilm.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFilm.TabIndex = 5;
            pictureBoxFilm.TabStop = false;
            // 
            // PeliculasViews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 359);
            Controls.Add(pictureBoxFilm);
            Controls.Add(btnSalir);
            Controls.Add(btnEditar);
            Controls.Add(btnBorrar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridViewFilm);
            Name = "PeliculasViews";
            Text = "PeliculasViews";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFilm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewFilm;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private PictureBox pictureBoxFilm;
    }
}