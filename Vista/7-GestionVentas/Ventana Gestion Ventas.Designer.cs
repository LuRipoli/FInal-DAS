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
            pnelppalmedio = new Panel();
            grbBuscarSucursal = new GroupBox();
            btnBuscar = new Button();
            lblId = new Label();
            txtNombreBuscado = new TextBox();
            grbGrillaVentas = new GroupBox();
            dgvSucursales = new DataGridView();
            grbIngresoDatos = new GroupBox();
            cmbProducto = new ComboBox();
            label5 = new Label();
            btnAgregar = new Button();
            grbMetodoDePago = new GroupBox();
            rbtTransferencia = new RadioButton();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            txtTotal = new TextBox();
            label3 = new Label();
            txtDescuento = new TextBox();
            label2 = new Label();
            cmbClientes = new ComboBox();
            label1 = new Label();
            cmbSucursales = new ComboBox();
            lblNombre = new Label();
            pnelppaltitulo = new Panel();
            lblTituloPrograma = new Label();
            pnelppalbotones = new Panel();
            btnBuscarVenta = new Button();
            btnVolver = new Button();
            btnSalir = new Button();
            btnAgregarVenta = new Button();
            pnelppalmedio.SuspendLayout();
            grbBuscarSucursal.SuspendLayout();
            grbGrillaVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            grbIngresoDatos.SuspendLayout();
            grbMetodoDePago.SuspendLayout();
            pnelppaltitulo.SuspendLayout();
            pnelppalbotones.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.ActiveCaption;
            pnelppalmedio.Controls.Add(grbBuscarSucursal);
            pnelppalmedio.Controls.Add(grbGrillaVentas);
            pnelppalmedio.Controls.Add(grbIngresoDatos);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(241, 120);
            pnelppalmedio.Margin = new Padding(2);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1137, 700);
            pnelppalmedio.TabIndex = 15;
            pnelppalmedio.Paint += pnelppalmedio_Paint;
            // 
            // grbBuscarSucursal
            // 
            grbBuscarSucursal.Controls.Add(btnBuscar);
            grbBuscarSucursal.Controls.Add(lblId);
            grbBuscarSucursal.Controls.Add(txtNombreBuscado);
            grbBuscarSucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbBuscarSucursal.Location = new Point(41, 486);
            grbBuscarSucursal.Margin = new Padding(2);
            grbBuscarSucursal.Name = "grbBuscarSucursal";
            grbBuscarSucursal.Padding = new Padding(2);
            grbBuscarSucursal.Size = new Size(317, 138);
            grbBuscarSucursal.TabIndex = 19;
            grbBuscarSucursal.TabStop = false;
            grbBuscarSucursal.Text = "Buscar Sucursal";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.HighlightText;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(103, 78);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(117, 35);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.Location = new Point(81, 20);
            lblId.Margin = new Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(154, 20);
            lblId.TabIndex = 18;
            lblId.Text = "Nombre de Sucursal:";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombreBuscado
            // 
            txtNombreBuscado.Font = new Font("Segoe UI", 9F);
            txtNombreBuscado.Location = new Point(31, 47);
            txtNombreBuscado.Margin = new Padding(2);
            txtNombreBuscado.Name = "txtNombreBuscado";
            txtNombreBuscado.Size = new Size(257, 27);
            txtNombreBuscado.TabIndex = 17;
            // 
            // grbGrillaVentas
            // 
            grbGrillaVentas.BackgroundImageLayout = ImageLayout.None;
            grbGrillaVentas.Controls.Add(dgvSucursales);
            grbGrillaVentas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbGrillaVentas.Location = new Point(386, 58);
            grbGrillaVentas.Margin = new Padding(2);
            grbGrillaVentas.Name = "grbGrillaVentas";
            grbGrillaVentas.Padding = new Padding(2);
            grbGrillaVentas.Size = new Size(655, 463);
            grbGrillaVentas.TabIndex = 18;
            grbGrillaVentas.TabStop = false;
            grbGrillaVentas.Text = "Grilla de Ventas";
            // 
            // dgvSucursales
            // 
            dgvSucursales.AllowUserToAddRows = false;
            dgvSucursales.AllowUserToDeleteRows = false;
            dgvSucursales.AllowUserToResizeColumns = false;
            dgvSucursales.AllowUserToResizeRows = false;
            dgvSucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSucursales.BackgroundColor = SystemColors.GrayText;
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursales.Location = new Point(20, 34);
            dgvSucursales.Margin = new Padding(2);
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.RowHeadersWidth = 62;
            dgvSucursales.Size = new Size(619, 414);
            dgvSucursales.TabIndex = 1;
            // 
            // grbIngresoDatos
            // 
            grbIngresoDatos.Controls.Add(cmbProducto);
            grbIngresoDatos.Controls.Add(label5);
            grbIngresoDatos.Controls.Add(btnAgregar);
            grbIngresoDatos.Controls.Add(grbMetodoDePago);
            grbIngresoDatos.Controls.Add(dtpFecha);
            grbIngresoDatos.Controls.Add(label4);
            grbIngresoDatos.Controls.Add(txtTotal);
            grbIngresoDatos.Controls.Add(label3);
            grbIngresoDatos.Controls.Add(txtDescuento);
            grbIngresoDatos.Controls.Add(label2);
            grbIngresoDatos.Controls.Add(cmbClientes);
            grbIngresoDatos.Controls.Add(label1);
            grbIngresoDatos.Controls.Add(cmbSucursales);
            grbIngresoDatos.Controls.Add(lblNombre);
            grbIngresoDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbIngresoDatos.Location = new Point(41, 58);
            grbIngresoDatos.Margin = new Padding(2);
            grbIngresoDatos.Name = "grbIngresoDatos";
            grbIngresoDatos.Padding = new Padding(2);
            grbIngresoDatos.Size = new Size(319, 411);
            grbIngresoDatos.TabIndex = 17;
            grbIngresoDatos.TabStop = false;
            grbIngresoDatos.Text = "Ingreso de Datos";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(91, 181);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(144, 28);
            cmbProducto.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(95, 161);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 28;
            label5.Text = "Producto:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.HighlightText;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(105, 363);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 34);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // grbMetodoDePago
            // 
            grbMetodoDePago.Controls.Add(rbtTransferencia);
            grbMetodoDePago.Controls.Add(rbtTarjeta);
            grbMetodoDePago.Controls.Add(rbtEfectivo);
            grbMetodoDePago.Location = new Point(5, 274);
            grbMetodoDePago.Name = "grbMetodoDePago";
            grbMetodoDePago.Size = new Size(309, 84);
            grbMetodoDePago.TabIndex = 27;
            grbMetodoDePago.TabStop = false;
            grbMetodoDePago.Text = "Metodo de Pago";
            // 
            // rbtTransferencia
            // 
            rbtTransferencia.AutoSize = true;
            rbtTransferencia.Location = new Point(6, 54);
            rbtTransferencia.Name = "rbtTransferencia";
            rbtTransferencia.Size = new Size(124, 24);
            rbtTransferencia.TabIndex = 22;
            rbtTransferencia.TabStop = true;
            rbtTransferencia.Text = "Transferencia";
            rbtTransferencia.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(186, 26);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(78, 24);
            rbtTarjeta.TabIndex = 21;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(6, 26);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(86, 24);
            rbtEfectivo.TabIndex = 20;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(5, 241);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(309, 27);
            dtpFecha.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(9, 218);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 25;
            label4.Text = "Fecha:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 9F);
            txtTotal.Location = new Point(170, 117);
            txtTotal.Margin = new Padding(2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(144, 27);
            txtTotal.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(174, 95);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 24;
            label3.Text = "Total:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescuento
            // 
            txtDescuento.Font = new Font("Segoe UI", 9F);
            txtDescuento.Location = new Point(5, 117);
            txtDescuento.Margin = new Padding(2);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(144, 27);
            txtDescuento.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(9, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 22;
            label2.Text = "% de Descuento:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(170, 57);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(144, 28);
            cmbClientes.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(174, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 20;
            label1.Text = "Cliente:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbSucursales
            // 
            cmbSucursales.FormattingEnabled = true;
            cmbSucursales.Location = new Point(5, 57);
            cmbSucursales.Name = "cmbSucursales";
            cmbSucursales.Size = new Size(144, 28);
            cmbSucursales.TabIndex = 19;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(9, 37);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Sucursal:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnelppaltitulo
            // 
            pnelppaltitulo.BackColor = SystemColors.ControlLightLight;
            pnelppaltitulo.Controls.Add(lblTituloPrograma);
            pnelppaltitulo.Dock = DockStyle.Top;
            pnelppaltitulo.Location = new Point(241, 0);
            pnelppaltitulo.Margin = new Padding(2);
            pnelppaltitulo.Name = "pnelppaltitulo";
            pnelppaltitulo.Size = new Size(1137, 120);
            pnelppaltitulo.TabIndex = 14;
            // 
            // lblTituloPrograma
            // 
            lblTituloPrograma.AutoSize = true;
            lblTituloPrograma.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloPrograma.Location = new Point(366, 40);
            lblTituloPrograma.Margin = new Padding(2, 0, 2, 0);
            lblTituloPrograma.Name = "lblTituloPrograma";
            lblTituloPrograma.Size = new Size(305, 46);
            lblTituloPrograma.TabIndex = 0;
            lblTituloPrograma.Text = "Gestión de Ventas";
            lblTituloPrograma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnelppalbotones
            // 
            pnelppalbotones.BackColor = SystemColors.GrayText;
            pnelppalbotones.Controls.Add(btnBuscarVenta);
            pnelppalbotones.Controls.Add(btnVolver);
            pnelppalbotones.Controls.Add(btnSalir);
            pnelppalbotones.Controls.Add(btnAgregarVenta);
            pnelppalbotones.Dock = DockStyle.Left;
            pnelppalbotones.Location = new Point(0, 0);
            pnelppalbotones.Margin = new Padding(2);
            pnelppalbotones.Name = "pnelppalbotones";
            pnelppalbotones.Size = new Size(241, 820);
            pnelppalbotones.TabIndex = 13;
            pnelppalbotones.Paint += pnelppalbotones_Paint;
            // 
            // btnBuscarVenta
            // 
            btnBuscarVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarVenta.Location = new Point(38, 302);
            btnBuscarVenta.Margin = new Padding(2);
            btnBuscarVenta.Name = "btnBuscarVenta";
            btnBuscarVenta.Size = new Size(164, 56);
            btnBuscarVenta.TabIndex = 10;
            btnBuscarVenta.Text = "Buscar Venta";
            btnBuscarVenta.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.Location = new Point(38, 372);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(164, 56);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(38, 442);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(164, 56);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir del Programa";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarVenta.Location = new Point(38, 236);
            btnAgregarVenta.Margin = new Padding(2);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(164, 56);
            btnAgregarVenta.TabIndex = 4;
            btnAgregarVenta.Text = "Agregar Venta";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarSucursal_Click;
            // 
            // Ventana_Gestion_Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 820);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            Controls.Add(pnelppalbotones);
            Margin = new Padding(2);
            Name = "Ventana_Gestion_Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventana_Gestion_Ventas";
            pnelppalmedio.ResumeLayout(false);
            grbBuscarSucursal.ResumeLayout(false);
            grbBuscarSucursal.PerformLayout();
            grbGrillaVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            grbIngresoDatos.ResumeLayout(false);
            grbIngresoDatos.PerformLayout();
            grbMetodoDePago.ResumeLayout(false);
            grbMetodoDePago.PerformLayout();
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            pnelppalbotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private GroupBox grbBuscarSucursal;
        private Button btnBuscar;
        private Label lblId;
        private TextBox txtNombreBuscado;
        private GroupBox grbGrillaVentas;
        private DataGridView dgvSucursales;
        private GroupBox grbIngresoDatos;
        private Label lblNombre;
        private Panel pnelppaltitulo;
        private Label lblTituloPrograma;
        private Panel pnelppalbotones;
        private Button btnBuscarVenta;
        private Button btnVolver;
        private Button btnSalir;
        private Button btnAgregarVenta;
        private TextBox txtTotal;
        private Label label3;
        private TextBox txtDescuento;
        private Label label2;
        private ComboBox cmbClientes;
        private Label label1;
        private ComboBox cmbSucursales;
        private GroupBox grbMetodoDePago;
        private RadioButton rbtTransferencia;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private DateTimePicker dtpFecha;
        private Label label4;
        private Button btnAgregar;
        private ComboBox cmbProducto;
        private Label label5;
    }
}