using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Context : DbContext
    {
        private string conexion = "Data Source=GASPAR-SCALBI\\SQLEXPRESS;Initial Catalog=FINAL-DAS;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False";
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<StockPorSucursal> StockPorSucursales { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(conexion);
    }
}