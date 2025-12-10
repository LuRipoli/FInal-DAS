namespace Vista
{
    partial class Ventana_Gestion_Ventas
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
            tlpDatos = new TableLayoutPanel();
            grbDatos = new GroupBox();
            btnBuscar = new Button();
            btnLimpiarCampos = new Button();
            tlpRegistroStock = new TableLayoutPanel();
            txtTotal = new TextBox();
            txtNombreVendedor = new TextBox();
            label9 = new Label();
            nudCantidad = new NumericUpDown();
            label8 = new Label();
            label3 = new Label();
            tlpTipoCliente = new TableLayoutPanel();
            rdbTarjeta = new RadioButton();
            rdbTransferencia = new RadioButton();
            rdbEfectivo = new RadioButton();
            nudDescuento = new NumericUpDown();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblProducto = new Label();
            cmbProducto = new ComboBox();
            lblSucursal = new Label();
            cmbSucursales = new ComboBox();
            cmbClientes = new ComboBox();
            dtpFecha = new DateTimePicker();
            lblCantidad = new Label();
            tlpBuscar = new TableLayoutPanel();
            dtpFechaBuscada = new DateTimePicker();
            label6 = new Label();
            grbGrillaVentas = new GroupBox();
            btnRefrescar = new Button();
            dgvVentas = new DataGridView();
            tlpDivision = new TableLayoutPanel();
            btnAgregar = new Button();
            btnBuscarVenta = new Button();
            pnelppaltitulo = new Panel();
            lblTituloGR = new Label();
            btnVolver = new Button();
            btnSalir = new Button();
            pnelppalmedio.SuspendLayout();
            tlpDatos.SuspendLayout();
            grbDatos.SuspendLayout();
            tlpRegistroStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            tlpTipoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).BeginInit();
            tlpBuscar.SuspendLayout();
            grbGrillaVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            tlpDivision.SuspendLayout();
            pnelppaltitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.AppWorkspace;
            pnelppalmedio.Controls.Add(tlpDatos);
            pnelppalmedio.Controls.Add(tlpDivision);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(0, 80);
            pnelppalmedio.Margin = new Padding(2);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(2004, 863);
            pnelppalmedio.TabIndex = 15;
            // 
            // tlpDatos
            // 
            tlpDatos.ColumnCount = 2;
            tlpDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpDatos.Controls.Add(grbDatos, 0, 0);
            tlpDatos.Controls.Add(grbGrillaVentas, 1, 0);
            tlpDatos.Dock = DockStyle.Fill;
            tlpDatos.Location = new Point(0, 100);
            tlpDatos.Name = "tlpDatos";
            tlpDatos.RowCount = 1;
            tlpDatos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDatos.Size = new Size(2004, 763);
            tlpDatos.TabIndex = 21;
            // 
            // grbDatos
            // 
            grbDatos.Controls.Add(btnBuscar);
            grbDatos.Controls.Add(btnLimpiarCampos);
            grbDatos.Controls.Add(tlpRegistroStock);
            grbDatos.Controls.Add(tlpBuscar);
            grbDatos.Dock = DockStyle.Fill;
            grbDatos.FlatStyle = FlatStyle.Flat;
            grbDatos.Location = new Point(0, 0);
            grbDatos.Margin = new Padding(0);
            grbDatos.Name = "grbDatos";
            grbDatos.Padding = new Padding(0);
            grbDatos.Size = new Size(801, 763);
            grbDatos.TabIndex = 21;
            grbDatos.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkSlateGray;
            btnBuscar.Dock = DockStyle.Bottom;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(0, 698);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(801, 65);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar Venta";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
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
            btnLimpiarCampos.Location = new Point(0, 24);
            btnLimpiarCampos.Margin = new Padding(0);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(801, 65);
            btnLimpiarCampos.TabIndex = 2;
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
            tlpRegistroStock.Controls.Add(txtTotal, 1, 7);
            tlpRegistroStock.Controls.Add(txtNombreVendedor, 1, 3);
            tlpRegistroStock.Controls.Add(label9, 0, 3);
            tlpRegistroStock.Controls.Add(nudCantidad, 1, 4);
            tlpRegistroStock.Controls.Add(label8, 0, 4);
            tlpRegistroStock.Controls.Add(label3, 0, 8);
            tlpRegistroStock.Controls.Add(tlpTipoCliente, 1, 6);
            tlpRegistroStock.Controls.Add(nudDescuento, 1, 5);
            tlpRegistroStock.Controls.Add(label7, 0, 6);
            tlpRegistroStock.Controls.Add(label2, 0, 5);
            tlpRegistroStock.Controls.Add(label1, 0, 2);
            tlpRegistroStock.Controls.Add(lblProducto, 0, 0);
            tlpRegistroStock.Controls.Add(cmbProducto, 1, 0);
            tlpRegistroStock.Controls.Add(lblSucursal, 0, 1);
            tlpRegistroStock.Controls.Add(cmbSucursales, 1, 1);
            tlpRegistroStock.Controls.Add(cmbClientes, 1, 2);
            tlpRegistroStock.Controls.Add(dtpFecha, 1, 8);
            tlpRegistroStock.Controls.Add(lblCantidad, 0, 7);
            tlpRegistroStock.Location = new Point(3, 92);
            tlpRegistroStock.Name = "tlpRegistroStock";
            tlpRegistroStock.RowCount = 9;
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tlpRegistroStock.Size = new Size(795, 530);
            tlpRegistroStock.TabIndex = 26;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(308, 417);
            txtTotal.Margin = new Padding(8);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(476, 42);
            txtTotal.TabIndex = 35;
            // 
            // txtNombreVendedor
            // 
            txtNombreVendedor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreVendedor.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreVendedor.Location = new Point(308, 185);
            txtNombreVendedor.Margin = new Padding(8);
            txtNombreVendedor.Name = "txtNombreVendedor";
            txtNombreVendedor.Size = new Size(476, 42);
            txtNombreVendedor.TabIndex = 34;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(6, 187);
            label9.Name = "label9";
            label9.Size = new Size(288, 35);
            label9.TabIndex = 33;
            label9.Text = "Nombre Vendedor:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudCantidad
            // 
            nudCantidad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudCantidad.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidad.Location = new Point(308, 243);
            nudCantidad.Margin = new Padding(8);
            nudCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(476, 42);
            nudCantidad.TabIndex = 32;
            nudCantidad.TextAlign = HorizontalAlignment.Center;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(6, 245);
            label8.Name = "label8";
            label8.Size = new Size(288, 35);
            label8.TabIndex = 31;
            label8.Text = "Cantidad Vendida:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(6, 479);
            label3.Name = "label3";
            label3.Size = new Size(288, 35);
            label3.TabIndex = 30;
            label3.Text = "Fecha de la Venta:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpTipoCliente
            // 
            tlpTipoCliente.ColumnCount = 3;
            tlpTipoCliente.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpTipoCliente.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpTipoCliente.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpTipoCliente.Controls.Add(rdbTarjeta, 2, 0);
            tlpTipoCliente.Controls.Add(rdbTransferencia, 1, 0);
            tlpTipoCliente.Controls.Add(rdbEfectivo, 0, 0);
            tlpTipoCliente.Dock = DockStyle.Fill;
            tlpTipoCliente.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlpTipoCliente.Location = new Point(300, 351);
            tlpTipoCliente.Margin = new Padding(0);
            tlpTipoCliente.Name = "tlpTipoCliente";
            tlpTipoCliente.RowCount = 1;
            tlpTipoCliente.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTipoCliente.Size = new Size(492, 55);
            tlpTipoCliente.TabIndex = 29;
            // 
            // rdbTarjeta
            // 
            rdbTarjeta.AutoSize = true;
            rdbTarjeta.Dock = DockStyle.Fill;
            rdbTarjeta.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdbTarjeta.ForeColor = Color.DarkSlateGray;
            rdbTarjeta.Location = new Point(347, 4);
            rdbTarjeta.Margin = new Padding(4);
            rdbTarjeta.Name = "rdbTarjeta";
            rdbTarjeta.Size = new Size(141, 47);
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
            rdbTransferencia.Location = new Point(151, 11);
            rdbTransferencia.Margin = new Padding(4);
            rdbTransferencia.Name = "rdbTransferencia";
            rdbTransferencia.Size = new Size(188, 33);
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
            rdbEfectivo.Location = new Point(4, 11);
            rdbEfectivo.Margin = new Padding(4);
            rdbEfectivo.Name = "rdbEfectivo";
            rdbEfectivo.Size = new Size(139, 33);
            rdbEfectivo.TabIndex = 20;
            rdbEfectivo.TabStop = true;
            rdbEfectivo.Text = "Efectivo";
            rdbEfectivo.TextAlign = ContentAlignment.MiddleCenter;
            rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // nudDescuento
            // 
            nudDescuento.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudDescuento.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudDescuento.Location = new Point(308, 301);
            nudDescuento.Margin = new Padding(8);
            nudDescuento.Name = "nudDescuento";
            nudDescuento.Size = new Size(476, 42);
            nudDescuento.TabIndex = 28;
            nudDescuento.TextAlign = HorizontalAlignment.Center;
            nudDescuento.ValueChanged += nudDescuento_ValueChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(6, 361);
            label7.Name = "label7";
            label7.Size = new Size(288, 35);
            label7.TabIndex = 27;
            label7.Text = "Método de Pago:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(6, 293);
            label2.Name = "label2";
            label2.Size = new Size(288, 55);
            label2.TabIndex = 25;
            label2.Text = "Descuento Aplicado: (%)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(6, 129);
            label1.Name = "label1";
            label1.Size = new Size(288, 35);
            label1.TabIndex = 24;
            label1.Text = "Seleccionar Cliente:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProducto
            // 
            lblProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.ForeColor = Color.DarkSlateGray;
            lblProducto.Location = new Point(6, 13);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(288, 35);
            lblProducto.TabIndex = 6;
            lblProducto.Text = "Seleccionar Producto:";
            lblProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbProducto
            // 
            cmbProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbProducto.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(308, 11);
            cmbProducto.Margin = new Padding(8);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(476, 43);
            cmbProducto.TabIndex = 21;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // lblSucursal
            // 
            lblSucursal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucursal.ForeColor = Color.DarkSlateGray;
            lblSucursal.Location = new Point(6, 71);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(288, 35);
            lblSucursal.TabIndex = 18;
            lblSucursal.Text = "Seleccionar Sucursal:";
            lblSucursal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbSucursales
            // 
            cmbSucursales.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSucursales.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSucursales.FormattingEnabled = true;
            cmbSucursales.Location = new Point(308, 69);
            cmbSucursales.Margin = new Padding(8);
            cmbSucursales.Name = "cmbSucursales";
            cmbSucursales.Size = new Size(476, 43);
            cmbSucursales.TabIndex = 22;
            // 
            // cmbClientes
            // 
            cmbClientes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbClientes.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(308, 127);
            cmbClientes.Margin = new Padding(8);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(476, 43);
            cmbClientes.TabIndex = 21;
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFecha.CalendarFont = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Location = new Point(308, 476);
            dtpFecha.Margin = new Padding(8);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(476, 42);
            dtpFecha.TabIndex = 26;
            // 
            // lblCantidad
            // 
            lblCantidad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.DarkSlateGray;
            lblCantidad.Location = new Point(6, 419);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(288, 35);
            lblCantidad.TabIndex = 20;
            lblCantidad.Text = "Total de la Venta: ($)";
            lblCantidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpBuscar
            // 
            tlpBuscar.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpBuscar.ColumnCount = 2;
            tlpBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tlpBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tlpBuscar.Controls.Add(dtpFechaBuscada, 1, 0);
            tlpBuscar.Controls.Add(label6, 0, 0);
            tlpBuscar.Location = new Point(3, 618);
            tlpBuscar.Name = "tlpBuscar";
            tlpBuscar.RowCount = 1;
            tlpBuscar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBuscar.Size = new Size(795, 79);
            tlpBuscar.TabIndex = 25;
            // 
            // dtpFechaBuscada
            // 
            dtpFechaBuscada.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaBuscada.CalendarFont = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaBuscada.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaBuscada.Location = new Point(308, 18);
            dtpFechaBuscada.Margin = new Padding(8);
            dtpFechaBuscada.Name = "dtpFechaBuscada";
            dtpFechaBuscada.Size = new Size(476, 42);
            dtpFechaBuscada.TabIndex = 27;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(6, 22);
            label6.Name = "label6";
            label6.Size = new Size(288, 35);
            label6.TabIndex = 19;
            label6.Text = "Fecha de la Venta:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grbGrillaVentas
            // 
            grbGrillaVentas.BackgroundImageLayout = ImageLayout.None;
            grbGrillaVentas.Controls.Add(btnRefrescar);
            grbGrillaVentas.Controls.Add(dgvVentas);
            grbGrillaVentas.Dock = DockStyle.Fill;
            grbGrillaVentas.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbGrillaVentas.ForeColor = Color.DarkSlateGray;
            grbGrillaVentas.Location = new Point(806, 5);
            grbGrillaVentas.Margin = new Padding(5);
            grbGrillaVentas.Name = "grbGrillaVentas";
            grbGrillaVentas.Padding = new Padding(5);
            grbGrillaVentas.Size = new Size(1193, 753);
            grbGrillaVentas.TabIndex = 18;
            grbGrillaVentas.TabStop = false;
            grbGrillaVentas.Text = "Grilla de Ventas";
            // 
            // btnRefrescar
            // 
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Calibri", 16F, FontStyle.Bold);
            btnRefrescar.ForeColor = Color.DarkSlateGray;
            btnRefrescar.Location = new Point(1145, -5);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(40, 43);
            btnRefrescar.TabIndex = 25;
            btnRefrescar.Text = "🔄";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeColumns = false;
            dgvVentas.AllowUserToResizeRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvVentas.BackgroundColor = SystemColors.GrayText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.Dock = DockStyle.Fill;
            dgvVentas.Location = new Point(5, 40);
            dgvVentas.Margin = new Padding(20);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 62;
            dgvVentas.Size = new Size(1183, 708);
            dgvVentas.TabIndex = 1;
            // 
            // tlpDivision
            // 
            tlpDivision.BackColor = Color.PaleTurquoise;
            tlpDivision.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpDivision.ColumnCount = 2;
            tlpDivision.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDivision.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDivision.Controls.Add(btnAgregar, 0, 0);
            tlpDivision.Controls.Add(btnBuscarVenta, 1, 0);
            tlpDivision.Dock = DockStyle.Top;
            tlpDivision.Location = new Point(0, 0);
            tlpDivision.Name = "tlpDivision";
            tlpDivision.RowCount = 1;
            tlpDivision.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDivision.Size = new Size(2004, 100);
            tlpDivision.TabIndex = 20;
            // 
            // btnAgregar
            // 
            btnAgregar.Dock = DockStyle.Fill;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.DarkSlateGray;
            btnAgregar.Location = new Point(3, 3);
            btnAgregar.Margin = new Padding(0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(997, 94);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Ingresar Venta ➕";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // btnBuscarVenta
            // 
            btnBuscarVenta.Dock = DockStyle.Fill;
            btnBuscarVenta.FlatAppearance.BorderSize = 0;
            btnBuscarVenta.FlatStyle = FlatStyle.Flat;
            btnBuscarVenta.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarVenta.ForeColor = Color.DarkSlateGray;
            btnBuscarVenta.Location = new Point(1003, 3);
            btnBuscarVenta.Margin = new Padding(0);
            btnBuscarVenta.Name = "btnBuscarVenta";
            btnBuscarVenta.Size = new Size(998, 94);
            btnBuscarVenta.TabIndex = 10;
            btnBuscarVenta.Text = "Buscar Venta 🔍";
            btnBuscarVenta.UseVisualStyleBackColor = true;
            btnBuscarVenta.Click += btnBuscarVenta_Click;
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
            pnelppaltitulo.Size = new Size(2004, 80);
            pnelppaltitulo.TabIndex = 14;
            // 
            // lblTituloGR
            // 
            lblTituloGR.Anchor = AnchorStyles.Top;
            lblTituloGR.AutoSize = true;
            lblTituloGR.BackColor = Color.Transparent;
            lblTituloGR.Font = new Font("Calibri", 28F, FontStyle.Bold);
            lblTituloGR.ForeColor = Color.White;
            lblTituloGR.Location = new Point(787, 9);
            lblTituloGR.Margin = new Padding(2, 0, 2, 0);
            lblTituloGR.Name = "lblTituloGR";
            lblTituloGR.Size = new Size(404, 68);
            lblTituloGR.TabIndex = 14;
            lblTituloGR.Text = "Registrar Ventas";
            lblTituloGR.TextAlign = ContentAlignment.MiddleCenter;
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
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(1914, 0);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 80);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "❌";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Ventana_Gestion_Ventas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2004, 943);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            MinimumSize = new Size(1678, 999);
            Name = "Ventana_Gestion_Ventas";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            Load += Ventana_Gestion_Ventas_Load;
            pnelppalmedio.ResumeLayout(false);
            tlpDatos.ResumeLayout(false);
            grbDatos.ResumeLayout(false);
            tlpRegistroStock.ResumeLayout(false);
            tlpRegistroStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            tlpTipoCliente.ResumeLayout(false);
            tlpTipoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).EndInit();
            tlpBuscar.ResumeLayout(false);
            tlpBuscar.PerformLayout();
            grbGrillaVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            tlpDivision.ResumeLayout(false);
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private GroupBox grbGrillaVentas;
        private DataGridView dgvVentas;
        private GroupBox grbIngresoDatos;
        private Label lblNombre;
        private Panel pnelppaltitulo;
        private TextBox txtDescuento;
        private GroupBox grbMetodoDePago;
        private RadioButton rbtTransferencia;
        private RadioButton rbtEfectivo;
        private Label label4;
        private Button btnAgregar;
        private Label label5;
        private Button btnBuscarVenta;
        private Button btnVolver;
        private Button btnSalir;
        private Button btnAgregarVenta;
        private Label lblTituloGR;
        private TableLayoutPanel tlpDivision;
        private TableLayoutPanel tlpDatos;
        private ComboBox comboBox1;
        private NumericUpDown nudCantidadIngresada;
        private TextBox txtNombreVendedor;
        private Button btnRefrescar;
        private GroupBox grbDatos;
        private Button btnBuscar;
        private Button btnLimpiarCampos;
        private TableLayoutPanel tlpRegistroStock;
        private DateTimePicker dtpFecha;
        private Label label3;
        private TableLayoutPanel tlpTipoCliente;
        private RadioButton rdbTarjeta;
        private RadioButton rdbTransferencia;
        private RadioButton rdbEfectivo;
        private NumericUpDown nudDescuento;
        private Label label7;
        private Label label2;
        private Label label1;
        private Label lblProducto;
        private ComboBox cmbProducto;
        private Label lblSucursal;
        private ComboBox cmbSucursales;
        private Label lblCantidad;
        private ComboBox cmbClientes;
        private TableLayoutPanel tlpBuscar;
        private Label label6;
        private Label label9;
        private NumericUpDown nudCantidad;
        private Label label8;
        private DateTimePicker dtpFechaBuscada;
        private TextBox txtTotal;
    }
}