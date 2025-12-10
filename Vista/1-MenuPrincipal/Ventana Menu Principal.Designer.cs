namespace Vista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnelppaltitulo = new Panel();
            btnSalir = new Button();
            lblTituloGR = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            tlpBotones = new TableLayoutPanel();
            btnRegistrarIngresos = new Button();
            btnGestionarSucursales = new Button();
            btnReportesYConsultas = new Button();
            btnRegistrarVentas = new Button();
            btnGestionProductos = new Button();
            GestionDeCategorias = new Button();
            btnGestionClientes = new Button();
            tlpDatos = new TableLayoutPanel();
            grbProductosBajoStock = new GroupBox();
            dgvProductosBajoStock = new DataGridView();
            grbVentasSemana = new GroupBox();
            dgvVentasSemanales = new DataGridView();
            pnelppaltitulo.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tlpBotones.SuspendLayout();
            tlpDatos.SuspendLayout();
            grbProductosBajoStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosBajoStock).BeginInit();
            grbVentasSemana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentasSemanales).BeginInit();
            SuspendLayout();
            // 
            // pnelppaltitulo
            // 
            pnelppaltitulo.BackColor = Color.DarkSlateGray;
            pnelppaltitulo.Controls.Add(btnSalir);
            pnelppaltitulo.Controls.Add(lblTituloGR);
            pnelppaltitulo.Dock = DockStyle.Top;
            pnelppaltitulo.Location = new Point(0, 0);
            pnelppaltitulo.Margin = new Padding(2);
            pnelppaltitulo.Name = "pnelppaltitulo";
            pnelppaltitulo.Size = new Size(1698, 80);
            pnelppaltitulo.TabIndex = 15;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkSlateGray;
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 25F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(1608, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 80);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "❌";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblTituloGR
            // 
            lblTituloGR.BackColor = Color.Transparent;
            lblTituloGR.Font = new Font("Calibri", 28F, FontStyle.Bold);
            lblTituloGR.ForeColor = Color.White;
            lblTituloGR.Location = new Point(376, -1);
            lblTituloGR.Margin = new Padding(2, 0, 2, 0);
            lblTituloGR.Name = "lblTituloGR";
            lblTituloGR.Size = new Size(1012, 80);
            lblTituloGR.TabIndex = 1;
            lblTituloGR.Text = "Sistema de Gestión de Electrodomésticos";
            lblTituloGR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(1698, 694);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(tlpBotones);
            panel2.Controls.Add(tlpDatos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1698, 694);
            panel2.TabIndex = 10;
            // 
            // tlpBotones
            // 
            tlpBotones.BackColor = Color.PaleTurquoise;
            tlpBotones.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpBotones.ColumnCount = 7;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tlpBotones.Controls.Add(btnRegistrarIngresos, 4, 0);
            tlpBotones.Controls.Add(btnGestionarSucursales, 0, 0);
            tlpBotones.Controls.Add(btnReportesYConsultas, 6, 0);
            tlpBotones.Controls.Add(btnRegistrarVentas, 5, 0);
            tlpBotones.Controls.Add(btnGestionProductos, 2, 0);
            tlpBotones.Controls.Add(GestionDeCategorias, 1, 0);
            tlpBotones.Controls.Add(btnGestionClientes, 3, 0);
            tlpBotones.Dock = DockStyle.Top;
            tlpBotones.Location = new Point(0, 0);
            tlpBotones.Margin = new Padding(0);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 1;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tlpBotones.Size = new Size(1698, 100);
            tlpBotones.TabIndex = 9;
            // 
            // btnRegistrarIngresos
            // 
            btnRegistrarIngresos.BackColor = Color.PaleTurquoise;
            btnRegistrarIngresos.Cursor = Cursors.Hand;
            btnRegistrarIngresos.Dock = DockStyle.Fill;
            btnRegistrarIngresos.FlatAppearance.BorderSize = 0;
            btnRegistrarIngresos.FlatStyle = FlatStyle.Flat;
            btnRegistrarIngresos.Font = new Font("Calibri", 18F, FontStyle.Bold);
            btnRegistrarIngresos.ForeColor = Color.DarkSlateGray;
            btnRegistrarIngresos.Location = new Point(971, 3);
            btnRegistrarIngresos.Margin = new Padding(0);
            btnRegistrarIngresos.Name = "btnRegistrarIngresos";
            btnRegistrarIngresos.Size = new Size(239, 94);
            btnRegistrarIngresos.TabIndex = 6;
            btnRegistrarIngresos.Text = "Stock ➕";
            btnRegistrarIngresos.UseVisualStyleBackColor = false;
            btnRegistrarIngresos.Click += btnRegistrarIngresos_Click_1;
            // 
            // btnGestionarSucursales
            // 
            btnGestionarSucursales.BackColor = Color.PaleTurquoise;
            btnGestionarSucursales.Cursor = Cursors.Hand;
            btnGestionarSucursales.Dock = DockStyle.Fill;
            btnGestionarSucursales.FlatAppearance.BorderSize = 0;
            btnGestionarSucursales.FlatStyle = FlatStyle.Flat;
            btnGestionarSucursales.Font = new Font("Calibri", 18F, FontStyle.Bold);
            btnGestionarSucursales.ForeColor = Color.DarkSlateGray;
            btnGestionarSucursales.Location = new Point(3, 3);
            btnGestionarSucursales.Margin = new Padding(0);
            btnGestionarSucursales.Name = "btnGestionarSucursales";
            btnGestionarSucursales.Size = new Size(239, 94);
            btnGestionarSucursales.TabIndex = 5;
            btnGestionarSucursales.Text = "Sucursales 🏬";
            btnGestionarSucursales.UseVisualStyleBackColor = false;
            btnGestionarSucursales.Click += btnGestionarSucursales_Click_1;
            // 
            // btnReportesYConsultas
            // 
            btnReportesYConsultas.BackColor = Color.PaleTurquoise;
            btnReportesYConsultas.Cursor = Cursors.Hand;
            btnReportesYConsultas.Dock = DockStyle.Fill;
            btnReportesYConsultas.FlatAppearance.BorderSize = 0;
            btnReportesYConsultas.FlatStyle = FlatStyle.Flat;
            btnReportesYConsultas.Font = new Font("Calibri", 18F, FontStyle.Bold);
            btnReportesYConsultas.ForeColor = Color.DarkSlateGray;
            btnReportesYConsultas.Location = new Point(1455, 3);
            btnReportesYConsultas.Margin = new Padding(0);
            btnReportesYConsultas.Name = "btnReportesYConsultas";
            btnReportesYConsultas.Size = new Size(240, 94);
            btnReportesYConsultas.TabIndex = 3;
            btnReportesYConsultas.Text = "Reportes 📊";
            btnReportesYConsultas.UseVisualStyleBackColor = false;
            btnReportesYConsultas.Click += btnReportesYConsultas_Click_1;
            // 
            // btnRegistrarVentas
            // 
            btnRegistrarVentas.BackColor = Color.PaleTurquoise;
            btnRegistrarVentas.Cursor = Cursors.Hand;
            btnRegistrarVentas.Dock = DockStyle.Fill;
            btnRegistrarVentas.FlatAppearance.BorderSize = 0;
            btnRegistrarVentas.FlatStyle = FlatStyle.Flat;
            btnRegistrarVentas.Font = new Font("Calibri", 18F, FontStyle.Bold);
            btnRegistrarVentas.ForeColor = Color.DarkSlateGray;
            btnRegistrarVentas.Location = new Point(1213, 3);
            btnRegistrarVentas.Margin = new Padding(0);
            btnRegistrarVentas.Name = "btnRegistrarVentas";
            btnRegistrarVentas.Size = new Size(239, 94);
            btnRegistrarVentas.TabIndex = 2;
            btnRegistrarVentas.Text = "Ventas 💸";
            btnRegistrarVentas.UseVisualStyleBackColor = false;
            btnRegistrarVentas.Click += btnRegistrarVentas_Click;
            // 
            // btnGestionProductos
            // 
            btnGestionProductos.BackColor = Color.PaleTurquoise;
            btnGestionProductos.Cursor = Cursors.Hand;
            btnGestionProductos.Dock = DockStyle.Fill;
            btnGestionProductos.FlatAppearance.BorderSize = 0;
            btnGestionProductos.FlatStyle = FlatStyle.Flat;
            btnGestionProductos.Font = new Font("Calibri", 18F, FontStyle.Bold);
            btnGestionProductos.ForeColor = Color.DarkSlateGray;
            btnGestionProductos.Location = new Point(487, 3);
            btnGestionProductos.Margin = new Padding(0);
            btnGestionProductos.Name = "btnGestionProductos";
            btnGestionProductos.Size = new Size(239, 94);
            btnGestionProductos.TabIndex = 0;
            btnGestionProductos.Text = "Productos 📦 ";
            btnGestionProductos.UseVisualStyleBackColor = false;
            btnGestionProductos.Click += btnGestionProductos_Click_1;
            // 
            // GestionDeCategorias
            // 
            GestionDeCategorias.BackColor = Color.PaleTurquoise;
            GestionDeCategorias.Cursor = Cursors.Hand;
            GestionDeCategorias.Dock = DockStyle.Fill;
            GestionDeCategorias.FlatAppearance.BorderSize = 0;
            GestionDeCategorias.FlatStyle = FlatStyle.Flat;
            GestionDeCategorias.Font = new Font("Calibri", 18F, FontStyle.Bold);
            GestionDeCategorias.ForeColor = Color.DarkSlateGray;
            GestionDeCategorias.Location = new Point(245, 3);
            GestionDeCategorias.Margin = new Padding(0);
            GestionDeCategorias.Name = "GestionDeCategorias";
            GestionDeCategorias.Size = new Size(239, 94);
            GestionDeCategorias.TabIndex = 4;
            GestionDeCategorias.Text = "Categorias 📂 ";
            GestionDeCategorias.UseVisualStyleBackColor = false;
            GestionDeCategorias.Click += GestionDeCategorias_Click_1;
            // 
            // btnGestionClientes
            // 
            btnGestionClientes.BackColor = Color.PaleTurquoise;
            btnGestionClientes.Cursor = Cursors.Hand;
            btnGestionClientes.Dock = DockStyle.Fill;
            btnGestionClientes.FlatAppearance.BorderSize = 0;
            btnGestionClientes.FlatStyle = FlatStyle.Flat;
            btnGestionClientes.Font = new Font("Calibri", 18F, FontStyle.Bold);
            btnGestionClientes.ForeColor = Color.DarkSlateGray;
            btnGestionClientes.Location = new Point(729, 3);
            btnGestionClientes.Margin = new Padding(0);
            btnGestionClientes.Name = "btnGestionClientes";
            btnGestionClientes.Size = new Size(239, 94);
            btnGestionClientes.TabIndex = 1;
            btnGestionClientes.Text = "Clientes 👤";
            btnGestionClientes.UseVisualStyleBackColor = false;
            btnGestionClientes.Click += btnGestionClientes_Click_1;
            // 
            // tlpDatos
            // 
            tlpDatos.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpDatos.ColumnCount = 2;
            tlpDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.5F));
            tlpDatos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.5F));
            tlpDatos.Controls.Add(grbProductosBajoStock, 1, 0);
            tlpDatos.Controls.Add(grbVentasSemana, 0, 0);
            tlpDatos.Dock = DockStyle.Fill;
            tlpDatos.Location = new Point(0, 0);
            tlpDatos.Margin = new Padding(0);
            tlpDatos.Name = "tlpDatos";
            tlpDatos.Padding = new Padding(5);
            tlpDatos.RowCount = 1;
            tlpDatos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDatos.Size = new Size(1698, 694);
            tlpDatos.TabIndex = 8;
            // 
            // grbProductosBajoStock
            // 
            grbProductosBajoStock.Controls.Add(dgvProductosBajoStock);
            grbProductosBajoStock.Dock = DockStyle.Bottom;
            grbProductosBajoStock.FlatStyle = FlatStyle.Flat;
            grbProductosBajoStock.Font = new Font("Calibri", 14F, FontStyle.Bold);
            grbProductosBajoStock.ForeColor = Color.DarkSlateGray;
            grbProductosBajoStock.Location = new Point(981, 114);
            grbProductosBajoStock.Margin = new Padding(5, 0, 0, 0);
            grbProductosBajoStock.Name = "grbProductosBajoStock";
            grbProductosBajoStock.Padding = new Padding(5, 0, 0, 5);
            grbProductosBajoStock.Size = new Size(709, 572);
            grbProductosBajoStock.TabIndex = 0;
            grbProductosBajoStock.TabStop = false;
            grbProductosBajoStock.Text = "Productos bajo Stock";
            // 
            // dgvProductosBajoStock
            // 
            dgvProductosBajoStock.AllowUserToAddRows = false;
            dgvProductosBajoStock.AllowUserToDeleteRows = false;
            dgvProductosBajoStock.AllowUserToResizeColumns = false;
            dgvProductosBajoStock.AllowUserToResizeRows = false;
            dgvProductosBajoStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductosBajoStock.BackgroundColor = SystemColors.GrayText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductosBajoStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductosBajoStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductosBajoStock.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductosBajoStock.Dock = DockStyle.Fill;
            dgvProductosBajoStock.Location = new Point(5, 35);
            dgvProductosBajoStock.Name = "dgvProductosBajoStock";
            dgvProductosBajoStock.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProductosBajoStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductosBajoStock.RowHeadersVisible = false;
            dgvProductosBajoStock.RowHeadersWidth = 62;
            dgvProductosBajoStock.Size = new Size(704, 532);
            dgvProductosBajoStock.TabIndex = 0;
            // 
            // grbVentasSemana
            // 
            grbVentasSemana.Controls.Add(dgvVentasSemanales);
            grbVentasSemana.Dock = DockStyle.Bottom;
            grbVentasSemana.FlatStyle = FlatStyle.Flat;
            grbVentasSemana.Font = new Font("Calibri", 14F, FontStyle.Bold);
            grbVentasSemana.ForeColor = Color.DarkSlateGray;
            grbVentasSemana.Location = new Point(8, 114);
            grbVentasSemana.Margin = new Padding(0, 0, 5, 0);
            grbVentasSemana.Name = "grbVentasSemana";
            grbVentasSemana.Padding = new Padding(0, 0, 5, 5);
            grbVentasSemana.RightToLeft = RightToLeft.No;
            grbVentasSemana.Size = new Size(960, 572);
            grbVentasSemana.TabIndex = 1;
            grbVentasSemana.TabStop = false;
            grbVentasSemana.Text = "Ventas de la Semana";
            // 
            // dgvVentasSemanales
            // 
            dgvVentasSemanales.AllowUserToAddRows = false;
            dgvVentasSemanales.AllowUserToDeleteRows = false;
            dgvVentasSemanales.AllowUserToResizeColumns = false;
            dgvVentasSemanales.AllowUserToResizeRows = false;
            dgvVentasSemanales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentasSemanales.BackgroundColor = SystemColors.GrayText;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvVentasSemanales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvVentasSemanales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvVentasSemanales.DefaultCellStyle = dataGridViewCellStyle5;
            dgvVentasSemanales.Dock = DockStyle.Fill;
            dgvVentasSemanales.Location = new Point(0, 35);
            dgvVentasSemanales.Name = "dgvVentasSemanales";
            dgvVentasSemanales.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvVentasSemanales.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvVentasSemanales.RowHeadersVisible = false;
            dgvVentasSemanales.RowHeadersWidth = 62;
            dgvVentasSemanales.Size = new Size(955, 532);
            dgvVentasSemanales.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1698, 774);
            Controls.Add(panel1);
            Controls.Add(pnelppaltitulo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4);
            MinimumSize = new Size(1630, 830);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += Form1_Load;
            pnelppaltitulo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tlpBotones.ResumeLayout(false);
            tlpDatos.ResumeLayout(false);
            grbProductosBajoStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductosBajoStock).EndInit();
            grbVentasSemana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentasSemanales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnelppaltitulo;
        private Label lblTituloGR;
        private Button btnSalir;
        private Panel panel1;
        private TableLayoutPanel tlpDatos;
        private GroupBox grbProductosBajoStock;
        private GroupBox grbVentasSemana;
        private DataGridView dgvProductosBajoStock;
        private DataGridView dgvVentasSemanales;
        private Panel panel2;
        private TableLayoutPanel tlpBotones;
        private Button btnRegistrarIngresos;
        private Button btnGestionarSucursales;
        private Button btnReportesYConsultas;
        private Button btnRegistrarVentas;
        private Button btnGestionProductos;
        private Button GestionDeCategorias;
        private Button btnGestionClientes;
    }
}
