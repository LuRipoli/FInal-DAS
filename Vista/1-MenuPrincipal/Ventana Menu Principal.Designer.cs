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
            pnelppaltitulo = new Panel();
            btnSalir = new Button();
            lblTituloGR = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            grbProductosBajoStock = new GroupBox();
            dgvProductosBajoStock = new DataGridView();
            grbVentasSemana = new GroupBox();
            dgvVentasSemanales = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnRegistrarIngresos = new Button();
            btnGestionarSucursales = new Button();
            btnReportesYConsultas = new Button();
            btnRegistrarVentas = new Button();
            btnGestionProductos = new Button();
            GestionDeCategorias = new Button();
            btnGestionClientes = new Button();
            pnelppalmedio = new Panel();
            pnelppaltitulo.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grbProductosBajoStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosBajoStock).BeginInit();
            grbVentasSemana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentasSemanales).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            pnelppalmedio.SuspendLayout();
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
            pnelppaltitulo.Size = new Size(1647, 80);
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
            btnSalir.Location = new Point(1557, 0);
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
            lblTituloGR.Location = new Point(0, 0);
            lblTituloGR.Margin = new Padding(2, 0, 2, 0);
            lblTituloGR.Name = "lblTituloGR";
            lblTituloGR.Size = new Size(1581, 80);
            lblTituloGR.TabIndex = 1;
            lblTituloGR.Text = "Sistema de Gestión de Electrodomésticos";
            lblTituloGR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 232);
            panel1.Name = "panel1";
            panel1.Size = new Size(1647, 542);
            panel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(grbProductosBajoStock, 1, 0);
            tableLayoutPanel2.Controls.Add(grbVentasSemana, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(10);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1647, 542);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // grbProductosBajoStock
            // 
            grbProductosBajoStock.Controls.Add(dgvProductosBajoStock);
            grbProductosBajoStock.Dock = DockStyle.Fill;
            grbProductosBajoStock.FlatStyle = FlatStyle.Flat;
            grbProductosBajoStock.Font = new Font("Calibri", 14F, FontStyle.Bold);
            grbProductosBajoStock.ForeColor = Color.DarkSlateGray;
            grbProductosBajoStock.Location = new Point(826, 13);
            grbProductosBajoStock.Name = "grbProductosBajoStock";
            grbProductosBajoStock.Size = new Size(808, 516);
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductosBajoStock.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductosBajoStock.Dock = DockStyle.Fill;
            dgvProductosBajoStock.Location = new Point(3, 38);
            dgvProductosBajoStock.Name = "dgvProductosBajoStock";
            dgvProductosBajoStock.ReadOnly = true;
            dgvProductosBajoStock.RowHeadersWidth = 62;
            dgvProductosBajoStock.Size = new Size(802, 475);
            dgvProductosBajoStock.TabIndex = 0;
            // 
            // grbVentasSemana
            // 
            grbVentasSemana.Controls.Add(dgvVentasSemanales);
            grbVentasSemana.Dock = DockStyle.Fill;
            grbVentasSemana.FlatStyle = FlatStyle.Flat;
            grbVentasSemana.Font = new Font("Calibri", 14F, FontStyle.Bold);
            grbVentasSemana.ForeColor = Color.DarkSlateGray;
            grbVentasSemana.Location = new Point(13, 13);
            grbVentasSemana.Name = "grbVentasSemana";
            grbVentasSemana.RightToLeft = RightToLeft.No;
            grbVentasSemana.Size = new Size(807, 516);
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvVentasSemanales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvVentasSemanales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Calibri", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvVentasSemanales.DefaultCellStyle = dataGridViewCellStyle4;
            dgvVentasSemanales.Dock = DockStyle.Fill;
            dgvVentasSemanales.Location = new Point(3, 38);
            dgvVentasSemanales.Name = "dgvVentasSemanales";
            dgvVentasSemanales.ReadOnly = true;
            dgvVentasSemanales.RowHeadersVisible = false;
            dgvVentasSemanales.RowHeadersWidth = 62;
            dgvVentasSemanales.Size = new Size(801, 475);
            dgvVentasSemanales.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.PaleTurquoise;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Controls.Add(btnRegistrarIngresos, 4, 0);
            tableLayoutPanel1.Controls.Add(btnGestionarSucursales, 0, 0);
            tableLayoutPanel1.Controls.Add(btnReportesYConsultas, 6, 0);
            tableLayoutPanel1.Controls.Add(btnRegistrarVentas, 5, 0);
            tableLayoutPanel1.Controls.Add(btnGestionProductos, 2, 0);
            tableLayoutPanel1.Controls.Add(GestionDeCategorias, 1, 0);
            tableLayoutPanel1.Controls.Add(btnGestionClientes, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1647, 152);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btnRegistrarIngresos
            // 
            btnRegistrarIngresos.BackColor = Color.PaleTurquoise;
            btnRegistrarIngresos.Cursor = Cursors.Hand;
            btnRegistrarIngresos.Dock = DockStyle.Fill;
            btnRegistrarIngresos.FlatAppearance.BorderSize = 0;
            btnRegistrarIngresos.FlatStyle = FlatStyle.Flat;
            btnRegistrarIngresos.Font = new Font("Calibri", 20F, FontStyle.Bold);
            btnRegistrarIngresos.ForeColor = Color.DarkSlateGray;
            btnRegistrarIngresos.Location = new Point(940, 0);
            btnRegistrarIngresos.Margin = new Padding(0);
            btnRegistrarIngresos.Name = "btnRegistrarIngresos";
            btnRegistrarIngresos.Size = new Size(235, 152);
            btnRegistrarIngresos.TabIndex = 6;
            btnRegistrarIngresos.Text = " Ingresos\r\n ➕";
            btnRegistrarIngresos.UseVisualStyleBackColor = false;
            btnRegistrarIngresos.Click += btnRegistrarIngresos_Click;
            // 
            // btnGestionarSucursales
            // 
            btnGestionarSucursales.BackColor = Color.PaleTurquoise;
            btnGestionarSucursales.Cursor = Cursors.Hand;
            btnGestionarSucursales.Dock = DockStyle.Fill;
            btnGestionarSucursales.FlatAppearance.BorderSize = 0;
            btnGestionarSucursales.FlatStyle = FlatStyle.Flat;
            btnGestionarSucursales.Font = new Font("Calibri", 20F, FontStyle.Bold);
            btnGestionarSucursales.ForeColor = Color.DarkSlateGray;
            btnGestionarSucursales.Location = new Point(0, 0);
            btnGestionarSucursales.Margin = new Padding(0);
            btnGestionarSucursales.Name = "btnGestionarSucursales";
            btnGestionarSucursales.Size = new Size(235, 152);
            btnGestionarSucursales.TabIndex = 5;
            btnGestionarSucursales.Text = "Sucursales 🏬";
            btnGestionarSucursales.UseVisualStyleBackColor = false;
            btnGestionarSucursales.Click += btnGestionarSucursales_Click;
            // 
            // btnReportesYConsultas
            // 
            btnReportesYConsultas.BackColor = Color.PaleTurquoise;
            btnReportesYConsultas.Cursor = Cursors.Hand;
            btnReportesYConsultas.Dock = DockStyle.Fill;
            btnReportesYConsultas.FlatAppearance.BorderSize = 0;
            btnReportesYConsultas.FlatStyle = FlatStyle.Flat;
            btnReportesYConsultas.Font = new Font("Calibri", 20F, FontStyle.Bold);
            btnReportesYConsultas.ForeColor = Color.DarkSlateGray;
            btnReportesYConsultas.Location = new Point(1410, 0);
            btnReportesYConsultas.Margin = new Padding(0);
            btnReportesYConsultas.Name = "btnReportesYConsultas";
            btnReportesYConsultas.Size = new Size(237, 152);
            btnReportesYConsultas.TabIndex = 3;
            btnReportesYConsultas.Text = " Reportes \r\n📊";
            btnReportesYConsultas.UseVisualStyleBackColor = false;
            btnReportesYConsultas.Click += btnReportesYConsultas_Click;
            // 
            // btnRegistrarVentas
            // 
            btnRegistrarVentas.BackColor = Color.PaleTurquoise;
            btnRegistrarVentas.Cursor = Cursors.Hand;
            btnRegistrarVentas.Dock = DockStyle.Fill;
            btnRegistrarVentas.FlatAppearance.BorderSize = 0;
            btnRegistrarVentas.FlatStyle = FlatStyle.Flat;
            btnRegistrarVentas.Font = new Font("Calibri", 20F, FontStyle.Bold);
            btnRegistrarVentas.ForeColor = Color.DarkSlateGray;
            btnRegistrarVentas.Location = new Point(1175, 0);
            btnRegistrarVentas.Margin = new Padding(0);
            btnRegistrarVentas.Name = "btnRegistrarVentas";
            btnRegistrarVentas.Size = new Size(235, 152);
            btnRegistrarVentas.TabIndex = 2;
            btnRegistrarVentas.Text = " Ventas \r\n💸";
            btnRegistrarVentas.UseVisualStyleBackColor = false;
            btnRegistrarVentas.Click += btnGestionVentas_Click;
            // 
            // btnGestionProductos
            // 
            btnGestionProductos.BackColor = Color.PaleTurquoise;
            btnGestionProductos.Cursor = Cursors.Hand;
            btnGestionProductos.Dock = DockStyle.Fill;
            btnGestionProductos.FlatAppearance.BorderSize = 0;
            btnGestionProductos.FlatStyle = FlatStyle.Flat;
            btnGestionProductos.Font = new Font("Calibri", 20F, FontStyle.Bold);
            btnGestionProductos.ForeColor = Color.DarkSlateGray;
            btnGestionProductos.Location = new Point(470, 0);
            btnGestionProductos.Margin = new Padding(0);
            btnGestionProductos.Name = "btnGestionProductos";
            btnGestionProductos.Size = new Size(235, 152);
            btnGestionProductos.TabIndex = 0;
            btnGestionProductos.Text = "Productos 📦 ";
            btnGestionProductos.UseVisualStyleBackColor = false;
            btnGestionProductos.Click += btnGestionProductos_Click;
            // 
            // GestionDeCategorias
            // 
            GestionDeCategorias.BackColor = Color.PaleTurquoise;
            GestionDeCategorias.Cursor = Cursors.Hand;
            GestionDeCategorias.Dock = DockStyle.Fill;
            GestionDeCategorias.FlatAppearance.BorderSize = 0;
            GestionDeCategorias.FlatStyle = FlatStyle.Flat;
            GestionDeCategorias.Font = new Font("Calibri", 20F, FontStyle.Bold);
            GestionDeCategorias.ForeColor = Color.DarkSlateGray;
            GestionDeCategorias.Location = new Point(235, 0);
            GestionDeCategorias.Margin = new Padding(0);
            GestionDeCategorias.Name = "GestionDeCategorias";
            GestionDeCategorias.Size = new Size(235, 152);
            GestionDeCategorias.TabIndex = 4;
            GestionDeCategorias.Text = "Categorias 📂 ";
            GestionDeCategorias.UseVisualStyleBackColor = false;
            GestionDeCategorias.Click += GestionDeCategorias_Click;
            // 
            // btnGestionClientes
            // 
            btnGestionClientes.BackColor = Color.PaleTurquoise;
            btnGestionClientes.Cursor = Cursors.Hand;
            btnGestionClientes.Dock = DockStyle.Fill;
            btnGestionClientes.FlatAppearance.BorderSize = 0;
            btnGestionClientes.FlatStyle = FlatStyle.Flat;
            btnGestionClientes.Font = new Font("Calibri", 20F, FontStyle.Bold);
            btnGestionClientes.ForeColor = Color.DarkSlateGray;
            btnGestionClientes.Location = new Point(705, 0);
            btnGestionClientes.Margin = new Padding(0);
            btnGestionClientes.Name = "btnGestionClientes";
            btnGestionClientes.Size = new Size(235, 152);
            btnGestionClientes.TabIndex = 1;
            btnGestionClientes.Text = " Clientes \r\n👤";
            btnGestionClientes.UseVisualStyleBackColor = false;
            btnGestionClientes.Click += btnGestionClientes_Click;
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = Color.PaleTurquoise;
            pnelppalmedio.Controls.Add(tableLayoutPanel1);
            pnelppalmedio.Dock = DockStyle.Top;
            pnelppalmedio.Location = new Point(0, 80);
            pnelppalmedio.Margin = new Padding(2);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1647, 152);
            pnelppalmedio.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1647, 774);
            Controls.Add(panel1);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4);
            MinimumSize = new Size(1603, 830);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += Form1_Load;
            pnelppaltitulo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            grbProductosBajoStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductosBajoStock).EndInit();
            grbVentasSemana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentasSemanales).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            pnelppalmedio.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnelppaltitulo;
        private Label lblTituloGR;
        private Button btnSalir;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox grbProductosBajoStock;
        private GroupBox grbVentasSemana;
        private DataGridView dgvProductosBajoStock;
        private DataGridView dgvVentasSemanales;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnRegistrarIngresos;
        private Button btnGestionarSucursales;
        private Button btnReportesYConsultas;
        private Button btnRegistrarVentas;
        private Button btnGestionProductos;
        private Button GestionDeCategorias;
        private Button btnGestionClientes;
        private Panel pnelppalmedio;
    }
}
