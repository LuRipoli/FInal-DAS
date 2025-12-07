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
            grbIngresoDatos.Enabled = false;
            PrecargaCmbs();
        }

        private void pnelppalmedio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodoPago mp;
            if (rbtEfectivo.Checked)
                mp = MetodoPago.Efectivo;
            else if (rbtTarjeta.Checked)
                mp = MetodoPago.Tarjeta;
            else if (rbtTransferencia.Checked)
                mp = MetodoPago.Transferencia;
            else
            {
                MessageBox.Show("Método de pago no seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cmbClientes.Text, out int clienteId))
            {
                MessageBox.Show("Cliente inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el producto buscándolo en la colección que sí devuelve objetos Producto
            var productos = ControladoraProductos.Instancia().ObtenerProducto();
            var productoSeleccionado = productos.FirstOrDefault(p => string.Equals(p.Nombre, Convert.ToString(cmbProducto.Text), StringComparison.CurrentCultureIgnoreCase));
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtDescuento.Text, out decimal descuento))
            {
                descuento = 0m; // o mostrar error según la lógica deseada
            }

            if (!decimal.TryParse(txtTotal.Text, out decimal total))
            {
                MessageBox.Show("Total inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            controladora.AgregarVenta(dtpFecha.Value, clienteId, mp, descuento, total, productoSeleccionado);
        }

        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            grbIngresoDatos.Enabled = true;
        }

        public void PrecargaCmbs()
        {
            var clientes = ControladoraClientes.Instancia().ObtenerClientes();
            foreach (var cliente in clientes)
            {
                cmbClientes.Items.Add(cliente.Id);
            }

            var productos = ControladoraProductos.Instancia().ObtenerProducto();
            foreach (var producto in productos)
            {
                cmbProducto.Items.Add(producto.Nombre);
            }

            var sucursal = ControladoraSucursales.Instancia().ObtenerSucursales();
            foreach (var suc in sucursal)
            {
                cmbSucursales.Items.Add(suc.Nombre);
            }
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

        private void pnelppalbotones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
