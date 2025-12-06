namespace Vista
{
    partial class Ventana_Gestion_Sucursales
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
            pnelppalmedio = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            grbGrillaSucursales = new GroupBox();
            dgvSucursales = new DataGridView();
            grbManejodeDatos = new GroupBox();
            grbIngresoDatos = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblNombre = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtNombre = new TextBox();
            btnLimpiarCampos = new Button();
            grbBuscarSucursal = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblId = new Label();
            txtNombreBuscado = new TextBox();
            btnBuscar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBuscarSucursal = new Button();
            btnEliminarSucursal = new Button();
            btnModificarSucursal = new Button();
            btnAgregarSucursal = new Button();
            pnelppaltitulo = new Panel();
            lblTituloGR = new Label();
            btnVolver = new Button();
            btnSalir = new Button();
            pnelppalmedio.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grbGrillaSucursales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            grbManejodeDatos.SuspendLayout();
            grbIngresoDatos.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            grbBuscarSucursal.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnelppaltitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.ActiveCaption;
            pnelppalmedio.Controls.Add(tableLayoutPanel2);
            pnelppalmedio.Controls.Add(tableLayoutPanel1);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(0, 80);
            pnelppalmedio.Margin = new Padding(2);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1229, 679);
            pnelppalmedio.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.AppWorkspace;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(grbGrillaSucursales, 1, 0);
            tableLayoutPanel2.Controls.Add(grbManejodeDatos, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 146);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1229, 533);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // grbGrillaSucursales
            // 
            grbGrillaSucursales.BackgroundImageLayout = ImageLayout.None;
            grbGrillaSucursales.Controls.Add(dgvSucursales);
            grbGrillaSucursales.Dock = DockStyle.Fill;
            grbGrillaSucursales.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbGrillaSucursales.ForeColor = Color.DarkSlateGray;
            grbGrillaSucursales.Location = new Point(624, 10);
            grbGrillaSucursales.Margin = new Padding(10);
            grbGrillaSucursales.Name = "grbGrillaSucursales";
            grbGrillaSucursales.Size = new Size(595, 513);
            grbGrillaSucursales.TabIndex = 18;
            grbGrillaSucursales.TabStop = false;
            grbGrillaSucursales.Text = "Grilla de Sucursales";
            // 
            // dgvSucursales
            // 
            dgvSucursales.AllowUserToAddRows = false;
            dgvSucursales.AllowUserToDeleteRows = false;
            dgvSucursales.AllowUserToResizeColumns = false;
            dgvSucursales.AllowUserToResizeRows = false;
            dgvSucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSucursales.BackgroundColor = SystemColors.GrayText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSucursales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursales.Dock = DockStyle.Fill;
            dgvSucursales.Location = new Point(3, 38);
            dgvSucursales.Margin = new Padding(20);
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSucursales.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSucursales.RowHeadersWidth = 62;
            dgvSucursales.Size = new Size(589, 472);
            dgvSucursales.TabIndex = 1;
            // 
            // grbManejodeDatos
            // 
            grbManejodeDatos.Controls.Add(grbIngresoDatos);
            grbManejodeDatos.Controls.Add(grbBuscarSucursal);
            grbManejodeDatos.Dock = DockStyle.Fill;
            grbManejodeDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbManejodeDatos.Location = new Point(10, 10);
            grbManejodeDatos.Margin = new Padding(10);
            grbManejodeDatos.Name = "grbManejodeDatos";
            grbManejodeDatos.Padding = new Padding(0);
            grbManejodeDatos.Size = new Size(594, 513);
            grbManejodeDatos.TabIndex = 17;
            grbManejodeDatos.TabStop = false;
            // 
            // grbIngresoDatos
            // 
            grbIngresoDatos.Controls.Add(tableLayoutPanel3);
            grbIngresoDatos.Controls.Add(btnLimpiarCampos);
            grbIngresoDatos.Dock = DockStyle.Top;
            grbIngresoDatos.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbIngresoDatos.ForeColor = Color.DarkSlateGray;
            grbIngresoDatos.Location = new Point(0, 24);
            grbIngresoDatos.Name = "grbIngresoDatos";
            grbIngresoDatos.Padding = new Padding(0);
            grbIngresoDatos.Size = new Size(594, 278);
            grbIngresoDatos.TabIndex = 21;
            grbIngresoDatos.TabStop = false;
            grbIngresoDatos.Text = "Ingreso de Datos";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(lblNombre, 0, 0);
            tableLayoutPanel3.Controls.Add(txtDireccion, 1, 1);
            tableLayoutPanel3.Controls.Add(lblDireccion, 0, 1);
            tableLayoutPanel3.Controls.Add(txtNombre, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 100);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(594, 178);
            tableLayoutPanel3.TabIndex = 19;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(3, 27);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(291, 35);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre de Sucursal:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDireccion.Font = new Font("Segoe UI", 12F);
            txtDireccion.Location = new Point(305, 114);
            txtDireccion.Margin = new Padding(8);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(281, 39);
            txtDireccion.TabIndex = 17;
            txtDireccion.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(3, 116);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(291, 35);
            lblDireccion.TabIndex = 18;
            lblDireccion.Text = "Dirección:";
            lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(305, 25);
            txtNombre.Margin = new Padding(8);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(281, 39);
            txtNombre.TabIndex = 0;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = Color.DarkSlateGray;
            btnLimpiarCampos.Dock = DockStyle.Top;
            btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            btnLimpiarCampos.FlatStyle = FlatStyle.Flat;
            btnLimpiarCampos.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarCampos.ForeColor = Color.White;
            btnLimpiarCampos.Location = new Point(0, 35);
            btnLimpiarCampos.Margin = new Padding(0);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(594, 65);
            btnLimpiarCampos.TabIndex = 16;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // grbBuscarSucursal
            // 
            grbBuscarSucursal.Controls.Add(tableLayoutPanel4);
            grbBuscarSucursal.Controls.Add(btnBuscar);
            grbBuscarSucursal.Dock = DockStyle.Bottom;
            grbBuscarSucursal.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbBuscarSucursal.ForeColor = Color.DarkSlateGray;
            grbBuscarSucursal.Location = new Point(0, 310);
            grbBuscarSucursal.Name = "grbBuscarSucursal";
            grbBuscarSucursal.Padding = new Padding(10);
            grbBuscarSucursal.Size = new Size(594, 203);
            grbBuscarSucursal.TabIndex = 20;
            grbBuscarSucursal.TabStop = false;
            grbBuscarSucursal.Text = "Buscar Sucursal";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(lblId, 0, 0);
            tableLayoutPanel4.Controls.Add(txtNombreBuscado, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(10, 45);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(574, 83);
            tableLayoutPanel4.TabIndex = 20;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(3, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(281, 35);
            lblId.TabIndex = 18;
            lblId.Text = "Nombre de Sucursal:";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombreBuscado
            // 
            txtNombreBuscado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombreBuscado.Font = new Font("Segoe UI", 12F);
            txtNombreBuscado.Location = new Point(295, 22);
            txtNombreBuscado.Margin = new Padding(8);
            txtNombreBuscado.Name = "txtNombreBuscado";
            txtNombreBuscado.Size = new Size(271, 39);
            txtNombreBuscado.TabIndex = 17;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DarkSlateGray;
            btnBuscar.Dock = DockStyle.Bottom;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(10, 128);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(574, 65);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar Sucursal";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.PaleTurquoise;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnBuscarSucursal, 3, 0);
            tableLayoutPanel1.Controls.Add(btnEliminarSucursal, 2, 0);
            tableLayoutPanel1.Controls.Add(btnModificarSucursal, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarSucursal, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1229, 146);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // btnBuscarSucursal
            // 
            btnBuscarSucursal.BackColor = Color.PaleTurquoise;
            btnBuscarSucursal.Cursor = Cursors.Hand;
            btnBuscarSucursal.Dock = DockStyle.Fill;
            btnBuscarSucursal.FlatAppearance.BorderSize = 0;
            btnBuscarSucursal.FlatStyle = FlatStyle.Flat;
            btnBuscarSucursal.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarSucursal.ForeColor = Color.DarkSlateGray;
            btnBuscarSucursal.Location = new Point(921, 0);
            btnBuscarSucursal.Margin = new Padding(0);
            btnBuscarSucursal.Name = "btnBuscarSucursal";
            btnBuscarSucursal.Size = new Size(308, 146);
            btnBuscarSucursal.TabIndex = 10;
            btnBuscarSucursal.Text = "Buscar 🔍";
            btnBuscarSucursal.UseVisualStyleBackColor = false;
            btnBuscarSucursal.Click += btnBuscarSucursal_Click;
            // 
            // btnEliminarSucursal
            // 
            btnEliminarSucursal.Cursor = Cursors.Hand;
            btnEliminarSucursal.Dock = DockStyle.Fill;
            btnEliminarSucursal.FlatAppearance.BorderSize = 0;
            btnEliminarSucursal.FlatStyle = FlatStyle.Flat;
            btnEliminarSucursal.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarSucursal.ForeColor = Color.DarkSlateGray;
            btnEliminarSucursal.Location = new Point(614, 0);
            btnEliminarSucursal.Margin = new Padding(0);
            btnEliminarSucursal.Name = "btnEliminarSucursal";
            btnEliminarSucursal.Size = new Size(307, 146);
            btnEliminarSucursal.TabIndex = 6;
            btnEliminarSucursal.Text = "Eliminar 🗑️";
            btnEliminarSucursal.UseVisualStyleBackColor = true;
            btnEliminarSucursal.Click += btnEliminarSucursal_Click;
            // 
            // btnModificarSucursal
            // 
            btnModificarSucursal.Cursor = Cursors.Hand;
            btnModificarSucursal.Dock = DockStyle.Fill;
            btnModificarSucursal.FlatAppearance.BorderSize = 0;
            btnModificarSucursal.FlatStyle = FlatStyle.Flat;
            btnModificarSucursal.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarSucursal.ForeColor = Color.DarkSlateGray;
            btnModificarSucursal.Location = new Point(307, 0);
            btnModificarSucursal.Margin = new Padding(0);
            btnModificarSucursal.Name = "btnModificarSucursal";
            btnModificarSucursal.Size = new Size(307, 146);
            btnModificarSucursal.TabIndex = 5;
            btnModificarSucursal.Text = "Modificar 🛠️";
            btnModificarSucursal.UseVisualStyleBackColor = true;
            btnModificarSucursal.Click += btnModificarSucursal_Click;
            // 
            // btnAgregarSucursal
            // 
            btnAgregarSucursal.Cursor = Cursors.Hand;
            btnAgregarSucursal.Dock = DockStyle.Fill;
            btnAgregarSucursal.FlatAppearance.BorderSize = 0;
            btnAgregarSucursal.FlatStyle = FlatStyle.Flat;
            btnAgregarSucursal.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarSucursal.ForeColor = Color.DarkSlateGray;
            btnAgregarSucursal.Location = new Point(0, 0);
            btnAgregarSucursal.Margin = new Padding(0);
            btnAgregarSucursal.Name = "btnAgregarSucursal";
            btnAgregarSucursal.Size = new Size(307, 146);
            btnAgregarSucursal.TabIndex = 4;
            btnAgregarSucursal.Text = "Agregar ➕";
            btnAgregarSucursal.UseVisualStyleBackColor = true;
            btnAgregarSucursal.Click += btnAgregarSucursal_Click;
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
            pnelppaltitulo.Size = new Size(1229, 80);
            pnelppaltitulo.TabIndex = 17;
            // 
            // lblTituloGR
            // 
            lblTituloGR.Anchor = AnchorStyles.Top;
            lblTituloGR.AutoSize = true;
            lblTituloGR.BackColor = Color.Transparent;
            lblTituloGR.Font = new Font("Calibri", 28F, FontStyle.Bold);
            lblTituloGR.ForeColor = Color.White;
            lblTituloGR.Location = new Point(364, 6);
            lblTituloGR.Margin = new Padding(2, 0, 2, 0);
            lblTituloGR.Name = "lblTituloGR";
            lblTituloGR.Size = new Size(548, 68);
            lblTituloGR.TabIndex = 10;
            lblTituloGR.Text = "Gestión de Sucursales:";
            lblTituloGR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVolver
            // 
            btnVolver.AutoSize = true;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Dock = DockStyle.Left;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Calibri", 25F, FontStyle.Bold);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(0, 0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(90, 80);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "↩️";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 25F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(1139, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 80);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "❌";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Ventana_Gestion_Sucursales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 759);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(1251, 815);
            MinimumSize = new Size(1251, 815);
            Name = "Ventana_Gestion_Sucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventana_Gestion_Sucursales";
            pnelppalmedio.ResumeLayout(false);
            pnelppalmedio.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            grbGrillaSucursales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            grbManejodeDatos.ResumeLayout(false);
            grbIngresoDatos.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            grbBuscarSucursal.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private Button btnBuscar;
        private Label lblId;
        private TextBox txtNombreBuscado;
        private GroupBox grbGrillaSucursales;
        private DataGridView dgvSucursales;
        private GroupBox grbManejodeDatos;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private Button btnLimpiarCampos;
        private Label lblNombre;
        private TextBox txtNombre;
        private Panel pnelppaltitulo;
        private Button btnBuscarSucursal;
        private Button btnVolver;
        private Button btnSalir;
        private Button btnEliminarSucursal;
        private Button btnModificarSucursal;
        private Button btnAgregarSucursal;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTituloGR;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox grbIngresoDatos;
        private GroupBox grbBuscarSucursal;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}