using Controladora;
using Entidades;
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
    public partial class Ventana_Gestion_Ventas : Form
    {
        ControladoraVentas controladora = ControladoraVentas.Instancia();
        public Ventana_Gestion_Ventas()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClientes.SelectedIndex == -1 || cmbProducto.SelectedIndex == -1 || cmbSucursales.SelectedIndex == -1)
                    throw new DatosInvalidosException("Debe completar todos los campos.");
                if (string.IsNullOrWhiteSpace(txtNombreVendedor.Text))
                    throw new DatosInvalidosException("Debe ingresar el nombre del vendedor.");
                if (nudCantidad.Value <= 0)
                    throw new DatosInvalidosException("La cantidad vendida debe ser mayor a 0.");

                MetodoPago metodo = rdbEfectivo.Checked ? MetodoPago.Efectivo : rdbTransferencia.Checked ? MetodoPago.Transferencia : rdbTarjeta.Checked ? MetodoPago.Tarjeta : throw new DatosInvalidosException("Debe seleccionar un método de pago.");

                Cliente cliente = (Cliente)cmbClientes.SelectedItem;
                Producto producto = (Producto)cmbProducto.SelectedItem;
                Sucursal sucursal = (Sucursal)cmbSucursales.SelectedItem;

                decimal descuento = nudDescuento.Value;
                int cantidad = (int)nudCantidad.Value;
                string nombreVendedor = txtNombreVendedor.Text.Trim();
                DateTime fecha = dtpFecha.Value;

                controladora.AgregarVenta(fecha, cliente.Id, metodo, descuento, producto, sucursal, cantidad, nombreVendedor);

                MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Refrescar();
                LimpiarCampos();
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PrecargarCombos()
        {
            var clientes = ControladoraClientes.Instancia().ObtenerClientes().ToList();
            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "Nombre";
            cmbClientes.ValueMember = "Id";
            cmbClientes.SelectedIndex = -1;

            var productos = ControladoraProductos.Instancia().ObtenerProductos().ToList();
            cmbProducto.DataSource = productos;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";
            cmbProducto.SelectedIndex = -1;

            var sucursales = ControladoraSucursales.Instancia().ObtenerSucursales().ToList();
            cmbSucursales.DataSource = sucursales;
            cmbSucursales.DisplayMember = "Nombre";
            cmbSucursales.ValueMember = "Id";
            cmbSucursales.SelectedIndex = -1;
        }
        private void Refrescar()
        {
            var ventas = controladora.ObtenerVentas().Select(v => new { v.Id, Fecha = v.Fecha.ToString("dd/MM/yyyy HH:mm"), Cliente = v.Cliente.Nombre, Producto = v.Producto.Nombre, Sucursal = v.Sucursal.Nombre, Metodo = v.MetodoPago.ToString(), v.Descuento, v.Cantidad, v.Total, Vendedor = v.NombreVendedor }).OrderBy(x => x.Fecha).ToList();

            dgvVentas.DataSource = null;
            dgvVentas.DataSource = ventas;
            dgvVentas.ClearSelection();
        }
        private void LimpiarCampos()
        {
            cmbClientes.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
            cmbSucursales.SelectedIndex = -1;
            txtTotal.Text = "";
            nudDescuento.Value = 0;
            nudCantidad.Value = 0;
            txtNombreVendedor.Text = string.Empty;
            rdbEfectivo.Checked = false;
            rdbTransferencia.Checked = false;
            rdbTarjeta.Checked = false;
            dtpFecha.Value = DateTime.Now;
            dtpFechaBuscada.Value = DateTime.Now;
            tlpBuscar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            tlpBuscar.Enabled = true;
            btnBuscar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaBuscada = dtpFechaBuscada.Value.Date;
                var ventas = controladora.ObtenerVentas().Where(v => v.Fecha.Date == fechaBuscada).ToList();

                if (ventas.Count == 0)
                    MessageBox.Show("No se encontraron ventas para la fecha seleccionada.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvVentas.DataSource = null;
                dgvVentas.DataSource = ventas;
                tlpBuscar.Enabled = false;
                btnBuscar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar las ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void CalcularTotalVenta()
        {
            if (cmbProducto.SelectedIndex != -1 && nudCantidad.Value > 0)
            {
                var producto = (Producto)cmbProducto.SelectedItem;

                decimal precioUnitario = producto.Precio;
                decimal subtotal = precioUnitario * nudCantidad.Value;
                decimal descuento = (subtotal * nudDescuento.Value) / 100;
                decimal total = subtotal - descuento;

                txtTotal.Text = total.ToString("0.00");
            }
        }
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotalVenta();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotalVenta();
        }

        private void nudDescuento_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotalVenta();
        }

        private void Ventana_Gestion_Ventas_Load(object sender, EventArgs e)
        {
            Refrescar();
            PrecargarCombos();
            LimpiarCampos();
        }
    }
}
