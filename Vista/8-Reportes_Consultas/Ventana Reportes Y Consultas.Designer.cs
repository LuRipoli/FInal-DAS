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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            pnelppalmedio = new Panel();
            tlpBotones = new TableLayoutPanel();
            btnreporteventas = new Button();
            btnreportesucursal = new Button();
            btnreporteproductoss = new Button();
            btnreportecliente = new Button();
            Grpfiltros = new GroupBox();
            txtNombreVendedor = new TextBox();
            label1 = new Label();
            fechahasta = new DateTimePicker();
            label6 = new Label();
            fechadesde = new DateTimePicker();
            label5 = new Label();
            combometodo = new ComboBox();
            combosucursal = new ComboBox();
            combocliente = new ComboBox();
            btnlimpiar = new Button();
            btnaplicar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            grbGrillaClientes = new GroupBox();
            dgvreporte = new DataGridView();
            pnelppaltitulo = new Panel();
            lblTituloGR = new Label();
            btnSalir = new Button();
            btnVolver = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnelppalmedio.SuspendLayout();
            tlpBotones.SuspendLayout();
            Grpfiltros.SuspendLayout();
            grbGrillaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvreporte).BeginInit();
            pnelppaltitulo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.AppWorkspace;
            pnelppalmedio.Controls.Add(tableLayoutPanel1);
            pnelppalmedio.Controls.Add(tlpBotones);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(0, 80);
            pnelppalmedio.Margin = new Padding(1);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1565, 722);
            pnelppalmedio.TabIndex = 15;
            pnelppalmedio.Paint += pnelppalmedio_Paint;
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
            tlpBotones.Controls.Add(btnreporteventas, 2, 0);
            tlpBotones.Controls.Add(btnreportesucursal, 0, 0);
            tlpBotones.Controls.Add(btnreporteproductoss, 1, 0);
            tlpBotones.Controls.Add(btnreportecliente, 3, 0);
            tlpBotones.Cursor = Cursors.No;
            tlpBotones.Dock = DockStyle.Top;
            tlpBotones.Location = new Point(0, 0);
            tlpBotones.Margin = new Padding(2);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 1;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotones.Size = new Size(1565, 100);
            tlpBotones.TabIndex = 24;
            // 
            // btnreporteventas
            // 
            btnreporteventas.Dock = DockStyle.Fill;
            btnreporteventas.FlatAppearance.BorderSize = 0;
            btnreporteventas.FlatStyle = FlatStyle.Flat;
            btnreporteventas.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreporteventas.ForeColor = Color.DarkSlateGray;
            btnreporteventas.Location = new Point(783, 3);
            btnreporteventas.Margin = new Padding(0);
            btnreporteventas.Name = "btnreporteventas";
            btnreporteventas.Size = new Size(387, 94);
            btnreporteventas.TabIndex = 4;
            btnreporteventas.Text = "Ventas 📊";
            btnreporteventas.UseVisualStyleBackColor = true;
            // 
            // btnreportesucursal
            // 
            btnreportesucursal.Dock = DockStyle.Fill;
            btnreportesucursal.FlatAppearance.BorderSize = 0;
            btnreportesucursal.FlatStyle = FlatStyle.Flat;
            btnreportesucursal.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreportesucursal.ForeColor = Color.DarkSlateGray;
            btnreportesucursal.Location = new Point(3, 3);
            btnreportesucursal.Margin = new Padding(0);
            btnreportesucursal.Name = "btnreportesucursal";
            btnreportesucursal.Size = new Size(387, 94);
            btnreportesucursal.TabIndex = 10;
            btnreportesucursal.Text = "Sucursal 🏢";
            btnreportesucursal.UseVisualStyleBackColor = true;
            // 
            // btnreporteproductoss
            // 
            btnreporteproductoss.Dock = DockStyle.Fill;
            btnreporteproductoss.FlatAppearance.BorderSize = 0;
            btnreporteproductoss.FlatStyle = FlatStyle.Flat;
            btnreporteproductoss.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreporteproductoss.ForeColor = Color.DarkSlateGray;
            btnreporteproductoss.Location = new Point(393, 3);
            btnreporteproductoss.Margin = new Padding(0);
            btnreporteproductoss.Name = "btnreporteproductoss";
            btnreporteproductoss.Size = new Size(387, 94);
            btnreporteproductoss.TabIndex = 6;
            btnreporteproductoss.Text = "Productos 📦";
            btnreporteproductoss.UseVisualStyleBackColor = true;
            // 
            // btnreportecliente
            // 
            btnreportecliente.Dock = DockStyle.Fill;
            btnreportecliente.FlatAppearance.BorderSize = 0;
            btnreportecliente.FlatStyle = FlatStyle.Flat;
            btnreportecliente.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreportecliente.ForeColor = Color.DarkSlateGray;
            btnreportecliente.Location = new Point(1173, 3);
            btnreportecliente.Margin = new Padding(0);
            btnreportecliente.Name = "btnreportecliente";
            btnreportecliente.Size = new Size(389, 94);
            btnreportecliente.TabIndex = 5;
            btnreportecliente.Text = "Cliente 👤";
            btnreportecliente.UseVisualStyleBackColor = true;
            // 
            // Grpfiltros
            // 
            Grpfiltros.Controls.Add(txtNombreVendedor);
            Grpfiltros.Controls.Add(label1);
            Grpfiltros.Controls.Add(fechahasta);
            Grpfiltros.Controls.Add(label6);
            Grpfiltros.Controls.Add(fechadesde);
            Grpfiltros.Controls.Add(label5);
            Grpfiltros.Controls.Add(combometodo);
            Grpfiltros.Controls.Add(combosucursal);
            Grpfiltros.Controls.Add(combocliente);
            Grpfiltros.Controls.Add(btnlimpiar);
            Grpfiltros.Controls.Add(btnaplicar);
            Grpfiltros.Controls.Add(label4);
            Grpfiltros.Controls.Add(label3);
            Grpfiltros.Controls.Add(label2);
            Grpfiltros.Location = new Point(4, 5);
            Grpfiltros.Margin = new Padding(4, 5, 4, 5);
            Grpfiltros.Name = "Grpfiltros";
            Grpfiltros.Padding = new Padding(4, 5, 4, 5);
            Grpfiltros.Size = new Size(774, 612);
            Grpfiltros.TabIndex = 19;
            Grpfiltros.TabStop = false;
            Grpfiltros.Text = "Filtros";
            // 
            // txtNombreVendedor
            // 
            txtNombreVendedor.Location = new Point(845, 62);
            txtNombreVendedor.Margin = new Padding(4);
            txtNombreVendedor.Name = "txtNombreVendedor";
            txtNombreVendedor.Size = new Size(325, 31);
            txtNombreVendedor.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(845, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 15;
            label1.Text = "Nombre del Vendedor";
            // 
            // fechahasta
            // 
            fechahasta.Location = new Point(124, 115);
            fechahasta.Margin = new Padding(4, 5, 4, 5);
            fechahasta.Name = "fechahasta";
            fechahasta.Size = new Size(284, 31);
            fechahasta.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 121);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 13;
            label6.Text = "Fecha Hasta";
            // 
            // fechadesde
            // 
            fechadesde.Location = new Point(124, 66);
            fechadesde.Margin = new Padding(4, 5, 4, 5);
            fechadesde.Name = "fechadesde";
            fechadesde.Size = new Size(284, 31);
            fechadesde.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 71);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 11;
            label5.Text = "Fecha Desde";
            // 
            // combometodo
            // 
            combometodo.FormattingEnabled = true;
            combometodo.Location = new Point(189, 250);
            combometodo.Margin = new Padding(4, 5, 4, 5);
            combometodo.Name = "combometodo";
            combometodo.Size = new Size(172, 33);
            combometodo.TabIndex = 10;
            // 
            // combosucursal
            // 
            combosucursal.FormattingEnabled = true;
            combosucursal.Location = new Point(189, 202);
            combosucursal.Margin = new Padding(4, 5, 4, 5);
            combosucursal.Name = "combosucursal";
            combosucursal.Size = new Size(172, 33);
            combosucursal.TabIndex = 9;
            // 
            // combocliente
            // 
            combocliente.FormattingEnabled = true;
            combocliente.Location = new Point(189, 152);
            combocliente.Margin = new Padding(4, 5, 4, 5);
            combocliente.Name = "combocliente";
            combocliente.Size = new Size(172, 33);
            combocliente.TabIndex = 8;
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
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnaplicar
            // 
            btnaplicar.Location = new Point(839, 128);
            btnaplicar.Margin = new Padding(4, 5, 4, 5);
            btnaplicar.Name = "btnaplicar";
            btnaplicar.Size = new Size(162, 45);
            btnaplicar.TabIndex = 6;
            btnaplicar.Text = "Aplicar";
            btnaplicar.UseVisualStyleBackColor = true;
            btnaplicar.Click += btnaplicar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 262);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 5;
            label4.Text = "Metodo de Pago";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 216);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 4;
            label3.Text = "Sucursal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 166);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 3;
            label2.Text = "Cliente";
            // 
            // grbGrillaClientes
            // 
            grbGrillaClientes.BackgroundImageLayout = ImageLayout.None;
            grbGrillaClientes.Controls.Add(dgvreporte);
            grbGrillaClientes.Dock = DockStyle.Fill;
            grbGrillaClientes.Font = new Font("Segoe UI", 9F);
            grbGrillaClientes.Location = new Point(784, 4);
            grbGrillaClientes.Margin = new Padding(2, 4, 2, 4);
            grbGrillaClientes.Name = "grbGrillaClientes";
            grbGrillaClientes.Padding = new Padding(2, 4, 2, 4);
            grbGrillaClientes.Size = new Size(779, 614);
            grbGrillaClientes.TabIndex = 18;
            grbGrillaClientes.TabStop = false;
            grbGrillaClientes.Text = "Grilla de Clientes";
            // 
            // dgvreporte
            // 
            dgvreporte.AllowUserToAddRows = false;
            dgvreporte.AllowUserToDeleteRows = false;
            dgvreporte.AllowUserToResizeColumns = false;
            dgvreporte.AllowUserToResizeRows = false;
            dgvreporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvreporte.BackgroundColor = SystemColors.GrayText;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvreporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvreporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvreporte.DefaultCellStyle = dataGridViewCellStyle8;
            dgvreporte.Dock = DockStyle.Fill;
            dgvreporte.Location = new Point(2, 28);
            dgvreporte.Margin = new Padding(1);
            dgvreporte.Name = "dgvreporte";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvreporte.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvreporte.RowHeadersWidth = 62;
            dgvreporte.Size = new Size(775, 582);
            dgvreporte.TabIndex = 1;
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
            pnelppaltitulo.Size = new Size(1565, 80);
            pnelppaltitulo.TabIndex = 14;
            // 
            // lblTituloGR
            // 
            lblTituloGR.Anchor = AnchorStyles.Top;
            lblTituloGR.AutoSize = true;
            lblTituloGR.BackColor = Color.Transparent;
            lblTituloGR.Font = new Font("Calibri", 28F, FontStyle.Bold);
            lblTituloGR.ForeColor = Color.White;
            lblTituloGR.Location = new Point(516, 6);
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
            btnSalir.Location = new Point(1475, 0);
            btnSalir.Margin = new Padding(2, 4, 2, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 80);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "❌";
            btnSalir.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(grbGrillaClientes, 1, 0);
            tableLayoutPanel1.Controls.Add(Grpfiltros, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1565, 622);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // Ventana_Reportes_Y_Consultas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1565, 802);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2, 4, 2, 4);
            Name = "Ventana_Reportes_Y_Consultas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes ";
            pnelppalmedio.ResumeLayout(false);
            tlpBotones.ResumeLayout(false);
            Grpfiltros.ResumeLayout(false);
            Grpfiltros.PerformLayout();
            grbGrillaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvreporte).EndInit();
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private GroupBox grbGrillaClientes;
        private DataGridView dgvreporte;
        private Panel pnelppaltitulo;
        private Button btnreportesucursal;
        private Button btnVolver;
        private Button btnSalir;
        private Button btnreporteproductoss;
        private Button btnreportecliente;
        private Button btnreporteventas;
        private GroupBox Grpfiltros;
        private Label label3;
        private Label label2;
        private DateTimePicker fechahasta;
        private Label label6;
        private DateTimePicker fechadesde;
        private Label label5;
        private ComboBox combometodo;
        private ComboBox combosucursal;
        private ComboBox combocliente;
        private Button btnlimpiar;
        private Button btnaplicar;
        private Label label4;
        private TextBox txtNombreVendedor;
        private Label label1;
        private Label lblTituloGR;
        private TableLayoutPanel tlpBotones;
        private TableLayoutPanel tableLayoutPanel1;
    }
}