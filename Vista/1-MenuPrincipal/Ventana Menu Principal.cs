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

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana_Gestion_Productos fProductos = new Ventana_Gestion_Productos();
            fProductos.Show();
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana_Gestion_Clientes fClientes = new Ventana_Gestion_Clientes();
            fClientes.Show();

        }

        private void btnGestionVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana_Gestion_Ventas fVentas = new Ventana_Gestion_Ventas();
            fVentas.Show();
        }

        private void btnReportesYConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana_Reportes_Y_Consultas fReportesYConsultas = new Ventana_Reportes_Y_Consultas();
            fReportesYConsultas.Show();
        }

        private void GestionDeCategorias_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_de_Rubros fRubros = new Gestion_de_Rubros();
            fRubros.Show();
        }
        #region HELPER
        private void Refrescar()
        {
            var controladoraStockPorSucursal = ControladoraStocksPorSucursal.Instancia();
            var productosBajoStock = controladoraStockPorSucursal.ObtenerProductosBajoStockPorSucursal().Select(s => new {Producto = s.Producto.Nombre,Sucursal = s.Sucursal.Nombre,StockRestante = s.Cantidad}).ToList();
            dgvProductosBajoStock.DataSource = productosBajoStock;
            dgvProductosBajoStock.Columns["StockRestante"].HeaderText = "Stock Restante";
            AplicarColoresProductosBajoStock();
            var controladoraVentas = ControladoraVentas.Instancia();
            var ventasSemanales = controladoraVentas.ObtenerVentasdelaSemana().Select(v => new { Fecha = v.Fecha.ToString("dd/MM/yyyy"), Cliente = v.Cliente.Nombre, MetodoDePago = v.MetodoPago.ToString(), Total = v.Total, Descuento = v.Descuento }).ToList();
            dgvVentasSemanales.DataSource = ventasSemanales;     
            dgvVentasSemanales.Columns["MetodoDePago"].HeaderText = "Método de Pago";
        }

        private void AplicarColoresProductosBajoStock()
        {
            foreach (DataGridViewRow row in dgvProductosBajoStock.Rows)
            {
                if (row.Cells["Stock"].Value != null && int.TryParse(row.Cells["Stock"].Value.ToString(), out int stock))
                {
                    if (stock <= 10)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                    }
                    else if (stock > 10 && stock <= 15)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Orange;
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    }
                    else if (stock <= 25)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGestionarSucursales_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana_Gestion_Sucursales fSucursales = new Ventana_Gestion_Sucursales();
            fSucursales.Show();
        }

        private void btnRegistrarIngresos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana_Gestion_Stock fIngresos = new Ventana_Gestion_Stock();
            fIngresos.Show();
        }
    }
}
