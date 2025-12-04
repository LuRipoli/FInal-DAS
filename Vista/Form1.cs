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

        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            Ventana_Gestion_Productos fProductos = new Ventana_Gestion_Productos();
            fProductos.Show();

            this.Hide();
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            Ventana_Gestion_Clientes fClientes = new Ventana_Gestion_Clientes();
            fClientes.Show();

            this.Hide();
        }

        private void btnGestionVentas_Click(object sender, EventArgs e)
        {
            Ventana_Gestion_Ventas fVentas = new Ventana_Gestion_Ventas();
            fVentas.Show();

            this.Hide();
        }

        private void btnReportesYConsultas_Click(object sender, EventArgs e)
        {
            Ventana_Reportes_Y_Consultas fReportesYConsultas = new Ventana_Reportes_Y_Consultas();
            fReportesYConsultas.Show();
            this.Hide();
        }

        private void GestionDeCategorias_Click(object sender, EventArgs e)
        {
            Gestion_de_Rubros fRubros = new Gestion_de_Rubros();
            fRubros.Show();
            this.Hide();
        }
    }
}
