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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnelppalmedio = new Panel();
            tlpDivision = new TableLayoutPanel();
            grbGrillaSucursales = new GroupBox();
            btnRefrescar = new Button();
            dgvSucursales = new DataGridView();
            grbManejodeDatos = new GroupBox();
            tlpIngreso = new TableLayoutPanel();
            lblNombre = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtNombre = new TextBox();
            btnLimpiarCampos = new Button();
            tlpBuscar = new TableLayoutPanel();
            cmbSucursal = new ComboBox();
            lblId = new Label();
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
            tlpIngreso.SuspendLayout();
            tlpBuscar.SuspendLayout();
            tlpBotones.SuspendLayout();
            pnelppaltitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.AppWorkspace;
            pnelppalmedio.Controls.Add(tlpDivision);
            pnelppalmedio.Controls.Add(tlpBotones);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(0, 64);
            pnelppalmedio.Margin = new Padding(2);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1030, 406);
            pnelppalmedio.TabIndex = 18;
            // 
            // tlpDivision
            // 
            tlpDivision.BackColor = SystemColors.AppWorkspace;
            tlpDivision.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpDivision.ColumnCount = 2;
            tlpDivision.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpDivision.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpDivision.Controls.Add(grbGrillaSucursales, 1, 0);
            tlpDivision.Controls.Add(grbManejodeDatos, 0, 0);
            tlpDivision.Dock = DockStyle.Fill;
            tlpDivision.Location = new Point(0, 84);
            tlpDivision.Margin = new Padding(2);
            tlpDivision.MaximumSize = new Size(1027, 319);
            tlpDivision.MinimumSize = new Size(1027, 319);
            tlpDivision.Name = "tlpDivision";
            tlpDivision.RowCount = 1;
            tlpDivision.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDivision.Size = new Size(1027, 319);
            tlpDivision.TabIndex = 21;
            // 
            // grbGrillaSucursales
            // 
            grbGrillaSucursales.BackgroundImageLayout = ImageLayout.None;
            grbGrillaSucursales.Controls.Add(btnRefrescar);
            grbGrillaSucursales.Controls.Add(dgvSucursales);
            grbGrillaSucursales.Dock = DockStyle.Fill;
            grbGrillaSucursales.FlatStyle = FlatStyle.Flat;
            grbGrillaSucursales.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbGrillaSucursales.ForeColor = Color.DarkSlateGray;
            grbGrillaSucursales.Location = new Point(472, 11);
            grbGrillaSucursales.Margin = new Padding(8);
            grbGrillaSucursales.Name = "grbGrillaSucursales";
            grbGrillaSucursales.Padding = new Padding(2);
            grbGrillaSucursales.Size = new Size(544, 297);
            grbGrillaSucursales.TabIndex = 18;
            grbGrillaSucursales.TabStop = false;
            grbGrillaSucursales.Text = "Grilla de Sucursales";
            // 
            // btnRefrescar
            // 
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Calibri", 16F, FontStyle.Bold);
            btnRefrescar.Location = new Point(510, -8);
            btnRefrescar.Margin = new Padding(2);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(32, 37);
            btnRefrescar.TabIndex = 2;
            btnRefrescar.Text = "🔄";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // dgvSucursales
            // 
            dgvSucursales.AllowUserToAddRows = false;
            dgvSucursales.AllowUserToDeleteRows = false;
            dgvSucursales.AllowUserToResizeColumns = false;
            dgvSucursales.AllowUserToResizeRows = false;
            dgvSucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSucursales.BackgroundColor = SystemColors.GrayText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSucursales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSucursales.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSucursales.Dock = DockStyle.Fill;
            dgvSucursales.Location = new Point(2, 31);
            dgvSucursales.Margin = new Padding(16);
            dgvSucursales.MultiSelect = false;
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSucursales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSucursales.RowHeadersVisible = false;
            dgvSucursales.RowHeadersWidth = 62;
            dgvSucursales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSucursales.Size = new Size(540, 264);
            dgvSucursales.TabIndex = 1;
            dgvSucursales.SelectionChanged += dgvSucursales_SelectionChanged;
            // 
            // grbManejodeDatos
            // 
            grbManejodeDatos.Controls.Add(tlpIngreso);
            grbManejodeDatos.Controls.Add(btnLimpiarCampos);
            grbManejodeDatos.Controls.Add(tlpBuscar);
            grbManejodeDatos.Controls.Add(btnBuscar);
            grbManejodeDatos.Dock = DockStyle.Fill;
            grbManejodeDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbManejodeDatos.Location = new Point(11, 11);
            grbManejodeDatos.Margin = new Padding(8);
            grbManejodeDatos.Name = "grbManejodeDatos";
            grbManejodeDatos.Padding = new Padding(0);
            grbManejodeDatos.Size = new Size(442, 297);
            grbManejodeDatos.TabIndex = 17;
            grbManejodeDatos.TabStop = false;
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
            tlpIngreso.Dock = DockStyle.Top;
            tlpIngreso.Location = new Point(0, 72);
            tlpIngreso.Margin = new Padding(2);
            tlpIngreso.Name = "tlpIngreso";
            tlpIngreso.RowCount = 2;
            tlpIngreso.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpIngreso.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpIngreso.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tlpIngreso.Size = new Size(442, 122);
            tlpIngreso.TabIndex = 24;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.AppWorkspace;
            lblNombre.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.DarkSlateGray;
            lblNombre.Location = new Point(5, 3);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(212, 56);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre de Sucursal:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDireccion.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(225, 74);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(211, 32);
            txtDireccion.TabIndex = 17;
            txtDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.ForeColor = Color.DarkSlateGray;
            lblDireccion.Location = new Point(5, 76);
            lblDireccion.Margin = new Padding(2, 0, 2, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(212, 29);
            lblDireccion.TabIndex = 18;
            lblDireccion.Text = "Dirección:";
            lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(225, 17);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 28);
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
            btnLimpiarCampos.Location = new Point(0, 20);
            btnLimpiarCampos.Margin = new Padding(0);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(442, 52);
            btnLimpiarCampos.TabIndex = 23;
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
            tlpBuscar.Controls.Add(cmbSucursal, 1, 0);
            tlpBuscar.Controls.Add(lblId, 0, 0);
            tlpBuscar.Dock = DockStyle.Bottom;
            tlpBuscar.Enabled = false;
            tlpBuscar.Location = new Point(0, 189);
            tlpBuscar.Margin = new Padding(2);
            tlpBuscar.Name = "tlpBuscar";
            tlpBuscar.RowCount = 1;
            tlpBuscar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBuscar.Size = new Size(442, 56);
            tlpBuscar.TabIndex = 22;
            // 
            // cmbSucursal
            // 
            cmbSucursal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSucursal.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(225, 13);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(211, 29);
            cmbSucursal.TabIndex = 23;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.DarkSlateGray;
            lblId.Location = new Point(5, 13);
            lblId.Margin = new Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(212, 29);
            lblId.TabIndex = 18;
            lblId.Text = "Sucursal Buscada:";
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
            btnBuscar.Location = new Point(0, 245);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(442, 52);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar Sucursal";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
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
            tlpBotones.Margin = new Padding(2);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 1;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tlpBotones.Size = new Size(1030, 84);
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
            btnBuscarSucursal.Location = new Point(771, 3);
            btnBuscarSucursal.Margin = new Padding(0);
            btnBuscarSucursal.Name = "btnBuscarSucursal";
            btnBuscarSucursal.Size = new Size(256, 78);
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
            btnEliminarSucursal.Location = new Point(515, 3);
            btnEliminarSucursal.Margin = new Padding(0);
            btnEliminarSucursal.Name = "btnEliminarSucursal";
            btnEliminarSucursal.Size = new Size(253, 78);
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
            btnModificarSucursal.Location = new Point(259, 3);
            btnModificarSucursal.Margin = new Padding(0);
            btnModificarSucursal.Name = "btnModificarSucursal";
            btnModificarSucursal.Size = new Size(253, 78);
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
            btnAgregarSucursal.Size = new Size(253, 78);
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
            pnelppaltitulo.Size = new Size(1030, 64);
            pnelppaltitulo.TabIndex = 17;
            // 
            // lblTituloGR
            // 
            lblTituloGR.Anchor = AnchorStyles.Top;
            lblTituloGR.AutoSize = true;
            lblTituloGR.BackColor = Color.Transparent;
            lblTituloGR.Font = new Font("Calibri", 28F, FontStyle.Bold);
            lblTituloGR.ForeColor = Color.White;
            lblTituloGR.Location = new Point(328, 5);
            lblTituloGR.Margin = new Padding(2, 0, 2, 0);
            lblTituloGR.Name = "lblTituloGR";
            lblTituloGR.Size = new Size(464, 58);
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
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(77, 64);
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
            btnSalir.Location = new Point(958, 0);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(72, 64);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "❌";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Ventana_Gestion_Sucursales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 470);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            MaximumSize = new Size(1048, 517);
            MinimumSize = new Size(1048, 517);
            Name = "Ventana_Gestion_Sucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sucursales";
            Load += Ventana_Gestion_Sucursales_Load;
            pnelppalmedio.ResumeLayout(false);
            pnelppalmedio.PerformLayout();
            tlpDivision.ResumeLayout(false);
            grbGrillaSucursales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            grbManejodeDatos.ResumeLayout(false);
            tlpIngreso.ResumeLayout(false);
            tlpIngreso.PerformLayout();
            tlpBuscar.ResumeLayout(false);
            tlpBuscar.PerformLayout();
            tlpBotones.ResumeLayout(false);
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private GroupBox grbGrillaSucursales;
        private DataGridView dgvSucursales;
        private GroupBox grbManejodeDatos;
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
        private Button btnRefrescar;
        private TableLayoutPanel tlpIngreso;
        private Label lblNombre;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtNombre;
        private Button btnLimpiarCampos;
        private TableLayoutPanel tlpBuscar;
        private Label lblId;
        private Button btnBuscar;
        private ComboBox cmbSucursal;
    }
}