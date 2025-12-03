namespace Vista
{
    partial class Ventana_Gestion_Clientes
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
            pnelppaltitulo = new Panel();
            lblTituloPrograma = new Label();
            pnelppalbotones = new Panel();
            btnVolver = new Button();
            btnSalir = new Button();
            btnEliminarCliente = new Button();
            btnModificarCliente = new Button();
            btnAgregarCliente = new Button();
            grbGrillaClientes = new GroupBox();
            dgvClientes = new DataGridView();
            grbIngresoDatosProveedores = new GroupBox();
            btnLimpiarCampos = new Button();
            this.txtEmail = new TextBox();
            lblEmail = new Label();
            this.lblNombre = new Label();
            txtNombre = new TextBox();
            grbTipoCliente = new GroupBox();
            lblSelección = new Label();
            rdbMinorista = new RadioButton();
            rdbMayorista = new RadioButton();
            grbBuscarCliente = new GroupBox();
            btnBuscar = new Button();
            lblId = new Label();
            txtId = new TextBox();
            btnCliente = new Button();
            pnelppalmedio.SuspendLayout();
            pnelppaltitulo.SuspendLayout();
            pnelppalbotones.SuspendLayout();
            grbGrillaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            grbIngresoDatosProveedores.SuspendLayout();
            grbTipoCliente.SuspendLayout();
            grbBuscarCliente.SuspendLayout();
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
            pnelppalmedio.Margin = new Padding(2);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1331, 795);
            pnelppalmedio.TabIndex = 12;
            // 
            // pnelppaltitulo
            // 
            pnelppaltitulo.BackColor = SystemColors.ControlLightLight;
            pnelppaltitulo.Controls.Add(lblTituloPrograma);
            pnelppaltitulo.Dock = DockStyle.Top;
            pnelppaltitulo.Location = new Point(301, 0);
            pnelppaltitulo.Margin = new Padding(2);
            pnelppaltitulo.Name = "pnelppaltitulo";
            pnelppaltitulo.Size = new Size(1331, 150);
            pnelppaltitulo.TabIndex = 11;
            // 
            // lblTituloPrograma
            // 
            lblTituloPrograma.AutoSize = true;
            lblTituloPrograma.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloPrograma.Location = new Point(458, 50);
            lblTituloPrograma.Margin = new Padding(2, 0, 2, 0);
            lblTituloPrograma.Name = "lblTituloPrograma";
            lblTituloPrograma.Size = new Size(384, 54);
            lblTituloPrograma.TabIndex = 0;
            lblTituloPrograma.Text = "Gestión de Clientes";
            lblTituloPrograma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnelppalbotones
            // 
            pnelppalbotones.BackColor = SystemColors.GrayText;
            pnelppalbotones.Controls.Add(btnCliente);
            pnelppalbotones.Controls.Add(btnVolver);
            pnelppalbotones.Controls.Add(btnSalir);
            pnelppalbotones.Controls.Add(btnEliminarCliente);
            pnelppalbotones.Controls.Add(btnModificarCliente);
            pnelppalbotones.Controls.Add(btnAgregarCliente);
            pnelppalbotones.Dock = DockStyle.Left;
            pnelppalbotones.Location = new Point(0, 0);
            pnelppalbotones.Margin = new Padding(2);
            pnelppalbotones.Name = "pnelppalbotones";
            pnelppalbotones.Size = new Size(301, 945);
            pnelppalbotones.TabIndex = 10;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.Location = new Point(46, 609);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(205, 70);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(46, 696);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(205, 70);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir del Programa";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarCliente.Location = new Point(46, 434);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(205, 70);
            btnEliminarCliente.TabIndex = 6;
            btnEliminarCliente.Text = "Eliminar Cliente";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificarCliente.Location = new Point(46, 345);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(205, 70);
            btnModificarCliente.TabIndex = 5;
            btnModificarCliente.Text = "Modificar Cliente";
            btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarCliente.Location = new Point(46, 260);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(205, 70);
            btnAgregarCliente.TabIndex = 4;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // grbGrillaClientes
            // 
            grbGrillaClientes.BackgroundImageLayout = ImageLayout.None;
            grbGrillaClientes.Controls.Add(dgvClientes);
            grbGrillaClientes.Font = new Font("Segoe UI", 9F);
            grbGrillaClientes.Location = new Point(482, 73);
            grbGrillaClientes.Name = "grbGrillaClientes";
            grbGrillaClientes.Size = new Size(819, 579);
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
            dgvClientes.Location = new Point(25, 42);
            dgvClientes.Margin = new Padding(2);
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
            dgvClientes.Size = new Size(774, 518);
            dgvClientes.TabIndex = 1;
            // 
            // grbIngresoDatosProveedores
            // 
            grbIngresoDatosProveedores.Controls.Add(grbTipoCliente);
            grbIngresoDatosProveedores.Controls.Add(btnLimpiarCampos);
            grbIngresoDatosProveedores.Controls.Add(this.txtEmail);
            grbIngresoDatosProveedores.Controls.Add(lblEmail);
            grbIngresoDatosProveedores.Controls.Add(this.lblNombre);
            grbIngresoDatosProveedores.Controls.Add(txtNombre);
            grbIngresoDatosProveedores.Location = new Point(51, 73);
            grbIngresoDatosProveedores.Name = "grbIngresoDatosProveedores";
            grbIngresoDatosProveedores.Size = new Size(399, 431);
            grbIngresoDatosProveedores.TabIndex = 17;
            grbIngresoDatosProveedores.TabStop = false;
            grbIngresoDatosProveedores.Text = "Ingreso de Datos";
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = SystemColors.HighlightText;
            btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            btnLimpiarCampos.FlatStyle = FlatStyle.Flat;
            btnLimpiarCampos.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarCampos.Location = new Point(119, 42);
            btnLimpiarCampos.Margin = new Padding(2);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(146, 65);
            btnLimpiarCampos.TabIndex = 16;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new Font("Segoe UI", 9F);
            this.txtEmail.Location = new Point(42, 211);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(320, 33);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(167, 181);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 25);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblNombre.Location = new Point(110, 117);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new Size(181, 25);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre del Cliente:";
            this.lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(42, 145);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 31);
            txtNombre.TabIndex = 0;
            // 
            // grbTipoCliente
            // 
            grbTipoCliente.Controls.Add(lblSelección);
            grbTipoCliente.Controls.Add(rdbMinorista);
            grbTipoCliente.Controls.Add(rdbMayorista);
            grbTipoCliente.Location = new Point(42, 261);
            grbTipoCliente.Margin = new Padding(2);
            grbTipoCliente.Name = "grbTipoCliente";
            grbTipoCliente.Padding = new Padding(2);
            grbTipoCliente.Size = new Size(320, 153);
            grbTipoCliente.TabIndex = 17;
            grbTipoCliente.TabStop = false;
            grbTipoCliente.Text = "Tipo de Cliente";
            // 
            // lblSelección
            // 
            lblSelección.AutoSize = true;
            lblSelección.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSelección.Location = new Point(33, 45);
            lblSelección.Margin = new Padding(2, 0, 2, 0);
            lblSelección.Name = "lblSelección";
            lblSelección.Size = new Size(263, 25);
            lblSelección.TabIndex = 15;
            lblSelección.Text = "Seleccione el tipo de registro:";
            lblSelección.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rdbMinorista
            // 
            rdbMinorista.AutoSize = true;
            rdbMinorista.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdbMinorista.Location = new Point(33, 85);
            rdbMinorista.Margin = new Padding(2);
            rdbMinorista.Name = "rdbMinorista";
            rdbMinorista.Size = new Size(118, 29);
            rdbMinorista.TabIndex = 12;
            rdbMinorista.TabStop = true;
            rdbMinorista.Text = "Minorista";
            rdbMinorista.UseVisualStyleBackColor = true;
            // 
            // rdbMayorista
            // 
            rdbMayorista.AutoSize = true;
            rdbMayorista.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdbMayorista.Location = new Point(174, 85);
            rdbMayorista.Margin = new Padding(2);
            rdbMayorista.Name = "rdbMayorista";
            rdbMayorista.Size = new Size(122, 29);
            rdbMayorista.TabIndex = 11;
            rdbMayorista.TabStop = true;
            rdbMayorista.Text = "Mayorista";
            rdbMayorista.UseVisualStyleBackColor = true;
            // 
            // grbBuscarCliente
            // 
            grbBuscarCliente.Controls.Add(btnBuscar);
            grbBuscarCliente.Controls.Add(lblId);
            grbBuscarCliente.Controls.Add(txtId);
            grbBuscarCliente.Location = new Point(54, 527);
            grbBuscarCliente.Name = "grbBuscarCliente";
            grbBuscarCliente.Size = new Size(396, 226);
            grbBuscarCliente.TabIndex = 19;
            grbBuscarCliente.TabStop = false;
            grbBuscarCliente.Text = "Buscar Cliente";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.HighlightText;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(116, 131);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 65);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.Location = new Point(101, 46);
            lblId.Name = "lblId";
            lblId.Size = new Size(181, 25);
            lblId.TabIndex = 18;
            lblId.Text = "Nombre del Cliente:";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 9F);
            txtId.Location = new Point(61, 84);
            txtId.Name = "txtId";
            txtId.Size = new Size(274, 31);
            txtId.TabIndex = 17;
            // 
            // btnCliente
            // 
            btnCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCliente.Location = new Point(46, 521);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(205, 70);
            btnCliente.TabIndex = 10;
            btnCliente.Text = "Buscar Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            // 
            // Ventana_Gestion_Clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1632, 945);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            Controls.Add(pnelppalbotones);
            Name = "Ventana_Gestion_Clientes";
            Text = "Ventana_Gestion_Clientes";
            pnelppalmedio.ResumeLayout(false);
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            pnelppalbotones.ResumeLayout(false);
            grbGrillaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            grbIngresoDatosProveedores.ResumeLayout(false);
            grbIngresoDatosProveedores.PerformLayout();
            grbTipoCliente.ResumeLayout(false);
            grbTipoCliente.PerformLayout();
            grbBuscarCliente.ResumeLayout(false);
            grbBuscarCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private Panel pnelppaltitulo;
        private Label lblTituloPrograma;
        private Panel pnelppalbotones;
        private Button btnAgregarCuenta;
        private Button btnVolver;
        private Label label1;
        private Button btnSalir;
        private Button btnEliminarCliente;
        private Button btnModificarCliente;
        private Button btnAgregarCliente;
        private GroupBox grbGrillaClientes;
        private DataGridView dgvClientes;
        private GroupBox grbIngresoDatosProveedores;
        private ComboBox cbRubro;
        private Button btnLimpiarCampos;
        private Label label2;
        private TextBox txtemailProveedor;
        private Label lblDireccion;
        private Label lblEmail;
        private Label lbltelefonoproveedor;
        private Label lblNombreProveedor;
        private TextBox txttelefonoProveedor;
        private TextBox txtDireccionProveedor;
        private TextBox txtNombre;
        private GroupBox grbTipoCliente;
        private Label lblSelección;
        private RadioButton rdbMinorista;
        private RadioButton rdbMayorista;
        private GroupBox grbBuscarCliente;
        private Button btnBuscar;
        private Label lblId;
        private TextBox txtId;
        private Button btnCliente;
    }
}