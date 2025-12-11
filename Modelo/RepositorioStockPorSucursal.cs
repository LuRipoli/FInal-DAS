using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class RepositorioStockPorSucursal
    {
        private readonly Context context;

        public RepositorioStockPorSucursal()
        {
            context = new Context();
        }


        public IReadOnlyCollection<Entidades.StockPorSucursal> ObtenerStocks()
        {
            return context.StockPorSucursales.Include(s => s.Producto).ThenInclude(p => p.Categoria).Include(s => s.Sucursal).ToList();
        }
        public StockPorSucursal? ObtenerStockPorSucursal(int productoId, int sucursalId)
        {
            return context.StockPorSucursales.Include(s => s.Producto).Include(s => s.Sucursal).FirstOrDefault(s => s.ProductoId == productoId && s.SucursalId == sucursalId);
        }
        public IReadOnlyCollection<StockPorSucursal> ObtenerProductosBajoStockPorSucursal()
        {
            return context.StockPorSucursales.Include(s => s.Sucursal).Include(s => s.Producto).Where(s => s.Cantidad <= 25).ToList().AsReadOnly();
        }
        public void AgregarStockPorSucursal(Entidades.StockPorSucursal stock)
        {
            context.StockPorSucursales.Add(stock);
            context.SaveChanges();
        }
        public void ModificarStockPorSucursal(Entidades.StockPorSucursal stock)
        {
            context.StockPorSucursales.Update(stock);
            context.SaveChanges();
        }
        public void EliminarStockPorSucursal(Entidades.StockPorSucursal stock)
        {
            context.StockPorSucursales.Remove(stock);
            context.SaveChanges();
        }
    }
}
