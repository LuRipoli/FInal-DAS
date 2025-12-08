namespace Vista
{
    partial class Ventana_Gestion_Clientes
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
            tlpBotones = new TableLayoutPanel();
            btnEliminarCliente = new Button();
            btnModificarCliente = new Button();
            btnBuscarCliente = new Button();
            btnAgregarCliente = new Button();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            grbGrillaClientes = new GroupBox();
            btnRefrescar = new Button();
            dgvClientes = new DataGridView();
            grbDatos = new GroupBox();
            tlpBuscar = new TableLayoutPanel();
            label1 = new Label();
            txtNombreBuscado = new TextBox();
            btnBuscar = new Button();
            tlpIngreso = new TableLayoutPanel();
            label2 = new Label();
            lblNombre = new Label();
            txtEmail = new TextBox();
            lblDireccion = new Label();
            txtNombre = new TextBox();
            tlpTipoCliente = new TableLayoutPanel();
            rdbMinorista = new RadioButton();
            rdbMayorista = new RadioButton();
            btnLimpiarCampos = new Button();
            pnelppaltitulo.SuspendLayout();
            tlpBotones.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grbGrillaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            grbDatos.SuspendLayout();
            tlpBuscar.SuspendLayout();
            tlpIngreso.SuspendLayout();
            tlpTipoCliente.SuspendLayout();
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
            pnelppaltitulo.Size = new Size(1468, 80);
            pnelppaltitulo.TabIndex = 11;
            // 
            // lblTituloGR
            // 
            lblTituloGR.Anchor = AnchorStyles.Top;
            lblTituloGR.AutoSize = true;
            lblTituloGR.BackColor = Color.Transparent;
            lblTituloGR.Font = new Font("Calibri", 28F, FontStyle.Bold);
            lblTituloGR.ForeColor = Color.White;
            lblTituloGR.Location = new Point(498, 6);
            lblTituloGR.Margin = new Padding(2, 0, 2, 0);
            lblTituloGR.Name = "lblTituloGR";
            lblTituloGR.Size = new Size(489, 68);
            lblTituloGR.TabIndex = 12;
            lblTituloGR.Text = "Gestión de Clientes:";
            lblTituloGR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(1378, 0);
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
            // tlpBotones
            // 
            tlpBotones.BackColor = Color.PaleTurquoise;
            tlpBotones.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpBotones.ColumnCount = 4;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotones.Controls.Add(btnEliminarCliente, 2, 0);
            tlpBotones.Controls.Add(btnModificarCliente, 1, 0);
            tlpBotones.Controls.Add(btnBuscarCliente, 3, 0);
            tlpBotones.Controls.Add(btnAgregarCliente, 0, 0);
            tlpBotones.Cursor = Cursors.No;
            tlpBotones.Dock = DockStyle.Top;
            tlpBotones.Location = new Point(0, 80);
            tlpBotones.Margin = new Padding(2);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 1;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotones.Size = new Size(1468, 152);
            tlpBotones.TabIndex = 23;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Cursor = Cursors.Hand;
            btnEliminarCliente.Dock = DockStyle.Fill;
            btnEliminarCliente.FlatAppearance.BorderSize = 0;
            btnEliminarCliente.FlatStyle = FlatStyle.Flat;
            btnEliminarCliente.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarCliente.ForeColor = Color.DarkSlateGray;
            btnEliminarCliente.Location = new Point(737, 5);
            btnEliminarCliente.Margin = new Padding(2);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(359, 142);
            btnEliminarCliente.TabIndex = 6;
            btnEliminarCliente.Text = "Eliminar 🗑️";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click_1;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Cursor = Cursors.Hand;
            btnModificarCliente.Dock = DockStyle.Fill;
            btnModificarCliente.FlatAppearance.BorderSize = 0;
            btnModificarCliente.FlatStyle = FlatStyle.Flat;
            btnModificarCliente.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarCliente.ForeColor = Color.DarkSlateGray;
            btnModificarCliente.Location = new Point(371, 5);
            btnModificarCliente.Margin = new Padding(2);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(359, 142);
            btnModificarCliente.TabIndex = 5;
            btnModificarCliente.Text = "Modificar 🛠️";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click_1;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Cursor = Cursors.Hand;
            btnBuscarCliente.Dock = DockStyle.Fill;
            btnBuscarCliente.FlatAppearance.BorderSize = 0;
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarCliente.ForeColor = Color.DarkSlateGray;
            btnBuscarCliente.Location = new Point(1103, 5);
            btnBuscarCliente.Margin = new Padding(2);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(360, 142);
            btnBuscarCliente.TabIndex = 10;
            btnBuscarCliente.Text = "Buscar 🔍";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click_1;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Cursor = Cursors.Hand;
            btnAgregarCliente.Dock = DockStyle.Fill;
            btnAgregarCliente.FlatAppearance.BorderSize = 0;
            btnAgregarCliente.FlatStyle = FlatStyle.Flat;
            btnAgregarCliente.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCliente.ForeColor = Color.DarkSlateGray;
            btnAgregarCliente.Location = new Point(5, 5);
            btnAgregarCliente.Margin = new Padding(2);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(359, 142);
            btnAgregarCliente.TabIndex = 4;
            btnAgregarCliente.Text = "Agregar ➕";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 232);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1468, 470);
            panel1.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.AppWorkspace;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel2.Controls.Add(grbGrillaClientes, 1, 0);
            tableLayoutPanel2.Controls.Add(grbDatos, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1468, 470);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // grbGrillaClientes
            // 
            grbGrillaClientes.BackColor = SystemColors.AppWorkspace;
            grbGrillaClientes.BackgroundImageLayout = ImageLayout.None;
            grbGrillaClientes.Controls.Add(btnRefrescar);
            grbGrillaClientes.Controls.Add(dgvClientes);
            grbGrillaClientes.Dock = DockStyle.Fill;
            grbGrillaClientes.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbGrillaClientes.ForeColor = Color.DarkSlateGray;
            grbGrillaClientes.Location = new Point(662, 2);
            grbGrillaClientes.Margin = new Padding(2);
            grbGrillaClientes.Name = "grbGrillaClientes";
            grbGrillaClientes.Padding = new Padding(2);
            grbGrillaClientes.Size = new Size(804, 466);
            grbGrillaClientes.TabIndex = 18;
            grbGrillaClientes.TabStop = false;
            grbGrillaClientes.Text = "Grilla de Clientes";
            // 
            // btnRefrescar
            // 
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Calibri", 16F, FontStyle.Bold);
            btnRefrescar.ForeColor = Color.DarkSlateGray;
            btnRefrescar.Location = new Point(755, -5);
            btnRefrescar.Margin = new Padding(2);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(40, 42);
            btnRefrescar.TabIndex = 23;
            btnRefrescar.Text = "🔄";
            btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = SystemColors.GrayText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.Location = new Point(2, 37);
            dgvClientes.Margin = new Padding(20, 20, 20, 20);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.Size = new Size(800, 427);
            dgvClientes.TabIndex = 1;
            // 
            // grbDatos
            // 
            grbDatos.Controls.Add(tlpBuscar);
            grbDatos.Controls.Add(btnBuscar);
            grbDatos.Controls.Add(tlpIngreso);
            grbDatos.Controls.Add(btnLimpiarCampos);
            grbDatos.Dock = DockStyle.Fill;
            grbDatos.Location = new Point(2, 2);
            grbDatos.Margin = new Padding(2);
            grbDatos.Name = "grbDatos";
            grbDatos.Padding = new Padding(2);
            grbDatos.Size = new Size(656, 466);
            grbDatos.TabIndex = 19;
            grbDatos.TabStop = false;
            // 
            // tlpBuscar
            // 
            tlpBuscar.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpBuscar.ColumnCount = 2;
            tlpBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBuscar.Controls.Add(label1, 0, 0);
            tlpBuscar.Controls.Add(txtNombreBuscado, 1, 0);
            tlpBuscar.Dock = DockStyle.Bottom;
            tlpBuscar.Enabled = false;
            tlpBuscar.Location = new Point(2, 304);
            tlpBuscar.Margin = new Padding(2);
            tlpBuscar.Name = "tlpBuscar";
            tlpBuscar.RowCount = 1;
            tlpBuscar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBuscar.Size = new Size(652, 95);
            tlpBuscar.TabIndex = 23;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(5, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(317, 35);
            label1.TabIndex = 18;
            label1.Text = "Cliente Buscado:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombreBuscado
            // 
            txtNombreBuscado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreBuscado.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreBuscado.Location = new Point(335, 26);
            txtNombreBuscado.Margin = new Padding(8, 8, 8, 8);
            txtNombreBuscado.Name = "txtNombreBuscado";
            txtNombreBuscado.Size = new Size(306, 42);
            txtNombreBuscado.TabIndex = 17;
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
            btnBuscar.Location = new Point(2, 399);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(652, 65);
            btnBuscar.TabIndex = 22;
            btnBuscar.Text = "Buscar Cliente";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // tlpIngreso
            // 
            tlpIngreso.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpIngreso.ColumnCount = 2;
            tlpIngreso.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpIngreso.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpIngreso.Controls.Add(label2, 0, 2);
            tlpIngreso.Controls.Add(lblNombre, 0, 0);
            tlpIngreso.Controls.Add(txtEmail, 1, 1);
            tlpIngreso.Controls.Add(lblDireccion, 0, 1);
            tlpIngreso.Controls.Add(txtNombre, 1, 0);
            tlpIngreso.Controls.Add(tlpTipoCliente, 1, 2);
            tlpIngreso.Dock = DockStyle.Top;
            tlpIngreso.Location = new Point(2, 91);
            tlpIngreso.Margin = new Padding(2);
            tlpIngreso.Name = "tlpIngreso";
            tlpIngreso.RowCount = 3;
            tlpIngreso.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpIngreso.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpIngreso.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpIngreso.Size = new Size(652, 214);
            tlpIngreso.TabIndex = 21;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(5, 152);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(317, 35);
            label2.TabIndex = 19;
            label2.Text = "Tipo de Cliente";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.DarkSlateGray;
            lblNombre.Location = new Point(5, 15);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(317, 35);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre del Cliente:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(335, 76);
            txtEmail.Margin = new Padding(8, 8, 8, 8);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(306, 39);
            txtEmail.TabIndex = 17;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.ForeColor = Color.DarkSlateGray;
            lblDireccion.Location = new Point(5, 78);
            lblDireccion.Margin = new Padding(2, 0, 2, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(317, 35);
            lblDireccion.TabIndex = 18;
            lblDireccion.Text = "Email:";
            lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(335, 12);
            txtNombre.Margin = new Padding(8, 8, 8, 8);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(306, 42);
            txtNombre.TabIndex = 0;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // tlpTipoCliente
            // 
            tlpTipoCliente.ColumnCount = 2;
            tlpTipoCliente.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTipoCliente.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTipoCliente.Controls.Add(rdbMinorista, 0, 0);
            tlpTipoCliente.Controls.Add(rdbMayorista, 1, 0);
            tlpTipoCliente.Dock = DockStyle.Fill;
            tlpTipoCliente.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlpTipoCliente.Location = new Point(337, 139);
            tlpTipoCliente.Margin = new Padding(10, 10, 10, 10);
            tlpTipoCliente.Name = "tlpTipoCliente";
            tlpTipoCliente.RowCount = 1;
            tlpTipoCliente.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTipoCliente.Size = new Size(302, 62);
            tlpTipoCliente.TabIndex = 20;
            // 
            // rdbMinorista
            // 
            rdbMinorista.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rdbMinorista.AutoSize = true;
            rdbMinorista.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbMinorista.ForeColor = Color.DarkSlateGray;
            rdbMinorista.Location = new Point(2, 14);
            rdbMinorista.Margin = new Padding(2);
            rdbMinorista.Name = "rdbMinorista";
            rdbMinorista.Size = new Size(147, 33);
            rdbMinorista.TabIndex = 0;
            rdbMinorista.TabStop = true;
            rdbMinorista.Text = "Minorista";
            rdbMinorista.TextAlign = ContentAlignment.MiddleCenter;
            rdbMinorista.UseVisualStyleBackColor = true;
            // 
            // rdbMayorista
            // 
            rdbMayorista.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rdbMayorista.AutoSize = true;
            rdbMayorista.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbMayorista.ForeColor = Color.DarkSlateGray;
            rdbMayorista.Location = new Point(153, 14);
            rdbMayorista.Margin = new Padding(2);
            rdbMayorista.Name = "rdbMayorista";
            rdbMayorista.Size = new Size(147, 33);
            rdbMayorista.TabIndex = 1;
            rdbMayorista.TabStop = true;
            rdbMayorista.Text = "Mayorista";
            rdbMayorista.TextAlign = ContentAlignment.MiddleCenter;
            rdbMayorista.UseVisualStyleBackColor = true;
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
            btnLimpiarCampos.Size = new Size(652, 65);
            btnLimpiarCampos.TabIndex = 20;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // Ventana_Gestion_Clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1468, 702);
            Controls.Add(panel1);
            Controls.Add(tlpBotones);
            Controls.Add(pnelppaltitulo);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            MaximumSize = new Size(1653, 904);
            Name = "Ventana_Gestion_Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            tlpBotones.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            grbGrillaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            grbDatos.ResumeLayout(false);
            tlpBuscar.ResumeLayout(false);
            tlpBuscar.PerformLayout();
            tlpIngreso.ResumeLayout(false);
            tlpIngreso.PerformLayout();
            tlpTipoCliente.ResumeLayout(false);
            tlpTipoCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnelppaltitulo;
        private Button btnAgregarCuenta;
        private Button btnVolver;
        private Button btnSalir;
        private GroupBox grbIngresoDatos;
        private ComboBox cbRubro;
        private GroupBox grbBuscarCategoria;
        private TextBox textBox2;
        private Button button2;
        private TextBox txtemailProveedor;
        private Label lblEmail;
        private Label lbltelefonoproveedor;
        private Label lblNombreProveedor;
        private TextBox txttelefonoProveedor;
        private TextBox txtDireccionProveedor;
        private GroupBox grbTipoCliente;
        private Label lblSelección;
        private GroupBox grbBuscarCliente;
        private Label lblId;
        private Label label3;
        private Label lblTituloGR;
        private TextBox txtDireccion;
        private TableLayoutPanel tlpBotones;
        private Button btnEliminarCliente;
        private Button btnModificarCliente;
        private Button btnBuscarCliente;
        private Button btnAgregarCliente;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox grbGrillaClientes;
        private Button btnRefrescar;
        private DataGridView dgvClientes;
        private GroupBox grbDatos;
        private TableLayoutPanel tlpBuscar;
        private Label label1;
        private TextBox txtNombreBuscado;
        private Button btnBuscar;
        private TableLayoutPanel tlpIngreso;
        private Label label2;
        private Label lblNombre;
        private TextBox txtEmail;
        private Label lblDireccion;
        private TextBox txtNombre;
        private TableLayoutPanel tlpTipoCliente;
        private RadioButton rdbMinorista;
        private RadioButton rdbMayorista;
        private Button btnLimpiarCampos;
    }
}