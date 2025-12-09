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
            pnelppaltitulo = new Panel();
            lblTituloGR = new Label();
            btnSalir = new Button();
            btnVolver = new Button();
            btnNuevoProducto = new Button();
            btnModificarProducto = new Button();
            btnEliminarProducto = new Button();
            btnBuscarProducto = new Button();
            pnelppalmedio = new Panel();
            tlpDatos = new TableLayoutPanel();
            grbGrillaClientes = new GroupBox();
            btnRefrescar = new Button();
            dgvProductos = new DataGridView();
            grbManejoDatos = new GroupBox();
            tlpIngreso = new TableLayoutPanel();
            label1 = new Label();
            nudPrecio = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            txtDescripcion = new TextBox();
            lblDireccion = new Label();
            txtNombre = new TextBox();
            cmbCategoria = new ComboBox();
            btnLimpiarCampos = new Button();
            tlpBuscar = new TableLayoutPanel();
            cmbProducto = new ComboBox();
            lblId = new Label();
            btnBuscar = new Button();
            tlpBotones = new TableLayoutPanel();
            pnelppaltitulo.SuspendLayout();
            pnelppalmedio.SuspendLayout();
            tlpDatos.SuspendLayout();
            grbGrillaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            grbManejoDatos.SuspendLayout();
            tlpIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            tlpBuscar.SuspendLayout();
            tlpBotones.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppaltitulo
            // 
            pnelppaltitulo.BackColor = Color.DarkSlateGray;
            pnelppaltitulo.Controls.Add(lblTituloGR);
            pnelppaltitulo.Controls.Add(btnSalir);
            pnelppaltitulo.Controls.Add(btnVolver);
            pnelppaltitulo.Dock = DockStyle.Top;
            pnelppaltitulo.Location = new Point(0, 0);
            pnelppaltitulo.Margin = new Padding(2);
            pnelppaltitulo.Name = "pnelppaltitulo";
            pnelppaltitulo.Size = new Size(1354, 80);
            pnelppaltitulo.TabIndex = 14;
            // 
            // lblTituloGR
            // 
            lblTituloGR.Anchor = AnchorStyles.Top;
            lblTituloGR.AutoSize = true;
            lblTituloGR.BackColor = Color.Transparent;
            lblTituloGR.Font = new Font("Calibri", 28F, FontStyle.Bold);
            lblTituloGR.ForeColor = Color.White;
            lblTituloGR.Location = new Point(440, 10);
            lblTituloGR.Margin = new Padding(2, 0, 2, 0);
            lblTituloGR.Name = "lblTituloGR";
            lblTituloGR.Size = new Size(538, 68);
            lblTituloGR.TabIndex = 12;
            lblTituloGR.Text = "Gestión de Productos:";
            lblTituloGR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(1264, 0);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 80);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "❌";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnVolver
            // 
            btnVolver.Dock = DockStyle.Left;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Calibri", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(0, 0);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(90, 80);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "↩️";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Dock = DockStyle.Fill;
            btnNuevoProducto.FlatAppearance.BorderSize = 0;
            btnNuevoProducto.FlatStyle = FlatStyle.Flat;
            btnNuevoProducto.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoProducto.ForeColor = Color.DarkSlateGray;
            btnNuevoProducto.Location = new Point(5, 5);
            btnNuevoProducto.Margin = new Padding(2);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(330, 90);
            btnNuevoProducto.TabIndex = 4;
            btnNuevoProducto.Text = "Agregar ➕";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Dock = DockStyle.Fill;
            btnModificarProducto.FlatAppearance.BorderSize = 0;
            btnModificarProducto.FlatStyle = FlatStyle.Flat;
            btnModificarProducto.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarProducto.ForeColor = Color.DarkSlateGray;
            btnModificarProducto.Location = new Point(342, 5);
            btnModificarProducto.Margin = new Padding(2);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(330, 90);
            btnModificarProducto.TabIndex = 5;
            btnModificarProducto.Text = "Modificar 🛠️";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Dock = DockStyle.Fill;
            btnEliminarProducto.FlatAppearance.BorderSize = 0;
            btnEliminarProducto.FlatStyle = FlatStyle.Flat;
            btnEliminarProducto.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarProducto.ForeColor = Color.DarkSlateGray;
            btnEliminarProducto.Location = new Point(679, 5);
            btnEliminarProducto.Margin = new Padding(2);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(330, 90);
            btnEliminarProducto.TabIndex = 6;
            btnEliminarProducto.Text = "Eliminar 🗑️";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Dock = DockStyle.Fill;
            btnBuscarProducto.FlatAppearance.BorderSize = 0;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarProducto.ForeColor = Color.DarkSlateGray;
            btnBuscarProducto.Location = new Point(1016, 5);
            btnBuscarProducto.Margin = new Padding(2);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(333, 90);
            btnBuscarProducto.TabIndex = 10;
            btnBuscarProducto.Text = "Buscar 🔍";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.AppWorkspace;
            pnelppalmedio.Controls.Add(tlpDatos);
            pnelppalmedio.Controls.Add(tlpBotones);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(0, 80);
            pnelppalmedio.Margin = new Padding(2);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1354, 617);
            pnelppalmedio.TabIndex = 15;
            // 
            // tlpDatos
            // 
            tlpDatos.ColumnCount = 2;
            tlpDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpDatos.Controls.Add(grbGrillaClientes, 1, 0);
            tlpDatos.Controls.Add(grbManejoDatos, 0, 0);
            tlpDatos.Dock = DockStyle.Fill;
            tlpDatos.Location = new Point(0, 100);
            tlpDatos.Margin = new Padding(2);
            tlpDatos.Name = "tlpDatos";
            tlpDatos.RowCount = 1;
            tlpDatos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDatos.Size = new Size(1354, 517);
            tlpDatos.TabIndex = 25;
            // 
            // grbGrillaClientes
            // 
            grbGrillaClientes.BackgroundImageLayout = ImageLayout.None;
            grbGrillaClientes.Controls.Add(btnRefrescar);
            grbGrillaClientes.Controls.Add(dgvProductos);
            grbGrillaClientes.Dock = DockStyle.Fill;
            grbGrillaClientes.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbGrillaClientes.ForeColor = Color.DarkSlateGray;
            grbGrillaClientes.Location = new Point(611, 2);
            grbGrillaClientes.Margin = new Padding(2);
            grbGrillaClientes.Name = "grbGrillaClientes";
            grbGrillaClientes.Padding = new Padding(2);
            grbGrillaClientes.Size = new Size(741, 513);
            grbGrillaClientes.TabIndex = 18;
            grbGrillaClientes.TabStop = false;
            grbGrillaClientes.Text = "Grilla de Productos";
            // 
            // btnRefrescar
            // 
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Calibri", 16F, FontStyle.Bold);
            btnRefrescar.Location = new Point(698, -5);
            btnRefrescar.Margin = new Padding(2);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(40, 42);
            btnRefrescar.TabIndex = 4;
            btnRefrescar.Text = "🔄";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
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
            dataGridViewCellStyle1.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.Location = new Point(2, 37);
            dgvProductos.Margin = new Padding(0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(737, 474);
            dgvProductos.TabIndex = 1;
            // 
            // grbManejoDatos
            // 
            grbManejoDatos.Controls.Add(tlpIngreso);
            grbManejoDatos.Controls.Add(btnLimpiarCampos);
            grbManejoDatos.Controls.Add(tlpBuscar);
            grbManejoDatos.Controls.Add(btnBuscar);
            grbManejoDatos.Dock = DockStyle.Fill;
            grbManejoDatos.Location = new Point(2, 2);
            grbManejoDatos.Margin = new Padding(2);
            grbManejoDatos.Name = "grbManejoDatos";
            grbManejoDatos.Padding = new Padding(2);
            grbManejoDatos.Size = new Size(605, 513);
            grbManejoDatos.TabIndex = 0;
            grbManejoDatos.TabStop = false;
            // 
            // tlpIngreso
            // 
            tlpIngreso.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpIngreso.ColumnCount = 2;
            tlpIngreso.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpIngreso.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpIngreso.Controls.Add(label1, 0, 3);
            tlpIngreso.Controls.Add(nudPrecio, 1, 2);
            tlpIngreso.Controls.Add(label2, 0, 2);
            tlpIngreso.Controls.Add(label3, 0, 0);
            tlpIngreso.Controls.Add(txtDescripcion, 1, 1);
            tlpIngreso.Controls.Add(lblDireccion, 0, 1);
            tlpIngreso.Controls.Add(txtNombre, 1, 0);
            tlpIngreso.Controls.Add(cmbCategoria, 1, 3);
            tlpIngreso.Dock = DockStyle.Top;
            tlpIngreso.Location = new Point(2, 91);
            tlpIngreso.Margin = new Padding(2);
            tlpIngreso.Name = "tlpIngreso";
            tlpIngreso.RowCount = 4;
            tlpIngreso.RowStyles.Add(new RowStyle(SizeType.Percent, 22.7639179F));
            tlpIngreso.RowStyles.Add(new RowStyle(SizeType.Percent, 31.7082462F));
            tlpIngreso.RowStyles.Add(new RowStyle(SizeType.Percent, 22.7639179F));
            tlpIngreso.RowStyles.Add(new RowStyle(SizeType.Percent, 22.7639179F));
            tlpIngreso.Size = new Size(601, 293);
            tlpIngreso.TabIndex = 28;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(5, 240);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(292, 35);
            label1.TabIndex = 33;
            label1.Text = "Categoría:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudPrecio
            // 
            nudPrecio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudPrecio.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudPrecio.Location = new Point(306, 170);
            nudPrecio.Margin = new Padding(4);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(288, 42);
            nudPrecio.TabIndex = 32;
            nudPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(5, 174);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(292, 35);
            label2.TabIndex = 19;
            label2.Text = "Precio";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(5, 17);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(292, 35);
            label3.TabIndex = 6;
            label3.Text = "Nombre del Producto:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(306, 73);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(288, 80);
            txtDescripcion.TabIndex = 17;
            txtDescripcion.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.ForeColor = Color.DarkSlateGray;
            lblDireccion.Location = new Point(5, 95);
            lblDireccion.Margin = new Padding(2, 0, 2, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(292, 35);
            lblDireccion.TabIndex = 18;
            lblDireccion.Text = "Descripción:";
            lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(306, 13);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(288, 42);
            txtNombre.TabIndex = 0;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbCategoria.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(306, 236);
            cmbCategoria.Margin = new Padding(4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(288, 43);
            cmbCategoria.TabIndex = 34;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = Color.DarkSlateGray;
            btnLimpiarCampos.Cursor = Cursors.Hand;
            btnLimpiarCampos.Dock = DockStyle.Top;
            btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            btnLimpiarCampos.FlatStyle = FlatStyle.Flat;
            btnLimpiarCampos.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarCampos.ForeColor = Color.White;
            btnLimpiarCampos.Location = new Point(2, 26);
            btnLimpiarCampos.Margin = new Padding(0);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(601, 65);
            btnLimpiarCampos.TabIndex = 27;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click_1;
            // 
            // tlpBuscar
            // 
            tlpBuscar.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpBuscar.ColumnCount = 2;
            tlpBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBuscar.Controls.Add(cmbProducto, 1, 0);
            tlpBuscar.Controls.Add(lblId, 0, 0);
            tlpBuscar.Dock = DockStyle.Bottom;
            tlpBuscar.Enabled = false;
            tlpBuscar.Location = new Point(2, 381);
            tlpBuscar.Margin = new Padding(2);
            tlpBuscar.Name = "tlpBuscar";
            tlpBuscar.RowCount = 1;
            tlpBuscar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBuscar.Size = new Size(601, 65);
            tlpBuscar.TabIndex = 26;
            // 
            // cmbProducto
            // 
            cmbProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbProducto.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(306, 11);
            cmbProducto.Margin = new Padding(4);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(288, 43);
            cmbProducto.TabIndex = 22;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.DarkSlateGray;
            lblId.Location = new Point(5, 15);
            lblId.Margin = new Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(292, 35);
            lblId.TabIndex = 18;
            lblId.Text = "Producto Buscado:";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkSlateGray;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Dock = DockStyle.Bottom;
            btnBuscar.Enabled = false;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(2, 446);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(601, 65);
            btnBuscar.TabIndex = 25;
            btnBuscar.Text = "Buscar Cliente";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // tlpBotones
            // 
            tlpBotones.BackColor = Color.PaleTurquoise;
            tlpBotones.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpBotones.ColumnCount = 4;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotones.Controls.Add(btnNuevoProducto, 0, 0);
            tlpBotones.Controls.Add(btnBuscarProducto, 3, 0);
            tlpBotones.Controls.Add(btnModificarProducto, 1, 0);
            tlpBotones.Controls.Add(btnEliminarProducto, 2, 0);
            tlpBotones.Dock = DockStyle.Top;
            tlpBotones.Location = new Point(0, 0);
            tlpBotones.Margin = new Padding(2);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 1;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotones.Size = new Size(1354, 100);
            tlpBotones.TabIndex = 24;
            // 
            // Ventana_Gestion_Productos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 697);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            MaximumSize = new Size(1376, 753);
            MinimumSize = new Size(1376, 753);
            Name = "Ventana_Gestion_Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            Load += Ventana_Gestion_Productos_Load;
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            pnelppalmedio.ResumeLayout(false);
            tlpDatos.ResumeLayout(false);
            grbGrillaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            grbManejoDatos.ResumeLayout(false);
            tlpIngreso.ResumeLayout(false);
            tlpIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            tlpBuscar.ResumeLayout(false);
            tlpBuscar.PerformLayout();
            tlpBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnelppaltitulo;
        private Button btnNuevoProducto;
        private Button btnModificarProducto;
        private GroupBox grbIngresoDatos;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private Button btnLimpiarCampos;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblProducto;
        private Button btnEliminarProducto;
        private Button btnSalir;
        private Button btnVolver;
        private Button btnBuscarProducto;
        private Panel pnelppalmedio;
        private Label lblTituloGR;
        private TableLayoutPanel tlpBotones;
        private TableLayoutPanel tlpDatos;
        private GroupBox grbManejoDatos;
        private GroupBox grbGrillaClientes;
        private DataGridView dgvProductos;
        private TableLayoutPanel tlpBuscar;
        private Label lblId;
        private TextBox textBox1;
        private Button button2;
        private TableLayoutPanel tlpIngreso;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private Label lblDireccion;
        private TextBox textBox2;
        private TableLayoutPanel tlpTipoCliente;
        private RadioButton rdbMinorista;
        private RadioButton rdbMayorista;
        private Button btnBuscar;
        private Label label1;
        private NumericUpDown nudPrecio;
        private ComboBox cmbCategoria;
        private Button btnRefrescar;
        private ComboBox cmbProducto;
    }
}