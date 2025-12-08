namespace Vista
{
    partial class Ventana_Gestion_Stock
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
            tableLayoutPanel2 = new TableLayoutPanel();
            grbGrillaStockPorSucursal = new GroupBox();
            btnRefrescar = new Button();
            dgvStock = new DataGridView();
            grbDatos = new GroupBox();
            btnLimpiarCampos = new Button();
            tlpRegistroStock = new TableLayoutPanel();
            lblProducto = new Label();
            cmbProducto = new ComboBox();
            lblSucursal = new Label();
            nudCantidadIngresada = new NumericUpDown();
            cmbSucursal = new ComboBox();
            lblCantidad = new Label();
            tlpBuscar = new TableLayoutPanel();
            txtIdBuscado = new TextBox();
            lblId = new Label();
            btnBuscar = new Button();
            tlpBotones = new TableLayoutPanel();
            btnAgregarStock = new Button();
            btnBuscarSucursal = new Button();
            pnelppaltitulo = new Panel();
            lblTituloGR = new Label();
            btnSalir = new Button();
            btnVolver = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnelppalmedio.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grbGrillaStockPorSucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            grbDatos.SuspendLayout();
            tlpRegistroStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadIngresada).BeginInit();
            tlpBuscar.SuspendLayout();
            tlpBotones.SuspendLayout();
            pnelppaltitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.AppWorkspace;
            pnelppalmedio.Controls.Add(tableLayoutPanel2);
            pnelppalmedio.Controls.Add(tlpBotones);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(0, 80);
            pnelppalmedio.Margin = new Padding(2);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1291, 628);
            pnelppalmedio.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel2.Controls.Add(grbGrillaStockPorSucursal, 1, 0);
            tableLayoutPanel2.Controls.Add(grbDatos, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 152);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1291, 476);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // grbGrillaStockPorSucursal
            // 
            grbGrillaStockPorSucursal.BackgroundImageLayout = ImageLayout.None;
            grbGrillaStockPorSucursal.Controls.Add(btnRefrescar);
            grbGrillaStockPorSucursal.Controls.Add(dgvStock);
            grbGrillaStockPorSucursal.Dock = DockStyle.Fill;
            grbGrillaStockPorSucursal.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbGrillaStockPorSucursal.ForeColor = Color.DarkSlateGray;
            grbGrillaStockPorSucursal.Location = new Point(583, 3);
            grbGrillaStockPorSucursal.Name = "grbGrillaStockPorSucursal";
            grbGrillaStockPorSucursal.Size = new Size(705, 470);
            grbGrillaStockPorSucursal.TabIndex = 18;
            grbGrillaStockPorSucursal.TabStop = false;
            grbGrillaStockPorSucursal.Text = "Grilla Stock Por Sucursal";
            // 
            // btnRefrescar
            // 
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Calibri", 16F, FontStyle.Bold);
            btnRefrescar.ForeColor = Color.DarkSlateGray;
            btnRefrescar.Location = new Point(661, -5);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(40, 43);
            btnRefrescar.TabIndex = 24;
            btnRefrescar.Text = "🔄";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // dgvStock
            // 
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AllowUserToDeleteRows = false;
            dgvStock.AllowUserToResizeColumns = false;
            dgvStock.AllowUserToResizeRows = false;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.BackgroundColor = SystemColors.GrayText;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvStock.DefaultCellStyle = dataGridViewCellStyle5;
            dgvStock.Dock = DockStyle.Fill;
            dgvStock.Location = new Point(3, 38);
            dgvStock.Margin = new Padding(2);
            dgvStock.Name = "dgvStock";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvStock.RowHeadersWidth = 62;
            dgvStock.Size = new Size(699, 429);
            dgvStock.TabIndex = 1;
            // 
            // grbDatos
            // 
            grbDatos.Controls.Add(btnLimpiarCampos);
            grbDatos.Controls.Add(tlpRegistroStock);
            grbDatos.Controls.Add(tlpBuscar);
            grbDatos.Controls.Add(btnBuscar);
            grbDatos.Dock = DockStyle.Fill;
            grbDatos.FlatStyle = FlatStyle.Flat;
            grbDatos.Location = new Point(0, 0);
            grbDatos.Margin = new Padding(0);
            grbDatos.Name = "grbDatos";
            grbDatos.Size = new Size(580, 476);
            grbDatos.TabIndex = 19;
            grbDatos.TabStop = false;
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
            btnLimpiarCampos.Size = new Size(574, 65);
            btnLimpiarCampos.TabIndex = 27;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // tlpRegistroStock
            // 
            tlpRegistroStock.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpRegistroStock.ColumnCount = 2;
            tlpRegistroStock.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRegistroStock.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRegistroStock.Controls.Add(lblProducto, 0, 0);
            tlpRegistroStock.Controls.Add(cmbProducto, 1, 0);
            tlpRegistroStock.Controls.Add(lblSucursal, 0, 1);
            tlpRegistroStock.Controls.Add(nudCantidadIngresada, 1, 2);
            tlpRegistroStock.Controls.Add(cmbSucursal, 1, 1);
            tlpRegistroStock.Controls.Add(lblCantidad, 0, 2);
            tlpRegistroStock.Location = new Point(3, 95);
            tlpRegistroStock.Name = "tlpRegistroStock";
            tlpRegistroStock.RowCount = 3;
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpRegistroStock.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpRegistroStock.Size = new Size(574, 200);
            tlpRegistroStock.TabIndex = 26;
            // 
            // lblProducto
            // 
            lblProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.ForeColor = Color.DarkSlateGray;
            lblProducto.Location = new Point(6, 16);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(276, 35);
            lblProducto.TabIndex = 6;
            lblProducto.Text = "Seleccionar Producto:";
            lblProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbProducto
            // 
            cmbProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbProducto.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(296, 12);
            cmbProducto.Margin = new Padding(8);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(267, 43);
            cmbProducto.TabIndex = 21;
            // 
            // lblSucursal
            // 
            lblSucursal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucursal.ForeColor = Color.DarkSlateGray;
            lblSucursal.Location = new Point(6, 81);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(276, 35);
            lblSucursal.TabIndex = 18;
            lblSucursal.Text = "Seleccionar Sucursal:";
            lblSucursal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudCantidadIngresada
            // 
            nudCantidadIngresada.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudCantidadIngresada.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidadIngresada.Location = new Point(296, 144);
            nudCantidadIngresada.Margin = new Padding(8);
            nudCantidadIngresada.Name = "nudCantidadIngresada";
            nudCantidadIngresada.Size = new Size(267, 42);
            nudCantidadIngresada.TabIndex = 23;
            nudCantidadIngresada.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbSucursal
            // 
            cmbSucursal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSucursal.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(296, 77);
            cmbSucursal.Margin = new Padding(8);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(267, 43);
            cmbSucursal.TabIndex = 22;
            // 
            // lblCantidad
            // 
            lblCantidad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.DarkSlateGray;
            lblCantidad.Location = new Point(6, 147);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(276, 35);
            lblCantidad.TabIndex = 20;
            lblCantidad.Text = "Cantidad Ingresada:";
            lblCantidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpBuscar
            // 
            tlpBuscar.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpBuscar.ColumnCount = 2;
            tlpBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBuscar.Controls.Add(txtIdBuscado, 1, 0);
            tlpBuscar.Controls.Add(lblId, 0, 0);
            tlpBuscar.Dock = DockStyle.Bottom;
            tlpBuscar.Location = new Point(3, 292);
            tlpBuscar.Name = "tlpBuscar";
            tlpBuscar.RowCount = 1;
            tlpBuscar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBuscar.Size = new Size(574, 116);
            tlpBuscar.TabIndex = 25;
            // 
            // txtIdBuscado
            // 
            txtIdBuscado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIdBuscado.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdBuscado.Location = new Point(296, 37);
            txtIdBuscado.Margin = new Padding(8);
            txtIdBuscado.Name = "txtIdBuscado";
            txtIdBuscado.Size = new Size(267, 42);
            txtIdBuscado.TabIndex = 20;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.DarkSlateGray;
            lblId.Location = new Point(6, 40);
            lblId.Name = "lblId";
            lblId.Size = new Size(276, 35);
            lblId.TabIndex = 19;
            lblId.Text = "ID Sucursal Buscada:";
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
            btnBuscar.Location = new Point(3, 408);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(574, 65);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "Buscar Sucursal";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // tlpBotones
            // 
            tlpBotones.BackColor = Color.PaleTurquoise;
            tlpBotones.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpBotones.ColumnCount = 2;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotones.Controls.Add(btnAgregarStock, 0, 0);
            tlpBotones.Controls.Add(btnBuscarSucursal, 1, 0);
            tlpBotones.Cursor = Cursors.No;
            tlpBotones.Dock = DockStyle.Top;
            tlpBotones.Location = new Point(0, 0);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 1;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpBotones.Size = new Size(1291, 152);
            tlpBotones.TabIndex = 23;
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.Cursor = Cursors.Hand;
            btnAgregarStock.Dock = DockStyle.Fill;
            btnAgregarStock.FlatAppearance.BorderSize = 0;
            btnAgregarStock.FlatStyle = FlatStyle.Flat;
            btnAgregarStock.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarStock.ForeColor = Color.DarkSlateGray;
            btnAgregarStock.Location = new Point(6, 6);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(635, 140);
            btnAgregarStock.TabIndex = 4;
            btnAgregarStock.Text = "Ingresar Mercadería ➕";
            btnAgregarStock.UseVisualStyleBackColor = true;
            btnAgregarStock.Click += btnAgregarStock_Click;
            // 
            // btnBuscarSucursal
            // 
            btnBuscarSucursal.Cursor = Cursors.Hand;
            btnBuscarSucursal.Dock = DockStyle.Fill;
            btnBuscarSucursal.FlatAppearance.BorderSize = 0;
            btnBuscarSucursal.FlatStyle = FlatStyle.Flat;
            btnBuscarSucursal.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarSucursal.ForeColor = Color.DarkSlateGray;
            btnBuscarSucursal.Location = new Point(650, 6);
            btnBuscarSucursal.Name = "btnBuscarSucursal";
            btnBuscarSucursal.Size = new Size(635, 140);
            btnBuscarSucursal.TabIndex = 10;
            btnBuscarSucursal.Text = "Buscar Sucursal 🔍";
            btnBuscarSucursal.UseVisualStyleBackColor = true;
            btnBuscarSucursal.Click += btnBuscarSucursal_Click;
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
            pnelppaltitulo.Size = new Size(1291, 80);
            pnelppaltitulo.TabIndex = 20;
            // 
            // lblTituloGR
            // 
            lblTituloGR.Anchor = AnchorStyles.Top;
            lblTituloGR.AutoSize = true;
            lblTituloGR.BackColor = Color.Transparent;
            lblTituloGR.Font = new Font("Calibri", 28F, FontStyle.Bold);
            lblTituloGR.ForeColor = Color.White;
            lblTituloGR.Location = new Point(413, 6);
            lblTituloGR.Margin = new Padding(2, 0, 2, 0);
            lblTituloGR.Name = "lblTituloGR";
            lblTituloGR.Size = new Size(430, 68);
            lblTituloGR.TabIndex = 13;
            lblTituloGR.Text = "Gestión de Stock:";
            lblTituloGR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(1201, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 80);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "❌";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnVolver
            // 
            btnVolver.Cursor = Cursors.Hand;
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
            // Ventana_Gestion_Stock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 708);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(1313, 764);
            MinimumSize = new Size(1313, 764);
            Name = "Ventana_Gestion_Stock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock";
            pnelppalmedio.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            grbGrillaStockPorSucursal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            grbDatos.ResumeLayout(false);
            tlpRegistroStock.ResumeLayout(false);
            tlpRegistroStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadIngresada).EndInit();
            tlpBuscar.ResumeLayout(false);
            tlpBuscar.PerformLayout();
            tlpBotones.ResumeLayout(false);
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private GroupBox grbGrillaStockPorSucursal;
        private DataGridView dgvStock;
        private Label lblCantidad;
        private Label lblSucursal;
        private Label lblProducto;
        private Panel pnelppaltitulo;
        private Button btnBuscarSucursal;
        private Button btnVolver;
        private Button btnSalir;
        private Button btnAgregarStock;
        private NumericUpDown nudCantidadIngresada;
        private ComboBox cmbSucursal;
        private ComboBox cmbProducto;
        private Label lblTituloGR;
        private TableLayoutPanel tlpBotones;
        private TableLayoutPanel tableLayoutPanel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grbDatos;
        private TableLayoutPanel tlpBuscar;
        private Button btnBuscar;
        private Label lblId;
        private TableLayoutPanel tlpRegistroStock;
        private TextBox txtIdBuscado;
        private Button btnRefrescar;
        private Button btnLimpiarCampos;
    }
}