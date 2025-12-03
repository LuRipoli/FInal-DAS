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
            grbGrillaClientes = new GroupBox();
            dgvClientes = new DataGridView();
            pnelppaltitulo = new Panel();
            lblTituloPrograma = new Label();
            pnelppalbotones = new Panel();
            btnreportesucursal = new Button();
            btnVolver = new Button();
            btnSalir = new Button();
            btnreporteproductoss = new Button();
            btnreportecliente = new Button();
            btnreporteventas = new Button();
            Grpfiltros = new GroupBox();
            label1 = new Label();
            rdminorista = new RadioButton();
            rdmayorista = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnaplicar = new Button();
            btnlimpiar = new Button();
            combocliente = new ComboBox();
            combosucursal = new ComboBox();
            combometodo = new ComboBox();
            label5 = new Label();
            fechadesde = new DateTimePicker();
            label6 = new Label();
            fechahasta = new DateTimePicker();
            pnelppalmedio.SuspendLayout();
            grbGrillaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            pnelppaltitulo.SuspendLayout();
            pnelppalbotones.SuspendLayout();
            Grpfiltros.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.ActiveCaption;
            pnelppalmedio.Controls.Add(Grpfiltros);
            pnelppalmedio.Controls.Add(grbGrillaClientes);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(211, 90);
            pnelppalmedio.Margin = new Padding(1, 1, 1, 1);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(983, 466);
            pnelppalmedio.TabIndex = 15;
            // 
            // grbGrillaClientes
            // 
            grbGrillaClientes.BackgroundImageLayout = ImageLayout.None;
            grbGrillaClientes.Controls.Add(dgvClientes);
            grbGrillaClientes.Font = new Font("Segoe UI", 9F);
            grbGrillaClientes.Location = new Point(14, 13);
            grbGrillaClientes.Margin = new Padding(2, 2, 2, 2);
            grbGrillaClientes.Name = "grbGrillaClientes";
            grbGrillaClientes.Padding = new Padding(2, 2, 2, 2);
            grbGrillaClientes.Size = new Size(859, 269);
            grbGrillaClientes.TabIndex = 18;
            grbGrillaClientes.TabStop = false;
            grbGrillaClientes.Text = "Grilla de Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClientes.BackgroundColor = SystemColors.GrayText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.Location = new Point(18, 25);
            dgvClientes.Margin = new Padding(1, 1, 1, 1);
            dgvClientes.Name = "dgvClientes";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.Size = new Size(828, 227);
            dgvClientes.TabIndex = 1;
            // 
            // pnelppaltitulo
            // 
            pnelppaltitulo.BackColor = SystemColors.ControlLightLight;
            pnelppaltitulo.Controls.Add(lblTituloPrograma);
            pnelppaltitulo.Dock = DockStyle.Top;
            pnelppaltitulo.Location = new Point(211, 0);
            pnelppaltitulo.Margin = new Padding(1, 1, 1, 1);
            pnelppaltitulo.Name = "pnelppaltitulo";
            pnelppaltitulo.Size = new Size(983, 90);
            pnelppaltitulo.TabIndex = 14;
            // 
            // lblTituloPrograma
            // 
            lblTituloPrograma.AutoSize = true;
            lblTituloPrograma.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloPrograma.Location = new Point(321, 30);
            lblTituloPrograma.Margin = new Padding(1, 0, 1, 0);
            lblTituloPrograma.Name = "lblTituloPrograma";
            lblTituloPrograma.Size = new Size(277, 37);
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
            pnelppalbotones.Margin = new Padding(1, 1, 1, 1);
            pnelppalbotones.Name = "pnelppalbotones";
            pnelppalbotones.Size = new Size(211, 556);
            pnelppalbotones.TabIndex = 13;
            // 
            // btnreportesucursal
            // 
            btnreportesucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnreportesucursal.Location = new Point(32, 313);
            btnreportesucursal.Margin = new Padding(2, 2, 2, 2);
            btnreportesucursal.Name = "btnreportesucursal";
            btnreportesucursal.Size = new Size(144, 42);
            btnreportesucursal.TabIndex = 10;
            btnreportesucursal.Text = "Reporte por Sucursal";
            btnreportesucursal.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.Location = new Point(32, 365);
            btnVolver.Margin = new Padding(2, 2, 2, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(144, 42);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(32, 418);
            btnSalir.Margin = new Padding(2, 2, 2, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(144, 42);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir del Programa";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnreporteproductoss
            // 
            btnreporteproductoss.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnreporteproductoss.Location = new Point(32, 260);
            btnreporteproductoss.Margin = new Padding(2, 2, 2, 2);
            btnreporteproductoss.Name = "btnreporteproductoss";
            btnreporteproductoss.Size = new Size(144, 42);
            btnreporteproductoss.TabIndex = 6;
            btnreporteproductoss.Text = "Reporte de Productos";
            btnreporteproductoss.UseVisualStyleBackColor = true;
            // 
            // btnreportecliente
            // 
            btnreportecliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnreportecliente.Location = new Point(32, 207);
            btnreportecliente.Margin = new Padding(2, 2, 2, 2);
            btnreportecliente.Name = "btnreportecliente";
            btnreportecliente.Size = new Size(144, 42);
            btnreportecliente.TabIndex = 5;
            btnreportecliente.Text = "Reporte de Cliente";
            btnreportecliente.UseVisualStyleBackColor = true;
            // 
            // btnreporteventas
            // 
            btnreporteventas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnreporteventas.Location = new Point(32, 156);
            btnreporteventas.Margin = new Padding(2, 2, 2, 2);
            btnreporteventas.Name = "btnreporteventas";
            btnreporteventas.Size = new Size(144, 42);
            btnreporteventas.TabIndex = 4;
            btnreporteventas.Text = "Reporte de Ventas";
            btnreporteventas.UseVisualStyleBackColor = true;
            // 
            // Grpfiltros
            // 
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
            Grpfiltros.Controls.Add(rdmayorista);
            Grpfiltros.Controls.Add(rdminorista);
            Grpfiltros.Controls.Add(label1);
            Grpfiltros.Location = new Point(14, 287);
            Grpfiltros.Name = "Grpfiltros";
            Grpfiltros.Size = new Size(715, 167);
            Grpfiltros.TabIndex = 19;
            Grpfiltros.TabStop = false;
            Grpfiltros.Text = "Filtros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 91);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo De Cliente:";
            // 
            // rdminorista
            // 
            rdminorista.AutoSize = true;
            rdminorista.Location = new Point(6, 109);
            rdminorista.Name = "rdminorista";
            rdminorista.Size = new Size(75, 19);
            rdminorista.TabIndex = 1;
            rdminorista.TabStop = true;
            rdminorista.Text = "Minorista";
            rdminorista.UseVisualStyleBackColor = true;
            // 
            // rdmayorista
            // 
            rdmayorista.AutoSize = true;
            rdmayorista.Location = new Point(6, 134);
            rdmayorista.Name = "rdmayorista";
            rdmayorista.Size = new Size(77, 19);
            rdmayorista.TabIndex = 2;
            rdmayorista.TabStop = true;
            rdmayorista.Text = "Mayorista";
            rdmayorista.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 30);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 60);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Sucursal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 88);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 5;
            label4.Text = "Metodo de Pago";
            // 
            // btnaplicar
            // 
            btnaplicar.Location = new Point(117, 130);
            btnaplicar.Name = "btnaplicar";
            btnaplicar.Size = new Size(75, 23);
            btnaplicar.TabIndex = 6;
            btnaplicar.Text = "Aplicar";
            btnaplicar.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(198, 130);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 7;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // combocliente
            // 
            combocliente.FormattingEnabled = true;
            combocliente.Location = new Point(439, 22);
            combocliente.Name = "combocliente";
            combocliente.Size = new Size(121, 23);
            combocliente.TabIndex = 8;
            // 
            // combosucursal
            // 
            combosucursal.FormattingEnabled = true;
            combosucursal.Location = new Point(439, 52);
            combosucursal.Name = "combosucursal";
            combosucursal.Size = new Size(121, 23);
            combosucursal.TabIndex = 9;
            // 
            // combometodo
            // 
            combometodo.FormattingEnabled = true;
            combometodo.Location = new Point(439, 80);
            combometodo.Name = "combometodo";
            combometodo.Size = new Size(121, 23);
            combometodo.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 22);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 11;
            label5.Text = "Fecha Desde";
            // 
            // fechadesde
            // 
            fechadesde.Location = new Point(85, 19);
            fechadesde.Name = "fechadesde";
            fechadesde.Size = new Size(200, 23);
            fechadesde.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 52);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 13;
            label6.Text = "Fecha Hasta";
            // 
            // fechahasta
            // 
            fechahasta.Location = new Point(85, 48);
            fechahasta.Name = "fechahasta";
            fechahasta.Size = new Size(200, 23);
            fechahasta.TabIndex = 14;
            // 
            // Ventana_Reportes_Y_Consultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 556);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            Controls.Add(pnelppalbotones);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Ventana_Reportes_Y_Consultas";
            Text = "Ventana_Reportes_Y_Consultas";
            pnelppalmedio.ResumeLayout(false);
            grbGrillaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            pnelppalbotones.ResumeLayout(false);
            Grpfiltros.ResumeLayout(false);
            Grpfiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private GroupBox grbGrillaClientes;
        private DataGridView dgvClientes;
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
        private RadioButton rdmayorista;
        private RadioButton rdminorista;
        private Label label1;
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
    }
}