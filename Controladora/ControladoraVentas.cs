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

        public void AgregarVenta(DateTime fecha, int clienteId, MetodoPago metodoPago, decimal descto, Producto producto, Sucursal sucursal, int cantidad, string nombreVendedor)
        {
            if (clienteId <= 0) 
                throw new DatosInvalidosException("El cliente es obligatorio.");
            if (DateTime.Now < fecha) 
                throw new DatosInvalidosException("La fecha no puede ser futura.");
            if (!Enum.IsDefined(typeof(MetodoPago), metodoPago)) 
                throw new DatosInvalidosException("Método de pago inválido.");
            if (descto < 0) 
                throw new DatosInvalidosException("El descuento no es válido.");
            if (producto == null) 
                throw new DatosInvalidosException("El producto es obligatorio.");
            if (sucursal == null)
                throw new DatosInvalidosException("La sucursal es obligatoria.");
            if (cantidad <= 0) 
                throw new DatosInvalidosException("La cantidad debe ser mayor a cero.");
            if (string.IsNullOrWhiteSpace(nombreVendedor)) 
                throw new DatosInvalidosException("Debe indicar el vendedor.");

            var controladoraStock = ControladoraStocksPorSucursal.Instancia();
            var stock = controladoraStock.ObtenerStockPorSucursalPorId(producto.Id, sucursal.Id);
            if (stock == null || stock.Cantidad < cantidad)
                throw new DatosInvalidosException("No hay stock suficiente.");

            Venta venta = new Venta();
            venta.Fecha = fecha;
            venta.ClienteId = clienteId;
            venta.ProductoId = producto.Id;
            venta.SucursalId = sucursal.Id;
            venta.MetodoPago = metodoPago;
            venta.Descuento = descto;
            venta.Cantidad = cantidad;
            venta.NombreVendedor = nombreVendedor;
            venta.CalcularTotal(producto.Precio, cantidad, descto);

            repositorio.AgregarVenta(venta);

            controladoraStock.ModificarStock(producto.Id, sucursal.Id, cantidad, 0);
        }

        /*public void EliminarVenta(int idVenta)
        {
            if (idVenta <= 0)
                throw new DatosInvalidosException("El ID de la venta no es válido.");

            var venta = repositorio.ObtenerVentaPorId(idVenta);           //Lo mismo que explicamos en el repo, no tiene mucho sentido eliminar una venta ya realizada (El modificar lo eliminamos je)
            if (venta == null)
                throw new EntidadNoEncontradaException("No se encontró la venta especificada.");
            repositorio.EliminarVenta(venta);
        }*/
   
        public Venta ObtenerVentaPorId(int idVenta)
        {
            if (idVenta <= 0)
                throw new DatosInvalidosException("El ID de la venta no es válido.");
            var venta = repositorio.ObtenerVentaPorId(idVenta);
            if (venta == null)
                throw new EntidadNoEncontradaException("No se encontró la venta especificada.");
            return venta;
        }
    }
}
