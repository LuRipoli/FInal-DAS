using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Context : DbContext
    {
<<<<<<< HEAD
        private string conexion = "Data Source=GASPAR-SCALBI\\SQLEXPRESS;Initial Catalog=FINAL-DAS;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False";
=======
        private string conexion = "Data Source=MATEO\\SQLEXPRESS;Initial Catalog=FINAL-DAS;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False";
>>>>>>> a52e813bc1fa5f61489273a797e6124ccc414415

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public int hola;
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(conexion);
    }
}