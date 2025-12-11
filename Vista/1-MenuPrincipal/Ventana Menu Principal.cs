using Controladora;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        #region HELPER
        private void Refrescar()
        {
            dgvProductosBajoStock.DataSource = ControladoraStocksPorSucursal.Instancia().ObtenerProductosBajoStockPorSucursal().Select(s => new { Producto = s.Producto.Nombre, Sucursal = s.Sucursal.Nombre, Stock = s.Cantidad }).OrderBy(x => x.Stock).ToList();
            dgvProductosBajoStock.Columns["Stock"].HeaderText = "Stock Restante";
            dgvProductosBajoStock.ClearSelection();
            AplicarColoresProductosBajoStock();

            dgvVentasSemanales.DataSource = ControladoraVentas.Instancia().ObtenerVentasdelaSemana().Select(v => new { Fecha = v.Fecha.ToString("dd/MM/yyyy"), Cliente = v.Cliente.Nombre, MetodoDePago = v.MetodoPago.ToString(), Total = (v.Producto.Precio * v.Cantidad).ToString("$#,0.00"), Descuento = ((int)v.Descuento).ToString() + "%", Resultado = v.Total.ToString("$#,0.00") }).ToList();
            dgvVentasSemanales.Columns["MetodoDePago"].HeaderText = "Método";
            dgvVentasSemanales.ClearSelection();
        }

        private void AplicarColoresProductosBajoStock()
        {
            if (!dgvProductosBajoStock.Columns.Contains("Stock")) 
                return;

            foreach (DataGridViewRow row in dgvProductosBajoStock.Rows)
            {
                if (!int.TryParse(row.Cells["Stock"].Value?.ToString(), out int stock)) 
                    continue;

                row.DefaultCellStyle.ForeColor = Color.Black;
                if (stock <= 10) 
                { row.DefaultCellStyle.BackColor = Color.IndianRed; 
                    row.DefaultCellStyle.ForeColor = Color.White; 
                }
                else if (stock <= 25) 
                    row.DefaultCellStyle.BackColor = Color.Gold;
                else 
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGestionarSucursales_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ventana_Gestion_Sucursales fSucursales = new Ventana_Gestion_Sucursales();
            fSucursales.Show();
        }

        private void GestionDeCategorias_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_de_Rubros fRubros = new Gestion_de_Rubros();
            fRubros.Show();
        }

        private void btnGestionProductos_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ventana_Gestion_Productos fProductos = new Ventana_Gestion_Productos();
            fProductos.Show();
        }

        private void btnGestionClientes_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ventana_Gestion_Clientes fClientes = new Ventana_Gestion_Clientes();
            fClientes.Show();
        }

        private void btnRegistrarIngresos_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ventana_Gestion_Stock fIngresos = new Ventana_Gestion_Stock();
            fIngresos.Show();
        }

        private void btnRegistrarVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana_Gestion_Ventas fVentas = new Ventana_Gestion_Ventas();
            fVentas.Show();
        }

        private void btnReportesYConsultas_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ventana_Reportes_Y_Consultas fReportesYConsultas = new Ventana_Reportes_Y_Consultas();
            fReportesYConsultas.Show();
        }
    }
}
