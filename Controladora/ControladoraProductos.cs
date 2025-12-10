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
        private readonly RepositorioProductos repositorio;
        private static ControladoraProductos instancia;
        private ControladoraProductos()
        {
            repositorio = new RepositorioProductos();
        }
        public static ControladoraProductos Instancia()
        {
            if (instancia == null)
                instancia = new ControladoraProductos();

            return instancia;
        }
        public List<Producto> ObtenerProductos()
        {
            return repositorio.ObtenerProducto()?.ToList() ?? new List<Producto>();
        }

        public Producto ObtenerProductoPorID(int idProducto)
        {
            if (idProducto <= 0)
                throw new DatosInvalidosException("El ID del producto no es válido.");

            var producto = repositorio.ObtenerProductoPorID(idProducto);

            if (producto == null)
                throw new EntidadNoEncontradaException("No se encontró el producto especificado.");

            return producto;
        }

        public void AgregarProducto(string nombre, string descripcion, decimal precio, Categoria categoria)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new DatosInvalidosException("El nombre del producto no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(descripcion))
                throw new DatosInvalidosException("La descripción no puede estar vacía.");

            if (precio <= 0)
                throw new DatosInvalidosException("El precio debe ser mayor a cero.");

            if (categoria == null)
                throw new DatosInvalidosException("La categoría es obligatoria.");

            var listaProductos = repositorio.ObtenerProducto();

            if (listaProductos.Any(p => p.Nombre.ToLower() == nombre.ToLower()))
                throw new EntidadYaExistenteException("Ya existe un producto con ese nombre.");

            Producto nuevoProducto = new Producto();
            nuevoProducto.Nombre = nombre;
            nuevoProducto.Descripcion = descripcion;
            nuevoProducto.Precio = precio;
            nuevoProducto.CategoriaId = categoria.Id; 

            repositorio.AgregarProducto(nuevoProducto);

            // Esto es para crear stock inicial en todas las sucursales
            ControladoraStocksPorSucursal.Instancia().InicializarStockParaProductoNuevo(nuevoProducto.Id);
        }

        public void ModificarProducto(int idProducto, string nombre, string descripcion, decimal precio, Categoria categoria)
        {
            var producto = repositorio.ObtenerProductoPorID(idProducto);

            if (producto == null)
                throw new EntidadNoEncontradaException("No se encontró el producto especificado.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new DatosInvalidosException("El nombre no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(descripcion))
                throw new DatosInvalidosException("La descripción no puede estar vacía.");

            if (precio <= 0)
                throw new DatosInvalidosException("El precio debe ser mayor a cero.");

            if (categoria == null)
                throw new DatosInvalidosException("Debe seleccionar una categoría.");

            var listaProductos = repositorio.ObtenerProducto();

            if (listaProductos.Any(p => p.Nombre.ToLower() == nombre.ToLower() && p.Id != idProducto))
                throw new EntidadYaExistenteException("Ya existe otro producto con ese nombre.");

            producto.Nombre = nombre;
            producto.Descripcion = descripcion;
            producto.Precio = precio;
            producto.CategoriaId = categoria.Id;  

            repositorio.ModificarProducto(producto);
        }

        public void EliminarProducto(int idProducto)
        {
            if (idProducto <= 0)
                throw new DatosInvalidosException("El ID del producto no es válido.");

            var producto = repositorio.ObtenerProductoPorID(idProducto);

            if (producto == null)
                throw new EntidadNoEncontradaException("No se encontró el producto especificado.");

            repositorio.EliminarProducto(producto);
        }

        public Producto ObtenerProductoPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new DatosInvalidosException("Debe ingresar un nombre.");

            var producto = repositorio.ObtenerProductoPorNombre(nombre);

            if (producto == null)
                throw new EntidadNoEncontradaException("No se encontró ningún producto con ese nombre.");

            return producto;
        }
    }
}
