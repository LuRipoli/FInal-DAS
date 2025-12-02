using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades; 

namespace Controladora
{
    internal class ControladoraProductos
    {
        private RepositorioProductos repositorio = new RepositorioProductos();
        private static ControladoraProductos instancia;

        public static ControladoraProductos Instancia()
        {
            if (instancia == null)
                instancia = new ControladoraProductos();

            return instancia;
        }

        private ControladoraProductos() { }


        public IReadOnlyCollection<Entidades.Producto> ObtenerProducto()        //Para obtener todos los productos
        {
            return repositorio.ObtenerProducto();
        }

        public Producto? ObtenerProductoPorID(int idProducto)                   //Para obtener un producto pr ID
        {
            if (idProducto <= 0)
            {
                return null; 
            }
            return repositorio.ObtenerProductoPorID(idProducto); 
        }

        public void AgregarProducto(Producto producto)
        {
            if (producto == null)
            {
                throw new ArgumentNullException(nameof(producto));
                repositorio.AgregarProducto(producto); 
            }
        }

        public void ModificarProducto(Producto producto)
        {
            if (producto == null)
            {
                throw new ArgumentNullException(nameof(producto));
            }
            repositorio.ModificarProducto(producto); 
        }

        public bool EliminarProducto( int idProducto)
        {
            if (idProducto <= 0)
            {
                return false; 

            }

            var producto =  repositorio.ObtenerProductoPorID(idProducto); 
            
            if (producto == null)
            {
                return false; 
            }

            repositorio.EliminarProducto(producto);
            return true; 
        }
    }
}
