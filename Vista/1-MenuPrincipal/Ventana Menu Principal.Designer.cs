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
            pnelppaltitulo = new Panel();
            btnSalir = new Button();
            lblTituloGR = new Label();
            pnelppalmedio = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnGestionarSucursales = new Button();
            btnReportesYConsultas = new Button();
            btnRegistrarVentas = new Button();
            btnGestionProductos = new Button();
            GestionDeCategorias = new Button();
            btnGestionClientes = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            grbProductosBajoStock = new GroupBox();
            dgvProductosBajoStock = new DataGridView();
            grbVentasSemana = new GroupBox();
            dgvVentasSemanales = new DataGridView();
            btnRegistrarIngresos = new Button();
            pnelppaltitulo.SuspendLayout();
            pnelppalmedio.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grbProductosBajoStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosBajoStock).BeginInit();
            grbVentasSemana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentasSemanales).BeginInit();
            SuspendLayout();
            // 
            // pnelppaltitulo
            // 
            pnelppaltitulo.BackColor = SystemColors.ControlLightLight;
            pnelppaltitulo.Controls.Add(btnSalir);
            pnelppaltitulo.Controls.Add(lblTituloGR);
            pnelppaltitulo.Dock = DockStyle.Top;
            pnelppaltitulo.Location = new Point(0, 0);
            pnelppaltitulo.Margin = new Padding(2);
            pnelppaltitulo.Name = "pnelppaltitulo";
            pnelppaltitulo.Size = new Size(1633, 80);
            pnelppaltitulo.TabIndex = 15;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLightLight;
            btnSalir.Dock = DockStyle.Right;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(1487, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(146, 80);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir del Programa";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblTituloGR
            // 
            lblTituloGR.AutoSize = true;
            lblTituloGR.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloGR.Location = new Point(427, 13);
            lblTituloGR.Margin = new Padding(2, 0, 2, 0);
            lblTituloGR.Name = "lblTituloGR";
            lblTituloGR.Size = new Size(795, 54);
            lblTituloGR.TabIndex = 1;
            lblTituloGR.Text = "Sistema de Gestión de Electrodomésticos";
            lblTituloGR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.ActiveCaption;
            pnelppalmedio.Controls.Add(tableLayoutPanel1);
            pnelppalmedio.Location = new Point(0, 80);
            pnelppalmedio.Margin = new Padding(2);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1632, 152);
            pnelppalmedio.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
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
            tableLayoutPanel1.Size = new Size(1632, 152);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btnGestionarSucursales
            // 
            btnGestionarSucursales.Cursor = Cursors.Hand;
            btnGestionarSucursales.Dock = DockStyle.Fill;
            btnGestionarSucursales.FlatAppearance.BorderSize = 0;
            btnGestionarSucursales.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnGestionarSucursales.Location = new Point(10, 10);
            btnGestionarSucursales.Margin = new Padding(10);
            btnGestionarSucursales.Name = "btnGestionarSucursales";
            btnGestionarSucursales.Size = new Size(213, 132);
            btnGestionarSucursales.TabIndex = 5;
            btnGestionarSucursales.Text = "Gestión de Sucursales";
            btnGestionarSucursales.UseVisualStyleBackColor = true;
            btnGestionarSucursales.Click += btnGestionarSucursales_Click;
            // 
            // btnReportesYConsultas
            // 
            btnReportesYConsultas.Cursor = Cursors.Hand;
            btnReportesYConsultas.Dock = DockStyle.Fill;
            btnReportesYConsultas.FlatAppearance.BorderSize = 0;
            btnReportesYConsultas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnReportesYConsultas.Location = new Point(1408, 10);
            btnReportesYConsultas.Margin = new Padding(10);
            btnReportesYConsultas.Name = "btnReportesYConsultas";
            btnReportesYConsultas.Size = new Size(214, 132);
            btnReportesYConsultas.TabIndex = 3;
            btnReportesYConsultas.Text = "Reportes y Consultas";
            btnReportesYConsultas.UseVisualStyleBackColor = true;
            btnReportesYConsultas.Click += btnReportesYConsultas_Click;
            // 
            // btnRegistrarVentas
            // 
            btnRegistrarVentas.Cursor = Cursors.Hand;
            btnRegistrarVentas.Dock = DockStyle.Fill;
            btnRegistrarVentas.FlatAppearance.BorderSize = 0;
            btnRegistrarVentas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnRegistrarVentas.Location = new Point(1175, 10);
            btnRegistrarVentas.Margin = new Padding(10);
            btnRegistrarVentas.Name = "btnRegistrarVentas";
            btnRegistrarVentas.Size = new Size(213, 132);
            btnRegistrarVentas.TabIndex = 2;
            btnRegistrarVentas.Text = "Registrar Ventas";
            btnRegistrarVentas.UseVisualStyleBackColor = true;
            btnRegistrarVentas.Click += btnGestionVentas_Click;
            // 
            // btnGestionProductos
            // 
            btnGestionProductos.Cursor = Cursors.Hand;
            btnGestionProductos.Dock = DockStyle.Fill;
            btnGestionProductos.FlatAppearance.BorderSize = 0;
            btnGestionProductos.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnGestionProductos.Location = new Point(476, 10);
            btnGestionProductos.Margin = new Padding(10);
            btnGestionProductos.Name = "btnGestionProductos";
            btnGestionProductos.Size = new Size(213, 132);
            btnGestionProductos.TabIndex = 0;
            btnGestionProductos.Text = "Gestion de Productos";
            btnGestionProductos.UseVisualStyleBackColor = true;
            btnGestionProductos.Click += btnGestionProductos_Click;
            // 
            // GestionDeCategorias
            // 
            GestionDeCategorias.Cursor = Cursors.Hand;
            GestionDeCategorias.Dock = DockStyle.Fill;
            GestionDeCategorias.FlatAppearance.BorderSize = 0;
            GestionDeCategorias.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            GestionDeCategorias.Location = new Point(243, 10);
            GestionDeCategorias.Margin = new Padding(10);
            GestionDeCategorias.Name = "GestionDeCategorias";
            GestionDeCategorias.Size = new Size(213, 132);
            GestionDeCategorias.TabIndex = 4;
            GestionDeCategorias.Text = "Gestion de Categorias";
            GestionDeCategorias.UseVisualStyleBackColor = true;
            GestionDeCategorias.Click += GestionDeCategorias_Click;
            // 
            // btnGestionClientes
            // 
            btnGestionClientes.Cursor = Cursors.Hand;
            btnGestionClientes.Dock = DockStyle.Fill;
            btnGestionClientes.FlatAppearance.BorderSize = 0;
            btnGestionClientes.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnGestionClientes.Location = new Point(709, 10);
            btnGestionClientes.Margin = new Padding(10);
            btnGestionClientes.Name = "btnGestionClientes";
            btnGestionClientes.Size = new Size(213, 132);
            btnGestionClientes.TabIndex = 1;
            btnGestionClientes.Text = "Gestion de Clientes";
            btnGestionClientes.UseVisualStyleBackColor = true;
            btnGestionClientes.Click += btnGestionClientes_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 237);
            panel1.Name = "panel1";
            panel1.Size = new Size(1635, 546);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1632, 543);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(grbProductosBajoStock, 0, 0);
            tableLayoutPanel2.Controls.Add(grbVentasSemana, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(10);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1632, 543);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // grbProductosBajoStock
            // 
            grbProductosBajoStock.Controls.Add(dgvProductosBajoStock);
            grbProductosBajoStock.Dock = DockStyle.Fill;
            grbProductosBajoStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbProductosBajoStock.Location = new Point(13, 13);
            grbProductosBajoStock.Name = "grbProductosBajoStock";
            grbProductosBajoStock.Size = new Size(800, 517);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductosBajoStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductosBajoStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosBajoStock.Dock = DockStyle.Fill;
            dgvProductosBajoStock.Location = new Point(3, 27);
            dgvProductosBajoStock.Name = "dgvProductosBajoStock";
            dgvProductosBajoStock.ReadOnly = true;
            dgvProductosBajoStock.RowHeadersWidth = 62;
            dgvProductosBajoStock.Size = new Size(794, 487);
            dgvProductosBajoStock.TabIndex = 0;
            // 
            // grbVentasSemana
            // 
            grbVentasSemana.Controls.Add(dgvVentasSemanales);
            grbVentasSemana.Dock = DockStyle.Fill;
            grbVentasSemana.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbVentasSemana.Location = new Point(819, 13);
            grbVentasSemana.Name = "grbVentasSemana";
            grbVentasSemana.Size = new Size(800, 517);
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVentasSemanales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVentasSemanales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentasSemanales.Dock = DockStyle.Fill;
            dgvVentasSemanales.Location = new Point(3, 27);
            dgvVentasSemanales.Name = "dgvVentasSemanales";
            dgvVentasSemanales.ReadOnly = true;
            dgvVentasSemanales.RowHeadersWidth = 62;
            dgvVentasSemanales.Size = new Size(794, 487);
            dgvVentasSemanales.TabIndex = 0;
            // 
            // btnRegistrarIngresos
            // 
            btnRegistrarIngresos.Cursor = Cursors.Hand;
            btnRegistrarIngresos.Dock = DockStyle.Fill;
            btnRegistrarIngresos.FlatAppearance.BorderSize = 0;
            btnRegistrarIngresos.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnRegistrarIngresos.Location = new Point(942, 10);
            btnRegistrarIngresos.Margin = new Padding(10);
            btnRegistrarIngresos.Name = "btnRegistrarIngresos";
            btnRegistrarIngresos.Size = new Size(213, 132);
            btnRegistrarIngresos.TabIndex = 6;
            btnRegistrarIngresos.Text = "Registrar Ingresos";
            btnRegistrarIngresos.UseVisualStyleBackColor = true;
            btnRegistrarIngresos.Click += btnRegistrarIngresos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1633, 808);
            Controls.Add(panel1);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += Form1_Load;
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            pnelppalmedio.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
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
        private Panel pnelppalmedio;
        private Button btnSalir;
        private Button btnGestionProductos;
        private Button GestionDeCategorias;
        private Button btnRegistrarVentas;
        private Button btnGestionClientes;
        private Button btnReportesYConsultas;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox grbProductosBajoStock;
        private GroupBox grbVentasSemana;
        private DataGridView dgvProductosBajoStock;
        private DataGridView dgvVentasSemanales;
        private Button btnGestionarSucursales;
        private Button btnRegistrarIngresos;
    }
}
