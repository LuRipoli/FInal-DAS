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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnelppalmedio = new Panel();
            Grpfiltros = new GroupBox();
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
            lblTituloPrograma = new Label();
            pnelppalbotones = new Panel();
            btnreportesucursal = new Button();
            btnVolver = new Button();
            btnSalir = new Button();
            btnreporteproductoss = new Button();
            btnreportecliente = new Button();
            btnreporteventas = new Button();
            label1 = new Label();
            txtNombreVendedor = new TextBox();
            pnelppalmedio.SuspendLayout();
            Grpfiltros.SuspendLayout();
            grbGrillaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvreporte).BeginInit();
            pnelppaltitulo.SuspendLayout();
            pnelppalbotones.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.ActiveCaption;
            pnelppalmedio.Controls.Add(Grpfiltros);
            pnelppalmedio.Controls.Add(grbGrillaClientes);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(241, 120);
            pnelppalmedio.Margin = new Padding(1);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1011, 621);
            pnelppalmedio.TabIndex = 15;
            pnelppalmedio.Paint += pnelppalmedio_Paint;
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
            Grpfiltros.Location = new Point(16, 451);
            Grpfiltros.Margin = new Padding(3, 4, 3, 4);
            Grpfiltros.Name = "Grpfiltros";
            Grpfiltros.Padding = new Padding(3, 4, 3, 4);
            Grpfiltros.Size = new Size(982, 155);
            Grpfiltros.TabIndex = 19;
            Grpfiltros.TabStop = false;
            Grpfiltros.Text = "Filtros";
            // 
            // fechahasta
            // 
            fechahasta.Location = new Point(99, 92);
            fechahasta.Margin = new Padding(3, 4, 3, 4);
            fechahasta.Name = "fechahasta";
            fechahasta.Size = new Size(228, 27);
            fechahasta.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 97);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 13;
            label6.Text = "Fecha Hasta";
            // 
            // fechadesde
            // 
            fechadesde.Location = new Point(99, 53);
            fechadesde.Margin = new Padding(3, 4, 3, 4);
            fechadesde.Name = "fechadesde";
            fechadesde.Size = new Size(228, 27);
            fechadesde.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 57);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 11;
            label5.Text = "Fecha Desde";
            // 
            // combometodo
            // 
            combometodo.FormattingEnabled = true;
            combometodo.Location = new Point(502, 107);
            combometodo.Margin = new Padding(3, 4, 3, 4);
            combometodo.Name = "combometodo";
            combometodo.Size = new Size(138, 28);
            combometodo.TabIndex = 10;
            // 
            // combosucursal
            // 
            combosucursal.FormattingEnabled = true;
            combosucursal.Location = new Point(502, 69);
            combosucursal.Margin = new Padding(3, 4, 3, 4);
            combosucursal.Name = "combosucursal";
            combosucursal.Size = new Size(138, 28);
            combosucursal.TabIndex = 9;
            // 
            // combocliente
            // 
            combocliente.FormattingEnabled = true;
            combocliente.Location = new Point(502, 29);
            combocliente.Margin = new Padding(3, 4, 3, 4);
            combocliente.Name = "combocliente";
            combocliente.Size = new Size(138, 28);
            combocliente.TabIndex = 8;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(807, 102);
            btnlimpiar.Margin = new Padding(3, 4, 3, 4);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(130, 36);
            btnlimpiar.TabIndex = 7;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnaplicar
            // 
            btnaplicar.Location = new Point(671, 102);
            btnaplicar.Margin = new Padding(3, 4, 3, 4);
            btnaplicar.Name = "btnaplicar";
            btnaplicar.Size = new Size(130, 36);
            btnaplicar.TabIndex = 6;
            btnaplicar.Text = "Aplicar";
            btnaplicar.UseVisualStyleBackColor = true;
            btnaplicar.Click += btnaplicar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(368, 117);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 5;
            label4.Text = "Metodo de Pago";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 80);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 4;
            label3.Text = "Sucursal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 40);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "Cliente";
            // 
            // grbGrillaClientes
            // 
            grbGrillaClientes.BackgroundImageLayout = ImageLayout.None;
            grbGrillaClientes.Controls.Add(dgvreporte);
            grbGrillaClientes.Font = new Font("Segoe UI", 9F);
            grbGrillaClientes.Location = new Point(16, 17);
            grbGrillaClientes.Margin = new Padding(2, 3, 2, 3);
            grbGrillaClientes.Name = "grbGrillaClientes";
            grbGrillaClientes.Padding = new Padding(2, 3, 2, 3);
            grbGrillaClientes.Size = new Size(982, 427);
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvreporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvreporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvreporte.DefaultCellStyle = dataGridViewCellStyle5;
            dgvreporte.Location = new Point(17, 24);
            dgvreporte.Margin = new Padding(1);
            dgvreporte.Name = "dgvreporte";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvreporte.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvreporte.RowHeadersWidth = 62;
            dgvreporte.Size = new Size(946, 382);
            dgvreporte.TabIndex = 1;
            // 
            // pnelppaltitulo
            // 
            pnelppaltitulo.BackColor = SystemColors.ControlLightLight;
            pnelppaltitulo.Controls.Add(lblTituloPrograma);
            pnelppaltitulo.Dock = DockStyle.Top;
            pnelppaltitulo.Location = new Point(241, 0);
            pnelppaltitulo.Margin = new Padding(1);
            pnelppaltitulo.Name = "pnelppaltitulo";
            pnelppaltitulo.Size = new Size(1011, 120);
            pnelppaltitulo.TabIndex = 14;
            // 
            // lblTituloPrograma
            // 
            lblTituloPrograma.AutoSize = true;
            lblTituloPrograma.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloPrograma.Location = new Point(367, 40);
            lblTituloPrograma.Margin = new Padding(1, 0, 1, 0);
            lblTituloPrograma.Name = "lblTituloPrograma";
            lblTituloPrograma.Size = new Size(341, 46);
            lblTituloPrograma.TabIndex = 0;
            lblTituloPrograma.Text = "Gestión de Reportes";
            lblTituloPrograma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnelppalbotones
            // 
            pnelppalbotones.BackColor = SystemColors.GrayText;
            pnelppalbotones.Controls.Add(btnreportesucursal);
            pnelppalbotones.Controls.Add(btnVolver);
            pnelppalbotones.Controls.Add(btnSalir);
            pnelppalbotones.Controls.Add(btnreporteproductoss);
            pnelppalbotones.Controls.Add(btnreportecliente);
            pnelppalbotones.Controls.Add(btnreporteventas);
            pnelppalbotones.Dock = DockStyle.Left;
            pnelppalbotones.Location = new Point(0, 0);
            pnelppalbotones.Margin = new Padding(1);
            pnelppalbotones.Name = "pnelppalbotones";
            pnelppalbotones.Size = new Size(241, 741);
            pnelppalbotones.TabIndex = 13;
            // 
            // btnreportesucursal
            // 
            btnreportesucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnreportesucursal.Location = new Point(37, 417);
            btnreportesucursal.Margin = new Padding(2, 3, 2, 3);
            btnreportesucursal.Name = "btnreportesucursal";
            btnreportesucursal.Size = new Size(165, 56);
            btnreportesucursal.TabIndex = 10;
            btnreportesucursal.Text = "Reporte por Sucursal";
            btnreportesucursal.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.Location = new Point(37, 487);
            btnVolver.Margin = new Padding(2, 3, 2, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(165, 56);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(37, 557);
            btnSalir.Margin = new Padding(2, 3, 2, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(165, 56);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir del Programa";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnreporteproductoss
            // 
            btnreporteproductoss.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnreporteproductoss.Location = new Point(37, 347);
            btnreporteproductoss.Margin = new Padding(2, 3, 2, 3);
            btnreporteproductoss.Name = "btnreporteproductoss";
            btnreporteproductoss.Size = new Size(165, 56);
            btnreporteproductoss.TabIndex = 6;
            btnreporteproductoss.Text = "Reporte de Productos";
            btnreporteproductoss.UseVisualStyleBackColor = true;
            // 
            // btnreportecliente
            // 
            btnreportecliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnreportecliente.Location = new Point(37, 276);
            btnreportecliente.Margin = new Padding(2, 3, 2, 3);
            btnreportecliente.Name = "btnreportecliente";
            btnreportecliente.Size = new Size(165, 56);
            btnreportecliente.TabIndex = 5;
            btnreportecliente.Text = "Reporte de Cliente";
            btnreportecliente.UseVisualStyleBackColor = true;
            // 
            // btnreporteventas
            // 
            btnreporteventas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnreporteventas.Location = new Point(37, 208);
            btnreporteventas.Margin = new Padding(2, 3, 2, 3);
            btnreporteventas.Name = "btnreporteventas";
            btnreporteventas.Size = new Size(165, 56);
            btnreporteventas.TabIndex = 4;
            btnreporteventas.Text = "Reporte de Ventas";
            btnreporteventas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(676, 28);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 15;
            label1.Text = "Nombre del Vendedor";
            // 
            // txtNombreVendedor
            // 
            txtNombreVendedor.Location = new Point(676, 50);
            txtNombreVendedor.Name = "txtNombreVendedor";
            txtNombreVendedor.Size = new Size(261, 27);
            txtNombreVendedor.TabIndex = 20;
            // 
            // Ventana_Reportes_Y_Consultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 741);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            Controls.Add(pnelppalbotones);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Ventana_Reportes_Y_Consultas";
            Text = "Ventana_Reportes_Y_Consultas";
            pnelppalmedio.ResumeLayout(false);
            Grpfiltros.ResumeLayout(false);
            Grpfiltros.PerformLayout();
            grbGrillaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvreporte).EndInit();
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            pnelppalbotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private GroupBox grbGrillaClientes;
        private DataGridView dgvreporte;
        private Panel pnelppaltitulo;
        private Label lblTituloPrograma;
        private Panel pnelppalbotones;
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
    }
}