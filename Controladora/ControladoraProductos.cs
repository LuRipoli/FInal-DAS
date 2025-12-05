using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades; 

namespace Controladora
{
    public class ControladoraProductos
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
            return repositorio.ObtenerProducto()?.ToList() ?? new List<Producto>();
        }

        public Producto? ObtenerProductoPorID(int idProducto)                   //Para obtener un producto pr ID
        {
            if (idProducto <= 0)
            {
                throw new IdNoEncontradoException(nameof(Producto));    //Si el ID es negativo, no existe como ID de algun Producto.
                return null; 
            }
            
            if (repositorio.ObtenerProductoPorID(idProducto) == null)
            {
                throw new DatosInvalidosException(nameof(Producto));  //Si no existe ningun producto con ese ID, lanza la excepcion de Datos Inavlidos.
            }

            return repositorio.ObtenerProductoPorID(idProducto);
        }

        public void AgregarProducto(Producto producto)
        {
            if (producto == null)
            {
                throw new EntidadNoEncontradaException(nameof(producto));    //No buscas nada, porque ingresas con un producto nulo, uno que no existe.
               
            }
            repositorio.AgregarProducto(producto);
        }

        public void ModificarProducto(Producto producto)
        {
            if (producto == null)
            {
                throw new ArgumentNullException(nameof(producto));
            }
            repositorio.ModificarProducto(producto); 

            if (repositorio.lista.Count == 0)
            {
                throw new ListaVaciaException("No hay productos para modificar en la lista"); // No se encuntra el producto con un ID nulo para poder modificarlo.
            }
        }

        public bool EliminarProducto( int idProducto)
        {
            if (repositorio.ObtenerProductoPorID(idProducto) == null)
            {
                throw new IdNoEncontradoException("No hay productos para borar en la lista"); // No se encuntra el producto con un ID nulo para poder borrarlo.
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

        public List<Producto> ObtenerProductosBajoStock()
        {
            return repositorio.ObtenerProductosBajoStock()?.ToList() ?? new List<Producto>();
        }
    }
}
