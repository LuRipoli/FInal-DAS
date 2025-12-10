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
    public partial class Ventana_Gestion_Stock : Form
    {
        public Ventana_Gestion_Stock()
        {
            InitializeComponent();
        
        }
        #region HELPER
        private void Refrescar()
        {
            var controladora = ControladoraStocksPorSucursal.Instancia();
            var lista = controladora.ObtenerStocks().OrderBy(s => s.Sucursal.Nombre).ThenBy(s => s.Cantidad).Select(s => new { Sucursal = s.Sucursal.Nombre, Producto = s.Producto.Nombre, Stock = s.Cantidad }).ToList();
            dgvStock.DataSource = lista;
            AplicarColoresStock();
            dgvStock.ClearSelection();
        }

        private void CargarCombos()
        {
            var ctrlProductos = ControladoraProductos.Instancia();
            var ctrlSucursales = ControladoraSucursales.Instancia();

            cmbProducto.DataSource = ctrlProductos.ObtenerProductos().ToList();
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";

            cmbSucursal.DataSource = ctrlSucursales.ObtenerSucursales().ToList();
            cmbSucursal.DisplayMember = "Nombre";
            cmbSucursal.ValueMember = "Id";

            foreach (var sucursal in ctrlSucursales.ObtenerSucursales())
            {
                cmbSucursales.Items.Add(sucursal.Id);
            }
        }

        private void LimpiarCampos()
        {
            cmbSucursales.SelectedIndex = -1;
            nudCantidadIngresada.Value = 0;

            if (cmbProducto.Items.Count > 0) cmbProducto.SelectedIndex = -1;
            if (cmbSucursal.Items.Count > 0) cmbSucursal.SelectedIndex = -1;
        }
        private void AplicarColoresStock()
        {
            if (!dgvStock.Columns.Contains("Stock"))
                return;

            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                if (!int.TryParse(row.Cells["Stock"].Value?.ToString(), out int stock))
                    continue;

                row.DefaultCellStyle.ForeColor = Color.Black;

                if (stock <= 10)
                {
                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (stock <= 25)
                    row.DefaultCellStyle.BackColor = Color.Gold;
                else
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
            }

        }
        #endregion

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProducto.SelectedIndex == -1)
                    throw new DatosInvalidosException("Debe seleccionar un producto.");
                if (cmbSucursal.SelectedIndex == -1)
                    throw new DatosInvalidosException("Debe seleccionar una sucursal.");

                int productoId = (int)cmbProducto.SelectedValue;
                int sucursalId = (int)cmbSucursal.SelectedValue;
                int cantidad = (int)nudCantidadIngresada.Value;

                if (cantidad <= 0)
                    throw new DatosInvalidosException("La cantidad debe ser mayor a cero.");

                var controladora = ControladoraStocksPorSucursal.Instancia();
                controladora.ModificarStock(productoId, sucursalId, cantidad, 1);

                MessageBox.Show("Stock agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Refrescar();
                LimpiarCampos();
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (EntidadNoEncontradaException ex)
            {
                MessageBox.Show(ex.Message, "Entidad no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarSucursal_Click(object sender, EventArgs e)
        {
            tlpBuscar.Enabled = true;
            btnBuscar.Enabled = true;
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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbSucursales.SelectedIndex != -1)
                    throw new DatosInvalidosException("Debe ingresar un ID de sucursal.");

                int idSucursal = int.Parse(cmbSucursales.Text.Trim());

                var controladora = ControladoraStocksPorSucursal.Instancia();
                var lista = controladora.ObtenerStocks().Where(s => s.Sucursal.Id == idSucursal).OrderBy(s => s.Cantidad).Select(s => new { Sucursal = s.Sucursal.Nombre, Producto = s.Producto.Nombre, Stock = s.Cantidad }).ToList();
                if (lista.Count == 0)
                    throw new EntidadNoEncontradaException("No hay stocks para esa sucursal.");

                dgvStock.DataSource = lista;
                tlpBuscar.Enabled = false;
                btnBuscar.Enabled = false;
                cmbSucursales.SelectedIndex = -1;
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (EntidadNoEncontradaException ex)
            {
                MessageBox.Show(ex.Message, "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tlpBuscar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void Ventana_Gestion_Stock_Load(object sender, EventArgs e)
        {
            CargarCombos();
            Refrescar();
            LimpiarCampos();
        }
    }
}
