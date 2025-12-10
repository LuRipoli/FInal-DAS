using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioProductos
    {
        private readonly Context context;

        public RepositorioProductos()
        {
            context = new Context();
        }


        public IReadOnlyCollection<Entidades.Producto> ObtenerProducto()
        {
            return context.Productos.Include(p => p.Categoria).ToList().AsReadOnly();
        }
        public void AgregarProducto (Entidades.Producto producto)
        {
            context.Productos.Add(producto);
            context.SaveChanges(); 

        }

        public void ModificarProducto(Entidades.Producto producto)
        {
            context.Productos.Update(producto);
            context.SaveChanges(); 
        }

        public void EliminarProducto(Entidades.Producto producto)
        {
            context.Productos.Remove(producto);
            context.SaveChanges(); 
        }

        public Producto? ObtenerProductoPorID(int idProducto)
        {
            return context.Productos.FirstOrDefault(c => c.Id == idProducto);
        }

        public Producto? ObtenerProductoPorNombre (string nombre)
        {
            return context.Productos.FirstOrDefault(c => c.Nombre == nombre);
        }

    }

}
