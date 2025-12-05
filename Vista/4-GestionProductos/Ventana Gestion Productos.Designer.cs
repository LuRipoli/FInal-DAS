namespace Vista
{
    partial class Ventana_Gestion_Productos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnelppalmedio = new Panel();
            grbBuscarProducto = new GroupBox();
            btnBuscar = new Button();
            lblNombreProducto = new Label();
            txtNombreBuscado = new TextBox();
            grbGrillaClientes = new GroupBox();
            dgvProductos = new DataGridView();
            grbIngresoDatos = new GroupBox();
            nudPrecio = new NumericUpDown();
            label1 = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            btnLimpiarCampos = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            cmbCategoria = new ComboBox();
            lblProducto = new Label();
            pnelppaltitulo = new Panel();
            lblTituloPrograma = new Label();
            pnelppalbotones = new Panel();
            btnBuscarProducto = new Button();
            btnVolver = new Button();
            btnSalir = new Button();
            btnEliminarProducto = new Button();
            btnModificarProducto = new Button();
            btnNuevoProducto = new Button();
            pnelppalmedio.SuspendLayout();
            grbBuscarProducto.SuspendLayout();
            grbGrillaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            grbIngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            pnelppaltitulo.SuspendLayout();
            pnelppalbotones.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.ActiveCaption;
            pnelppalmedio.Controls.Add(grbBuscarProducto);
            pnelppalmedio.Controls.Add(grbGrillaClientes);
            pnelppalmedio.Controls.Add(grbIngresoDatos);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(301, 150);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1353, 743);
            pnelppalmedio.TabIndex = 15;
            // 
            // grbBuscarProducto
            // 
            grbBuscarProducto.Controls.Add(btnBuscar);
            grbBuscarProducto.Controls.Add(lblNombreProducto);
            grbBuscarProducto.Controls.Add(txtNombreBuscado);
            grbBuscarProducto.Enabled = false;
            grbBuscarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbBuscarProducto.Location = new Point(44, 506);
            grbBuscarProducto.Name = "grbBuscarProducto";
            grbBuscarProducto.Size = new Size(406, 203);
            grbBuscarProducto.TabIndex = 19;
            grbBuscarProducto.TabStop = false;
            grbBuscarProducto.Text = "Buscar Producto";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.HighlightText;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(125, 118);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 65);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombreProducto.Location = new Point(101, 37);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(200, 25);
            lblNombreProducto.TabIndex = 18;
            lblNombreProducto.Text = "Nombre del Producto:";
            lblNombreProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombreBuscado
            // 
            txtNombreBuscado.Font = new Font("Segoe UI", 9F);
            txtNombreBuscado.Location = new Point(61, 73);
            txtNombreBuscado.Name = "txtNombreBuscado";
            txtNombreBuscado.Size = new Size(274, 31);
            txtNombreBuscado.TabIndex = 17;
            // 
            // grbGrillaClientes
            // 
            grbGrillaClientes.BackgroundImageLayout = ImageLayout.None;
            grbGrillaClientes.Controls.Add(dgvProductos);
            grbGrillaClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbGrillaClientes.Location = new Point(483, 25);
            grbGrillaClientes.Name = "grbGrillaClientes";
            grbGrillaClientes.Size = new Size(819, 684);
            grbGrillaClientes.TabIndex = 18;
            grbGrillaClientes.TabStop = false;
            grbGrillaClientes.Text = "Grilla de Productos";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = SystemColors.GrayText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.Location = new Point(3, 27);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(813, 654);
            dgvProductos.TabIndex = 1;
            // 
            // grbIngresoDatos
            // 
            grbIngresoDatos.Controls.Add(nudPrecio);
            grbIngresoDatos.Controls.Add(label1);
            grbIngresoDatos.Controls.Add(txtDescripcion);
            grbIngresoDatos.Controls.Add(lblDescripcion);
            grbIngresoDatos.Controls.Add(btnLimpiarCampos);
            grbIngresoDatos.Controls.Add(lblNombre);
            grbIngresoDatos.Controls.Add(txtNombre);
            grbIngresoDatos.Controls.Add(cmbCategoria);
            grbIngresoDatos.Controls.Add(lblProducto);
            grbIngresoDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbIngresoDatos.Location = new Point(44, 25);
            grbIngresoDatos.Name = "grbIngresoDatos";
            grbIngresoDatos.Size = new Size(406, 475);
            grbIngresoDatos.TabIndex = 17;
            grbIngresoDatos.TabStop = false;
            grbIngresoDatos.Text = "Ingreso de Datos";
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(42, 346);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(320, 31);
            nudPrecio.TabIndex = 31;
            nudPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(161, 313);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 30;
            label1.Text = "Precio:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 9F);
            txtDescripcion.Location = new Point(42, 221);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(320, 88);
            txtDescripcion.TabIndex = 27;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescripcion.Location = new Point(139, 187);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(116, 25);
            lblDescripcion.TabIndex = 28;
            lblDescripcion.Text = "Descripción:";
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = SystemColors.HighlightText;
            btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            btnLimpiarCampos.FlatStyle = FlatStyle.Flat;
            btnLimpiarCampos.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarCampos.Location = new Point(126, 39);
            btnLimpiarCampos.Margin = new Padding(2);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(146, 65);
            btnLimpiarCampos.TabIndex = 26;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(103, 116);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(200, 25);
            lblNombre.TabIndex = 25;
            lblNombre.Text = "Nombre del Producto:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(42, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 31);
            txtNombre.TabIndex = 24;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(42, 408);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(320, 33);
            cmbCategoria.TabIndex = 23;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProducto.Location = new Point(147, 380);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(99, 25);
            lblProducto.TabIndex = 22;
            lblProducto.Text = "Categoria:";
            lblProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnelppaltitulo
            // 
            pnelppaltitulo.BackColor = SystemColors.ControlLightLight;
            pnelppaltitulo.Controls.Add(lblTituloPrograma);
            pnelppaltitulo.Dock = DockStyle.Top;
            pnelppaltitulo.Location = new Point(301, 0);
            pnelppaltitulo.Name = "pnelppaltitulo";
            pnelppaltitulo.Size = new Size(1353, 150);
            pnelppaltitulo.TabIndex = 14;
            // 
            // lblTituloPrograma
            // 
            lblTituloPrograma.AutoSize = true;
            lblTituloPrograma.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloPrograma.Location = new Point(457, 50);
            lblTituloPrograma.Name = "lblTituloPrograma";
            lblTituloPrograma.Size = new Size(426, 54);
            lblTituloPrograma.TabIndex = 0;
            lblTituloPrograma.Text = "Gestión de Productos";
            lblTituloPrograma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnelppalbotones
            // 
            pnelppalbotones.BackColor = SystemColors.GrayText;
            pnelppalbotones.Controls.Add(btnBuscarProducto);
            pnelppalbotones.Controls.Add(btnVolver);
            pnelppalbotones.Controls.Add(btnSalir);
            pnelppalbotones.Controls.Add(btnEliminarProducto);
            pnelppalbotones.Controls.Add(btnModificarProducto);
            pnelppalbotones.Controls.Add(btnNuevoProducto);
            pnelppalbotones.Dock = DockStyle.Left;
            pnelppalbotones.Location = new Point(0, 0);
            pnelppalbotones.Name = "pnelppalbotones";
            pnelppalbotones.Size = new Size(301, 893);
            pnelppalbotones.TabIndex = 13;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarProducto.Location = new Point(46, 522);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(206, 70);
            btnBuscarProducto.TabIndex = 10;
            btnBuscarProducto.Text = "Buscar Producto";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.Location = new Point(46, 608);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(206, 70);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(46, 697);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(206, 70);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir del Programa";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarProducto.Location = new Point(46, 433);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(206, 70);
            btnEliminarProducto.TabIndex = 6;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificarProducto.Location = new Point(46, 345);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(206, 70);
            btnModificarProducto.TabIndex = 5;
            btnModificarProducto.Text = "Modificar Producto";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevoProducto.Location = new Point(46, 260);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(206, 70);
            btnNuevoProducto.TabIndex = 4;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // Ventana_Gestion_Productos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1654, 893);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            Controls.Add(pnelppalbotones);
            Name = "Ventana_Gestion_Productos";
            Text = "Ventana_Gestion_Productos";
            Load += Ventana_Gestion_Productos_Load;
            pnelppalmedio.ResumeLayout(false);
            grbBuscarProducto.ResumeLayout(false);
            grbBuscarProducto.PerformLayout();
            grbGrillaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            grbIngresoDatos.ResumeLayout(false);
            grbIngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            pnelppalbotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private GroupBox grbBuscarProducto;
        private Button btnBuscar;
        private Label lblNombreProducto;
        private TextBox txtNombreBuscado;
        private GroupBox grbGrillaClientes;
        private DataGridView dgvProductos;
        private GroupBox grbIngresoDatos;
        private Panel pnelppaltitulo;
        private Label lblTituloPrograma;
        private Panel pnelppalbotones;
        private Button btnBuscarProducto;
        private Button btnVolver;
        private Button btnSalir;
        private Button btnEliminarProducto;
        private Button btnModificarProducto;
        private Button btnNuevoProducto;
        private ComboBox cmbCategoria;
        private Label lblProducto;
        private Label label1;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private Button btnLimpiarCampos;
        private Label lblNombre;
        private TextBox txtNombre;
        private NumericUpDown nudPrecio;
    }
}