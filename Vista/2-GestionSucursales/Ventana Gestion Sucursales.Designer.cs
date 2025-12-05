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
            grbBuscarSucursal = new GroupBox();
            btnBuscar = new Button();
            lblId = new Label();
            txtNombreBuscado = new TextBox();
            grbGrillaSucursales = new GroupBox();
            dgvSucursales = new DataGridView();
            grbIngresoDatosSucursal = new GroupBox();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            btnLimpiarCampos = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            pnelppaltitulo = new Panel();
            lblTituloPrograma = new Label();
            pnelppalbotones = new Panel();
            btnBuscarSucursal = new Button();
            btnVolver = new Button();
            btnSalir = new Button();
            btnEliminarSucursal = new Button();
            btnModificarSucursal = new Button();
            btnAgregarSucursal = new Button();
            pnelppalmedio.SuspendLayout();
            grbBuscarSucursal.SuspendLayout();
            grbGrillaSucursales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            grbIngresoDatosSucursal.SuspendLayout();
            pnelppaltitulo.SuspendLayout();
            pnelppalbotones.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.ActiveCaption;
            pnelppalmedio.Controls.Add(grbBuscarSucursal);
            pnelppalmedio.Controls.Add(grbGrillaSucursales);
            pnelppalmedio.Controls.Add(grbIngresoDatosSucursal);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(301, 150);
            pnelppalmedio.Margin = new Padding(2);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1321, 618);
            pnelppalmedio.TabIndex = 18;
            // 
            // grbBuscarSucursal
            // 
            grbBuscarSucursal.Controls.Add(btnBuscar);
            grbBuscarSucursal.Controls.Add(lblId);
            grbBuscarSucursal.Controls.Add(txtNombreBuscado);
            grbBuscarSucursal.Enabled = false;
            grbBuscarSucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbBuscarSucursal.Location = new Point(54, 371);
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
            lblId.Location = new Point(101, 33);
            lblId.Name = "lblId";
            lblId.Size = new Size(188, 25);
            lblId.TabIndex = 18;
            lblId.Text = "Nombre de Sucursal:";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombreBuscado
            // 
            txtNombreBuscado.Font = new Font("Segoe UI", 9F);
            txtNombreBuscado.Location = new Point(39, 66);
            txtNombreBuscado.Name = "txtNombreBuscado";
            txtNombreBuscado.Size = new Size(320, 31);
            txtNombreBuscado.TabIndex = 17;
            // 
            // grbGrillaSucursales
            // 
            grbGrillaSucursales.BackgroundImageLayout = ImageLayout.None;
            grbGrillaSucursales.Controls.Add(dgvSucursales);
            grbGrillaSucursales.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbGrillaSucursales.Location = new Point(482, 73);
            grbGrillaSucursales.Name = "grbGrillaSucursales";
            grbGrillaSucursales.Size = new Size(819, 513);
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSucursales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursales.Dock = DockStyle.Fill;
            dgvSucursales.Location = new Point(3, 27);
            dgvSucursales.Margin = new Padding(2);
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSucursales.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSucursales.RowHeadersWidth = 62;
            dgvSucursales.Size = new Size(813, 483);
            dgvSucursales.TabIndex = 1;
            // 
            // grbIngresoDatosSucursal
            // 
            grbIngresoDatosSucursal.Controls.Add(txtDireccion);
            grbIngresoDatosSucursal.Controls.Add(lblDireccion);
            grbIngresoDatosSucursal.Controls.Add(btnLimpiarCampos);
            grbIngresoDatosSucursal.Controls.Add(lblNombre);
            grbIngresoDatosSucursal.Controls.Add(txtNombre);
            grbIngresoDatosSucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbIngresoDatosSucursal.Location = new Point(51, 73);
            grbIngresoDatosSucursal.Name = "grbIngresoDatosSucursal";
            grbIngresoDatosSucursal.Size = new Size(399, 281);
            grbIngresoDatosSucursal.TabIndex = 17;
            grbIngresoDatosSucursal.TabStop = false;
            grbIngresoDatosSucursal.Text = "Ingreso de Datos";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 9F);
            txtDireccion.Location = new Point(42, 231);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(320, 33);
            txtDireccion.TabIndex = 17;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDireccion.Location = new Point(147, 199);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(97, 25);
            lblDireccion.TabIndex = 18;
            lblDireccion.Text = "Dirección:";
            lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = SystemColors.HighlightText;
            btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            btnLimpiarCampos.FlatStyle = FlatStyle.Flat;
            btnLimpiarCampos.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarCampos.Location = new Point(126, 41);
            btnLimpiarCampos.Margin = new Padding(2);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(146, 65);
            btnLimpiarCampos.TabIndex = 16;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(110, 127);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(188, 25);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre de Sucursal:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(42, 155);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 31);
            txtNombre.TabIndex = 0;
            // 
            // pnelppaltitulo
            // 
            pnelppaltitulo.BackColor = SystemColors.ControlLightLight;
            pnelppaltitulo.Controls.Add(lblTituloPrograma);
            pnelppaltitulo.Dock = DockStyle.Top;
            pnelppaltitulo.Location = new Point(301, 0);
            pnelppaltitulo.Margin = new Padding(2);
            pnelppaltitulo.Name = "pnelppaltitulo";
            pnelppaltitulo.Size = new Size(1321, 150);
            pnelppaltitulo.TabIndex = 17;
            // 
            // lblTituloPrograma
            // 
            lblTituloPrograma.AutoSize = true;
            lblTituloPrograma.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloPrograma.Location = new Point(458, 50);
            lblTituloPrograma.Margin = new Padding(2, 0, 2, 0);
            lblTituloPrograma.Name = "lblTituloPrograma";
            lblTituloPrograma.Size = new Size(431, 54);
            lblTituloPrograma.TabIndex = 0;
            lblTituloPrograma.Text = "Gestión de Sucursales";
            lblTituloPrograma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnelppalbotones
            // 
            pnelppalbotones.BackColor = SystemColors.GrayText;
            pnelppalbotones.Controls.Add(btnBuscarSucursal);
            pnelppalbotones.Controls.Add(btnVolver);
            pnelppalbotones.Controls.Add(btnSalir);
            pnelppalbotones.Controls.Add(btnEliminarSucursal);
            pnelppalbotones.Controls.Add(btnModificarSucursal);
            pnelppalbotones.Controls.Add(btnAgregarSucursal);
            pnelppalbotones.Dock = DockStyle.Left;
            pnelppalbotones.Location = new Point(0, 0);
            pnelppalbotones.Margin = new Padding(2);
            pnelppalbotones.Name = "pnelppalbotones";
            pnelppalbotones.Size = new Size(301, 768);
            pnelppalbotones.TabIndex = 16;
            // 
            // btnBuscarSucursal
            // 
            btnBuscarSucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarSucursal.Location = new Point(46, 489);
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
            btnVolver.Location = new Point(46, 577);
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
            btnSalir.Location = new Point(46, 664);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(205, 70);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir del Programa";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminarSucursal
            // 
            btnEliminarSucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarSucursal.Location = new Point(46, 402);
            btnEliminarSucursal.Name = "btnEliminarSucursal";
            btnEliminarSucursal.Size = new Size(205, 70);
            btnEliminarSucursal.TabIndex = 6;
            btnEliminarSucursal.Text = "Eliminar Sucursal";
            btnEliminarSucursal.UseVisualStyleBackColor = true;
            btnEliminarSucursal.Click += btnEliminarSucursal_Click;
            // 
            // btnModificarSucursal
            // 
            btnModificarSucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificarSucursal.Location = new Point(46, 313);
            btnModificarSucursal.Name = "btnModificarSucursal";
            btnModificarSucursal.Size = new Size(205, 70);
            btnModificarSucursal.TabIndex = 5;
            btnModificarSucursal.Text = "Modificar Sucursal";
            btnModificarSucursal.UseVisualStyleBackColor = true;
            btnModificarSucursal.Click += btnModificarSucursal_Click;
            // 
            // btnAgregarSucursal
            // 
            btnAgregarSucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarSucursal.Location = new Point(46, 228);
            btnAgregarSucursal.Name = "btnAgregarSucursal";
            btnAgregarSucursal.Size = new Size(205, 70);
            btnAgregarSucursal.TabIndex = 4;
            btnAgregarSucursal.Text = "Agregar Sucursal";
            btnAgregarSucursal.UseVisualStyleBackColor = true;
            btnAgregarSucursal.Click += btnAgregarSucursal_Click;
            // 
            // Ventana_Gestion_Sucursales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1622, 768);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            Controls.Add(pnelppalbotones);
            Name = "Ventana_Gestion_Sucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventana_Gestion_Sucursales";
            pnelppalmedio.ResumeLayout(false);
            grbBuscarSucursal.ResumeLayout(false);
            grbBuscarSucursal.PerformLayout();
            grbGrillaSucursales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            grbIngresoDatosSucursal.ResumeLayout(false);
            grbIngresoDatosSucursal.PerformLayout();
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
        private TextBox txtNombreBuscado;
        private GroupBox grbGrillaSucursales;
        private DataGridView dgvSucursales;
        private GroupBox grbIngresoDatosSucursal;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private Button btnLimpiarCampos;
        private Label lblNombre;
        private TextBox txtNombre;
        private Panel pnelppaltitulo;
        private Label lblTituloPrograma;
        private Panel pnelppalbotones;
        private Button btnBuscarSucursal;
        private Button btnVolver;
        private Button btnSalir;
        private Button btnEliminarSucursal;
        private Button btnModificarSucursal;
        private Button btnAgregarSucursal;
    }
}