using ClosedXML.Excel;
using Controladora;
using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public enum ModoReporte //Para modularizar mejor el código, se nos ocurrió la idea de fijar modos segun el botón apretado. 
    {
        Sucursales,
        Productos,
        Ventas,
        Clientes,
        General
    }
    public partial class Ventana_Reportes_Y_Consultas : Form
    {

        private ModoReporte modoActual = ModoReporte.General; //Cuando se arranca el form, mostramos el menu general
        public Ventana_Reportes_Y_Consultas()
        {
            InitializeComponent();
            ResetearColoresBotones();
            MostrarDashboardInicial();
            CargarCampos();
            ActivarBoton(btnReporteGeneral);
        }
        #region HELPER FORM
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

            //Analizamos la existencia de las ventas, de no haber, seteamos los valores en 0 para evitar errores y marcar la ausencia.
            if (!ventas.Any())
            {
                lblCard1Valor.Text = "0";
                lblCard2Valor.Text = "$0";
                lblCard3Valor.Text = "$0";

                lblTicketValor.Text = "$0";
                lblVentaMasAltaValor.Text = "-";
                lblVentaMasBajaValor.Text = "-";
                lblMejorVendedorValor.Text = "-";
                lblProductoMasVendidoValor.Text = "-";
                lblSucursalMasVentasValor.Text = "-";

                pbEfectivo.Value = pbTransferencia.Value = pbTarjeta.Value = 0;
                lblPorcentajeEfectivo.Text = lblPorcentajeTransferencia.Text = lblPorcentajeTarjeta.Text = "0%";

                lblTop5Contenido.Text = "No hay productos vendidos todavía.";
                return;
            }

            // 1 - Calculamos los valores que van a ir en los títulos de arriba. 
            int totalVentas = ventas.Count;
            decimal ingresosTotales = ventas.Sum(v => v.Total); //Aclarar que son ingresos Brutos, algo que podemos hacer en el futuro es que el programa reste costos y salarios. (Agregar clase Personal - Empleado - Vendedor)
            decimal ticketPromedio = ingresosTotales / totalVentas;
            // 2 - 
            //Buscamos venta más cara y más barata.
            var ventaMax = ventas.OrderByDescending(v => v.Total).First();
            var ventaMin = ventas.OrderBy(v => v.Total).First();
            
            //Buscamos al vendedor con más ventas
            var vendedorMasVentas = ventas.GroupBy(v => v.NombreVendedor).Select(g => new { Nombre = g.Key, Cant = g.Count() }).OrderByDescending(x => x.Cant).First();
            //Producto con más ventas
            var productoMasVendido = ventas.GroupBy(v => v.Producto.Nombre).Select(g => new { Nombre = g.Key, Cant = g.Sum(v => v.Cantidad) }) .OrderByDescending(x => x.Cant).First();

            var sucursalMasVentas = ventas.GroupBy(v => v.Sucursal.Nombre).Select(g => new { Nombre = g.Key, Cant = g.Count() }).OrderByDescending(x => x.Cant).First();

            //1 - Pasamos esos valores que obtuvimos a los labels de arriba.
            lblCard1Valor.Text = $"{totalVentas}";
            lblCard2Valor.Text = $"${ingresosTotales:N0}";  //N0 Viene de Number Format, le asignamos que tenga 0 decimales (redondea para arriba)
            lblCard3Valor.Text = $"${ticketPromedio:N0}";

            //2 - Los otros valores los pasamos al resumen general.  Podemos usar atributos de otras clases, gracias a que es un objeto Venta y desde el repo incluimos las relaciones.
            lblVentaMasAltaValor.Text = $"${ventaMax.Total:N0} — {ventaMax.Producto.Nombre}";  
            lblVentaMasBajaValor.Text = $"${ventaMin.Total:N0} — {ventaMin.Producto.Nombre}";
            lblMejorVendedorValor.Text = $"{vendedorMasVentas.Nombre} ({vendedorMasVentas.Cant} ventas)";
            lblProductoMasVendidoValor.Text = $"{productoMasVendido.Nombre} ({productoMasVendido.Cant} unidades)";
            lblSucursalMasVentasValor.Text = $"{sucursalMasVentas.Nombre} ({sucursalMasVentas.Cant} ventas)";

            //3 - Contamos cuantos usaron cada método de pago, para luego calcular el porcentaje y setear las barras de progreso.
            int cantEf = ventas.Count(v => v.MetodoPago == MetodoPago.Efectivo);
            int cantTr = ventas.Count(v => v.MetodoPago == MetodoPago.Transferencia);
            int cantTa = ventas.Count(v => v.MetodoPago == MetodoPago.Tarjeta);

            double porcEfReal = cantEf * 100.0 / totalVentas;
            double porcTrReal = cantTr * 100.0 / totalVentas;
            double porcTaReal = 100.0 - porcEfReal - porcTrReal; // ajuste para cerrar en 100, sino a veces da 100,1 100,2 99,9. 

            pbEfectivo.Maximum = pbTransferencia.Maximum = pbTarjeta.Maximum = 100; //fiamos máximo en 100. 

            pbEfectivo.Value = (int)Math.Round(porcEfReal);  //los progressbar solo aceptan enteros y aprovechamos a redondear.
            pbTransferencia.Value = (int)Math.Round(porcTrReal);
            pbTarjeta.Value = 100 - pbEfectivo.Value - pbTransferencia.Value;

            lblPorcentajeEfectivo.Text = $"{porcEfReal:0.00}%";
            lblPorcentajeTransferencia.Text = $"{porcTrReal:0.00}%";
            lblPorcentajeTarjeta.Text = $"{porcTaReal:0.00}%";
            //4 - Top 5 productos más vendidos
            var top5 = ventas.GroupBy(v => v.Producto.Nombre).Select(g => new { Nombre = g.Key, Cant = g.Sum(v => v.Cantidad) }).OrderByDescending(x => x.Cant).Take(5).ToList();
            
            //Linea hecha con IA para formatear el top 5.
            lblTop5Contenido.Text = string.Join("\n",top5.Select((p, i) =>$"{i + 1}. {p.Nombre} — {p.Cant} {(p.Cant == 1 ? "unidad" : "unidades")}"));
        }
        private void ResetearColoresBotones()
        {
            btnReporteSucursal.BackColor = Color.PaleTurquoise;
            btnReporteCliente.BackColor = Color.PaleTurquoise;
            btnReporteVenta.BackColor = Color.PaleTurquoise;
            btnReporteProducto.BackColor = Color.PaleTurquoise;
            btnReporteGeneral.BackColor = Color.PaleTurquoise;
        }
        private void ActivarBoton(Button btn) //cada vez que apretamos un boton de reporte, se activa este metodo para cambiar el color del boton y decir al usuario en qué modo está.
        {
            ResetearColoresBotones();
            btn.BackColor = Color.MediumTurquoise;
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

        private void CargarCampos() //Usamos nombres para filtrar busquedas aca. 
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
            
            //Todo esto es formateo de DGV para que quede más lindo

            ConfigurarGrid(dgvReportes);
            dgvReportes.Columns["StockTotal"].HeaderText = "Stock total";
            dgvReportes.Columns["ProductosSinStock"].HeaderText = "Productos sin stock";
            dgvReportes.Columns["TotalVentas"].HeaderText = "Ventas";
            dgvReportes.Columns["TotalProductosVendidos"].HeaderText = "Productos vendidos";
            dgvReportes.Columns["TotalRecaudado"].HeaderText = "Recaudación";
            dgvReportes.Columns["Sucursal"].HeaderText = "Sucursal";
            dgvReportes.Columns["Dirección"].HeaderText = "Dirección";

            dgvReportes.Columns["TotalRecaudado"].DefaultCellStyle.Format = "C0";

            dgvReportes.Columns["Sucursal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReportes.Columns["Dirección"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvReportes.Columns["StockTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReportes.Columns["ProductosSinStock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReportes.Columns["TotalVentas"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReportes.Columns["TotalProductosVendidos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReportes.Columns["TotalRecaudado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void FiltrarClientes()
        {
            var ventas = ControladoraVentas.Instancia().ObtenerVentas().ToList();
            var clientes = ControladoraClientes.Instancia().ObtenerClientes();

            if (cmbClientes.SelectedIndex != -1)
                clientes = clientes.Where(c => c.Nombre.Contains(cmbClientes.Text.Trim())).ToList();

            var lista = clientes.Select(c => new { Cliente = c.Nombre, Email = c.Email, Tipo = c.TipoCliente.ToString(), Compras = ventas.Count(v => v.ClienteId == c.Id), ProductosComprados = ventas.Where(v => v.ClienteId == c.Id).Sum(v => v.Cantidad), TotalGastado = ventas.Where(v => v.ClienteId == c.Id).Sum(v => v.Total) }).OrderByDescending(x => x.TotalGastado).ToList();

            dgvReportes.DataSource = lista;
            
            //Todo esto es formateo de DGV para que quede más lindo

            ConfigurarGrid(dgvReportes);
            dgvReportes.Columns["TotalGastado"].DefaultCellStyle.Format = "C0";
            dgvReportes.Columns["TotalGastado"].HeaderCell.Value = "Total gastado";
            dgvReportes.Columns["ProductosComprados"].HeaderText = "Productos comprados";
            dgvReportes.Columns["Cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReportes.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReportes.Columns["Tipo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReportes.Columns["Compras"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReportes.Columns["ProductosComprados"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReportes.Columns["TotalGastado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }
        private void FiltrarProductos()
        {
            var ventas = ControladoraVentas.Instancia().ObtenerVentas().ToList();
            var productos = ControladoraProductos.Instancia().ObtenerProductos();

            if (cmbProducto.SelectedIndex != -1)
                productos = productos.Where(p => p.Nombre.Contains(cmbProducto.Text.Trim())).ToList();

            var lista = productos.Select(p => new { Producto = p.Nombre, Categoría = p.Categoria.Nombre, Precio = p.Precio, StockTotal = p.StocksPorSucursal.Sum(s => s.Cantidad), SucursalesConStock = p.StocksPorSucursal.Count(s => s.Cantidad > 0), Vendido = ventas.Where(v => v.ProductoId == p.Id).Sum(v => v.Cantidad), Recaudado = ventas.Where(v => v.ProductoId == p.Id).Sum(v => v.Total) }).OrderByDescending(x => x.Vendido).ToList();

            dgvReportes.DataSource = lista;
            
            //Todo esto es formateo de DGV para que quede más lindo

            ConfigurarGrid(dgvReportes);
            dgvReportes.Columns["StockTotal"].HeaderText = "Stock Total";
            dgvReportes.Columns["SucursalesConStock"].HeaderText = "Sucursales con stock";

            dgvReportes.Columns["Precio"].DefaultCellStyle.Format = "C0";
            dgvReportes.Columns["Recaudado"].DefaultCellStyle.Format = "C0";
            dgvReportes.Columns["Precio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReportes.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReportes.Columns["Categoría"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReportes.Columns["StockTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReportes.Columns["SucursalesConStock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReportes.Columns["Vendido"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReportes.Columns["Recaudado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

            var final = lista.OrderByDescending(v => v.Fecha).Select(v => new { Fecha = v.Fecha.ToString("dd/MM/yyyy HH:mm"), Producto = v.Producto.Nombre, Cliente = v.Cliente.Nombre, Vendedor = v.NombreVendedor, Método = v.MetodoPago.ToString(), Cantidad = v.Cantidad, Total = v.Total, Descuento = v.Descuento == 0 ? "-" : $"{v.Descuento:0}%" }).ToList();
            dgvReportes.DataSource = final;
            
            //Todo esto es formateo de DGV para que quede más lindo

            ConfigurarGrid(dgvReportes);
            dgvReportes.Columns["Total"].DefaultCellStyle.Format = "C0";
            dgvReportes.Columns["Cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReportes.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReportes.Columns["Vendedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvReportes.Columns["Método"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReportes.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReportes.Columns["Total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvReportes.Columns["Descuento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        #endregion

        //HELPER EXCEL (Nunca usamos Exportación a Excel y no sabíamos muy bien como implementarlo, asi qué los métodos y el formateo del Excel son completamente generados por IA)
        #region HELPER EXCEL
        private string ObtenerRutaExcel()
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string carpeta = Path.Combine(
                escritorio,
                "Reportes SGSE (Sistema Gestión Stock de Electrodomésticos)"
            );

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            return Path.Combine(carpeta, "Reportes_SGE.xlsx");
        }

        private XLWorkbook ObtenerWorkbook(string path)
        {
            XLWorkbook wb = File.Exists(path)
                ? new XLWorkbook(path)
                : new XLWorkbook();

            string[] hojas = { "General", "Sucursales", "Productos", "Ventas", "Clientes" };

            foreach (string h in hojas)
                if (!wb.Worksheets.Any(ws => ws.Name == h))
                    wb.Worksheets.Add(h);

            return wb;
        }

        private bool HayFiltrosActivos()
        {
            return
                dtpFechaDesde.Value.Date != new DateTime(2000, 1, 1) ||
                dtpFechaHasta.Value.Date != DateTime.Today ||
                cmbSucursales.SelectedIndex != -1 ||
                cmbClientes.SelectedIndex != -1 ||
                cmbProducto.SelectedIndex != -1 ||
                cmbVendedor.SelectedIndex != -1 ||
                rdbEfectivo.Checked ||
                rdbTransferencia.Checked ||
                rdbTarjeta.Checked;
        }

        private void AplicarBordes(IXLRange range)
        {
            range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
        }

        private void OrdenarHojasReporte(XLWorkbook wb)
        {
            var orden = new List<string>
            {
                "General",
                "Sucursales",
                "Productos",
                "Ventas",
                "Clientes"
            };

            int pos = 1;

            foreach (string nombreHoja in orden)
            {
                var ws = wb.Worksheets.FirstOrDefault(w => w.Name == nombreHoja);
                if (ws != null)
                {
                    ws.Position = pos;
                    pos++;
                }
            }
        }

        private void ExportarDesdeGrid(XLWorkbook wb, string nombreHoja)
        {
            if (dgvReportes.Rows.Count == 0)
                return;

            // 🔥 Reset real de la hoja
            if (wb.Worksheets.Any(w => w.Name == nombreHoja))
                wb.Worksheets.Delete(nombreHoja);

            var ws = wb.Worksheets.Add(nombreHoja);

            int colCount = dgvReportes.Columns.Count;
            int rowCount = dgvReportes.Rows.Count;

            // =====================
            // HEADER
            // =====================
            for (int c = 0; c < colCount; c++)
            {
                ws.Cell(1, c + 1).SetValue(dgvReportes.Columns[c].HeaderText);
            }

            // =====================
            // DATA
            // =====================
            for (int r = 0; r < rowCount; r++)
            {
                for (int c = 0; c < colCount; c++)
                {
                    object valor = dgvReportes.Rows[r].Cells[c].Value;
                    SetearValorCelda(ws.Cell(r + 2, c + 1), valor);
                }
            }

            // =====================
            // TABLA
            // =====================
            var rango = ws.Range(1, 1, rowCount + 1, colCount);
            var tabla = rango.CreateTable();
            tabla.Theme = XLTableTheme.TableStyleMedium9;

            // =====================
            // HEADER STYLE
            // =====================
            ws.Row(1).Style.Font.Bold = true;
            ws.Row(1).Style.Font.FontSize = 11;
            ws.Row(1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Row(1).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Row(1).Style.Alignment.WrapText = true;
            ws.Row(1).Height = 28;

            ws.SheetView.FreezeRows(1);
            AplicarBordes(rango);

            // =====================
            // FORMATO POR COLUMNA
            // =====================
            int filaInicio = 2;
            int filaFin = rowCount + 1;

            for (int c = 0; c < colCount; c++)
            {
                string header = dgvReportes.Columns[c].HeaderText;
                AplicarFormatoPorColumna(ws, filaInicio, filaFin, c + 1, header);
            }

            // =====================
            // AJUSTE DE ANCHOS (CORRECTO)
            // =====================

            // 1️⃣ Ajuste libre (sin min/max)
            ws.Columns().AdjustToContents();

            // 2️⃣ Corrección manual por tipo
            for (int c = 0; c < colCount; c++)
            {
                string h = dgvReportes.Columns[c].HeaderText.ToLower();
                var col = ws.Column(c + 1);

                // Texto largo
                if (h.Contains("cliente") || h.Contains("producto") || h.Contains("email") ||
                    h.Contains("sucursal") || h.Contains("dirección") || h.Contains("vendedor"))
                {
                    col.Width = Math.Min(Math.Max(col.Width, 28), 45);
                }
                // Dinero
                else if (h.Contains("precio") || h.Contains("recaud") || h.Contains("total gast"))
                {
                    col.Width = Math.Min(Math.Max(col.Width, 18), 30);
                }
                // Fechas
                else if (h.Contains("fecha"))
                {
                    col.Width = Math.Max(col.Width, 20);
                }
                // Numéricos chicos
                else
                {
                    col.Width = Math.Max(col.Width, 12);
                }
            }
        }

        private void ExportarGeneral(XLWorkbook wb)
        {
            if (wb.Worksheets.Any(w => w.Name == "General"))
                wb.Worksheets.Delete("General");

            var ws = wb.Worksheets.Add("General");

            ws.Column(1).Width = 38;
            ws.Column(2).Width = 65;

            int row = 1;

            // =====================
            // TÍTULO
            // =====================
            ws.Cell(row, 1).SetValue("INFORME GENERAL");
            ws.Range(row, 1, row, 2).Merge();
            ws.Range(row, 1, row, 2).Style.Font.Bold = true;
            ws.Range(row, 1, row, 2).Style.Font.FontSize = 18;
            ws.Range(row, 1, row, 2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Row(row).Height = 32;

            row += 1;

            // =====================
            // HELPER FILA
            // =====================
            void Fila(string label, string value, bool kpi = false)
            {
                ws.Cell(row, 1).SetValue(label);
                ws.Cell(row, 2).SetValue(value);

                var rango = ws.Range(row, 1, row, 2);

                rango.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                rango.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                rango.Style.Fill.BackgroundColor = kpi
                    ? XLColor.FromHtml("#BDD7EE")
                    : XLColor.FromHtml("#DEEAF6");

                ws.Cell(row, 1).Style.Font.Bold = true;
                ws.Cell(row, 2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                row++;
            }

            // =====================
            // KPIs
            // =====================
            Fila("Ventas totales", lblCard1Valor.Text, true);
            Fila("Ingresos totales", lblCard2Valor.Text, true);
            Fila("Ticket promedio", lblCard3Valor.Text, true);

            // =====================
            // DESTACADOS
            // =====================
            Fila("Venta más alta", lblVentaMasAltaValor.Text);
            Fila("Venta más baja", lblVentaMasBajaValor.Text);
            Fila("Mejor vendedor", lblMejorVendedorValor.Text);
            Fila("Producto más vendido", lblProductoMasVendidoValor.Text);
            Fila("Sucursal con más ventas", lblSucursalMasVentasValor.Text);

            // =====================
            // MÉTODOS DE PAGO
            // =====================
            Fila("Efectivo (%)", lblPorcentajeEfectivo.Text);
            Fila("Transferencia (%)", lblPorcentajeTransferencia.Text);
            Fila("Tarjeta (%)", lblPorcentajeTarjeta.Text);

            // =====================
            // TOP 5 PRODUCTOS (BLOQUE CERRADO)
            // =====================
            int inicioTop = row;

            ws.Cell(row, 1).SetValue("TOP 5 PRODUCTOS");
            ws.Range(row, 1, row, 2).Merge();
            ws.Range(row, 1, row, 2).Style.Font.Bold = true;
            ws.Range(row, 1, row, 2).Style.Font.FontSize = 13;
            ws.Range(row, 1, row, 2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Range(row, 1, row, 2).Style.Fill.BackgroundColor = XLColor.FromHtml("#BDD7EE");

            row++;

            ws.Range(row, 1, row + 4, 2).Merge();
            ws.Range(row, 1, row + 4, 2).SetValue(lblTop5Contenido.Text);
            ws.Range(row, 1, row + 4, 2).Style.Alignment.WrapText = true;
            ws.Range(row, 1, row + 4, 2).Style.Alignment.Vertical = XLAlignmentVerticalValues.Top;
            ws.Range(row, 1, row + 4, 2).Style.Fill.BackgroundColor = XLColor.FromHtml("#DEEAF6");

            AplicarBordes(ws.Range(inicioTop, 1, row + 4, 2));
        }


        private void SetearValorCelda(IXLCell cell, object valor)
        {
            if (valor == null)
            {
                cell.SetValue("");
                return;
            }

            if (valor is DateTime dt) { cell.SetValue(dt); return; }
            if (valor is int i) { cell.SetValue(i); return; }
            if (valor is long l) { cell.SetValue(l); return; }
            if (valor is decimal dec) { cell.SetValue(dec); return; }
            if (valor is double dbl) { cell.SetValue(dbl); return; }
            if (valor is float fl) { cell.SetValue((double)fl); return; }

            string s = valor.ToString()?.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(s))
            {
                cell.SetValue("");
                return;
            }

            if (DateTime.TryParseExact(
                s,
                "dd/MM/yyyy HH:mm",
                CultureInfo.GetCultureInfo("es-AR"),
                DateTimeStyles.None,
                out DateTime dt2))
            {
                cell.SetValue(dt2);
                return;
            }

            string limpio = s.Replace("$", "").Replace(".", "").Replace(",", ".");

            if (decimal.TryParse(limpio, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal d))
            {
                cell.SetValue(d);
                return;
            }

            cell.SetValue(s);
        }

        private void AplicarFormatoPorColumna(
            IXLWorksheet ws,
            int filaInicioDatos,
            int filaFinDatos,
            int col,
            string header)
                {
            string h = (header ?? "").Trim().ToLower();
            var rango = ws.Range(filaInicioDatos, col, filaFinDatos, col);

            // =========================
            // MONEDA ($)
            // =========================
            if (
                h == "total" ||
                h.Contains("precio") ||
                h.Contains("recaud") ||
                h.Contains("total gast") ||
                h.Contains("ingreso") ||
                h.Contains("importe")
            )
            {
                rango.Style.NumberFormat.Format = "$ #,##0";
                rango.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                return;
            }

            // =========================
            // FECHA
            // =========================
            if (h.Contains("fecha"))
            {
                rango.Style.DateFormat.Format = "dd/MM/yyyy HH:mm";
                rango.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                return;
            }

            // =========================
            // PORCENTAJE
            // =========================
            if (h.Contains("descuento") || h.Contains("porcentaje"))
            {
                rango.Style.NumberFormat.Format = "0%";
                rango.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                return;
            }

            // =========================
            // NUMÉRICO (NO MONEDA)
            // =========================
            if (
                h.Contains("stock") ||
                h.Contains("ventas") ||
                h.Contains("vendido") ||
                h.Contains("cantidad") ||
                h.Contains("compras") ||
                h.Contains("productos")
            )
            {
                rango.Style.NumberFormat.Format = "0";
                rango.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                return;
            }

            // =========================
            // TEXTO
            // =========================
            rango.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
        }
        #endregion
        private void pnelppalmedio_Paint(object sender, PaintEventArgs e)
        {
            //EXPLOTA EL PROGRAMA SI LO BORRO, NO TOCAR (Gaspar)                JAJAJA OK, fingimos demencia (Lucas)
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            modoActual = ModoReporte.General;
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

                    case ModoReporte.Productos:               //Aca se ve mejor la utilidad del enum ModoReporte
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

        private void tlpBotones_Paint(object sender, PaintEventArgs e)
        {
            // no tocar, el codigo hace pum (Lucas)           //Qué tipazo che (Gaspar) 
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (HayFiltrosActivos())
            {
                MessageBox.Show("No se puede exportar con filtros activos.\nLimpie los filtros para exportar.", "Exportación bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string path = ObtenerRutaExcel();

            try
            {
                var wb = ObtenerWorkbook(path);

                switch (modoActual)
                {
                    case ModoReporte.General:
                        ExportarGeneral(wb);
                        break;

                    case ModoReporte.Sucursales:
                        ExportarDesdeGrid(wb, "Sucursales");
                        break;

                    case ModoReporte.Productos:
                        ExportarDesdeGrid(wb, "Productos");        //Lo mismo, exportamos a Excel segun el modo actual. 
                        break;

                    case ModoReporte.Ventas:
                        ExportarDesdeGrid(wb, "Ventas");
                        break;

                    case ModoReporte.Clientes:
                        ExportarDesdeGrid(wb, "Clientes");
                        break;

                    default:
                        MessageBox.Show("Seleccione un reporte.");
                        return;
                }
                OrdenarHojasReporte(wb);
                wb.SaveAs(path);

                MessageBox.Show("Reporte exportado correctamente.\n\nUbicación:\n" + Path.GetDirectoryName(path), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException)
            {
                MessageBox.Show("El archivo Excel está abierto.\nCierrelo e intente nuevamente.", "Archivo en uso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
