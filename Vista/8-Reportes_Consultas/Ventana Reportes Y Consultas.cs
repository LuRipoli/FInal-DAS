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
        Clientes,
        General
    }
    public partial class Ventana_Reportes_Y_Consultas : Form
    {

        private ModoReporte modoActual = ModoReporte.Ninguno;

        public Ventana_Reportes_Y_Consultas()
        {
            InitializeComponent();
            ResetearColoresBotones();
            MostrarDashboardInicial();
            CargarCampos();

        }
        #region HELPER
        private void MostrarDashboard(bool mostrar)
        {
            tlpZona1.Visible = mostrar;
            tlpZona2.Visible = mostrar;
            tlpZona3.Visible = mostrar;

            dgvReportes.Visible = !mostrar;

            if (!mostrar)
                dgvReportes.BringToFront();   
            else
            {
                tlpZona1.BringToFront();
                tlpZona2.BringToFront();
                tlpZona3.BringToFront();
            }
        }
        private void MostrarDashboardInicial()
        {
            MostrarDashboard(true);   
            Refrescar();             
        }
        private void Refrescar()  //En su mayoria este método lo hizo todo ChatGpt, pero quedo muy bien y habia que dejarlo. 
        {
            var ventas = ControladoraVentas.Instancia().ObtenerVentas().OrderByDescending(v => v.Fecha).ToList();

            // -------------------------------------------------------------------
            // CASO SIN VENTAS
            // -------------------------------------------------------------------
            if (ventas.Count == 0)
            {
                // CARDS
                lblCard1Valor.Text = "0";
                lblCard2Valor.Text = "$0";
                lblCard3Valor.Text = "$0";

                lblCard1Sub.Text = "📄 Acumuladas";
                lblCard2Sub.Text = "⏱ Histórico";
                lblCard3Sub.Text = "📊 Por venta";

                // RESUMEN DE TABLA
                lblVentasTotalesValor.Text = "0";
                lblIngresosValor.Text = "$0";
                lblTicketValor.Text = "$0";
                lblVentaMasAltaValor.Text = "-";
                lblVentaMasBajaValor.Text = "-";
                lblMejorVendedorValor.Text = "-";

                // MÉTODOS DE PAGO
                pbEfectivo.Value = pbTransferencia.Value = pbTarjeta.Value = 0;
                lblPorcentajeEfectivo.Text = "0%";
                lblPorcentajeTransferencia.Text = "0%";
                lblPorcentajeTarjeta.Text = "0%";

                // TOP 5
                lblTop5Contenido.Text = "No hay productos vendidos todavía.";

                return;
            }

            // -------------------------------------------------------------------
            // CALCULOS BASE
            // -------------------------------------------------------------------
            int totalVentas = ventas.Count;
            decimal ingresosTotales = ventas.Sum(v => v.Total);
            decimal ticketPromedio = ingresosTotales / totalVentas;

            var ventaMax = ventas.OrderByDescending(v => v.Total).First();
            var ventaMin = ventas.OrderBy(v => v.Total).First();

            var vendedorTop = ventas
                .GroupBy(v => v.NombreVendedor)
                .Select(g => new { Nombre = g.Key, Cant = g.Count() })
                .OrderByDescending(x => x.Cant)
                .First();

            // -------------------------------------------------------------------
            // ZONA 1 – CARDS SUPERIORES
            // -------------------------------------------------------------------
            lblCard1Titulo.Text = "Ventas Totales";
            lblCard1Valor.Text = totalVentas.ToString();
            lblCard1Sub.Text = "📄 Acumuladas";

            lblCard2Titulo.Text = "Ingresos Acumulados";
            lblCard2Valor.Text = $"${ingresosTotales:N0}";
            lblCard2Sub.Text = "⏱ Histórico";

            lblCard3Titulo.Text = "Ticket Promedio";
            lblCard3Valor.Text = $"${ticketPromedio:N0}";
            lblCard3Sub.Text = "📊 Por venta";

            // -------------------------------------------------------------------
            // ZONA 2 – TABLA RESUMEN COMPLETO
            // -------------------------------------------------------------------
            lblVentasTotalesValor.Text = totalVentas.ToString();
            lblIngresosValor.Text = $"${ingresosTotales:N0}";
            lblTicketValor.Text = $"${ticketPromedio:N0}";
            lblVentaMasAltaValor.Text = $"${ventaMax.Total:N0} — {ventaMax.Producto.Nombre}";
            lblVentaMasBajaValor.Text = $"${ventaMin.Total:N0} — {ventaMin.Producto.Nombre}";
            lblMejorVendedorValor.Text = $"{vendedorTop.Nombre} ({vendedorTop.Cant} ventas)";

            // -------------------------------------------------------------------
            // ZONA 3 – MÉTODOS DE PAGO
            // -------------------------------------------------------------------
            int cantEfectivo = ventas.Count(v => v.MetodoPago == MetodoPago.Efectivo);
            int cantTransfer = ventas.Count(v => v.MetodoPago == MetodoPago.Transferencia);
            int cantTarjeta = ventas.Count(v => v.MetodoPago == MetodoPago.Tarjeta);

            int porcEfectivo = (int)(cantEfectivo * 100.0 / totalVentas);
            int porcTransfer = (int)(cantTransfer * 100.0 / totalVentas);
            int porcTarjeta = (int)(cantTarjeta * 100.0 / totalVentas);

            pbEfectivo.Maximum = pbTransferencia.Maximum = pbTarjeta.Maximum = 100;

            pbEfectivo.Value = porcEfectivo;
            pbTransferencia.Value = porcTransfer;
            pbTarjeta.Value = porcTarjeta;

            lblPorcentajeEfectivo.Text = $"{porcEfectivo}%";
            lblPorcentajeTransferencia.Text = $"{porcTransfer}%";
            lblPorcentajeTarjeta.Text = $"{porcTarjeta}%";

            // -------------------------------------------------------------------
            // ZONA 4 – TOP 5 PRODUCTOS MÁS VENDIDOS
            // -------------------------------------------------------------------
            var top5 = ventas
                .GroupBy(v => v.Producto.Nombre)
                .Select(g => new { Nombre = g.Key, Cant = g.Count() })
                .OrderByDescending(x => x.Cant)
                .Take(5)
                .ToList();

            lblTop5Contenido.Text = string.Join("\n",
                top5.Select((p, i) => $"{i + 1}. {p.Nombre} — {p.Cant} unidad(es)")
            );
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
            btnLimpiarCampos.Enabled = true;
        }
        private void LimpiarCampos()
        {
            dtpFechaDesde.Value = new DateTime(2000, 1, 1);
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
        private void ConfigurarGrid(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 240, 245);
            dgv.EnableHeadersVisualStyles = false;

            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.ClearSelection();
        }
        private void FiltrarSucursales()
        {
            var ventas = ControladoraVentas.Instancia().ObtenerVentas().ToList();
            var sucursales = ControladoraSucursales.Instancia().ObtenerSucursales();

            if (cmbSucursales.SelectedIndex != -1)
                sucursales = sucursales.Where(s => s.Nombre.Contains(cmbSucursales.Text.Trim())).ToList();

            var lista = sucursales.Select(s => new { Sucursal = s.Nombre, Dirección = s.Direccion, StockTotal = s.StocksPorSucursal.Sum(x => x.Cantidad), ProductosSinStock = s.StocksPorSucursal.Count(x => x.Cantidad == 0), TotalVentas = ventas.Count(v => v.SucursalId == s.Id), TotalProductosVendidos = ventas.Where(v => v.SucursalId == s.Id).Sum(v => v.Cantidad), TotalRecaudado = ventas.Where(v => v.SucursalId == s.Id).Sum(v => v.Total) }).OrderByDescending(x => x.TotalRecaudado).ToList();

            dgvReportes.DataSource = lista;
            ConfigurarGrid(dgvReportes);
            dgvReportes.Columns["Sucursal"].HeaderText = "Sucursal";
            dgvReportes.Columns["Dirección"].HeaderText = "Dirección";
            dgvReportes.Columns["StockTotal"].HeaderText = "Stock total";
            dgvReportes.Columns["ProductosSinStock"].HeaderText = "Productos sin stock";
            dgvReportes.Columns["TotalVentas"].HeaderText = "Ventas";
            dgvReportes.Columns["TotalProductosVendidos"].HeaderText = "Productos vendidos";
            dgvReportes.Columns["TotalRecaudado"].HeaderText = "Recaudación";

            dgvReportes.Columns["StockTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReportes.Columns["ProductosSinStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReportes.Columns["TotalVentas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReportes.Columns["TotalProductosVendidos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReportes.Columns["TotalRecaudado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReportes.Columns["TotalRecaudado"].DefaultCellStyle.Format = "C0";
        }
        private void FiltrarClientes()
        {
            var ventas = ControladoraVentas.Instancia().ObtenerVentas().ToList();
            var clientes = ControladoraClientes.Instancia().ObtenerClientes();

            if (cmbClientes.SelectedIndex != -1)
                clientes = clientes.Where(c => c.Nombre.Contains(cmbClientes.Text.Trim())).ToList();

            var lista = clientes.Select(c => new { Cliente = c.Nombre, Email = c.Email, Tipo = c.TipoCliente.ToString(), Compras = ventas.Count(v => v.ClienteId == c.Id), ProductosComprados = ventas.Where(v => v.ClienteId == c.Id).Sum(v => v.Cantidad), TotalGastado = ventas.Where(v => v.ClienteId == c.Id).Sum(v => v.Total) }).OrderByDescending(x => x.TotalGastado).ToList();

            dgvReportes.DataSource = lista;
            ConfigurarGrid(dgvReportes);

            dgvReportes.Columns["Compras"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReportes.Columns["ProductosComprados"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReportes.Columns["TotalGastado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReportes.Columns["TotalGastado"].DefaultCellStyle.Format = "C0";
        }
        private void FiltrarProductos()
        {
            var ventas = ControladoraVentas.Instancia().ObtenerVentas().ToList();
            var productos = ControladoraProductos.Instancia().ObtenerProductos();

            if (cmbProducto.SelectedIndex != -1)
                productos = productos.Where(p => p.Nombre.Contains(cmbProducto.Text.Trim())).ToList();

            var lista = productos.Select(p => new { Producto = p.Nombre, Categoría = p.Categoria.Nombre, Precio = p.Precio, StockTotal = p.StocksPorSucursal.Sum(s => s.Cantidad), SucursalesConStock = p.StocksPorSucursal.Count(s => s.Cantidad > 0), Vendido = ventas.Where(v => v.ProductoId == p.Id).Sum(v => v.Cantidad), Recaudado = ventas.Where(v => v.ProductoId == p.Id).Sum(v => v.Total) }).OrderByDescending(x => x.Vendido).ToList();

            dgvReportes.DataSource = lista;
            ConfigurarGrid(dgvReportes);

            dgvReportes.Columns["Precio"].DefaultCellStyle.Format = "C0";
            dgvReportes.Columns["Recaudado"].DefaultCellStyle.Format = "C0";
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

            var final = lista.OrderByDescending(v => v.Fecha).Select(v => new { Fecha = v.Fecha.ToString("dd/MM/yyyy HH:mm"), Producto = v.Producto.Nombre, Cliente = v.Cliente.Nombre, Vendedor = v.NombreVendedor, Método = v.MetodoPago.ToString(), Cantidad = v.Cantidad, Total = v.Total, Descuento = v.Descuento == 0 ? "-" : $"{v.Descuento}%" }).ToList();

            dgvReportes.DataSource = final;
            ConfigurarGrid(dgvReportes);

            dgvReportes.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReportes.Columns["Total"].DefaultCellStyle.Format = "C0";
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

                    case ModoReporte.General:
                        break;

                    default:
                        MessageBox.Show("Seleccione un tipo de reporte antes de aplicar filtros.");
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

            MostrarDashboard(false);  
            ActivarFiltros(false, true, false, false, false, false);

            FiltrarSucursales();

        }

        private void btnReporteProducto_Click(object sender, EventArgs e)
        {
            modoActual = ModoReporte.Productos;
            ActivarBoton(btnReporteProducto);

            MostrarDashboard(false);
            ActivarFiltros(false, false, false, true, false, false);

            FiltrarProductos();

        }

        private void btnReporteVenta_Click(object sender, EventArgs e)
        {
            modoActual = ModoReporte.Ventas;
            ActivarBoton(btnReporteVenta);

            MostrarDashboard(false);
            ActivarFiltros(true, true, true, true, true, true);

            FiltrarVentas();
        }

        private void btnReporteCliente_Click(object sender, EventArgs e)
        {
            modoActual = ModoReporte.Clientes;
            ActivarBoton(btnReporteCliente);

            MostrarDashboard(false);
            ActivarFiltros(false, false, true, false, false, false);

            FiltrarClientes();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReporteGeneral_Click(object sender, EventArgs e)
        {
            modoActual = ModoReporte.General;
            ActivarBoton(btnReporteGeneral);

            btnLimpiarCampos.Enabled = false;

            ActivarFiltros(false, false, false, false, false, false);

            LimpiarCampos();
            MostrarDashboard(true);  
            Refrescar();
        }
    }
}
