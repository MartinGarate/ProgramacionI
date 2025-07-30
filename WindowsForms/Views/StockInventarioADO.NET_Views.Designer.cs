namespace WindowsForms.Views
{
    partial class StockInventarioADOView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInventarioADOView));
            TabControl = new TabControl();
            tabPage_Lista = new TabPage();
            ButtonEliminarProducto = new FontAwesome.Sharp.IconButton();
            ButtonEditar = new FontAwesome.Sharp.IconButton();
            ButtonAgregar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            ButtonBuscar = new FontAwesome.Sharp.IconButton();
            textBoxBuscar = new TextBox();
            pictureBox_Stock = new PictureBox();
            dataGridView_Stock = new DataGridView();
            tabPage_EditarCrear = new TabPage();
            ButtonCancelar = new FontAwesome.Sharp.IconButton();
            ButtonGuardar = new FontAwesome.Sharp.IconButton();
            pictureBoxEditar_Crear = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxUrlImagen = new TextBox();
            textBoxProveedor = new TextBox();
            textBoxPrecio = new TextBox();
            numericUpDown_CantidadStock = new NumericUpDown();
            textBoxNombre = new TextBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            TabControl.SuspendLayout();
            tabPage_Lista.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Stock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Stock).BeginInit();
            tabPage_EditarCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEditar_Crear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_CantidadStock).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage_Lista);
            TabControl.Controls.Add(tabPage_EditarCrear);
            TabControl.Location = new Point(12, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(937, 571);
            TabControl.TabIndex = 0;
            // 
            // tabPage_Lista
            // 
            tabPage_Lista.Controls.Add(ButtonEliminarProducto);
            tabPage_Lista.Controls.Add(ButtonEditar);
            tabPage_Lista.Controls.Add(ButtonAgregar);
            tabPage_Lista.Controls.Add(panel1);
            tabPage_Lista.Controls.Add(ButtonBuscar);
            tabPage_Lista.Controls.Add(textBoxBuscar);
            tabPage_Lista.Controls.Add(pictureBox_Stock);
            tabPage_Lista.Controls.Add(dataGridView_Stock);
            tabPage_Lista.Location = new Point(4, 24);
            tabPage_Lista.Name = "tabPage_Lista";
            tabPage_Lista.Padding = new Padding(3);
            tabPage_Lista.Size = new Size(929, 543);
            tabPage_Lista.TabIndex = 0;
            tabPage_Lista.Text = "Lista";
            tabPage_Lista.UseVisualStyleBackColor = true;
            // 
            // ButtonEliminarProducto
            // 
            ButtonEliminarProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonEliminarProducto.BackColor = Color.FromArgb(242, 242, 242);
            ButtonEliminarProducto.FlatStyle = FlatStyle.Flat;
            ButtonEliminarProducto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonEliminarProducto.ForeColor = Color.FromArgb(64, 64, 64);
            ButtonEliminarProducto.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            ButtonEliminarProducto.IconColor = Color.FromArgb(64, 64, 64);
            ButtonEliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonEliminarProducto.IconSize = 24;
            ButtonEliminarProducto.ImageAlign = ContentAlignment.MiddleRight;
            ButtonEliminarProducto.Location = new Point(778, 476);
            ButtonEliminarProducto.Name = "ButtonEliminarProducto";
            ButtonEliminarProducto.Size = new Size(88, 28);
            ButtonEliminarProducto.TabIndex = 10;
            ButtonEliminarProducto.Text = "Eliminar";
            ButtonEliminarProducto.TextAlign = ContentAlignment.MiddleLeft;
            ButtonEliminarProducto.UseVisualStyleBackColor = false;
            ButtonEliminarProducto.Click += ButtonEliminarProducto_Click;
            // 
            // ButtonEditar
            // 
            ButtonEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonEditar.BackColor = Color.FromArgb(39, 34, 49);
            ButtonEditar.FlatStyle = FlatStyle.Flat;
            ButtonEditar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonEditar.ForeColor = Color.FromArgb(242, 242, 242);
            ButtonEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            ButtonEditar.IconColor = Color.FromArgb(242, 242, 242);
            ButtonEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonEditar.IconSize = 24;
            ButtonEditar.ImageAlign = ContentAlignment.MiddleRight;
            ButtonEditar.Location = new Point(426, 476);
            ButtonEditar.Name = "ButtonEditar";
            ButtonEditar.Size = new Size(88, 28);
            ButtonEditar.TabIndex = 9;
            ButtonEditar.Text = "Editar";
            ButtonEditar.TextAlign = ContentAlignment.MiddleLeft;
            ButtonEditar.UseVisualStyleBackColor = false;
            ButtonEditar.Click += ButtonEditar_Click;
            // 
            // ButtonAgregar
            // 
            ButtonAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonAgregar.BackColor = Color.FromArgb(39, 34, 49);
            ButtonAgregar.FlatStyle = FlatStyle.Flat;
            ButtonAgregar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonAgregar.ForeColor = Color.FromArgb(242, 242, 242);
            ButtonAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            ButtonAgregar.IconColor = Color.FromArgb(242, 242, 242);
            ButtonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonAgregar.IconSize = 24;
            ButtonAgregar.ImageAlign = ContentAlignment.MiddleRight;
            ButtonAgregar.Location = new Point(332, 476);
            ButtonAgregar.Name = "ButtonAgregar";
            ButtonAgregar.Size = new Size(88, 28);
            ButtonAgregar.TabIndex = 8;
            ButtonAgregar.Text = "Agregar";
            ButtonAgregar.TextAlign = ContentAlignment.MiddleLeft;
            ButtonAgregar.UseVisualStyleBackColor = false;
            ButtonAgregar.Click += ButtonAgregar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 34, 49);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 127);
            panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-4, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(602, 127);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // ButtonBuscar
            // 
            ButtonBuscar.BackColor = Color.FromArgb(48, 228, 148);
            ButtonBuscar.FlatStyle = FlatStyle.Popup;
            ButtonBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            ButtonBuscar.IconColor = Color.FromArgb(12, 23, 58);
            ButtonBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonBuscar.IconSize = 18;
            ButtonBuscar.Location = new Point(838, 207);
            ButtonBuscar.Name = "ButtonBuscar";
            ButtonBuscar.Size = new Size(28, 23);
            ButtonBuscar.TabIndex = 3;
            ButtonBuscar.UseVisualStyleBackColor = false;
            ButtonBuscar.Click += ButtonBuscar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(332, 207);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(507, 23);
            textBoxBuscar.TabIndex = 6;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            textBoxBuscar.Enter += textBoxBuscar_Enter;
            // 
            // pictureBox_Stock
            // 
            pictureBox_Stock.Location = new Point(65, 206);
            pictureBox_Stock.Name = "pictureBox_Stock";
            pictureBox_Stock.Size = new Size(261, 264);
            pictureBox_Stock.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Stock.TabIndex = 1;
            pictureBox_Stock.TabStop = false;
            // 
            // dataGridView_Stock
            // 
            dataGridView_Stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_Stock.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_Stock.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView_Stock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Stock.Location = new Point(332, 238);
            dataGridView_Stock.MultiSelect = false;
            dataGridView_Stock.Name = "dataGridView_Stock";
            dataGridView_Stock.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView_Stock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Stock.Size = new Size(534, 232);
            dataGridView_Stock.TabIndex = 0;
            dataGridView_Stock.SelectionChanged += dataGridView_Stock_SelectionChanged;
            // 
            // tabPage_EditarCrear
            // 
            tabPage_EditarCrear.Controls.Add(ButtonCancelar);
            tabPage_EditarCrear.Controls.Add(ButtonGuardar);
            tabPage_EditarCrear.Controls.Add(pictureBoxEditar_Crear);
            tabPage_EditarCrear.Controls.Add(label5);
            tabPage_EditarCrear.Controls.Add(label4);
            tabPage_EditarCrear.Controls.Add(label3);
            tabPage_EditarCrear.Controls.Add(label2);
            tabPage_EditarCrear.Controls.Add(label1);
            tabPage_EditarCrear.Controls.Add(textBoxUrlImagen);
            tabPage_EditarCrear.Controls.Add(textBoxProveedor);
            tabPage_EditarCrear.Controls.Add(textBoxPrecio);
            tabPage_EditarCrear.Controls.Add(numericUpDown_CantidadStock);
            tabPage_EditarCrear.Controls.Add(textBoxNombre);
            tabPage_EditarCrear.Controls.Add(panel2);
            tabPage_EditarCrear.Location = new Point(4, 24);
            tabPage_EditarCrear.Name = "tabPage_EditarCrear";
            tabPage_EditarCrear.Padding = new Padding(3);
            tabPage_EditarCrear.Size = new Size(929, 543);
            tabPage_EditarCrear.TabIndex = 1;
            tabPage_EditarCrear.Text = "Editar/Crear";
            tabPage_EditarCrear.UseVisualStyleBackColor = true;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonCancelar.BackColor = Color.FromArgb(242, 242, 242);
            ButtonCancelar.FlatStyle = FlatStyle.Flat;
            ButtonCancelar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonCancelar.ForeColor = Color.FromArgb(64, 64, 64);
            ButtonCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            ButtonCancelar.IconColor = Color.FromArgb(64, 64, 64);
            ButtonCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonCancelar.IconSize = 24;
            ButtonCancelar.ImageAlign = ContentAlignment.MiddleRight;
            ButtonCancelar.Location = new Point(786, 480);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(93, 28);
            ButtonCancelar.TabIndex = 22;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.TextAlign = ContentAlignment.MiddleLeft;
            ButtonCancelar.UseVisualStyleBackColor = false;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonGuardar
            // 
            ButtonGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonGuardar.BackColor = Color.FromArgb(39, 34, 49);
            ButtonGuardar.FlatStyle = FlatStyle.Flat;
            ButtonGuardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonGuardar.ForeColor = Color.FromArgb(242, 242, 242);
            ButtonGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            ButtonGuardar.IconColor = Color.FromArgb(242, 242, 242);
            ButtonGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonGuardar.IconSize = 24;
            ButtonGuardar.ImageAlign = ContentAlignment.MiddleRight;
            ButtonGuardar.Location = new Point(687, 480);
            ButtonGuardar.Name = "ButtonGuardar";
            ButtonGuardar.Size = new Size(93, 28);
            ButtonGuardar.TabIndex = 21;
            ButtonGuardar.Text = "Guardar";
            ButtonGuardar.TextAlign = ContentAlignment.MiddleLeft;
            ButtonGuardar.UseVisualStyleBackColor = false;
            ButtonGuardar.Click += ButtonGuardar_Click;
            // 
            // pictureBoxEditar_Crear
            // 
            pictureBoxEditar_Crear.Location = new Point(585, 204);
            pictureBoxEditar_Crear.Name = "pictureBoxEditar_Crear";
            pictureBoxEditar_Crear.Size = new Size(294, 270);
            pictureBoxEditar_Crear.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEditar_Crear.TabIndex = 20;
            pictureBoxEditar_Crear.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 342);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 19;
            label5.Text = "Url de Imagen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(99, 313);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 18;
            label4.Text = "Proveedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(137, 284);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 17;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 253);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 16;
            label2.Text = "Cantidad en Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 226);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 15;
            label1.Text = "Nombre";
            // 
            // textBoxUrlImagen
            // 
            textBoxUrlImagen.Location = new Point(211, 347);
            textBoxUrlImagen.Name = "textBoxUrlImagen";
            textBoxUrlImagen.Size = new Size(227, 23);
            textBoxUrlImagen.TabIndex = 14;
            // 
            // textBoxProveedor
            // 
            textBoxProveedor.Location = new Point(211, 315);
            textBoxProveedor.Name = "textBoxProveedor";
            textBoxProveedor.Size = new Size(227, 23);
            textBoxProveedor.TabIndex = 13;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(211, 284);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(227, 23);
            textBoxPrecio.TabIndex = 12;
            // 
            // numericUpDown_CantidadStock
            // 
            numericUpDown_CantidadStock.Location = new Point(211, 255);
            numericUpDown_CantidadStock.Name = "numericUpDown_CantidadStock";
            numericUpDown_CantidadStock.Size = new Size(227, 23);
            numericUpDown_CantidadStock.TabIndex = 11;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(211, 226);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(227, 23);
            textBoxNombre.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 34, 49);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(-1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 127);
            panel2.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-4, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(602, 127);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // StockInventarioADOView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 595);
            Controls.Add(TabControl);
            Name = "StockInventarioADOView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Stock Inventario - CyberBuy";
            TabControl.ResumeLayout(false);
            tabPage_Lista.ResumeLayout(false);
            tabPage_Lista.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Stock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Stock).EndInit();
            tabPage_EditarCrear.ResumeLayout(false);
            tabPage_EditarCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEditar_Crear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_CantidadStock).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage tabPage_Lista;
        private TextBox textBoxBuscar;
        private FontAwesome.Sharp.IconButton ButtonBuscar;
        private PictureBox pictureBox_Stock;
        private DataGridView dataGridView_Stock;
        private TabPage tabPage_EditarCrear;
        private Panel panel1;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton ButtonEliminarProducto;
        private FontAwesome.Sharp.IconButton ButtonEditar;
        private FontAwesome.Sharp.IconButton ButtonAgregar;
        private Label label1;
        private TextBox textBoxUrlImagen;
        private TextBox textBoxProveedor;
        private TextBox textBoxPrecio;
        private NumericUpDown numericUpDown_CantidadStock;
        private TextBox textBoxNombre;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBoxEditar_Crear;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private FontAwesome.Sharp.IconButton ButtonCancelar;
        private FontAwesome.Sharp.IconButton ButtonGuardar;
    }
}