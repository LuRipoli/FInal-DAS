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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnelppalmedio = new Panel();
            grbBuscarCliente = new GroupBox();
            btnBuscar = new Button();
            lblId = new Label();
            txtId = new TextBox();
            grbGrillaClientes = new GroupBox();
            dgvClientes = new DataGridView();
            grbIngresoDatosProveedores = new GroupBox();
            btnLimpiarCampos = new Button();
            lblEmail = new Label();
            txtNombre = new TextBox();
            pnelppaltitulo = new Panel();
            pnelppalbotones = new Panel();
            btnBuscarCategoriaId = new Button();
            btnVolver = new Button();
            btnSalir = new Button();
            btnEliminarCategoria = new Button();
            btnModificarCategoria = new Button();
            btnAgregarCategoria = new Button();
            lblTituloGR = new Label();
            BuscarCategoriaNombre = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            pnelppalmedio.SuspendLayout();
            grbBuscarCliente.SuspendLayout();
            grbGrillaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            grbIngresoDatosProveedores.SuspendLayout();
            pnelppaltitulo.SuspendLayout();
            pnelppalbotones.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.ActiveCaption;
            pnelppalmedio.Controls.Add(groupBox1);
            pnelppalmedio.Controls.Add(grbBuscarCliente);
            pnelppalmedio.Controls.Add(grbGrillaClientes);
            pnelppalmedio.Controls.Add(grbIngresoDatosProveedores);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(241, 120);
            pnelppalmedio.Margin = new Padding(2);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1060, 620);
            pnelppalmedio.TabIndex = 15;
            // 
            // grbBuscarCliente
            // 
            grbBuscarCliente.Controls.Add(btnBuscar);
            grbBuscarCliente.Controls.Add(lblId);
            grbBuscarCliente.Controls.Add(txtId);
            grbBuscarCliente.Location = new Point(41, 437);
            grbBuscarCliente.Margin = new Padding(2);
            grbBuscarCliente.Name = "grbBuscarCliente";
            grbBuscarCliente.Padding = new Padding(2);
            grbBuscarCliente.Size = new Size(317, 164);
            grbBuscarCliente.TabIndex = 19;
            grbBuscarCliente.TabStop = false;
            grbBuscarCliente.Text = "Buscar Categoria por nombre";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.HighlightText;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(93, 105);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(117, 52);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.Location = new Point(68, 33);
            lblId.Margin = new Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(167, 20);
            lblId.TabIndex = 18;
            lblId.Text = "Nombre del Categoria:";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 9F);
            txtId.Location = new Point(49, 67);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(220, 27);
            txtId.TabIndex = 17;
            // 
            // grbGrillaClientes
            // 
            grbGrillaClientes.BackgroundImageLayout = ImageLayout.None;
            grbGrillaClientes.Controls.Add(dgvClientes);
            grbGrillaClientes.Font = new Font("Segoe UI", 9F);
            grbGrillaClientes.Location = new Point(386, 58);
            grbGrillaClientes.Margin = new Padding(2);
            grbGrillaClientes.Name = "grbGrillaClientes";
            grbGrillaClientes.Padding = new Padding(2);
            grbGrillaClientes.Size = new Size(655, 543);
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle5;
            dgvClientes.Location = new Point(20, 26);
            dgvClientes.Margin = new Padding(2);
            dgvClientes.Name = "dgvClientes";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.Size = new Size(619, 510);
            dgvClientes.TabIndex = 1;
            // 
            // grbIngresoDatosProveedores
            // 
            grbIngresoDatosProveedores.Controls.Add(btnLimpiarCampos);
            grbIngresoDatosProveedores.Controls.Add(lblEmail);
            grbIngresoDatosProveedores.Controls.Add(txtNombre);
            grbIngresoDatosProveedores.Location = new Point(41, 58);
            grbIngresoDatosProveedores.Margin = new Padding(2);
            grbIngresoDatosProveedores.Name = "grbIngresoDatosProveedores";
            grbIngresoDatosProveedores.Padding = new Padding(2);
            grbIngresoDatosProveedores.Size = new Size(319, 176);
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
            btnLimpiarCampos.Location = new Point(34, 34);
            btnLimpiarCampos.Margin = new Padding(2);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(122, 52);
            btnLimpiarCampos.TabIndex = 16;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(133, 144);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 20);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Nombre:";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(34, 112);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(257, 27);
            txtNombre.TabIndex = 0;
            // 
            // pnelppaltitulo
            // 
            pnelppaltitulo.BackColor = SystemColors.ControlLightLight;
            pnelppaltitulo.Controls.Add(lblTituloGR);
            pnelppaltitulo.Dock = DockStyle.Top;
            pnelppaltitulo.Location = new Point(241, 0);
            pnelppaltitulo.Margin = new Padding(2);
            pnelppaltitulo.Name = "pnelppaltitulo";
            pnelppaltitulo.Size = new Size(1060, 120);
            pnelppaltitulo.TabIndex = 14;
            // 
            // pnelppalbotones
            // 
            pnelppalbotones.BackColor = SystemColors.GrayText;
            pnelppalbotones.Controls.Add(BuscarCategoriaNombre);
            pnelppalbotones.Controls.Add(btnBuscarCategoriaId);
            pnelppalbotones.Controls.Add(btnVolver);
            pnelppalbotones.Controls.Add(btnSalir);
            pnelppalbotones.Controls.Add(btnEliminarCategoria);
            pnelppalbotones.Controls.Add(btnModificarCategoria);
            pnelppalbotones.Controls.Add(btnAgregarCategoria);
            pnelppalbotones.Dock = DockStyle.Left;
            pnelppalbotones.Location = new Point(0, 0);
            pnelppalbotones.Margin = new Padding(2);
            pnelppalbotones.Name = "pnelppalbotones";
            pnelppalbotones.Size = new Size(241, 740);
            pnelppalbotones.TabIndex = 13;
            // 
            // btnBuscarCategoriaId
            // 
            btnBuscarCategoriaId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarCategoriaId.Location = new Point(37, 345);
            btnBuscarCategoriaId.Margin = new Padding(2);
            btnBuscarCategoriaId.Name = "btnBuscarCategoriaId";
            btnBuscarCategoriaId.Size = new Size(164, 56);
            btnBuscarCategoriaId.TabIndex = 10;
            btnBuscarCategoriaId.Text = "Buscar Categoria Por Id";
            btnBuscarCategoriaId.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.Location = new Point(37, 487);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(164, 56);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(37, 557);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(164, 56);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir del Programa";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarCategoria.Location = new Point(37, 275);
            btnEliminarCategoria.Margin = new Padding(2);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(164, 56);
            btnEliminarCategoria.TabIndex = 6;
            btnEliminarCategoria.Text = "Eliminar Categoria";
            btnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnModificarCategoria
            // 
            btnModificarCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificarCategoria.Location = new Point(37, 204);
            btnModificarCategoria.Margin = new Padding(2);
            btnModificarCategoria.Name = "btnModificarCategoria";
            btnModificarCategoria.Size = new Size(164, 56);
            btnModificarCategoria.TabIndex = 5;
            btnModificarCategoria.Text = "Modificar Categoria";
            btnModificarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarCategoria.Location = new Point(37, 136);
            btnAgregarCategoria.Margin = new Padding(2);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(164, 56);
            btnAgregarCategoria.TabIndex = 4;
            btnAgregarCategoria.Text = "Agregar Categoria";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // lblTituloGR
            // 
            lblTituloGR.AutoSize = true;
            lblTituloGR.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloGR.Location = new Point(377, 37);
            lblTituloGR.Margin = new Padding(2, 0, 2, 0);
            lblTituloGR.Name = "lblTituloGR";
            lblTituloGR.Size = new Size(313, 46);
            lblTituloGR.TabIndex = 1;
            lblTituloGR.Text = "Gestión de Rubros";
            lblTituloGR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BuscarCategoriaNombre
            // 
            BuscarCategoriaNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BuscarCategoriaNombre.Location = new Point(37, 415);
            BuscarCategoriaNombre.Margin = new Padding(2);
            BuscarCategoriaNombre.Name = "BuscarCategoriaNombre";
            BuscarCategoriaNombre.Size = new Size(164, 56);
            BuscarCategoriaNombre.TabIndex = 11;
            BuscarCategoriaNombre.Text = "Buscar Categoria Por Nombre";
            BuscarCategoriaNombre.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(41, 254);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(317, 164);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Categoria por Id";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(93, 105);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(117, 52);
            button1.TabIndex = 19;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(93, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 18;
            label1.Text = "Id del Categoria:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(49, 67);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 17;
            // 
            // Gestion_de_Rubros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 740);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            Controls.Add(pnelppalbotones);
            Name = "Gestion_de_Rubros";
            Text = "Gestion_de_Rubros";
            pnelppalmedio.ResumeLayout(false);
            grbBuscarCliente.ResumeLayout(false);
            grbBuscarCliente.PerformLayout();
            grbGrillaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            grbIngresoDatosProveedores.ResumeLayout(false);
            grbIngresoDatosProveedores.PerformLayout();
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            pnelppalbotones.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private GroupBox grbBuscarCliente;
        private Button btnBuscar;
        private Label lblId;
        private TextBox txtId;
        private GroupBox grbGrillaClientes;
        private DataGridView dgvClientes;
        private GroupBox grbIngresoDatosProveedores;
        private Button btnLimpiarCampos;
        private Label lblEmail;
        private TextBox txtNombre;
        private Panel pnelppaltitulo;
        private Panel pnelppalbotones;
        private Button btnBuscarCategoriaId;
        private Button btnVolver;
        private Button btnSalir;
        private Button btnEliminarCategoria;
        private Button btnModificarCategoria;
        private Button btnAgregarCategoria;
        private Label lblTituloGR;
        private Button BuscarCategoriaNombre;
        private GroupBox groupBox1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
    }
}