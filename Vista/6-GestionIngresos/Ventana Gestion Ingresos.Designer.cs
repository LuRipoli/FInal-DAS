namespace Vista
{
    partial class Ventana_Gestion_Ingresos
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
            pnelppalmedio = new Panel();
            grbBuscarSucursal = new GroupBox();
            btnBuscar = new Button();
            lblId = new Label();
            txtIdBuscado = new TextBox();
            grbGrillaStockPorSucursal = new GroupBox();
            dgvStock = new DataGridView();
            grbIngresoDatosSucursal = new GroupBox();
            nudCantidadIngresada = new NumericUpDown();
            cmbSucursal = new ComboBox();
            cmbProducto = new ComboBox();
            lblCantidad = new Label();
            lblSucursal = new Label();
            lblProducto = new Label();
            pnelppaltitulo = new Panel();
            lblTituloPrograma = new Label();
            pnelppalbotones = new Panel();
            btnBuscarSucursal = new Button();
            btnVolver = new Button();
            btnSalir = new Button();
            btnAgregarStock = new Button();
            pnelppalmedio.SuspendLayout();
            grbBuscarSucursal.SuspendLayout();
            grbGrillaStockPorSucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            grbIngresoDatosSucursal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadIngresada).BeginInit();
            pnelppaltitulo.SuspendLayout();
            pnelppalbotones.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.ActiveCaption;
            pnelppalmedio.Controls.Add(grbBuscarSucursal);
            pnelppalmedio.Controls.Add(grbGrillaStockPorSucursal);
            pnelppalmedio.Controls.Add(grbIngresoDatosSucursal);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(301, 150);
            pnelppalmedio.Margin = new Padding(2);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1364, 558);
            pnelppalmedio.TabIndex = 21;
            // 
            // grbBuscarSucursal
            // 
            grbBuscarSucursal.Controls.Add(btnBuscar);
            grbBuscarSucursal.Controls.Add(lblId);
            grbBuscarSucursal.Controls.Add(txtIdBuscado);
            grbBuscarSucursal.Enabled = false;
            grbBuscarSucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbBuscarSucursal.Location = new Point(54, 318);
            grbBuscarSucursal.Name = "grbBuscarSucursal";
            grbBuscarSucursal.Size = new Size(396, 215);
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
            btnBuscar.Location = new Point(123, 114);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 65);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.Location = new Point(125, 33);
            lblId.Name = "lblId";
            lblId.Size = new Size(136, 25);
            lblId.TabIndex = 18;
            lblId.Text = "Id de Sucursal:";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIdBuscado
            // 
            txtIdBuscado.Font = new Font("Segoe UI", 9F);
            txtIdBuscado.Location = new Point(39, 66);
            txtIdBuscado.Name = "txtIdBuscado";
            txtIdBuscado.Size = new Size(320, 31);
            txtIdBuscado.TabIndex = 17;
            // 
            // grbGrillaStockPorSucursal
            // 
            grbGrillaStockPorSucursal.BackgroundImageLayout = ImageLayout.None;
            grbGrillaStockPorSucursal.Controls.Add(dgvStock);
            grbGrillaStockPorSucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbGrillaStockPorSucursal.Location = new Point(482, 15);
            grbGrillaStockPorSucursal.Name = "grbGrillaStockPorSucursal";
            grbGrillaStockPorSucursal.Size = new Size(816, 513);
            grbGrillaStockPorSucursal.TabIndex = 18;
            grbGrillaStockPorSucursal.TabStop = false;
            grbGrillaStockPorSucursal.Text = "Grilla Stock Por Sucursal";
            // 
            // dgvStock
            // 
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AllowUserToDeleteRows = false;
            dgvStock.AllowUserToResizeColumns = false;
            dgvStock.AllowUserToResizeRows = false;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.BackgroundColor = SystemColors.GrayText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Dock = DockStyle.Fill;
            dgvStock.Location = new Point(3, 27);
            dgvStock.Margin = new Padding(2);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 62;
            dgvStock.Size = new Size(810, 483);
            dgvStock.TabIndex = 1;
            // 
            // grbIngresoDatosSucursal
            // 
            grbIngresoDatosSucursal.Controls.Add(nudCantidadIngresada);
            grbIngresoDatosSucursal.Controls.Add(cmbSucursal);
            grbIngresoDatosSucursal.Controls.Add(cmbProducto);
            grbIngresoDatosSucursal.Controls.Add(lblCantidad);
            grbIngresoDatosSucursal.Controls.Add(lblSucursal);
            grbIngresoDatosSucursal.Controls.Add(lblProducto);
            grbIngresoDatosSucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbIngresoDatosSucursal.Location = new Point(54, 15);
            grbIngresoDatosSucursal.Name = "grbIngresoDatosSucursal";
            grbIngresoDatosSucursal.Size = new Size(399, 281);
            grbIngresoDatosSucursal.TabIndex = 17;
            grbIngresoDatosSucursal.TabStop = false;
            grbIngresoDatosSucursal.Text = "Ingreso de Datos";
            // 
            // nudCantidadIngresada
            // 
            nudCantidadIngresada.Location = new Point(42, 230);
            nudCantidadIngresada.Name = "nudCantidadIngresada";
            nudCantidadIngresada.Size = new Size(317, 31);
            nudCantidadIngresada.TabIndex = 23;
            nudCantidadIngresada.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbSucursal
            // 
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(42, 162);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(320, 33);
            cmbSucursal.TabIndex = 22;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(42, 90);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(320, 33);
            cmbProducto.TabIndex = 21;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCantidad.Location = new Point(110, 202);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(182, 25);
            lblCantidad.TabIndex = 20;
            lblCantidad.Text = "Cantidad Ingresada:";
            lblCantidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSucursal.Location = new Point(147, 134);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(88, 25);
            lblSucursal.TabIndex = 18;
            lblSucursal.Text = "Sucursal:";
            lblSucursal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProducto.Location = new Point(147, 62);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(95, 25);
            lblProducto.TabIndex = 6;
            lblProducto.Text = "Producto:";
            lblProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnelppaltitulo
            // 
            pnelppaltitulo.BackColor = SystemColors.ControlLightLight;
            pnelppaltitulo.Controls.Add(lblTituloPrograma);
            pnelppaltitulo.Dock = DockStyle.Top;
            pnelppaltitulo.Location = new Point(301, 0);
            pnelppaltitulo.Margin = new Padding(2);
            pnelppaltitulo.Name = "pnelppaltitulo";
            pnelppaltitulo.Size = new Size(1364, 150);
            pnelppaltitulo.TabIndex = 20;
            // 
            // lblTituloPrograma
            // 
            lblTituloPrograma.AutoSize = true;
            lblTituloPrograma.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloPrograma.Location = new Point(458, 50);
            lblTituloPrograma.Margin = new Padding(2, 0, 2, 0);
            lblTituloPrograma.Name = "lblTituloPrograma";
            lblTituloPrograma.Size = new Size(395, 54);
            lblTituloPrograma.TabIndex = 0;
            lblTituloPrograma.Text = "Gestión de Ingresos";
            lblTituloPrograma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnelppalbotones
            // 
            pnelppalbotones.BackColor = SystemColors.GrayText;
            pnelppalbotones.Controls.Add(btnBuscarSucursal);
            pnelppalbotones.Controls.Add(btnVolver);
            pnelppalbotones.Controls.Add(btnSalir);
            pnelppalbotones.Controls.Add(btnAgregarStock);
            pnelppalbotones.Dock = DockStyle.Left;
            pnelppalbotones.Location = new Point(0, 0);
            pnelppalbotones.Margin = new Padding(2);
            pnelppalbotones.Name = "pnelppalbotones";
            pnelppalbotones.Size = new Size(301, 708);
            pnelppalbotones.TabIndex = 19;
            // 
            // btnBuscarSucursal
            // 
            btnBuscarSucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarSucursal.Location = new Point(46, 324);
            btnBuscarSucursal.Name = "btnBuscarSucursal";
            btnBuscarSucursal.Size = new Size(205, 70);
            btnBuscarSucursal.TabIndex = 10;
            btnBuscarSucursal.Text = "Buscar Sucursal";
            btnBuscarSucursal.UseVisualStyleBackColor = true;
            btnBuscarSucursal.Click += btnBuscarSucursal_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.Location = new Point(46, 412);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(205, 70);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(46, 499);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(205, 70);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir del Programa";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarStock.Location = new Point(46, 228);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(205, 70);
            btnAgregarStock.TabIndex = 4;
            btnAgregarStock.Text = "Agregar Stock";
            btnAgregarStock.UseVisualStyleBackColor = true;
            btnAgregarStock.Click += btnAgregarStock_Click;
            // 
            // Ventana_Gestion_Ingresos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1665, 708);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            Controls.Add(pnelppalbotones);
            Name = "Ventana_Gestion_Ingresos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventana_Gestion_Ingresos";
            pnelppalmedio.ResumeLayout(false);
            grbBuscarSucursal.ResumeLayout(false);
            grbBuscarSucursal.PerformLayout();
            grbGrillaStockPorSucursal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            grbIngresoDatosSucursal.ResumeLayout(false);
            grbIngresoDatosSucursal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadIngresada).EndInit();
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
        private TextBox txtIdBuscado;
        private GroupBox grbGrillaStockPorSucursal;
        private DataGridView dgvStock;
        private GroupBox grbIngresoDatosSucursal;
        private Label lblCantidad;
        private Label lblSucursal;
        private Label lblProducto;
        private Panel pnelppaltitulo;
        private Label lblTituloPrograma;
        private Panel pnelppalbotones;
        private Button btnBuscarSucursal;
        private Button btnVolver;
        private Button btnSalir;
        private Button btnAgregarStock;
        private NumericUpDown nudCantidadIngresada;
        private ComboBox cmbSucursal;
        private ComboBox cmbProducto;
    }
}