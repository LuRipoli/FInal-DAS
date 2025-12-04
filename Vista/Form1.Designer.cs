namespace Vista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGestionProductos = new Button();
            btnGestionClientes = new Button();
            btnGestionVentas = new Button();
            btnReportesYConsultas = new Button();
            GestionDeCategorias = new Button();
            SuspendLayout();
            // 
            // btnGestionProductos
            // 
            btnGestionProductos.Location = new Point(38, 56);
            btnGestionProductos.Name = "btnGestionProductos";
            btnGestionProductos.Size = new Size(185, 29);
            btnGestionProductos.TabIndex = 0;
            btnGestionProductos.Text = "Gestion de Productos";
            btnGestionProductos.UseVisualStyleBackColor = true;
            btnGestionProductos.Click += btnGestionProductos_Click;
            // 
            // btnGestionClientes
            // 
            btnGestionClientes.Location = new Point(38, 118);
            btnGestionClientes.Name = "btnGestionClientes";
            btnGestionClientes.Size = new Size(185, 29);
            btnGestionClientes.TabIndex = 1;
            btnGestionClientes.Text = "Gestion de Clientes";
            btnGestionClientes.UseVisualStyleBackColor = true;
            btnGestionClientes.Click += btnGestionClientes_Click;
            // 
            // btnGestionVentas
            // 
            btnGestionVentas.Location = new Point(38, 182);
            btnGestionVentas.Name = "btnGestionVentas";
            btnGestionVentas.Size = new Size(185, 29);
            btnGestionVentas.TabIndex = 2;
            btnGestionVentas.Text = "Gestion de Ventas";
            btnGestionVentas.UseVisualStyleBackColor = true;
            btnGestionVentas.Click += btnGestionVentas_Click;
            // 
            // btnReportesYConsultas
            // 
            btnReportesYConsultas.Location = new Point(38, 248);
            btnReportesYConsultas.Name = "btnReportesYConsultas";
            btnReportesYConsultas.Size = new Size(185, 29);
            btnReportesYConsultas.TabIndex = 3;
            btnReportesYConsultas.Text = "Reportes y Clientes";
            btnReportesYConsultas.UseVisualStyleBackColor = true;
            btnReportesYConsultas.Click += btnReportesYConsultas_Click;
            // 
            // GestionDeCategorias
            // 
            GestionDeCategorias.Location = new Point(38, 310);
            GestionDeCategorias.Name = "GestionDeCategorias";
            GestionDeCategorias.Size = new Size(185, 29);
            GestionDeCategorias.TabIndex = 4;
            GestionDeCategorias.Text = "Gestion de Categorias";
            GestionDeCategorias.UseVisualStyleBackColor = true;
            GestionDeCategorias.Click += GestionDeCategorias_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 363);
            Controls.Add(GestionDeCategorias);
            Controls.Add(btnReportesYConsultas);
            Controls.Add(btnGestionVentas);
            Controls.Add(btnGestionClientes);
            Controls.Add(btnGestionProductos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionProductos;
        private Button btnGestionClientes;
        private Button btnGestionVentas;
        private Button btnReportesYConsultas;
        private Button GestionDeCategorias;
    }
}
