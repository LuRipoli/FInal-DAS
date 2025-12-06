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
            cmbEliminarCategoria = new GroupBox();
            label4 = new Label();
            txtEliminarId = new TextBox();
            btnEliminar = new Button();
            cmbModificar = new GroupBox();
            label3 = new Label();
            txtModificarId = new TextBox();
            btnModificar = new Button();
            label2 = new Label();
            txtModificarNombre = new TextBox();
            cmbBuscarId = new GroupBox();
            btnBuscarId = new Button();
            label1 = new Label();
            txtBuscarId = new TextBox();
            cmbBuscarNombre = new GroupBox();
            btnBuscarNombre = new Button();
            lblId = new Label();
            txtBuscarNombre = new TextBox();
            grbGrillaClientes = new GroupBox();
            dgvClientes = new DataGridView();
            CmbIngresoDeDatos = new GroupBox();
            btnIngresoDeDatos = new Button();
            lblEmail = new Label();
            txtAgregar = new TextBox();
            pnelppaltitulo = new Panel();
            lblTituloGR = new Label();
            pnelppalbotones = new Panel();
            BuscarCategoriaNombre = new Button();
            btnBuscarCategoriaId = new Button();
            btnVolver = new Button();
            btnSalir = new Button();
            btnEliminarCategoria = new Button();
            btnModificarCategoria = new Button();
            btnAgregarCategoria = new Button();
            pnelppalmedio.SuspendLayout();
            cmbEliminarCategoria.SuspendLayout();
            cmbModificar.SuspendLayout();
            cmbBuscarId.SuspendLayout();
            cmbBuscarNombre.SuspendLayout();
            grbGrillaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            CmbIngresoDeDatos.SuspendLayout();
            pnelppaltitulo.SuspendLayout();
            pnelppalbotones.SuspendLayout();
            SuspendLayout();
            // 
            // pnelppalmedio
            // 
            pnelppalmedio.BackColor = SystemColors.ActiveCaption;
            pnelppalmedio.Controls.Add(cmbEliminarCategoria);
            pnelppalmedio.Controls.Add(cmbModificar);
            pnelppalmedio.Controls.Add(cmbBuscarId);
            pnelppalmedio.Controls.Add(cmbBuscarNombre);
            pnelppalmedio.Controls.Add(grbGrillaClientes);
            pnelppalmedio.Controls.Add(CmbIngresoDeDatos);
            pnelppalmedio.Dock = DockStyle.Fill;
            pnelppalmedio.Location = new Point(241, 120);
            pnelppalmedio.Margin = new Padding(2);
            pnelppalmedio.Name = "pnelppalmedio";
            pnelppalmedio.Size = new Size(1060, 724);
            pnelppalmedio.TabIndex = 15;
            // 
            // cmbEliminarCategoria
            // 
            cmbEliminarCategoria.Controls.Add(label4);
            cmbEliminarCategoria.Controls.Add(txtEliminarId);
            cmbEliminarCategoria.Controls.Add(btnEliminar);
            cmbEliminarCategoria.Location = new Point(394, 660);
            cmbEliminarCategoria.Margin = new Padding(2);
            cmbEliminarCategoria.Name = "cmbEliminarCategoria";
            cmbEliminarCategoria.Padding = new Padding(2);
            cmbEliminarCategoria.Size = new Size(317, 112);
            cmbEliminarCategoria.TabIndex = 22;
            cmbEliminarCategoria.TabStop = false;
            cmbEliminarCategoria.Text = "Eliminar Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(19, 41);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 21;
            label4.Text = "Id Categoria a Eliminar";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEliminarId
            // 
            txtEliminarId.Font = new Font("Segoe UI", 9F);
            txtEliminarId.Location = new Point(20, 64);
            txtEliminarId.Margin = new Padding(2);
            txtEliminarId.Name = "txtEliminarId";
            txtEliminarId.Size = new Size(177, 27);
            txtEliminarId.TabIndex = 20;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.HighlightText;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(217, 42);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 52);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cmbModificar
            // 
            cmbModificar.Controls.Add(label3);
            cmbModificar.Controls.Add(txtModificarId);
            cmbModificar.Controls.Add(btnModificar);
            cmbModificar.Controls.Add(label2);
            cmbModificar.Controls.Add(txtModificarNombre);
            cmbModificar.Location = new Point(49, 596);
            cmbModificar.Margin = new Padding(2);
            cmbModificar.Name = "cmbModificar";
            cmbModificar.Padding = new Padding(2);
            cmbModificar.Size = new Size(317, 176);
            cmbModificar.TabIndex = 20;
            cmbModificar.TabStop = false;
            cmbModificar.Text = "Modificar Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(15, 105);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(177, 20);
            label3.TabIndex = 21;
            label3.Text = "Id Categoria a Modificar";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtModificarId
            // 
            txtModificarId.Font = new Font("Segoe UI", 9F);
            txtModificarId.Location = new Point(15, 127);
            txtModificarId.Margin = new Padding(2);
            txtModificarId.Name = "txtModificarId";
            txtModificarId.Size = new Size(177, 27);
            txtModificarId.TabIndex = 20;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.HighlightText;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(212, 105);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 52);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(49, 42);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(229, 20);
            label2.TabIndex = 18;
            label2.Text = "Nuevo Nombre de la Categoria:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtModificarNombre
            // 
            txtModificarNombre.Font = new Font("Segoe UI", 9F);
            txtModificarNombre.Location = new Point(15, 64);
            txtModificarNombre.Margin = new Padding(2);
            txtModificarNombre.Name = "txtModificarNombre";
            txtModificarNombre.Size = new Size(287, 27);
            txtModificarNombre.TabIndex = 17;
            // 
            // cmbBuscarId
            // 
            cmbBuscarId.Controls.Add(btnBuscarId);
            cmbBuscarId.Controls.Add(label1);
            cmbBuscarId.Controls.Add(txtBuscarId);
            cmbBuscarId.Location = new Point(49, 229);
            cmbBuscarId.Margin = new Padding(2);
            cmbBuscarId.Name = "cmbBuscarId";
            cmbBuscarId.Padding = new Padding(2);
            cmbBuscarId.Size = new Size(317, 164);
            cmbBuscarId.TabIndex = 20;
            cmbBuscarId.TabStop = false;
            cmbBuscarId.Text = "Buscar Categoria por Id";
            // 
            // btnBuscarId
            // 
            btnBuscarId.BackColor = SystemColors.HighlightText;
            btnBuscarId.FlatAppearance.BorderSize = 0;
            btnBuscarId.FlatStyle = FlatStyle.Flat;
            btnBuscarId.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarId.Location = new Point(93, 105);
            btnBuscarId.Margin = new Padding(2);
            btnBuscarId.Name = "btnBuscarId";
            btnBuscarId.Size = new Size(117, 52);
            btnBuscarId.TabIndex = 19;
            btnBuscarId.Text = "Buscar";
            btnBuscarId.UseVisualStyleBackColor = false;
            btnBuscarId.Click += btnBuscarId_Click;
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
            // txtBuscarId
            // 
            txtBuscarId.Font = new Font("Segoe UI", 9F);
            txtBuscarId.Location = new Point(49, 67);
            txtBuscarId.Margin = new Padding(2);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(220, 27);
            txtBuscarId.TabIndex = 17;
            // 
            // cmbBuscarNombre
            // 
            cmbBuscarNombre.Controls.Add(btnBuscarNombre);
            cmbBuscarNombre.Controls.Add(lblId);
            cmbBuscarNombre.Controls.Add(txtBuscarNombre);
            cmbBuscarNombre.Location = new Point(49, 412);
            cmbBuscarNombre.Margin = new Padding(2);
            cmbBuscarNombre.Name = "cmbBuscarNombre";
            cmbBuscarNombre.Padding = new Padding(2);
            cmbBuscarNombre.Size = new Size(317, 164);
            cmbBuscarNombre.TabIndex = 19;
            cmbBuscarNombre.TabStop = false;
            cmbBuscarNombre.Text = "Buscar Categoria por nombre";
            // 
            // btnBuscarNombre
            // 
            btnBuscarNombre.BackColor = SystemColors.HighlightText;
            btnBuscarNombre.FlatAppearance.BorderSize = 0;
            btnBuscarNombre.FlatStyle = FlatStyle.Flat;
            btnBuscarNombre.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarNombre.Location = new Point(93, 105);
            btnBuscarNombre.Margin = new Padding(2);
            btnBuscarNombre.Name = "btnBuscarNombre";
            btnBuscarNombre.Size = new Size(117, 52);
            btnBuscarNombre.TabIndex = 19;
            btnBuscarNombre.Text = "Buscar";
            btnBuscarNombre.UseVisualStyleBackColor = false;
            btnBuscarNombre.Click += btnBuscar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.Location = new Point(70, 35);
            lblId.Margin = new Padding(2, 0, 2, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(167, 20);
            lblId.TabIndex = 18;
            lblId.Text = "Nombre del Categoria:";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Font = new Font("Segoe UI", 9F);
            txtBuscarNombre.Location = new Point(49, 67);
            txtBuscarNombre.Margin = new Padding(2);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(220, 27);
            txtBuscarNombre.TabIndex = 17;
            // 
            // grbGrillaClientes
            // 
            grbGrillaClientes.BackgroundImageLayout = ImageLayout.None;
            grbGrillaClientes.Controls.Add(dgvClientes);
            grbGrillaClientes.Font = new Font("Segoe UI", 9F);
            grbGrillaClientes.Location = new Point(394, 45);
            grbGrillaClientes.Margin = new Padding(2);
            grbGrillaClientes.Name = "grbGrillaClientes";
            grbGrillaClientes.Padding = new Padding(2);
            grbGrillaClientes.Size = new Size(655, 611);
            grbGrillaClientes.TabIndex = 18;
            grbGrillaClientes.TabStop = false;
            grbGrillaClientes.Text = "Grilla de Categorias";
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
            dgvClientes.Location = new Point(20, 26);
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
            dgvClientes.Size = new Size(619, 570);
            dgvClientes.TabIndex = 1;
            // 
            // CmbIngresoDeDatos
            // 
            CmbIngresoDeDatos.Controls.Add(btnIngresoDeDatos);
            CmbIngresoDeDatos.Controls.Add(lblEmail);
            CmbIngresoDeDatos.Controls.Add(txtAgregar);
            CmbIngresoDeDatos.Location = new Point(49, 45);
            CmbIngresoDeDatos.Margin = new Padding(2);
            CmbIngresoDeDatos.Name = "CmbIngresoDeDatos";
            CmbIngresoDeDatos.Padding = new Padding(2);
            CmbIngresoDeDatos.Size = new Size(319, 164);
            CmbIngresoDeDatos.TabIndex = 17;
            CmbIngresoDeDatos.TabStop = false;
            CmbIngresoDeDatos.Text = "Ingreso de Datos";
            // 
            // btnIngresoDeDatos
            // 
            btnIngresoDeDatos.BackColor = SystemColors.HighlightText;
            btnIngresoDeDatos.FlatAppearance.BorderSize = 0;
            btnIngresoDeDatos.FlatStyle = FlatStyle.Flat;
            btnIngresoDeDatos.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresoDeDatos.Location = new Point(99, 108);
            btnIngresoDeDatos.Margin = new Padding(2);
            btnIngresoDeDatos.Name = "btnIngresoDeDatos";
            btnIngresoDeDatos.Size = new Size(117, 52);
            btnIngresoDeDatos.TabIndex = 20;
            btnIngresoDeDatos.Text = "Agregar";
            btnIngresoDeDatos.UseVisualStyleBackColor = false;
            btnIngresoDeDatos.Click += button2_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(121, 38);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 20);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Nombre:";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAgregar
            // 
            txtAgregar.Font = new Font("Segoe UI", 9F);
            txtAgregar.Location = new Point(27, 67);
            txtAgregar.Margin = new Padding(2);
            txtAgregar.Name = "txtAgregar";
            txtAgregar.Size = new Size(257, 27);
            txtAgregar.TabIndex = 0;
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
            // lblTituloGR
            // 
            lblTituloGR.AutoSize = true;
            lblTituloGR.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloGR.Location = new Point(377, 37);
            lblTituloGR.Margin = new Padding(2, 0, 2, 0);
            lblTituloGR.Name = "lblTituloGR";
            lblTituloGR.Size = new Size(368, 46);
            lblTituloGR.TabIndex = 1;
            lblTituloGR.Text = "Gestión de Categorias";
            lblTituloGR.TextAlign = ContentAlignment.MiddleCenter;
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
            pnelppalbotones.Size = new Size(241, 844);
            pnelppalbotones.TabIndex = 13;
            // 
            // BuscarCategoriaNombre
            // 
            BuscarCategoriaNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BuscarCategoriaNombre.Location = new Point(41, 531);
            BuscarCategoriaNombre.Margin = new Padding(2);
            BuscarCategoriaNombre.Name = "BuscarCategoriaNombre";
            BuscarCategoriaNombre.Size = new Size(164, 56);
            BuscarCategoriaNombre.TabIndex = 11;
            BuscarCategoriaNombre.Text = "Buscar Categoria Por Nombre";
            BuscarCategoriaNombre.UseVisualStyleBackColor = true;
            BuscarCategoriaNombre.Click += BuscarCategoriaNombre_Click;
            // 
            // btnBuscarCategoriaId
            // 
            btnBuscarCategoriaId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarCategoriaId.Location = new Point(41, 461);
            btnBuscarCategoriaId.Margin = new Padding(2);
            btnBuscarCategoriaId.Name = "btnBuscarCategoriaId";
            btnBuscarCategoriaId.Size = new Size(164, 56);
            btnBuscarCategoriaId.TabIndex = 10;
            btnBuscarCategoriaId.Text = "Buscar Categoria Por Id";
            btnBuscarCategoriaId.UseVisualStyleBackColor = true;
            btnBuscarCategoriaId.Click += btnBuscarCategoriaId_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.Location = new Point(41, 603);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(164, 56);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(41, 673);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(164, 56);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir del Programa";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarCategoria.Location = new Point(41, 391);
            btnEliminarCategoria.Margin = new Padding(2);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(164, 56);
            btnEliminarCategoria.TabIndex = 6;
            btnEliminarCategoria.Text = "Eliminar Categoria";
            btnEliminarCategoria.UseVisualStyleBackColor = true;
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;
            // 
            // btnModificarCategoria
            // 
            btnModificarCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificarCategoria.Location = new Point(41, 320);
            btnModificarCategoria.Margin = new Padding(2);
            btnModificarCategoria.Name = "btnModificarCategoria";
            btnModificarCategoria.Size = new Size(164, 56);
            btnModificarCategoria.TabIndex = 5;
            btnModificarCategoria.Text = "Modificar Categoria";
            btnModificarCategoria.UseVisualStyleBackColor = true;
            btnModificarCategoria.Click += btnModificarCategoria_Click;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarCategoria.Location = new Point(41, 252);
            btnAgregarCategoria.Margin = new Padding(2);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(164, 56);
            btnAgregarCategoria.TabIndex = 4;
            btnAgregarCategoria.Text = "Agregar Categoria";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // Gestion_de_Rubros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 844);
            Controls.Add(pnelppalmedio);
            Controls.Add(pnelppaltitulo);
            Controls.Add(pnelppalbotones);
            Name = "Gestion_de_Rubros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion_de_Rubros";
            Load += Gestion_de_Rubros_Load;
            pnelppalmedio.ResumeLayout(false);
            cmbEliminarCategoria.ResumeLayout(false);
            cmbEliminarCategoria.PerformLayout();
            cmbModificar.ResumeLayout(false);
            cmbModificar.PerformLayout();
            cmbBuscarId.ResumeLayout(false);
            cmbBuscarId.PerformLayout();
            cmbBuscarNombre.ResumeLayout(false);
            cmbBuscarNombre.PerformLayout();
            grbGrillaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            CmbIngresoDeDatos.ResumeLayout(false);
            CmbIngresoDeDatos.PerformLayout();
            pnelppaltitulo.ResumeLayout(false);
            pnelppaltitulo.PerformLayout();
            pnelppalbotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnelppalmedio;
        private GroupBox cmbBuscarNombre;
        private Button btnBuscarNombre;
        private Label lblId;
        private TextBox txtBuscarNombre;
        private GroupBox grbGrillaClientes;
        private DataGridView dgvClientes;
        private GroupBox CmbIngresoDeDatos;
        private Label lblEmail;
        private TextBox txtAgregar;
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
        private GroupBox cmbBuscarId;
        private Button btnBuscarId;
        private Label label1;
        private TextBox txtBuscarId;
        private Button btnIngresoDeDatos;
        private GroupBox cmbModificar;
        private Button btnModificar;
        private Label label2;
        private TextBox txtModificarNombre;
        private Label label3;
        private TextBox txtModificarId;
        private GroupBox cmbEliminarCategoria;
        private Label label4;
        private TextBox txtEliminarId;
        private Button btnEliminar;
    }
}