using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraVentas
    {
        private RepositorioVentas repositorio = new RepositorioVentas();
        private static ControladoraVentas instancia;
        private ControladoraVentas()
        {
            repositorio = new RepositorioVentas();
        }
        public static ControladoraVentas Instancia()
        {
            if (instancia == null)
                instancia = new ControladoraVentas();

            return instancia;
        }



        public List<Venta> ObtenerVentas()
        {
            return repositorio.ObtenerVentas()?.ToList() ?? new List<Venta>();
        }

        public List<Venta> ObtenerVentasdelaSemana()
        {
            return repositorio.ObtenerVentasdelaSemana()?.ToList() ?? new List<Venta>();
        }

        public void AgregarVenta(DateTime fecha, int clienteId, MetodoPago metodoPago, decimal descto, decimal total, Producto producto, Sucursal sucursal, int cantidad, string nombreVendedor)
        {
            if (clienteId <= 0)
                throw new DatosInvalidosException("El cliente es obligatorio.");

            if (DateTime.Now < fecha)
                throw new DatosInvalidosException("La fecha de la venta no puede ser futura.");

            if (!Enum.IsDefined(typeof(MetodoPago), metodoPago))
                throw new DatosInvalidosException("El método de pago ingresado no es válido.");

            if (total <= 0)
                throw new DatosInvalidosException("El total de la venta debe ser mayor a cero.");

            if (descto < 0 || descto > total)
                throw new DatosInvalidosException("El descuento ingresado no es válido.");

            if (producto == null)
                throw new DatosInvalidosException("El producto es obligatorio.");

            if (sucursal == null)
                throw new DatosInvalidosException("La sucursal es obligatoria.");

            if (cantidad <= 0)
                throw new DatosInvalidosException("La cantidad debe ser mayor a cero.");

            if (string.IsNullOrWhiteSpace(nombreVendedor))
                throw new DatosInvalidosException("Debe indicarse el nombre del vendedor.");

            var ventas = repositorio.ObtenerVentas() ?? Array.Empty<Venta>();
            if (ventas.Any(v => v.Fecha == fecha && v.ClienteId == clienteId && v.Total == total && v.Producto.Id == producto.Id && v.Sucursal.Id == sucursal.Id && v.Cantidad == cantidad && v.NombreVendedor.ToLower() == nombreVendedor.ToLower()))
                throw new EntidadYaExistenteException("Ya existe una venta con esos datos.");

            var controladoraStock = ControladoraStocksPorSucursal.Instancia();
            var stock = controladoraStock.ObtenerStockPorSucursalPorId(producto.Id, sucursal.Id);
            if (stock == null || stock.Cantidad < cantidad)
                throw new DatosInvalidosException("No hay suficiente stock disponible para este producto en esta sucursal.");

            Venta nuevaVenta = new Venta();
            nuevaVenta.Fecha = fecha;
            nuevaVenta.ClienteId = clienteId;
            nuevaVenta.MetodoPago = metodoPago;
            nuevaVenta.Descuento = descto;
            nuevaVenta.Total = total;
            nuevaVenta.Producto = producto;
            nuevaVenta.Sucursal = sucursal;
            nuevaVenta.Cantidad = cantidad;
            nuevaVenta.NombreVendedor = nombreVendedor;

            repositorio.AgregarVenta(nuevaVenta);
            controladoraStock.ModificarStock(producto.Id, sucursal.Id, cantidad, 0); 
        }

        public void EliminarVenta(int idVenta)
        {
            if (idVenta <= 0)
                throw new DatosInvalidosException("El ID de la venta no es válido.");

            var venta = repositorio.ObtenerVentaPorId(idVenta);
            if (venta == null)
                throw new EntidadNoEncontradaException("No se encontró la venta especificada.");
            repositorio.EliminarVenta(venta);
        }

        public Venta ObtenerVentaPorId(int idVenta)
        {
            if (idVenta <= 0)
            {
                throw new DatosInvalidosException("El ID de la venta no es válido.");
            }
            var venta = repositorio.ObtenerVentaPorId(idVenta);
            if (venta == null)
            {
                throw new EntidadNoEncontradaException("No se encontró la venta especificada.");
            }
            return venta;
        }
    }
}
