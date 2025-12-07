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
            pnelppalmedio = new Panel();
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnEliminarCliente = new Button();
            btnModificarCliente = new Button();
            btnBuscarCliente = new Button();
            btnAgregarCliente = new Button();
            tlpBotones = new TableLayoutPanel();
            pnelppaltitulo = new Panel();
            lblTituloGR = new Label();
            btnSalir = new Button();
            btnVolver = new Button();
            pnelppalmedio.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grbGrillaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            grbDatos.SuspendLayout();
            tlpBuscar.SuspendLayout();
            tlpIngreso.SuspendLayout();
            tlpTipoCliente.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnelppaltitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.AppWorkspace;
            pnelppalmedio.Controls.Add(tableLayoutPanel2);
            pnelppalmedio.Controls.Add(tableLayoutPanel1);
            pnelppalmedio.Controls.Add(tlpBotones);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(0, 80);
            pnelppalmedio.Margin = new Padding(2);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1632, 770);
            pnelppalmedio.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(grbGrillaClientes, 1, 0);
            tableLayoutPanel2.Controls.Add(grbDatos, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 153);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1632, 617);
            tableLayoutPanel2.TabIndex = 23;
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
            grbGrillaClientes.Location = new Point(819, 3);
            grbGrillaClientes.Name = "grbGrillaClientes";
            grbGrillaClientes.Size = new Size(810, 611);
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
            btnRefrescar.Location = new Point(763, -5);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(40, 43);
            btnRefrescar.TabIndex = 23;
            btnRefrescar.Text = "🔄";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click_1;
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
            dgvClientes.Location = new Point(3, 38);
            dgvClientes.Margin = new Padding(20);
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
            dgvClientes.Size = new Size(804, 570);
            dgvClientes.TabIndex = 1;
            // 
            // grbDatos
            // 
            grbDatos.Controls.Add(tlpBuscar);
            grbDatos.Controls.Add(btnBuscar);
            grbDatos.Controls.Add(tlpIngreso);
            grbDatos.Controls.Add(btnLimpiarCampos);
            grbDatos.Dock = DockStyle.Fill;
            grbDatos.Location = new Point(3, 3);
            grbDatos.Name = "grbDatos";
            grbDatos.Size = new Size(810, 611);
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
            tlpBuscar.Dock = DockStyle.Fill;
            tlpBuscar.Enabled = false;
            tlpBuscar.Location = new Point(3, 334);
            tlpBuscar.Name = "tlpBuscar";
            tlpBuscar.RowCount = 1;
            tlpBuscar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBuscar.Size = new Size(804, 209);
            tlpBuscar.TabIndex = 23;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(6, 87);
            label1.Name = "label1";
            label1.Size = new Size(391, 35);
            label1.TabIndex = 18;
            label1.Text = "Cliente Buscado:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombreBuscado
            // 
            txtNombreBuscado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreBuscado.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreBuscado.Location = new Point(411, 83);
            txtNombreBuscado.Margin = new Padding(8);
            txtNombreBuscado.Name = "txtNombreBuscado";
            txtNombreBuscado.Size = new Size(382, 42);
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
            btnBuscar.Location = new Point(3, 543);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(804, 65);
            btnBuscar.TabIndex = 22;
            btnBuscar.Text = "Buscar Cliente";
            btnBuscar.UseVisualStyleBackColor = false;
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
            tlpIngreso.Location = new Point(3, 92);
            tlpIngreso.Name = "tlpIngreso";
            tlpIngreso.RowCount = 3;
            tlpIngreso.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpIngreso.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpIngreso.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpIngreso.Size = new Size(804, 242);
            tlpIngreso.TabIndex = 21;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(6, 175);
            label2.Name = "label2";
            label2.Size = new Size(391, 35);
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
            lblNombre.Location = new Point(6, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(391, 35);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre del Cliente:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(411, 90);
            txtEmail.Margin = new Padding(8);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(382, 39);
            txtEmail.TabIndex = 17;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.ForeColor = Color.DarkSlateGray;
            lblDireccion.Location = new Point(6, 92);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(391, 35);
            lblDireccion.TabIndex = 18;
            lblDireccion.Text = "Email:";
            lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(411, 16);
            txtNombre.Margin = new Padding(8);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(382, 42);
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
            tlpTipoCliente.Location = new Point(413, 157);
            tlpTipoCliente.Margin = new Padding(10);
            tlpTipoCliente.Name = "tlpTipoCliente";
            tlpTipoCliente.RowCount = 1;
            tlpTipoCliente.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTipoCliente.Size = new Size(378, 72);
            tlpTipoCliente.TabIndex = 20;
            // 
            // rdbMinorista
            // 
            rdbMinorista.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rdbMinorista.AutoSize = true;
            rdbMinorista.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbMinorista.ForeColor = Color.DarkSlateGray;
            rdbMinorista.Location = new Point(3, 16);
            rdbMinorista.Name = "rdbMinorista";
            rdbMinorista.Size = new Size(183, 39);
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
            rdbMayorista.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbMayorista.ForeColor = Color.DarkSlateGray;
            rdbMayorista.Location = new Point(192, 16);
            rdbMayorista.Name = "rdbMayorista";
            rdbMayorista.Size = new Size(183, 39);
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
            btnLimpiarCampos.Location = new Point(3, 27);
            btnLimpiarCampos.Margin = new Padding(0);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(804, 65);
            btnLimpiarCampos.TabIndex = 20;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.PaleTurquoise;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnEliminarCliente, 2, 0);
            tableLayoutPanel1.Controls.Add(btnModificarCliente, 1, 0);
            tableLayoutPanel1.Controls.Add(btnBuscarCliente, 3, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarCliente, 0, 0);
            tableLayoutPanel1.Cursor = Cursors.No;
            tableLayoutPanel1.Location = new Point(0, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1632, 152);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Dock = DockStyle.Fill;
            btnEliminarCliente.FlatAppearance.BorderSize = 0;
            btnEliminarCliente.FlatStyle = FlatStyle.Flat;
            btnEliminarCliente.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarCliente.ForeColor = Color.DarkSlateGray;
            btnEliminarCliente.Location = new Point(820, 6);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(398, 140);
            btnEliminarCliente.TabIndex = 6;
            btnEliminarCliente.Text = "Eliminar 🗑️";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Dock = DockStyle.Fill;
            btnModificarCliente.FlatAppearance.BorderSize = 0;
            btnModificarCliente.FlatStyle = FlatStyle.Flat;
            btnModificarCliente.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarCliente.ForeColor = Color.DarkSlateGray;
            btnModificarCliente.Location = new Point(413, 6);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(398, 140);
            btnModificarCliente.TabIndex = 5;
            btnModificarCliente.Text = "Modificar 🛠️";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Dock = DockStyle.Fill;
            btnBuscarCliente.FlatAppearance.BorderSize = 0;
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarCliente.ForeColor = Color.DarkSlateGray;
            btnBuscarCliente.Location = new Point(1227, 6);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(399, 140);
            btnBuscarCliente.TabIndex = 10;
            btnBuscarCliente.Text = "Buscar 🔍";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Dock = DockStyle.Fill;
            btnAgregarCliente.FlatAppearance.BorderSize = 0;
            btnAgregarCliente.FlatStyle = FlatStyle.Flat;
            btnAgregarCliente.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCliente.ForeColor = Color.DarkSlateGray;
            btnAgregarCliente.Location = new Point(6, 6);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(398, 140);
            btnAgregarCliente.TabIndex = 4;
            btnAgregarCliente.Text = "Agregar ➕";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
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
            tlpBotones.Dock = DockStyle.Top;
            tlpBotones.Location = new Point(0, 0);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 1;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotones.Size = new Size(1632, 6);
            tlpBotones.TabIndex = 21;
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
            pnelppaltitulo.Size = new Size(1632, 80);
            pnelppaltitulo.TabIndex = 11;
            // 
            // lblTituloGR
            // 
            lblTituloGR.Anchor = AnchorStyles.Top;
            lblTituloGR.AutoSize = true;
            lblTituloGR.BackColor = Color.Transparent;
            lblTituloGR.Font = new Font("Calibri", 28F, FontStyle.Bold);
            lblTituloGR.ForeColor = Color.White;
            lblTituloGR.Location = new Point(580, 6);
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
            btnSalir.Location = new Point(1542, 0);
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
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(90, 80);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "↩️";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // Ventana_Gestion_Clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1632, 850);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(1654, 906);
            MinimumSize = new Size(1654, 906);
            Name = "Ventana_Gestion_Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            pnelppalmedio.ResumeLayout(false);
            pnelppalmedio.PerformLayout();
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
            tableLayoutPanel1.ResumeLayout(false);
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private Panel pnelppaltitulo;
        private Button btnAgregarCuenta;
        private Button btnVolver;
        private Button btnSalir;
        private GroupBox grbGrillaClientes;
        private DataGridView dgvClientes;
        private GroupBox grbIngresoDatos;
        private ComboBox cbRubro;
        private Button btnLimpiarCampos;
        private GroupBox grbBuscarCategoria;
        private TextBox textBox2;
        private Button button2;
        private TableLayoutPanel tlpTipoCliente;
        private RadioButton rdbMinorista;
        private RadioButton rdbMayorista;
        private Label label2;
        private TextBox txtemailProveedor;
        private Label lblDireccion;
        private Label lblEmail;
        private Label lbltelefonoproveedor;
        private Label lblNombreProveedor;
        private TextBox txttelefonoProveedor;
        private TextBox txtDireccionProveedor;
        private TextBox txtNombre;
        private TableLayoutPanel tlpBuscar;
        private Label label1;
        private GroupBox grbTipoCliente;
        private Label lblSelección;
        private GroupBox grbBuscarCliente;
        private Button btnBuscar;
        private Label lblId;
        private TextBox txtNombreBuscado;
        private Button btnBuscarCliente;
        private TextBox txtEmail;
        private Label label3;
        private Label lblTituloGR;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEliminarCliente;
        private Button btnModificarCliente;
        private TableLayoutPanel tlpBotones;
        private Button btnAgregarCliente;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnRefrescar;
        private GroupBox grbDatos;
        private TableLayoutPanel tlpIngreso;
        private Label lblNombre;
        private TextBox txtDireccion;
    }
}