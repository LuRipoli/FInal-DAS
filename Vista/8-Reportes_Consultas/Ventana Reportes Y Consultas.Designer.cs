namespace Vista
{
    partial class Ventana_Reportes_Y_Consultas
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
            Grpfiltros = new GroupBox();
            btnAplicarFiltros = new Button();
            btnLimpiarCampos = new Button();
            tlpRegistroStock = new TableLayoutPanel();
            lblFechaDesde = new Label();
            dtpFechaHasta = new DateTimePicker();
            cmbVendedor = new ComboBox();
            lblNombreVendedor = new Label();
            tlpMetodoPago = new TableLayoutPanel();
            rdbTarjeta = new RadioButton();
            rdbTransferencia = new RadioButton();
            rdbEfectivo = new RadioButton();
            lblMetodoPago = new Label();
            lblProducto = new Label();
            cmbProducto = new ComboBox();
            lblSucursal = new Label();
            cmbSucursales = new ComboBox();
            dtpFechaDesde = new DateTimePicker();
            lblFechaHasta = new Label();
            cmbClientes = new ComboBox();
            lblCliente = new Label();
            btnlimpiar = new Button();
            groupBox1 = new GroupBox();
            lblDashBoard = new Label();
            dgvReportes = new DataGridView();
            tlpBotones = new TableLayoutPanel();
            btnReporteGeneral = new Button();
            btnReporteVenta = new Button();
            btnReporteSucursal = new Button();
            btnReporteProducto = new Button();
            btnReporteCliente = new Button();
            pnelppaltitulo = new Panel();
            lblTituloGR = new Label();
            btnSalir = new Button();
            btnVolver = new Button();
            pnelppalmedio.SuspendLayout();
            tlpDivision.SuspendLayout();
            Grpfiltros.SuspendLayout();
            tlpRegistroStock.SuspendLayout();
            tlpMetodoPago.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
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
            pnelppalmedio.Location = new Point(0, 80);
            pnelppalmedio.Margin = new Padding(1);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(2179, 893);
            pnelppalmedio.TabIndex = 15;
            pnelppalmedio.Paint += pnelppalmedio_Paint;
            // 
            // tlpDivision
            // 
            tlpDivision.ColumnCount = 2;
            tlpDivision.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpDivision.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpDivision.Controls.Add(Grpfiltros, 0, 0);
            tlpDivision.Controls.Add(groupBox1, 1, 0);
            tlpDivision.Dock = DockStyle.Fill;
            tlpDivision.Location = new Point(0, 100);
            tlpDivision.Name = "tlpDivision";
            tlpDivision.RowCount = 1;
            tlpDivision.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDivision.Size = new Size(2179, 793);
            tlpDivision.TabIndex = 25;
            // 
            // Grpfiltros
            // 
            Grpfiltros.Controls.Add(btnAplicarFiltros);
            Grpfiltros.Controls.Add(btnLimpiarCampos);
            Grpfiltros.Controls.Add(tlpRegistroStock);
            Grpfiltros.Controls.Add(btnlimpiar);
            Grpfiltros.Dock = DockStyle.Fill;
            Grpfiltros.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Grpfiltros.ForeColor = Color.DarkSlateGray;
            Grpfiltros.Location = new Point(4, 5);
            Grpfiltros.Margin = new Padding(4, 5, 4, 5);
            Grpfiltros.Name = "Grpfiltros";
            Grpfiltros.Padding = new Padding(4, 5, 4, 5);
            Grpfiltros.Size = new Size(754, 783);
            Grpfiltros.TabIndex = 19;
            Grpfiltros.TabStop = false;
            Grpfiltros.Text = "Filtros";
            // 
            // btnAplicarFiltros
            // 
            btnAplicarFiltros.BackColor = Color.DarkSlateGray;
            btnAplicarFiltros.Cursor = Cursors.Hand;
            btnAplicarFiltros.Dock = DockStyle.Bottom;
            btnAplicarFiltros.FlatAppearance.BorderSize = 0;
            btnAplicarFiltros.FlatStyle = FlatStyle.Flat;
            btnAplicarFiltros.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAplicarFiltros.ForeColor = Color.White;
            btnAplicarFiltros.Location = new Point(4, 713);
            btnAplicarFiltros.Margin = new Padding(2);
            btnAplicarFiltros.Name = "btnAplicarFiltros";
            btnAplicarFiltros.Size = new Size(746, 65);
            btnAplicarFiltros.TabIndex = 29;
            btnAplicarFiltros.Text = "Aplicar Filtros";
            btnAplicarFiltros.UseVisualStyleBackColor = false;
            btnAplicarFiltros.Click += btnAplicarFiltros_Click;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = Color.DarkSlateGray;
            btnLimpiarCampos.Cursor = Cursors.Hand;
            btnLimpiarCampos.Dock = DockStyle.Top;
            btnLimpiarCampos.Enabled = false;
            btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            btnLimpiarCampos.FlatStyle = FlatStyle.Flat;
            btnLimpiarCampos.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarCampos.ForeColor = Color.White;
            btnLimpiarCampos.Location = new Point(4, 40);
            btnLimpiarCampos.Margin = new Padding(0);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(746, 65);
            btnLimpiarCampos.TabIndex = 28;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // tlpRegistroStock
            // 
            tlpRegistroStock.Anchor = AnchorStyles.Bottom;
            tlpRegistroStock.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpRegistroStock.ColumnCount = 2;
            tlpRegistroStock.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tlpRegistroStock.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tlpRegistroStock.Controls.Add(lblFechaDesde, 0, 0);
            tlpRegistroStock.Controls.Add(dtpFechaHasta, 1, 1);
            tlpRegistroStock.Controls.Add(cmbVendedor, 1, 6);
            tlpRegistroStock.Controls.Add(lblNombreVendedor, 0, 6);
            tlpRegistroStock.Controls.Add(tlpMetodoPago, 1, 5);
            tlpRegistroStock.Controls.Add(lblMetodoPago, 0, 5);
            tlpRegistroStock.Controls.Add(lblProducto, 0, 4);
            tlpRegistroStock.Controls.Add(cmbProducto, 1, 4);
            tlpRegistroStock.Controls.Add(lblSucursal, 0, 2);
            tlpRegistroStock.Controls.Add(cmbSucursales, 1, 2);
            tlpRegistroStock.Controls.Add(dtpFechaDesde, 1, 0);
            tlpRegistroStock.Controls.Add(lblFechaHasta, 0, 1);
            tlpRegistroStock.Controls.Add(cmbClientes, 1, 3);
            tlpRegistroStock.Controls.Add(lblCliente, 0, 3);
            tlpRegistroStock.Location = new Point(4, 107);
            tlpRegistroStock.Name = "tlpRegistroStock";
            tlpRegistroStock.RowCount = 7;
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpRegistroStock.Size = new Size(746, 605);
            tlpRegistroStock.TabIndex = 27;
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaDesde.ForeColor = Color.DarkSlateGray;
            lblFechaDesde.Location = new Point(6, 26);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(270, 35);
            lblFechaDesde.TabIndex = 36;
            lblFechaDesde.Text = "Desde la Fecha:";
            lblFechaDesde.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaHasta.CalendarFont = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaHasta.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaHasta.Location = new Point(290, 113);
            dtpFechaHasta.Margin = new Padding(8);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(445, 32);
            dtpFechaHasta.TabIndex = 35;
            // 
            // cmbVendedor
            // 
            cmbVendedor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbVendedor.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbVendedor.FormattingEnabled = true;
            cmbVendedor.Location = new Point(290, 544);
            cmbVendedor.Margin = new Padding(8);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(445, 32);
            cmbVendedor.TabIndex = 34;
            // 
            // lblNombreVendedor
            // 
            lblNombreVendedor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNombreVendedor.AutoSize = true;
            lblNombreVendedor.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreVendedor.ForeColor = Color.DarkSlateGray;
            lblNombreVendedor.Location = new Point(6, 542);
            lblNombreVendedor.Name = "lblNombreVendedor";
            lblNombreVendedor.Size = new Size(270, 35);
            lblNombreVendedor.TabIndex = 33;
            lblNombreVendedor.Text = "Nombre Vendedor:";
            lblNombreVendedor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpMetodoPago
            // 
            tlpMetodoPago.ColumnCount = 3;
            tlpMetodoPago.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpMetodoPago.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpMetodoPago.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpMetodoPago.Controls.Add(rdbTarjeta, 2, 0);
            tlpMetodoPago.Controls.Add(rdbTransferencia, 1, 0);
            tlpMetodoPago.Controls.Add(rdbEfectivo, 0, 0);
            tlpMetodoPago.Dock = DockStyle.Fill;
            tlpMetodoPago.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlpMetodoPago.Location = new Point(282, 432);
            tlpMetodoPago.Margin = new Padding(0);
            tlpMetodoPago.Name = "tlpMetodoPago";
            tlpMetodoPago.RowCount = 1;
            tlpMetodoPago.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMetodoPago.Size = new Size(461, 83);
            tlpMetodoPago.TabIndex = 29;
            // 
            // rdbTarjeta
            // 
            rdbTarjeta.AutoSize = true;
            rdbTarjeta.Dock = DockStyle.Fill;
            rdbTarjeta.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbTarjeta.ForeColor = Color.DarkSlateGray;
            rdbTarjeta.Location = new Point(326, 4);
            rdbTarjeta.Margin = new Padding(4);
            rdbTarjeta.Name = "rdbTarjeta";
            rdbTarjeta.Size = new Size(131, 75);
            rdbTarjeta.TabIndex = 21;
            rdbTarjeta.TabStop = true;
            rdbTarjeta.Text = "Tarjeta";
            rdbTarjeta.TextAlign = ContentAlignment.MiddleCenter;
            rdbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rdbTransferencia
            // 
            rdbTransferencia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rdbTransferencia.AutoSize = true;
            rdbTransferencia.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbTransferencia.ForeColor = Color.DarkSlateGray;
            rdbTransferencia.Location = new Point(142, 25);
            rdbTransferencia.Margin = new Padding(4);
            rdbTransferencia.Name = "rdbTransferencia";
            rdbTransferencia.Size = new Size(176, 33);
            rdbTransferencia.TabIndex = 22;
            rdbTransferencia.TabStop = true;
            rdbTransferencia.Text = "Transferencia";
            rdbTransferencia.TextAlign = ContentAlignment.MiddleCenter;
            rdbTransferencia.UseVisualStyleBackColor = true;
            // 
            // rdbEfectivo
            // 
            rdbEfectivo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rdbEfectivo.AutoSize = true;
            rdbEfectivo.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbEfectivo.ForeColor = Color.DarkSlateGray;
            rdbEfectivo.Location = new Point(4, 25);
            rdbEfectivo.Margin = new Padding(4);
            rdbEfectivo.Name = "rdbEfectivo";
            rdbEfectivo.Size = new Size(130, 33);
            rdbEfectivo.TabIndex = 20;
            rdbEfectivo.TabStop = true;
            rdbEfectivo.Text = "Efectivo";
            rdbEfectivo.TextAlign = ContentAlignment.MiddleCenter;
            rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetodoPago.ForeColor = Color.DarkSlateGray;
            lblMetodoPago.Location = new Point(6, 456);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(270, 35);
            lblMetodoPago.TabIndex = 27;
            lblMetodoPago.Text = "Método de Pago:";
            lblMetodoPago.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProducto
            // 
            lblProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.ForeColor = Color.DarkSlateGray;
            lblProducto.Location = new Point(6, 370);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(270, 35);
            lblProducto.TabIndex = 6;
            lblProducto.Text = "Seleccionar Producto:";
            lblProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbProducto
            // 
            cmbProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbProducto.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(290, 371);
            cmbProducto.Margin = new Padding(8);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(445, 32);
            cmbProducto.TabIndex = 21;
            // 
            // lblSucursal
            // 
            lblSucursal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucursal.ForeColor = Color.DarkSlateGray;
            lblSucursal.Location = new Point(6, 198);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(270, 35);
            lblSucursal.TabIndex = 18;
            lblSucursal.Text = "Seleccionar Sucursal:";
            lblSucursal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbSucursales
            // 
            cmbSucursales.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSucursales.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSucursales.FormattingEnabled = true;
            cmbSucursales.Location = new Point(290, 199);
            cmbSucursales.Margin = new Padding(8);
            cmbSucursales.Name = "cmbSucursales";
            cmbSucursales.Size = new Size(445, 32);
            cmbSucursales.TabIndex = 22;
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaDesde.CalendarFont = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDesde.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDesde.Location = new Point(290, 28);
            dtpFechaDesde.Margin = new Padding(8);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(445, 32);
            dtpFechaDesde.TabIndex = 26;
            dtpFechaDesde.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaHasta.ForeColor = Color.DarkSlateGray;
            lblFechaHasta.Location = new Point(6, 112);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(270, 35);
            lblFechaHasta.TabIndex = 20;
            lblFechaHasta.Text = "Hasta la Fecha:";
            lblFechaHasta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbClientes
            // 
            cmbClientes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbClientes.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(290, 285);
            cmbClientes.Margin = new Padding(8);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(445, 32);
            cmbClientes.TabIndex = 21;
            // 
            // lblCliente
            // 
            lblCliente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.DarkSlateGray;
            lblCliente.Location = new Point(6, 284);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(270, 35);
            lblCliente.TabIndex = 24;
            lblCliente.Text = "Seleccionar Cliente:";
            lblCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(1009, 128);
            btnlimpiar.Margin = new Padding(4, 5, 4, 5);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(162, 45);
            btnlimpiar.TabIndex = 7;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDashBoard);
            groupBox1.Controls.Add(dgvReportes);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DarkSlateGray;
            groupBox1.Location = new Point(767, 5);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(1407, 783);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reportes Generales del Sistema:";
            // 
            // lblDashBoard
            // 
            lblDashBoard.AutoSize = true;
            lblDashBoard.Dock = DockStyle.Fill;
            lblDashBoard.Location = new Point(5, 40);
            lblDashBoard.Name = "lblDashBoard";
            lblDashBoard.Size = new Size(143, 35);
            lblDashBoard.TabIndex = 3;
            lblDashBoard.Text = "DashBoard";
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AllowUserToDeleteRows = false;
            dgvReportes.AllowUserToResizeColumns = false;
            dgvReportes.AllowUserToResizeRows = false;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.BackgroundColor = SystemColors.GrayText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReportes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReportes.Dock = DockStyle.Fill;
            dgvReportes.Location = new Point(5, 40);
            dgvReportes.Margin = new Padding(20);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvReportes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.RowHeadersWidth = 62;
            dgvReportes.Size = new Size(1397, 738);
            dgvReportes.TabIndex = 2;
            dgvReportes.Visible = false;
            // 
            // tlpBotones
            // 
            tlpBotones.BackColor = Color.PaleTurquoise;
            tlpBotones.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpBotones.ColumnCount = 5;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotones.Controls.Add(btnReporteGeneral, 0, 0);
            tlpBotones.Controls.Add(btnReporteVenta, 3, 0);
            tlpBotones.Controls.Add(btnReporteSucursal, 1, 0);
            tlpBotones.Controls.Add(btnReporteProducto, 2, 0);
            tlpBotones.Controls.Add(btnReporteCliente, 4, 0);
            tlpBotones.Cursor = Cursors.No;
            tlpBotones.Dock = DockStyle.Top;
            tlpBotones.Location = new Point(0, 0);
            tlpBotones.Margin = new Padding(2);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 1;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotones.Size = new Size(2179, 100);
            tlpBotones.TabIndex = 24;
            // 
            // btnReporteGeneral
            // 
            btnReporteGeneral.Cursor = Cursors.Hand;
            btnReporteGeneral.Dock = DockStyle.Fill;
            btnReporteGeneral.FlatAppearance.BorderSize = 0;
            btnReporteGeneral.FlatStyle = FlatStyle.Flat;
            btnReporteGeneral.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteGeneral.ForeColor = Color.DarkSlateGray;
            btnReporteGeneral.Location = new Point(3, 3);
            btnReporteGeneral.Margin = new Padding(0);
            btnReporteGeneral.Name = "btnReporteGeneral";
            btnReporteGeneral.Size = new Size(432, 94);
            btnReporteGeneral.TabIndex = 11;
            btnReporteGeneral.Text = "General 🗃️";
            btnReporteGeneral.UseVisualStyleBackColor = true;
            btnReporteGeneral.Click += btnReporteGeneral_Click;
            // 
            // btnReporteVenta
            // 
            btnReporteVenta.Cursor = Cursors.Hand;
            btnReporteVenta.Dock = DockStyle.Fill;
            btnReporteVenta.FlatAppearance.BorderSize = 0;
            btnReporteVenta.FlatStyle = FlatStyle.Flat;
            btnReporteVenta.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteVenta.ForeColor = Color.DarkSlateGray;
            btnReporteVenta.Location = new Point(1308, 3);
            btnReporteVenta.Margin = new Padding(0);
            btnReporteVenta.Name = "btnReporteVenta";
            btnReporteVenta.Size = new Size(432, 94);
            btnReporteVenta.TabIndex = 4;
            btnReporteVenta.Text = "Venta 📊";
            btnReporteVenta.UseVisualStyleBackColor = true;
            btnReporteVenta.Click += btnReporteVenta_Click;
            // 
            // btnReporteSucursal
            // 
            btnReporteSucursal.Cursor = Cursors.Hand;
            btnReporteSucursal.Dock = DockStyle.Fill;
            btnReporteSucursal.FlatAppearance.BorderSize = 0;
            btnReporteSucursal.FlatStyle = FlatStyle.Flat;
            btnReporteSucursal.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteSucursal.ForeColor = Color.DarkSlateGray;
            btnReporteSucursal.Location = new Point(438, 3);
            btnReporteSucursal.Margin = new Padding(0);
            btnReporteSucursal.Name = "btnReporteSucursal";
            btnReporteSucursal.Size = new Size(432, 94);
            btnReporteSucursal.TabIndex = 10;
            btnReporteSucursal.Text = "Sucursal 🏢";
            btnReporteSucursal.UseVisualStyleBackColor = true;
            btnReporteSucursal.Click += btnReporteSucursal_Click;
            // 
            // btnReporteProducto
            // 
            btnReporteProducto.Cursor = Cursors.Hand;
            btnReporteProducto.Dock = DockStyle.Fill;
            btnReporteProducto.FlatAppearance.BorderSize = 0;
            btnReporteProducto.FlatStyle = FlatStyle.Flat;
            btnReporteProducto.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteProducto.ForeColor = Color.DarkSlateGray;
            btnReporteProducto.Location = new Point(873, 3);
            btnReporteProducto.Margin = new Padding(0);
            btnReporteProducto.Name = "btnReporteProducto";
            btnReporteProducto.Size = new Size(432, 94);
            btnReporteProducto.TabIndex = 6;
            btnReporteProducto.Text = "Producto 📦";
            btnReporteProducto.UseVisualStyleBackColor = true;
            btnReporteProducto.Click += btnReporteProducto_Click;
            // 
            // btnReporteCliente
            // 
            btnReporteCliente.Cursor = Cursors.Hand;
            btnReporteCliente.Dock = DockStyle.Fill;
            btnReporteCliente.FlatAppearance.BorderSize = 0;
            btnReporteCliente.FlatStyle = FlatStyle.Flat;
            btnReporteCliente.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteCliente.ForeColor = Color.DarkSlateGray;
            btnReporteCliente.Location = new Point(1743, 3);
            btnReporteCliente.Margin = new Padding(0);
            btnReporteCliente.Name = "btnReporteCliente";
            btnReporteCliente.Size = new Size(433, 94);
            btnReporteCliente.TabIndex = 5;
            btnReporteCliente.Text = "Cliente 👤";
            btnReporteCliente.UseVisualStyleBackColor = true;
            btnReporteCliente.Click += btnReporteCliente_Click;
            // 
            // pnelppaltitulo
            // 
            pnelppaltitulo.BackColor = Color.DarkSlateGray;
            pnelppaltitulo.Controls.Add(lblTituloGR);
            pnelppaltitulo.Controls.Add(btnSalir);
            pnelppaltitulo.Controls.Add(btnVolver);
            pnelppaltitulo.Dock = DockStyle.Top;
            pnelppaltitulo.Location = new Point(0, 0);
            pnelppaltitulo.Margin = new Padding(1);
            pnelppaltitulo.Name = "pnelppaltitulo";
            pnelppaltitulo.Size = new Size(2179, 80);
            pnelppaltitulo.TabIndex = 14;
            // 
            // lblTituloGR
            // 
            lblTituloGR.Anchor = AnchorStyles.Top;
            lblTituloGR.AutoSize = true;
            lblTituloGR.BackColor = Color.Transparent;
            lblTituloGR.Font = new Font("Calibri", 28F, FontStyle.Bold);
            lblTituloGR.ForeColor = Color.White;
            lblTituloGR.Location = new Point(823, 6);
            lblTituloGR.Margin = new Padding(2, 0, 2, 0);
            lblTituloGR.Name = "lblTituloGR";
            lblTituloGR.Size = new Size(513, 68);
            lblTituloGR.TabIndex = 15;
            lblTituloGR.Text = "Reportes y Consultas";
            lblTituloGR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(2089, 0);
            btnSalir.Margin = new Padding(2, 4, 2, 4);
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
            btnVolver.Margin = new Padding(2, 4, 2, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(90, 80);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "↩️";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // Ventana_Reportes_Y_Consultas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2179, 973);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2, 4, 2, 4);
            MaximumSize = new Size(2201, 1029);
            MinimumSize = new Size(2201, 1029);
            Name = "Ventana_Reportes_Y_Consultas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes ";
            pnelppalmedio.ResumeLayout(false);
            tlpDivision.ResumeLayout(false);
            Grpfiltros.ResumeLayout(false);
            tlpRegistroStock.ResumeLayout(false);
            tlpRegistroStock.PerformLayout();
            tlpMetodoPago.ResumeLayout(false);
            tlpMetodoPago.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            tlpBotones.ResumeLayout(false);
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private GroupBox grbGrillaClientes;
        private Panel pnelppaltitulo;
        private Button btnReporteSucursal;
        private Button btnVolver;
        private Button btnSalir;
        private Button btnReporteProducto;
        private Button btnReporteCliente;
        private Button btnReporteVenta;
        private GroupBox Grpfiltros;
        private Button btnlimpiar;
        private Button btnaplicar;
        private TextBox txtNombreVendedor;
        private Label lblTituloGR;
        private TableLayoutPanel tlpBotones;
        private TableLayoutPanel tlpDivision;
        private TableLayoutPanel tlpRegistroStock;
        private TextBox textBox1;
        private Label lblNombreVendedor;
        private Label label3;
        private TableLayoutPanel tlpMetodoPago;
        private RadioButton rdbTarjeta;
        private RadioButton rdbTransferencia;
        private RadioButton rdbEfectivo;
        private Label lblMetodoPago;
        private Label lblCliente;
        private Label lblProducto;
        private ComboBox cmbProducto;
        private Label lblSucursal;
        private ComboBox cmbSucursales;
        private NumericUpDown nudTotal;
        private ComboBox cmbClientes;
        private DateTimePicker dtpFechaDesde;
        private Button btnLimpiarCampos;
        private ComboBox cmbVendedor;
        private Label lblFechaHasta;
        private DateTimePicker dtpFechaHasta;
        private Button btnAplicarFiltros;
        private Label lblCantidad;
        private Label lblFechaDesde;
        private Label lblDashBoard;
        private Button btnRefrescar;
        private GroupBox groupBox1;
        private DataGridView dgvReportes;
        private Button btnReporteGeneral;
    }
}