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
            Ventana_Gestion_Productos fProductos = new Ventana_Gestion_Productos();
            fProductos.Show();
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            Ventana_Gestion_Clientes fClientes = new Ventana_Gestion_Clientes();
            fClientes.Show();

        }

        private void btnGestionVentas_Click(object sender, EventArgs e)
        {
            Ventana_Gestion_Ventas fVentas = new Ventana_Gestion_Ventas();
            fVentas.Show();
        }

        private void btnReportesYConsultas_Click(object sender, EventArgs e)
        {
            Ventana_Reportes_Y_Consultas fReportesYConsultas = new Ventana_Reportes_Y_Consultas();
            fReportesYConsultas.Show();
        }

        private void GestionDeCategorias_Click(object sender, EventArgs e)
        {
            Gestion_de_Rubros fRubros = new Gestion_de_Rubros();
            fRubros.Show();
        }
        #region HELPER
        private void Refrescar()
        {
            var controladoraProductos = ControladoraProductos.Instancia();
            var productosBajoStock = controladoraProductos.ObtenerProductosBajoStock();
            dgvProductosBajoStock.DataSource = productosBajoStock;

            var controladoraVentas = ControladoraVentas.Instancia();
            var ventasSemanales = controladoraVentas.ObtenerVentasdelaSemana();
            dgvVentasSemanales.DataSource = ventasSemanales;
        }
        #endregion
    }
}
