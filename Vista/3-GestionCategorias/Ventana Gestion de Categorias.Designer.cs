namespace Vista
{
    partial class Gestion_de_Rubros
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
            tlpDivision = new TableLayoutPanel();
            grbManejodeDatos = new GroupBox();
            tlpIngreso = new TableLayoutPanel();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnLimpiarCampos = new Button();
            tlpBuscar = new TableLayoutPanel();
            lblId = new Label();
            txtNombreBuscado = new TextBox();
            btnBuscar = new Button();
            grbGrillaClientes = new GroupBox();
            btnRefrescar = new Button();
            dgvCategorias = new DataGridView();
            tlpBotones = new TableLayoutPanel();
            btnAgregarCategoria = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnBuscarCategoria = new Button();
            btnVolver = new Button();
            btnSalir = new Button();
            pnelppaltitulo = new Panel();
            lblTituloGR = new Label();
            pnelppalmedio.SuspendLayout();
            tlpDivision.SuspendLayout();
            grbManejodeDatos.SuspendLayout();
            tlpIngreso.SuspendLayout();
            tlpBuscar.SuspendLayout();
            grbGrillaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            tlpBotones.SuspendLayout();
            pnelppaltitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.ActiveCaption;
            pnelppalmedio.Controls.Add(tlpDivision);
            pnelppalmedio.Controls.Add(tlpBotones);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(0, 80);
            pnelppalmedio.Margin = new Padding(2);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1408, 664);
            pnelppalmedio.TabIndex = 15;
            // 
            // tlpDivision
            // 
            tlpDivision.BackColor = SystemColors.AppWorkspace;
            tlpDivision.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpDivision.ColumnCount = 2;
            tlpDivision.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDivision.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDivision.Controls.Add(grbManejodeDatos, 0, 0);
            tlpDivision.Controls.Add(grbGrillaClientes, 1, 0);
            tlpDivision.Dock = DockStyle.Fill;
            tlpDivision.Location = new Point(0, 150);
            tlpDivision.Name = "tlpDivision";
            tlpDivision.RowCount = 1;
            tlpDivision.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDivision.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDivision.Size = new Size(1408, 514);
            tlpDivision.TabIndex = 24;
            // 
            // grbManejodeDatos
            // 
            grbManejodeDatos.Controls.Add(tlpIngreso);
            grbManejodeDatos.Controls.Add(btnLimpiarCampos);
            grbManejodeDatos.Controls.Add(tlpBuscar);
            grbManejodeDatos.Controls.Add(btnBuscar);
            grbManejodeDatos.Dock = DockStyle.Fill;
            grbManejodeDatos.FlatStyle = FlatStyle.Flat;
            grbManejodeDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbManejodeDatos.Location = new Point(13, 13);
            grbManejodeDatos.Margin = new Padding(10);
            grbManejodeDatos.Name = "grbManejodeDatos";
            grbManejodeDatos.Padding = new Padding(0);
            grbManejodeDatos.Size = new Size(679, 488);
            grbManejodeDatos.TabIndex = 19;
            grbManejodeDatos.TabStop = false;
            // 
            // tlpIngreso
            // 
            tlpIngreso.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpIngreso.ColumnCount = 2;
            tlpIngreso.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpIngreso.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpIngreso.Controls.Add(lblNombre, 0, 0);
            tlpIngreso.Controls.Add(txtNombre, 1, 0);
            tlpIngreso.Dock = DockStyle.Top;
            tlpIngreso.Location = new Point(0, 89);
            tlpIngreso.Name = "tlpIngreso";
            tlpIngreso.RowCount = 1;
            tlpIngreso.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpIngreso.Size = new Size(679, 168);
            tlpIngreso.TabIndex = 24;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(6, 66);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(329, 35);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre de Categoria:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(349, 64);
            txtNombre.Margin = new Padding(8);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(319, 39);
            txtNombre.TabIndex = 0;
            txtNombre.TextAlign = HorizontalAlignment.Center;
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
            btnLimpiarCampos.Size = new Size(679, 65);
            btnLimpiarCampos.TabIndex = 23;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // tlpBuscar
            // 
            tlpBuscar.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tlpBuscar.ColumnCount = 2;
            tlpBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBuscar.Controls.Add(lblId, 0, 0);
            tlpBuscar.Controls.Add(txtNombreBuscado, 1, 0);
            tlpBuscar.Dock = DockStyle.Bottom;
            tlpBuscar.Enabled = false;
            tlpBuscar.Location = new Point(0, 255);
            tlpBuscar.Name = "tlpBuscar";
            tlpBuscar.RowCount = 1;
            tlpBuscar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBuscar.Size = new Size(679, 168);
            tlpBuscar.TabIndex = 22;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(6, 66);
            lblId.Name = "lblId";
            lblId.Size = new Size(329, 35);
            lblId.TabIndex = 18;
            lblId.Text = "Categoría Buscada:";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombreBuscado
            // 
            txtNombreBuscado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreBuscado.Font = new Font("Segoe UI", 12F);
            txtNombreBuscado.Location = new Point(349, 64);
            txtNombreBuscado.Margin = new Padding(8);
            txtNombreBuscado.Name = "txtNombreBuscado";
            txtNombreBuscado.Size = new Size(319, 39);
            txtNombreBuscado.TabIndex = 17;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkSlateGray;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Dock = DockStyle.Bottom;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(0, 423);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(679, 65);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar Categoria";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // grbGrillaClientes
            // 
            grbGrillaClientes.BackgroundImageLayout = ImageLayout.None;
            grbGrillaClientes.Controls.Add(btnRefrescar);
            grbGrillaClientes.Controls.Add(dgvCategorias);
            grbGrillaClientes.Dock = DockStyle.Fill;
            grbGrillaClientes.FlatStyle = FlatStyle.Flat;
            grbGrillaClientes.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbGrillaClientes.ForeColor = Color.DarkSlateGray;
            grbGrillaClientes.Location = new Point(707, 5);
            grbGrillaClientes.Margin = new Padding(2);
            grbGrillaClientes.Name = "grbGrillaClientes";
            grbGrillaClientes.Padding = new Padding(2);
            grbGrillaClientes.Size = new Size(696, 504);
            grbGrillaClientes.TabIndex = 18;
            grbGrillaClientes.TabStop = false;
            grbGrillaClientes.Text = "Grilla de Categorias";
            // 
            // btnRefrescar
            // 
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Calibri", 16F, FontStyle.Bold);
            btnRefrescar.Location = new Point(657, -6);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(40, 43);
            btnRefrescar.TabIndex = 3;
            btnRefrescar.Text = "🔄";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AllowUserToResizeColumns = false;
            dgvCategorias.AllowUserToResizeRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.BackgroundColor = SystemColors.GrayText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategorias.Dock = DockStyle.Fill;
            dgvCategorias.Location = new Point(2, 37);
            dgvCategorias.Margin = new Padding(20);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 62;
            dgvCategorias.Size = new Size(692, 465);
            dgvCategorias.TabIndex = 1;
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
            tlpBotones.Controls.Add(btnAgregarCategoria, 0, 0);
            tlpBotones.Controls.Add(btnEliminar, 2, 0);
            tlpBotones.Controls.Add(btnModificar, 1, 0);
            tlpBotones.Controls.Add(btnBuscarCategoria, 3, 0);
            tlpBotones.Dock = DockStyle.Top;
            tlpBotones.Location = new Point(0, 0);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 1;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotones.Size = new Size(1408, 150);
            tlpBotones.TabIndex = 23;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Cursor = Cursors.Hand;
            btnAgregarCategoria.Dock = DockStyle.Fill;
            btnAgregarCategoria.FlatAppearance.BorderSize = 0;
            btnAgregarCategoria.FlatStyle = FlatStyle.Flat;
            btnAgregarCategoria.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCategoria.ForeColor = Color.DarkSlateGray;
            btnAgregarCategoria.Location = new Point(3, 3);
            btnAgregarCategoria.Margin = new Padding(0);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(348, 144);
            btnAgregarCategoria.TabIndex = 4;
            btnAgregarCategoria.Text = "Agregar ➕";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.PaleTurquoise;
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.DarkSlateGray;
            btnEliminar.Location = new Point(707, 5);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(344, 140);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar 🗑️";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.PaleTurquoise;
            btnModificar.Dock = DockStyle.Fill;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.DarkSlateGray;
            btnModificar.Location = new Point(356, 5);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(344, 140);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar 🛠️";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBuscarCategoria
            // 
            btnBuscarCategoria.Cursor = Cursors.Hand;
            btnBuscarCategoria.Dock = DockStyle.Fill;
            btnBuscarCategoria.FlatAppearance.BorderSize = 0;
            btnBuscarCategoria.FlatStyle = FlatStyle.Flat;
            btnBuscarCategoria.Font = new Font("Calibri", 20F, FontStyle.Bold);
            btnBuscarCategoria.ForeColor = Color.DarkSlateGray;
            btnBuscarCategoria.Location = new Point(1056, 3);
            btnBuscarCategoria.Margin = new Padding(0);
            btnBuscarCategoria.Name = "btnBuscarCategoria";
            btnBuscarCategoria.Size = new Size(349, 144);
            btnBuscarCategoria.TabIndex = 10;
            btnBuscarCategoria.Text = "Buscar 🔍";
            btnBuscarCategoria.UseVisualStyleBackColor = true;
            btnBuscarCategoria.Click += btnBuscarCategoria_Click;
            // 
            // btnVolver
            // 
            btnVolver.Dock = DockStyle.Left;
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
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(1318, 0);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 80);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "❌";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
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
            pnelppaltitulo.Size = new Size(1408, 80);
            pnelppaltitulo.TabIndex = 14;
            // 
            // lblTituloGR
            // 
            lblTituloGR.Anchor = AnchorStyles.Top;
            lblTituloGR.AutoSize = true;
            lblTituloGR.BackColor = Color.Transparent;
            lblTituloGR.Font = new Font("Calibri", 28F, FontStyle.Bold);
            lblTituloGR.ForeColor = Color.White;
            lblTituloGR.Location = new Point(467, 8);
            lblTituloGR.Margin = new Padding(2, 0, 2, 0);
            lblTituloGR.Name = "lblTituloGR";
            lblTituloGR.Size = new Size(549, 68);
            lblTituloGR.TabIndex = 11;
            lblTituloGR.Text = "Gestión de Categorías:";
            lblTituloGR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Gestion_de_Rubros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 744);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4);
            MaximumSize = new Size(1430, 800);
            MinimumSize = new Size(1430, 800);
            Name = "Gestion_de_Rubros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorías";
            Load += Gestion_de_Rubros_Load;
            pnelppalmedio.ResumeLayout(false);
            tlpDivision.ResumeLayout(false);
            grbManejodeDatos.ResumeLayout(false);
            tlpIngreso.ResumeLayout(false);
            tlpIngreso.PerformLayout();
            tlpBuscar.ResumeLayout(false);
            tlpBuscar.PerformLayout();
            grbGrillaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            tlpBotones.ResumeLayout(false);
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private GroupBox grbGrillaClientes;
        private DataGridView dgvCategorias;
        private Button btnBuscarCategoria;
        private Button btnVolver;
        private Button btnSalir;
        private Button btnAgregarCategoria;
        private Button btnModificar;
        private Button btnEliminar;
        private Panel pnelppaltitulo;
        private Label lblTituloGR;
        private TableLayoutPanel tlpBotones;
        private TableLayoutPanel tlpDivision;
        private GroupBox grbManejodeDatos;
        private Button btnRefrescar;
        private TableLayoutPanel tlpIngreso;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnLimpiarCampos;
        private TableLayoutPanel tlpBuscar;
        private Label lblId;
        private TextBox txtNombreBuscado;
        private Button btnBuscar;
    }
}