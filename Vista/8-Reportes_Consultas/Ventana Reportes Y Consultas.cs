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
    public enum ModoReporte
    {
        Ninguno,
        Sucursales,
        Productos,
        Ventas,
        Clientes
    }
    public partial class Ventana_Reportes_Y_Consultas : Form
    {

        private ModoReporte modoActual = ModoReporte.Ninguno;

        public Ventana_Reportes_Y_Consultas()
        {
            InitializeComponent();
            LimpiarCampos();
            ResetearColoresBotones();
            MostrarDashboardInicial();
            CargarCampos();

        }
        #region HELPER
        private void MostrarDashboardInicial()
        {
            lblDashBoard.Visible = true;
            dgvReportes.Visible = false;

            Refrescar();
        }

        private void Refrescar()  //En su mayoria este método lo hizo todo ChatGpt, pero quedo muy bien y habia que dejarlo. 
        {

            var ventas = ControladoraVentas.Instancia().ObtenerVentas().OrderByDescending(v => v.Fecha).ToList();

            if (ventas.Count == 0)
            {
                lblDashBoard.Font = new Font("Calibri", 16, FontStyle.Bold);
                lblDashBoard.ForeColor = Color.DarkSlateGray;
                lblDashBoard.TextAlign = ContentAlignment.MiddleCenter;
                lblDashBoard.BackColor = Color.Transparent;
                lblDashBoard.Text =
                    "📭 SIN DATOS DISPONIBLES\n\n" +
                    "Aún no hay ventas registradas en el sistema.\n" +
                    "Cuando ingreses tu primera venta, verás aquí un resumen completo\n" +
                    "con métricas, estadísticas y tendencias.";
                dgvReportes.Visible = false;
                return;
            }

            int totalVentas = ventas.Count;
            decimal ingresosTotales = ventas.Sum(v => v.Total);
            decimal ticketPromedio = ingresosTotales / totalVentas;

            var ultimaVenta = ventas.First();
            var ventaMax = ventas.OrderByDescending(v => v.Total).First();
            var ventaMin = ventas.OrderBy(v => v.Total).First();

            var vendedorTop = ventas.GroupBy(v => v.NombreVendedor).Select(g => new { Nombre = g.Key, Cant = g.Count() }).OrderByDescending(x => x.Cant).First();
            var metodoTop = ventas.GroupBy(v => v.MetodoPago).Select(g => new { Metodo = g.Key, Cant = g.Count() }).OrderByDescending(x => x.Cant).First();
            int porcentajeMetodoTop = (int)((double)metodoTop.Cant / totalVentas * 100);

            // ===== BARRITAS ASCII =====
            string Barras(int porcentaje) => new string('█', porcentaje / 5).PadRight(20, ' ');

            // MÉTODOS DE PAGO
            var gruposPago = ventas.GroupBy(v => v.MetodoPago).Select(g => new { Metodo = g.Key, Porcentaje = (int)((double)g.Count() / totalVentas * 100) }).OrderByDescending(x => x.Porcentaje).ToList();
            string asciiPago = "📈 DISTRIBUCIÓN MÉTODO DE PAGO\n\n" + string.Concat(gruposPago.Select(g => $"{g.Metodo.ToString().PadRight(14)} {Barras(g.Porcentaje)} {g.Porcentaje}%\n"));

            // TOP PRODUCTOS
            var topProductos = ventas.GroupBy(v => v.Producto.Nombre).Select(g => new { Nombre = g.Key, Unidades = g.Count() }).OrderByDescending(x => x.Unidades).Take(5).ToList();
            string topProdText = "\n🏆 TOP 5 PRODUCTOS MÁS VENDIDOS\n\n" + string.Concat(topProductos.Select((p, i) => $"{i + 1}. {p.Nombre} — {p.Unidades} unidades\n"));

            // TOP CATEGORÍAS
            var topCategorias = ventas.GroupBy(v => v.Producto.Categoria.Nombre).Select(g => new { Categoria = g.Key, Porcentaje = (int)((double)g.Count() / totalVentas * 100) }).OrderByDescending(x => x.Porcentaje).Take(5).ToList();
            string topCatText = "\n🏪 TOP CATEGORÍAS\n\n" + string.Concat(topCategorias.Select(c => $"{c.Categoria} — {c.Porcentaje}%\n"));

            // TOP VENDEDORES
            var topVendedores = ventas.GroupBy(v => v.NombreVendedor).Select(g => new { Nombre = g.Key, Cant = g.Count() }).OrderByDescending(x => x.Cant).Take(5).ToList();
            string topVendText = "\n🧍 TOP 5 VENDEDORES\n\n" + string.Concat(topVendedores.Select((v, i) => $"{i + 1}. {v.Nombre} — {v.Cant} ventas\n"));

            // ÚLTIMOS 7 DÍAS
            var ultimos7 = ventas.GroupBy(v => v.Fecha.Date).Select(g => new { Fecha = g.Key, Cant = g.Count() }).OrderByDescending(g => g.Fecha).Take(7).OrderBy(x => x.Fecha).ToList();
            string ascii7dias = "\n📆 ÚLTIMOS 7 DÍAS\n\n" + string.Concat(ultimos7.Select(d => $"{d.Fecha:dd/MM} {Barras(d.Cant * 5)} {d.Cant} ventas\n"));

            // POR HORA
            Func<int, string> HoraLabel = h => h switch { 0 => "09–12 hs", 1 => "12–15 hs", 2 => "15–18 hs", 3 => "18–21 hs", _ => "Otros" };
            var ventasPorHora = ventas.GroupBy(v => v.Fecha.Hour < 12 ? 0 : v.Fecha.Hour < 15 ? 1 : v.Fecha.Hour < 18 ? 2 : 3).Select(g => new { Franja = HoraLabel(g.Key), Cant = g.Count() }).OrderBy(x => x.Franja).ToList();
            string asciiHoras = "\n⏱ VENTAS POR FRANJA HORARIA\n\n" + string.Concat(ventasPorHora.Select(h => $"{h.Franja.PadRight(10)} {Barras(h.Cant * 5)} {h.Cant} ventas\n"));

            // ÚLTIMAS 5 VENTAS
            var ultimas5 = ventas.Take(5).ToList();
            string ultimasText = "\n🕒 ÚLTIMAS 5 VENTAS\n\n" + string.Concat(ultimas5.Select(v => $"{v.Fecha:dd/MM HH:mm} — {v.Producto.Nombre} — ${v.Total} — {v.NombreVendedor} — {v.MetodoPago}\n"));

            // SALIDA FINAL
            lblDashBoard.Text =
                $"📊 RESUMEN GENERAL\n\n" +
                $"Ventas totales: {totalVentas}\n" +
                $"Ingresos acumulados: ${ingresosTotales:N0}\n" +
                $"Ticket promedio: ${ticketPromedio:N0}\n" +
                $"Venta más alta: ${ventaMax.Total} ({ventaMax.Producto.Nombre} — {ventaMax.NombreVendedor})\n" +
                $"Venta más baja: ${ventaMin.Total} ({ventaMin.Producto.Nombre} — {ventaMin.NombreVendedor})\n" +
                $"Última venta: {ultimaVenta.Fecha:dd/MM/yyyy HH:mm}\n" +
                $"Vendedor top: {vendedorTop.Nombre} ({vendedorTop.Cant} ventas)\n" +
                $"Método de pago más usado: {metodoTop.Metodo} ({porcentajeMetodoTop}%)\n\n" +
                asciiPago + "\n" +
                topProdText + "\n" +
                topCatText + "\n" +
                topVendText + "\n" +
                ascii7dias + "\n" +
                asciiHoras + "\n" +
                ultimasText;

            dgvReportes.DataSource = ultimas5;
            dgvReportes.Visible = false;
        }
        private void ResetearColoresBotones()
        {
            btnReporteSucursal.BackColor = Color.PaleTurquoise;
            btnReporteCliente.BackColor = Color.PaleTurquoise;
            btnReporteVenta.BackColor = Color.PaleTurquoise;
            btnReporteProducto.BackColor = Color.PaleTurquoise;
        }
        private void ActivarBoton(Button btn)
        {
            ResetearColoresBotones();
            btn.BackColor = Color.FromArgb(102, 205, 205);
        }
        private void LimpiarCampos()
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;

            cmbSucursales.SelectedIndex = -1;
            cmbClientes.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
            cmbVendedor.SelectedIndex = -1;

            rdbEfectivo.Checked = false;
            rdbTransferencia.Checked = false;
            rdbTarjeta.Checked = false;
        }

        private void CargarCampos()
        {
            cmbSucursales.DataSource = null;
            cmbSucursales.Items.Clear();
            var sucursales = ControladoraSucursales.Instancia().ObtenerSucursales();
            foreach (var s in sucursales)
                cmbSucursales.Items.Add(s.Nombre);

            cmbClientes.DataSource = null;
            cmbClientes.Items.Clear();
            var clientes = ControladoraClientes.Instancia().ObtenerClientes();
            foreach (var c in clientes)
                cmbClientes.Items.Add(c.Nombre);

            cmbProducto.DataSource = null;
            cmbProducto.Items.Clear();
            var productos = ControladoraProductos.Instancia().ObtenerProductos();
            foreach (var p in productos)
                cmbProducto.Items.Add(p.Nombre);

            cmbVendedor.DataSource = null;
            cmbVendedor.Items.Clear();
            var controladoraVentas = ControladoraVentas.Instancia();
            var vendedores = controladoraVentas.ObtenerVentas().Select(v => v.NombreVendedor).Distinct().OrderBy(x => x).ToList();
            foreach (var v in vendedores)
                cmbVendedor.Items.Add(v);
        }
        private void ActivarFiltros(bool fecha, bool sucursal, bool cliente, bool producto, bool metodoPago, bool vendedor)
        {
            dtpFechaDesde.Enabled = fecha;
            dtpFechaHasta.Enabled = fecha;

            cmbSucursales.Enabled = sucursal;
            cmbClientes.Enabled = cliente;
            cmbProducto.Enabled = producto;
            cmbVendedor.Enabled = vendedor;

            rdbEfectivo.Enabled = metodoPago;
            rdbTransferencia.Enabled = metodoPago;
            rdbTarjeta.Enabled = metodoPago;
        }
        private void FiltrarSucursales()
        {
            var lista = ControladoraSucursales.Instancia().ObtenerSucursales();

            if (cmbSucursales.SelectedIndex != -1)
            {
                string nombre = cmbSucursales.Text.Trim();
                lista = lista.Where(s => s.Nombre.Contains(nombre)).ToList();
            }

            dgvReportes.DataSource = lista;
        }
        private void FiltrarClientes()
        {
            var lista = ControladoraClientes.Instancia().ObtenerClientes();

            if (cmbClientes.SelectedIndex != -1)
            {
                string nombre = cmbClientes.Text.Trim();
                lista = lista.Where(c => c.Nombre.Contains(nombre)).ToList();
            }

            dgvReportes.DataSource = lista;
        }
        private void FiltrarProductos()
        {
            var lista = ControladoraProductos.Instancia().ObtenerProductos();

            if (cmbProducto.SelectedIndex != -1)
            {
                string nombre = cmbProducto.Text.Trim();
                lista = lista.Where(p => p.Nombre.Contains(nombre)).ToList();
            }

            dgvReportes.DataSource = lista;
        }
        private void FiltrarVentas()
        {
            var lista = ControladoraVentas.Instancia().ObtenerVentas();

            DateTime desde = dtpFechaDesde.Value.Date;
            DateTime hasta = dtpFechaHasta.Value.Date.AddDays(1).AddSeconds(-1);
            lista = lista.Where(v => v.Fecha >= desde && v.Fecha <= hasta).ToList();

            if (cmbSucursales.SelectedIndex != -1)
                lista = lista.Where(v => v.Sucursal.Nombre == cmbSucursales.Text).ToList();

            if (cmbClientes.SelectedIndex != -1)
                lista = lista.Where(v => v.Cliente.Nombre == cmbClientes.Text).ToList();

            if (cmbProducto.SelectedIndex != -1)
                lista = lista.Where(v => v.Producto.Nombre == cmbProducto.Text).ToList();

            if (cmbVendedor.SelectedIndex != -1)
                lista = lista.Where(v => v.NombreVendedor == cmbVendedor.Text).ToList();
            if (rdbEfectivo.Checked)
                lista = lista.Where(v => v.MetodoPago == MetodoPago.Efectivo).ToList();
            else if (rdbTransferencia.Checked)
                lista = lista.Where(v => v.MetodoPago == MetodoPago.Transferencia).ToList();
            else if (rdbTarjeta.Checked)
                lista = lista.Where(v => v.MetodoPago == MetodoPago.Tarjeta).ToList();

            dgvReportes.DataSource = lista;
        }
        #endregion 
        private void pnelppalmedio_Paint(object sender, PaintEventArgs e)
        {
            //EXPLOTA EL PROGRAMA SI LO BORRO, NO TOCAR
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            modoActual = ModoReporte.Ninguno;
            ResetearColoresBotones();
            MostrarDashboardInicial();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                switch (modoActual)
                {
                    case ModoReporte.Sucursales:
                        FiltrarSucursales();
                        break;

                    case ModoReporte.Clientes:
                        FiltrarClientes();
                        break;

                    case ModoReporte.Productos:
                        FiltrarProductos();
                        break;

                    case ModoReporte.Ventas:
                        FiltrarVentas();
                        break;

                    default:
                        MessageBox.Show("Seleccione un tipo de reporte antes de aplicar filtros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar filtros: " + ex.Message);
            }
        }

        private void btnReporteSucursal_Click(object sender, EventArgs e)
        {
            modoActual = ModoReporte.Sucursales;
            ActivarBoton(btnReporteSucursal);

            lblDashBoard.Visible = false;
            dgvReportes.Visible = true;

            ActivarFiltros(false, true, false, false, false, false);

            var lista = ControladoraSucursales.Instancia().ObtenerSucursales().Select(s => new { Sucursal = s.Nombre, Dirección = s.Direccion, ProductosDistintos = s.StocksPorSucursal.Count, StockTotal = s.StocksPorSucursal.Sum(x => x.Cantidad), StockPromedio = s.StocksPorSucursal.Count == 0 ? 0 : (int)s.StocksPorSucursal.Average(x => x.Cantidad) }).OrderBy(x => x.Sucursal).ToList();
            dgvReportes.DataSource = lista;
        }

        private void btnReporteProducto_Click(object sender, EventArgs e)
        {
            modoActual = ModoReporte.Productos;
            ActivarBoton(btnReporteProducto);

            lblDashBoard.Visible = false;
            dgvReportes.Visible = true;

            ActivarFiltros(false, false, false, true, false, false);

            var lista = ControladoraProductos.Instancia().ObtenerProductos().Select(p => new { Producto = p.Nombre, Categoría = p.Categoria.Nombre, Precio = $"${p.Precio:N0}", Vendido = ControladoraVentas.Instancia().ObtenerVentas().Where(v => v.Producto.Id == p.Id).Sum(v => v.Cantidad), StockTotal = p.StocksPorSucursal.Sum(s => s.Cantidad), SucursalesDisponibles = p.StocksPorSucursal.Count }).OrderBy(p => p.Categoría).ThenBy(p => p.Producto).ToList();
            dgvReportes.DataSource = lista;
        }

        private void btnReporteVenta_Click(object sender, EventArgs e)
        {
            modoActual = ModoReporte.Ventas;
            ActivarBoton(btnReporteVenta);

            lblDashBoard.Visible = false;
            dgvReportes.Visible = true;

            ActivarFiltros(true, true, true, true, true, true);

            var lista = ControladoraVentas.Instancia().ObtenerVentas().OrderByDescending(v => v.Fecha).Select(v => new { Fecha = v.Fecha.ToString("dd/MM/yyyy HH:mm"), Producto = v.Producto.Nombre, Cliente = v.Cliente.Nombre, Vendedor = v.NombreVendedor, Método = v.MetodoPago.ToString(), Cantidad = v.Cantidad, Total = $"${v.Total:N0}", Descuento = v.Descuento == 0 ? "-" : $"{v.Descuento}%" }).ToList();
            dgvReportes.DataSource = lista;
        }

        private void btnReporteCliente_Click(object sender, EventArgs e)
        {
            modoActual = ModoReporte.Clientes;
            ActivarBoton(btnReporteCliente);

            lblDashBoard.Visible = false;
            dgvReportes.Visible = true;

            ActivarFiltros(false, false, true, false, false, false);

            var lista = ControladoraClientes.Instancia().ObtenerClientes().Select(c => new { Cliente = c.Nombre, Email = c.Email, Tipo = c.TipoCliente.ToString(), Compras = ControladoraVentas.Instancia().ObtenerVentas().Count(v => v.Cliente.Id == c.Id), TotalGastado = $"${ControladoraVentas.Instancia().ObtenerVentas().Where(v => v.Cliente.Id == c.Id).Sum(v => v.Total):N0}" }).OrderByDescending(c => c.Compras).ToList();
            dgvReportes.DataSource = lista;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReporteGeneral_Click(object sender, EventArgs e)
        {
            modoActual = ModoReporte.Ninguno;
            ActivarBoton(btnReporteGeneral);

            dgvReportes.Visible = false;
            lblDashBoard.Visible = true;

            ActivarFiltros(false, false, false, false, false, false);

            LimpiarCampos();

            Refrescar();
        }
    }
}
