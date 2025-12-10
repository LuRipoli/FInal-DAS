using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraStocksPorSucursal
    {
        private readonly RepositorioStockPorSucursal repositorio;
        private static ControladoraStocksPorSucursal instancia;
        private ControladoraStocksPorSucursal()
        {
            repositorio = new RepositorioStockPorSucursal();
        }
        public static ControladoraStocksPorSucursal Instancia()
        {
            if (instancia == null)
                instancia = new ControladoraStocksPorSucursal();

            return instancia;
        }

        public void AgregarStock(int productoId, int sucursalId, int cantidad)
        {
            var existente = repositorio.ObtenerStockPorSucursal(productoId, sucursalId);
            if (existente != null)
                throw new EntidadYaExistenteException("Ya existe un registro de stock para este producto y sucursal.");

            var nuevoRegistro = new StockPorSucursal();

            nuevoRegistro.ProductoId = productoId;
            nuevoRegistro.SucursalId = sucursalId;
            nuevoRegistro.Cantidad = cantidad;
           
            repositorio.AgregarStockPorSucursal(nuevoRegistro);
        }

        public void ModificarStock(int productoId, int sucursalId, int cantidad, int opcion)
        {
            var stock = repositorio.ObtenerStockPorSucursal(productoId, sucursalId);

            if (stock == null)
                throw new EntidadNoEncontradaException("No se encontró el stock para ese producto en esa sucursal.");

            if (cantidad <= 0)
                throw new DatosInvalidosException("La cantidad debe ser mayor a cero.");

            switch (opcion)
            {
                case 0: 
                    stock.QuitarStock(cantidad); 
                    break;

                case 1: 
                    stock.AgregarStock(cantidad);
                    break;

                default:
                    throw new OperacionNoPermitidaException("Opción inválida para modificar el stock.");
            }

            repositorio.ModificarStockPorSucursal(stock);
        }

        public void EliminarStock(int productoId, int sucursalId)
        {
            var stock = repositorio.ObtenerStockPorSucursal(productoId, sucursalId);
            if (stock == null)
                throw new EntidadNoEncontradaException("No se encontró el stock para ese producto en esa sucursal.");

            repositorio.EliminarStockPorSucursal(stock);
        }

        public IReadOnlyCollection<StockPorSucursal> ObtenerProductosBajoStockPorSucursal()
        {
            return repositorio.ObtenerProductosBajoStockPorSucursal();
        }

        public IReadOnlyCollection<StockPorSucursal> ObtenerStocks()
        {
            return repositorio.ObtenerStocks();
        }

        public StockPorSucursal? ObtenerStockPorSucursalPorId(int productoId, int sucursalId)
        {
            return repositorio.ObtenerStockPorSucursal(productoId, sucursalId);
        }
        public void InicializarStockParaProductoNuevo(int productoId)
        {
            var sucursales = ControladoraSucursales.Instancia().ObtenerSucursales();
            foreach (var sucursal in sucursales)
            {
                var nuevoStock = new StockPorSucursal();
                nuevoStock.ProductoId = productoId;
                nuevoStock.SucursalId = sucursal.Id;
                nuevoStock.Cantidad = 0;

                repositorio.AgregarStockPorSucursal(nuevoStock);
            }
        }
        public void InicializarStockParaSucursalNueva(int sucursalId)
        {
            var productos = ControladoraProductos.Instancia().ObtenerProductos();
            foreach (var producto in productos)
            {
                var nuevoStock = new StockPorSucursal();
                nuevoStock.ProductoId = producto.Id;
                nuevoStock.SucursalId = sucursalId;
                nuevoStock.Cantidad = 0;

                repositorio.AgregarStockPorSucursal(nuevoStock);
            }
        }
    }
}
