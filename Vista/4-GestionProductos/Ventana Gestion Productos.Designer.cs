namespace Vista
{
    partial class Ventana_Gestion_Productos
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
            grbBuscarCliente = new GroupBox();
            btnBuscar = new Button();
            lblNombrePRODUCTO = new Label();
            txtId = new TextBox();
            grbGrillaClientes = new GroupBox();
            dgvProductos = new DataGridView();
            grbIngresoDatosProveedores = new GroupBox();
            txtStock = new TextBox();
            lblStock = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            btnLimpiarCampos = new Button();
            txtNombreProducto = new TextBox();
            lblPRODUCTOID = new Label();
            lblNombre = new Label();
            txtIDPRODUCTO = new TextBox();
            pnelppaltitulo = new Panel();
            lblTituloPrograma = new Label();
            pnelppalbotones = new Panel();
            btnBuscarProducto = new Button();
            btnVolver = new Button();
            btnSalir = new Button();
            btnEliminarProducto = new Button();
            btnModificarProducto = new Button();
            btnAgregarProducto = new Button();
            pnelppalmedio.SuspendLayout();
            grbBuscarCliente.SuspendLayout();
            grbGrillaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            grbIngresoDatosProveedores.SuspendLayout();
            pnelppaltitulo.SuspendLayout();
            pnelppalbotones.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.ActiveCaption;
            pnelppalmedio.Controls.Add(grbBuscarCliente);
            pnelppalmedio.Controls.Add(grbGrillaClientes);
            pnelppalmedio.Controls.Add(grbIngresoDatosProveedores);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(301, 150);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1393, 773);
            pnelppalmedio.TabIndex = 15;
            // 
            // grbBuscarCliente
            // 
            grbBuscarCliente.Controls.Add(btnBuscar);
            grbBuscarCliente.Controls.Add(lblNombrePRODUCTO);
            grbBuscarCliente.Controls.Add(txtId);
            grbBuscarCliente.Location = new Point(54, 527);
            grbBuscarCliente.Name = "grbBuscarCliente";
            grbBuscarCliente.Size = new Size(396, 227);
            grbBuscarCliente.TabIndex = 19;
            grbBuscarCliente.TabStop = false;
            grbBuscarCliente.Text = "Buscar Producto";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.HighlightText;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(116, 132);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 65);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblNombrePRODUCTO
            // 
            lblNombrePRODUCTO.AutoSize = true;
            lblNombrePRODUCTO.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombrePRODUCTO.Location = new Point(101, 47);
            lblNombrePRODUCTO.Name = "lblNombrePRODUCTO";
            lblNombrePRODUCTO.Size = new Size(200, 25);
            lblNombrePRODUCTO.TabIndex = 18;
            lblNombrePRODUCTO.Text = "Nombre del Producto:";
            lblNombrePRODUCTO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 9F);
            txtId.Location = new Point(61, 83);
            txtId.Name = "txtId";
            txtId.Size = new Size(274, 31);
            txtId.TabIndex = 17;
            // 
            // grbGrillaClientes
            // 
            grbGrillaClientes.BackgroundImageLayout = ImageLayout.None;
            grbGrillaClientes.Controls.Add(dgvProductos);
            grbGrillaClientes.Font = new Font("Segoe UI", 9F);
            grbGrillaClientes.Location = new Point(483, 73);
            grbGrillaClientes.Name = "grbGrillaClientes";
            grbGrillaClientes.Size = new Size(819, 578);
            grbGrillaClientes.TabIndex = 18;
            grbGrillaClientes.TabStop = false;
            grbGrillaClientes.Text = "Grilla de Productos";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.BackgroundColor = SystemColors.GrayText;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle5;
            dgvProductos.Location = new Point(26, 43);
            dgvProductos.Name = "dgvProductos";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(774, 517);
            dgvProductos.TabIndex = 1;
            // 
            // grbIngresoDatosProveedores
            // 
            grbIngresoDatosProveedores.Controls.Add(txtStock);
            grbIngresoDatosProveedores.Controls.Add(lblStock);
            grbIngresoDatosProveedores.Controls.Add(txtPrecio);
            grbIngresoDatosProveedores.Controls.Add(lblPrecio);
            grbIngresoDatosProveedores.Controls.Add(txtDescripcion);
            grbIngresoDatosProveedores.Controls.Add(lblDescripcion);
            grbIngresoDatosProveedores.Controls.Add(btnLimpiarCampos);
            grbIngresoDatosProveedores.Controls.Add(txtNombreProducto);
            grbIngresoDatosProveedores.Controls.Add(lblPRODUCTOID);
            grbIngresoDatosProveedores.Controls.Add(lblNombre);
            grbIngresoDatosProveedores.Controls.Add(txtIDPRODUCTO);
            grbIngresoDatosProveedores.Location = new Point(44, 25);
            grbIngresoDatosProveedores.Name = "grbIngresoDatosProveedores";
            grbIngresoDatosProveedores.Size = new Size(406, 478);
            grbIngresoDatosProveedores.TabIndex = 17;
            grbIngresoDatosProveedores.TabStop = false;
            grbIngresoDatosProveedores.Text = "Ingreso de Datos";
            grbIngresoDatosProveedores.Enter += grbIngresoDatosProveedores_Enter;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 9F);
            txtStock.Location = new Point(286, 423);
            txtStock.Multiline = true;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(115, 36);
            txtStock.TabIndex = 23;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStock.Location = new Point(214, 427);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(65, 25);
            lblStock.TabIndex = 23;
            lblStock.Text = "Stock:";
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 9F);
            txtPrecio.Location = new Point(89, 423);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(120, 36);
            txtPrecio.TabIndex = 22;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrecio.Location = new Point(10, 433);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(70, 25);
            lblPrecio.TabIndex = 21;
            lblPrecio.Text = "Precio:";
            lblPrecio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 9F);
            txtDescripcion.Location = new Point(56, 330);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(290, 36);
            txtDescripcion.TabIndex = 18;
            txtDescripcion.TextChanged += textBox1_TextChanged;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescripcion.Location = new Point(154, 282);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(116, 25);
            lblDescripcion.TabIndex = 17;
            lblDescripcion.Text = "Descripcion:";
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            lblDescripcion.Click += label1_Click;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = SystemColors.HighlightText;
            btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            btnLimpiarCampos.FlatStyle = FlatStyle.Flat;
            btnLimpiarCampos.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarCampos.Location = new Point(200, 30);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(146, 65);
            btnLimpiarCampos.TabIndex = 16;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Font = new Font("Segoe UI", 9F);
            txtNombreProducto.Location = new Point(56, 188);
            txtNombreProducto.Multiline = true;
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(290, 32);
            txtNombreProducto.TabIndex = 2;
            // 
            // lblPRODUCTOID
            // 
            lblPRODUCTOID.AutoSize = true;
            lblPRODUCTOID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPRODUCTOID.Location = new Point(26, 57);
            lblPRODUCTOID.Name = "lblPRODUCTOID";
            lblPRODUCTOID.Size = new Size(36, 25);
            lblPRODUCTOID.TabIndex = 10;
            lblPRODUCTOID.Text = "ID:";
            lblPRODUCTOID.TextAlign = ContentAlignment.MiddleCenter;
            lblPRODUCTOID.Click += lblEmail_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(109, 130);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(200, 25);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre del Producto:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            lblNombre.Click += lblNombre_Click;
            // 
            // txtIDPRODUCTO
            // 
            txtIDPRODUCTO.Font = new Font("Segoe UI", 9F);
            txtIDPRODUCTO.Location = new Point(109, 53);
            txtIDPRODUCTO.Name = "txtIDPRODUCTO";
            txtIDPRODUCTO.Size = new Size(68, 31);
            txtIDPRODUCTO.TabIndex = 0;
            txtIDPRODUCTO.TextChanged += txtNombre_TextChanged;
            // 
            // pnelppaltitulo
            // 
            pnelppaltitulo.BackColor = SystemColors.ControlLightLight;
            pnelppaltitulo.Controls.Add(lblTituloPrograma);
            pnelppaltitulo.Dock = DockStyle.Top;
            pnelppaltitulo.Location = new Point(301, 0);
            pnelppaltitulo.Name = "pnelppaltitulo";
            pnelppaltitulo.Size = new Size(1393, 150);
            pnelppaltitulo.TabIndex = 14;
            // 
            // lblTituloPrograma
            // 
            lblTituloPrograma.AutoSize = true;
            lblTituloPrograma.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloPrograma.Location = new Point(457, 50);
            lblTituloPrograma.Name = "lblTituloPrograma";
            lblTituloPrograma.Size = new Size(426, 54);
            lblTituloPrograma.TabIndex = 0;
            lblTituloPrograma.Text = "Gestion de Productos";
            lblTituloPrograma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnelppalbotones
            // 
            pnelppalbotones.BackColor = SystemColors.GrayText;
            pnelppalbotones.Controls.Add(btnBuscarProducto);
            pnelppalbotones.Controls.Add(btnVolver);
            pnelppalbotones.Controls.Add(btnSalir);
            pnelppalbotones.Controls.Add(btnEliminarProducto);
            pnelppalbotones.Controls.Add(btnModificarProducto);
            pnelppalbotones.Controls.Add(btnAgregarProducto);
            pnelppalbotones.Dock = DockStyle.Left;
            pnelppalbotones.Location = new Point(0, 0);
            pnelppalbotones.Name = "pnelppalbotones";
            pnelppalbotones.Size = new Size(301, 923);
            pnelppalbotones.TabIndex = 13;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarProducto.Location = new Point(46, 522);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(206, 70);
            btnBuscarProducto.TabIndex = 10;
            btnBuscarProducto.Text = "Buscar Producto";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.Location = new Point(46, 608);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(206, 70);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(46, 697);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(206, 70);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir del Programa";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarProducto.Location = new Point(46, 433);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(206, 70);
            btnEliminarProducto.TabIndex = 6;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificarProducto.Location = new Point(46, 345);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(206, 70);
            btnModificarProducto.TabIndex = 5;
            btnModificarProducto.Text = "Modificar Producto";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarProducto.Location = new Point(46, 260);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(206, 70);
            btnAgregarProducto.TabIndex = 4;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarCliente_Click;
            // 
            // Ventana_Gestion_Productos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1694, 923);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            Controls.Add(pnelppalbotones);
            Name = "Ventana_Gestion_Productos";
            Text = "Ventana_Gestion_Productos";
            pnelppalmedio.ResumeLayout(false);
            grbBuscarCliente.ResumeLayout(false);
            grbBuscarCliente.PerformLayout();
            grbGrillaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            grbIngresoDatosProveedores.ResumeLayout(false);
            grbIngresoDatosProveedores.PerformLayout();
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            pnelppalbotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private GroupBox grbBuscarCliente;
        private Button btnBuscar;
        private Label lblNombrePRODUCTO;
        private TextBox txtId;
        private GroupBox grbGrillaClientes;
        private DataGridView dgvProductos;
        private GroupBox grbIngresoDatosProveedores;
        private Button btnLimpiarCampos;
        private TextBox txtNombreProducto;
        private Label lblPRODUCTOID;
        private Label lblNombre;
        private TextBox txtIDPRODUCTO;
        private Panel pnelppaltitulo;
        private Label lblTituloPrograma;
        private Panel pnelppalbotones;
        private Button btnBuscarProducto;
        private Button btnVolver;
        private Button btnSalir;
        private Button btnEliminarProducto;
        private Button btnModificarProducto;
        private Button btnAgregarProducto;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private Label lblPrecio;
        private TextBox txtStock;
        private Label lblStock;
        private TextBox txtPrecio;
    }
}