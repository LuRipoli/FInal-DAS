namespace Vista
{
    partial class Ventana_Gestion_Sucursales
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnelppalmedio = new Panel();
            tlpDivision = new TableLayoutPanel();
            grbGrillaSucursales = new GroupBox();
            dgvSucursales = new DataGridView();
            grbManejodeDatos = new GroupBox();
            grbIngresoDatos = new GroupBox();
            tlpIngreso = new TableLayoutPanel();
            lblNombre = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtNombre = new TextBox();
            btnLimpiarCampos = new Button();
            grbBuscarCategoria = new GroupBox();
            tlpBuscar = new TableLayoutPanel();
            lblId = new Label();
            txtNombreBuscado = new TextBox();
            btnBuscar = new Button();
            tlpBotones = new TableLayoutPanel();
            btnBuscarSucursal = new Button();
            btnEliminarSucursal = new Button();
            btnModificarSucursal = new Button();
            btnAgregarSucursal = new Button();
            pnelppaltitulo = new Panel();
            lblTituloGR = new Label();
            btnVolver = new Button();
            btnSalir = new Button();
            pnelppalmedio.SuspendLayout();
            tlpDivision.SuspendLayout();
            grbGrillaSucursales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            grbManejodeDatos.SuspendLayout();
            grbIngresoDatos.SuspendLayout();
            tlpIngreso.SuspendLayout();
            grbBuscarCategoria.SuspendLayout();
            tlpBuscar.SuspendLayout();
            tlpBotones.SuspendLayout();
            pnelppaltitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.ActiveCaption;
            pnelppalmedio.Controls.Add(tlpDivision);
            pnelppalmedio.Controls.Add(tlpBotones);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(0, 80);
            pnelppalmedio.Margin = new Padding(2);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1229, 679);
            pnelppalmedio.TabIndex = 18;
            // 
            // tlpDivision
            // 
            tlpDivision.BackColor = SystemColors.AppWorkspace;
            tlpDivision.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpDivision.ColumnCount = 2;
            tlpDivision.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpDivision.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpDivision.Controls.Add(grbGrillaSucursales, 1, 0);
            tlpDivision.Controls.Add(grbManejodeDatos, 0, 0);
            tlpDivision.Dock = DockStyle.Fill;
            tlpDivision.Location = new Point(0, 152);
            tlpDivision.Name = "tlpDivision";
            tlpDivision.RowCount = 1;
            tlpDivision.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDivision.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDivision.Size = new Size(1229, 527);
            tlpDivision.TabIndex = 21;
            // 
            // grbGrillaSucursales
            // 
            grbGrillaSucursales.BackgroundImageLayout = ImageLayout.None;
            grbGrillaSucursales.Controls.Add(dgvSucursales);
            grbGrillaSucursales.Dock = DockStyle.Fill;
            grbGrillaSucursales.FlatStyle = FlatStyle.Flat;
            grbGrillaSucursales.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbGrillaSucursales.ForeColor = Color.DarkSlateGray;
            grbGrillaSucursales.Location = new Point(626, 13);
            grbGrillaSucursales.Margin = new Padding(10);
            grbGrillaSucursales.Name = "grbGrillaSucursales";
            grbGrillaSucursales.Size = new Size(590, 501);
            grbGrillaSucursales.TabIndex = 18;
            grbGrillaSucursales.TabStop = false;
            grbGrillaSucursales.Text = "Grilla de Sucursales";
            // 
            // dgvSucursales
            // 
            dgvSucursales.AllowUserToAddRows = false;
            dgvSucursales.AllowUserToDeleteRows = false;
            dgvSucursales.AllowUserToResizeColumns = false;
            dgvSucursales.AllowUserToResizeRows = false;
            dgvSucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSucursales.BackgroundColor = SystemColors.GrayText;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvSucursales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvSucursales.DefaultCellStyle = dataGridViewCellStyle5;
            dgvSucursales.Dock = DockStyle.Fill;
            dgvSucursales.Location = new Point(3, 38);
            dgvSucursales.Margin = new Padding(20);
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvSucursales.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvSucursales.RowHeadersVisible = false;
            dgvSucursales.RowHeadersWidth = 62;
            dgvSucursales.Size = new Size(584, 460);
            dgvSucursales.TabIndex = 1;
            // 
            // grbManejodeDatos
            // 
            grbManejodeDatos.Controls.Add(grbIngresoDatos);
            grbManejodeDatos.Controls.Add(grbBuscarCategoria);
            grbManejodeDatos.Dock = DockStyle.Fill;
            grbManejodeDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbManejodeDatos.Location = new Point(13, 13);
            grbManejodeDatos.Margin = new Padding(10);
            grbManejodeDatos.Name = "grbManejodeDatos";
            grbManejodeDatos.Padding = new Padding(0);
            grbManejodeDatos.Size = new Size(590, 501);
            grbManejodeDatos.TabIndex = 17;
            grbManejodeDatos.TabStop = false;
            // 
            // grbIngresoDatos
            // 
            grbIngresoDatos.Controls.Add(tlpIngreso);
            grbIngresoDatos.Controls.Add(btnLimpiarCampos);
            grbIngresoDatos.Dock = DockStyle.Top;
            grbIngresoDatos.FlatStyle = FlatStyle.Flat;
            grbIngresoDatos.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbIngresoDatos.ForeColor = Color.DarkSlateGray;
            grbIngresoDatos.Location = new Point(0, 24);
            grbIngresoDatos.Name = "grbIngresoDatos";
            grbIngresoDatos.Padding = new Padding(0);
            grbIngresoDatos.Size = new Size(590, 278);
            grbIngresoDatos.TabIndex = 21;
            grbIngresoDatos.TabStop = false;
            grbIngresoDatos.Text = "Ingreso de Datos";
            // 
            // tlpIngreso
            // 
            tlpIngreso.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpIngreso.ColumnCount = 2;
            tlpIngreso.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpIngreso.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpIngreso.Controls.Add(lblNombre, 0, 0);
            tlpIngreso.Controls.Add(txtDireccion, 1, 1);
            tlpIngreso.Controls.Add(lblDireccion, 0, 1);
            tlpIngreso.Controls.Add(txtNombre, 1, 0);
            tlpIngreso.Dock = DockStyle.Fill;
            tlpIngreso.Location = new Point(0, 100);
            tlpIngreso.Name = "tlpIngreso";
            tlpIngreso.RowCount = 2;
            tlpIngreso.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpIngreso.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpIngreso.Size = new Size(590, 178);
            tlpIngreso.TabIndex = 19;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(6, 27);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(284, 35);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre de Sucursal:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDireccion.Font = new Font("Segoe UI", 12F);
            txtDireccion.Location = new Point(304, 113);
            txtDireccion.Margin = new Padding(8);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(275, 39);
            txtDireccion.TabIndex = 17;
            txtDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(6, 115);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(284, 35);
            lblDireccion.TabIndex = 18;
            lblDireccion.Text = "Dirección:";
            lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(304, 25);
            txtNombre.Margin = new Padding(8);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(275, 39);
            txtNombre.TabIndex = 0;
            txtNombre.TextAlign = HorizontalAlignment.Center;
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
            btnLimpiarCampos.Location = new Point(0, 35);
            btnLimpiarCampos.Margin = new Padding(0);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(590, 65);
            btnLimpiarCampos.TabIndex = 16;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // grbBuscarCategoria
            // 
            grbBuscarCategoria.Controls.Add(tlpBuscar);
            grbBuscarCategoria.Controls.Add(btnBuscar);
            grbBuscarCategoria.Dock = DockStyle.Bottom;
            grbBuscarCategoria.Enabled = false;
            grbBuscarCategoria.FlatStyle = FlatStyle.Flat;
            grbBuscarCategoria.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbBuscarCategoria.ForeColor = Color.DarkSlateGray;
            grbBuscarCategoria.Location = new Point(0, 298);
            grbBuscarCategoria.Name = "grbBuscarCategoria";
            grbBuscarCategoria.Padding = new Padding(10);
            grbBuscarCategoria.Size = new Size(590, 203);
            grbBuscarCategoria.TabIndex = 20;
            grbBuscarCategoria.TabStop = false;
            grbBuscarCategoria.Text = "Buscar Sucursal";
            // 
            // tlpBuscar
            // 
            tlpBuscar.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpBuscar.ColumnCount = 2;
            tlpBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBuscar.Controls.Add(lblId, 0, 0);
            tlpBuscar.Controls.Add(txtNombreBuscado, 1, 0);
            tlpBuscar.Dock = DockStyle.Fill;
            tlpBuscar.Location = new Point(10, 45);
            tlpBuscar.Name = "tlpBuscar";
            tlpBuscar.RowCount = 1;
            tlpBuscar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBuscar.Size = new Size(570, 83);
            tlpBuscar.TabIndex = 20;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(6, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(274, 35);
            lblId.TabIndex = 18;
            lblId.Text = "Nombre de Sucursal:";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombreBuscado
            // 
            txtNombreBuscado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreBuscado.Font = new Font("Segoe UI", 12F);
            txtNombreBuscado.Location = new Point(294, 22);
            txtNombreBuscado.Margin = new Padding(8);
            txtNombreBuscado.Name = "txtNombreBuscado";
            txtNombreBuscado.Size = new Size(265, 39);
            txtNombreBuscado.TabIndex = 17;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkSlateGray;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Dock = DockStyle.Bottom;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(10, 128);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(570, 65);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar Sucursal";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tlpBotones
            // 
            tlpBotones.AutoSize = true;
            tlpBotones.BackColor = Color.PaleTurquoise;
            tlpBotones.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpBotones.ColumnCount = 4;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotones.Controls.Add(btnBuscarSucursal, 3, 0);
            tlpBotones.Controls.Add(btnEliminarSucursal, 2, 0);
            tlpBotones.Controls.Add(btnModificarSucursal, 1, 0);
            tlpBotones.Controls.Add(btnAgregarSucursal, 0, 0);
            tlpBotones.Dock = DockStyle.Top;
            tlpBotones.Location = new Point(0, 0);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 1;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotones.Size = new Size(1229, 152);
            tlpBotones.TabIndex = 20;
            // 
            // btnBuscarSucursal
            // 
            btnBuscarSucursal.BackColor = Color.PaleTurquoise;
            btnBuscarSucursal.Cursor = Cursors.Hand;
            btnBuscarSucursal.Dock = DockStyle.Fill;
            btnBuscarSucursal.FlatAppearance.BorderSize = 0;
            btnBuscarSucursal.FlatStyle = FlatStyle.Flat;
            btnBuscarSucursal.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarSucursal.ForeColor = Color.DarkSlateGray;
            btnBuscarSucursal.Location = new Point(921, 3);
            btnBuscarSucursal.Margin = new Padding(0);
            btnBuscarSucursal.Name = "btnBuscarSucursal";
            btnBuscarSucursal.Size = new Size(305, 146);
            btnBuscarSucursal.TabIndex = 10;
            btnBuscarSucursal.Text = "Buscar 🔍";
            btnBuscarSucursal.UseVisualStyleBackColor = false;
            btnBuscarSucursal.Click += btnBuscarSucursal_Click;
            // 
            // btnEliminarSucursal
            // 
            btnEliminarSucursal.Cursor = Cursors.Hand;
            btnEliminarSucursal.Dock = DockStyle.Fill;
            btnEliminarSucursal.FlatAppearance.BorderSize = 0;
            btnEliminarSucursal.FlatStyle = FlatStyle.Flat;
            btnEliminarSucursal.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarSucursal.ForeColor = Color.DarkSlateGray;
            btnEliminarSucursal.Location = new Point(615, 3);
            btnEliminarSucursal.Margin = new Padding(0);
            btnEliminarSucursal.Name = "btnEliminarSucursal";
            btnEliminarSucursal.Size = new Size(303, 146);
            btnEliminarSucursal.TabIndex = 6;
            btnEliminarSucursal.Text = "Eliminar 🗑️";
            btnEliminarSucursal.UseVisualStyleBackColor = true;
            btnEliminarSucursal.Click += btnEliminarSucursal_Click;
            // 
            // btnModificarSucursal
            // 
            btnModificarSucursal.Cursor = Cursors.Hand;
            btnModificarSucursal.Dock = DockStyle.Fill;
            btnModificarSucursal.FlatAppearance.BorderSize = 0;
            btnModificarSucursal.FlatStyle = FlatStyle.Flat;
            btnModificarSucursal.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarSucursal.ForeColor = Color.DarkSlateGray;
            btnModificarSucursal.Location = new Point(309, 3);
            btnModificarSucursal.Margin = new Padding(0);
            btnModificarSucursal.Name = "btnModificarSucursal";
            btnModificarSucursal.Size = new Size(303, 146);
            btnModificarSucursal.TabIndex = 5;
            btnModificarSucursal.Text = "Modificar 🛠️";
            btnModificarSucursal.UseVisualStyleBackColor = true;
            btnModificarSucursal.Click += btnModificarSucursal_Click;
            // 
            // btnAgregarSucursal
            // 
            btnAgregarSucursal.Cursor = Cursors.Hand;
            btnAgregarSucursal.Dock = DockStyle.Fill;
            btnAgregarSucursal.FlatAppearance.BorderSize = 0;
            btnAgregarSucursal.FlatStyle = FlatStyle.Flat;
            btnAgregarSucursal.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarSucursal.ForeColor = Color.DarkSlateGray;
            btnAgregarSucursal.Location = new Point(3, 3);
            btnAgregarSucursal.Margin = new Padding(0);
            btnAgregarSucursal.Name = "btnAgregarSucursal";
            btnAgregarSucursal.Size = new Size(303, 146);
            btnAgregarSucursal.TabIndex = 4;
            btnAgregarSucursal.Text = "Agregar ➕";
            btnAgregarSucursal.UseVisualStyleBackColor = true;
            btnAgregarSucursal.Click += btnAgregarSucursal_Click;
            // 
            // pnelppaltitulo
            // 
            pnelppaltitulo.BackColor = Color.DarkSlateGray;
            pnelppaltitulo.Controls.Add(lblTituloGR);
            pnelppaltitulo.Controls.Add(btnVolver);
            pnelppaltitulo.Controls.Add(btnSalir);
            pnelppaltitulo.Dock = DockStyle.Top;
            pnelppaltitulo.Location = new Point(0, 0);
            pnelppaltitulo.Margin = new Padding(2);
            pnelppaltitulo.Name = "pnelppaltitulo";
            pnelppaltitulo.Size = new Size(1229, 80);
            pnelppaltitulo.TabIndex = 17;
            // 
            // lblTituloGR
            // 
            lblTituloGR.Anchor = AnchorStyles.Top;
            lblTituloGR.AutoSize = true;
            lblTituloGR.BackColor = Color.Transparent;
            lblTituloGR.Font = new Font("Calibri", 28F, FontStyle.Bold);
            lblTituloGR.ForeColor = Color.White;
            lblTituloGR.Location = new Point(364, 6);
            lblTituloGR.Margin = new Padding(2, 0, 2, 0);
            lblTituloGR.Name = "lblTituloGR";
            lblTituloGR.Size = new Size(548, 68);
            lblTituloGR.TabIndex = 10;
            lblTituloGR.Text = "Gestión de Sucursales:";
            lblTituloGR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVolver
            // 
            btnVolver.AutoSize = true;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Dock = DockStyle.Left;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Calibri", 25F, FontStyle.Bold);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(0, 0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(90, 80);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "↩️";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 25F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(1139, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 80);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "❌";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Ventana_Gestion_Sucursales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 759);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(1251, 815);
            MinimumSize = new Size(1251, 815);
            Name = "Ventana_Gestion_Sucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sucursales";
            pnelppalmedio.ResumeLayout(false);
            pnelppalmedio.PerformLayout();
            tlpDivision.ResumeLayout(false);
            grbGrillaSucursales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            grbManejodeDatos.ResumeLayout(false);
            grbIngresoDatos.ResumeLayout(false);
            tlpIngreso.ResumeLayout(false);
            tlpIngreso.PerformLayout();
            grbBuscarCategoria.ResumeLayout(false);
            tlpBuscar.ResumeLayout(false);
            tlpBuscar.PerformLayout();
            tlpBotones.ResumeLayout(false);
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private Button btnBuscar;
        private Label lblId;
        private TextBox txtNombreBuscado;
        private GroupBox grbGrillaSucursales;
        private DataGridView dgvSucursales;
        private GroupBox grbManejodeDatos;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private Button btnLimpiarCampos;
        private Label lblNombre;
        private TextBox txtNombre;
        private Panel pnelppaltitulo;
        private Button btnBuscarSucursal;
        private Button btnVolver;
        private Button btnSalir;
        private Button btnEliminarSucursal;
        private Button btnModificarSucursal;
        private Button btnAgregarSucursal;
        private TableLayoutPanel tlpBotones;
        private Label lblTituloGR;
        private TableLayoutPanel tlpDivision;
        private GroupBox grbIngresoDatos;
        private GroupBox grbBuscarCategoria;
        private TableLayoutPanel tlpIngreso;
        private TableLayoutPanel tlpBuscar;
    }
}