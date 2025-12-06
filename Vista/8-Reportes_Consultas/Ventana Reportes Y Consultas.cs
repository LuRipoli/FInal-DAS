using Controladora;
using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Ventana_Reportes_Y_Consultas : Form
    {
        private List<Cliente> listaClientes = new List<Cliente>();
        private List<Sucursal> listaSucursales = new List<Sucursal>();

        private readonly ControladoraClientes ctrlClientes;
        private readonly ControladoraSucursales ctrlSucursales;
        private readonly ControladoraVentas ctrlVentas;
        public Ventana_Reportes_Y_Consultas()
        {
            InitializeComponent();

            ctrlClientes = ControladoraClientes.Instancia();
            ctrlSucursales = ControladoraSucursales.Instancia();
            ctrlVentas = ControladoraVentas.Instancia();

            CargarCombos();
            LimpiarFiltros();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void pnelppalmedio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        private void CargarCombos()
        {
            CargarComboClientes();
            CargarComboSucursales();
            CargarComboMetodosPago();
        }

        private void CargarComboClientes()
        {
            listaClientes = ctrlClientes.ObtenerClientes();

            combocliente.Items.Clear();

            foreach (var cli in listaClientes)
            {
                combocliente.Items.Add(cli.Nombre);
            }
        }

        private void CargarComboSucursales()
        {
            listaSucursales = ctrlSucursales.ObtenerSucursales();

            combosucursal.Items.Clear();

            foreach (var suc in listaSucursales)
            {
                combosucursal.Items.Add(suc.Nombre);
            }
        }


        private void CargarComboMetodosPago()
        {
            combometodo.Items.Clear();

            combometodo.Items.Add("Efectivo");
            combometodo.Items.Add("Tarjeta");
            combometodo.Items.Add("Transferencia");
        }

        private void LimpiarFiltros()
        {
            fechadesde.Value = DateTime.Today.AddMonths(-1);
            fechahasta.Value = DateTime.Today;

            combocliente.SelectedIndex = -1;
            combosucursal.SelectedIndex = -1;
            combometodo.SelectedIndex = -1;
        }

        private void btnaplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(combocliente.Text) || !string.IsNullOrEmpty(combosucursal.Text) || !string.IsNullOrEmpty(combometodo.Text))
                {
                    Consulta consulta = new Consulta
                    {
                        Fecha = fechadesde.Value,
                        Fecha= fechahasta.Value,
                        ClienteId = combocliente.Text,
                        SucursalId = combosucursal.Text,
                        MetodoPago = combometodo.Text
                    };
                }
                else
                {
                    MessageBox.Show("Seleccione al menos un filtro para aplicar la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
