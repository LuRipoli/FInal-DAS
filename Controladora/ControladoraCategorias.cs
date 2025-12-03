using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraCategorias
    {
        private RepositorioCategorias repositorio = new RepositorioCategorias();
        private static ControladoraCategorias instancia;
        public static ControladoraCategorias Instancia()
        {
            if (instancia == null)
                instancia = new ControladoraCategorias();
            
            return instancia;
        }

        public List<Categoria> ObtenerCategorias()
        {
            var listaCategorias = repositorio.ObtenerCategorias().ToList();
            if(listaCategorias == null || listaCategorias.Count == 0)
                throw new ListaVaciaException("No se encontraron categorías.");
            return listaCategorias;
        }

        public void AgregarCategoria(string Nombre)
        {
            if (string.IsNullOrEmpty(Nombre))
                throw new DatosInvalidosException("El nombre de la categoría no puede estar vacío.");

            var listaCategorias = repositorio.ObtenerCategorias();
            if (listaCategorias.Any(c => c.Nombre.ToLower() == Nombre.ToLower()))
                throw new EntidadYaExistenteException("Ya existe una categoría con ese nombre.");
            

            Categoria nuevaCategoria = new Categoria();
            nuevaCategoria.Nombre = Nombre;
            repositorio.AgrgarCategoria(nuevaCategoria);
        }

        public void ModificarCategoria(int idCategoria, string nuevoNombre)
        {
            var categoria = repositorio.ObtenerCategoriaPorId(idCategoria);

            if (categoria == null)
                throw new EntidadNoEncontradaException("No se encontró la categoría especificada.");
            if (string.IsNullOrEmpty(nuevoNombre))
                throw new DatosInvalidosException("El nombre de la categoría no puede estar vacío.");
            var listaCategorias = repositorio.ObtenerCategorias();

            if (listaCategorias.Any(c => c.Nombre.ToLower() == nuevoNombre.ToLower() && c.Id != idCategoria))
                throw new EntidadYaExistenteException("Ya existe una categoría con ese nombre.");
     

            categoria.Nombre = nuevoNombre;
            repositorio.ModificarCategoria(categoria);
        }

        public void EliminarCategoria(int idCategoria)
        {
            if(idCategoria <= 0)
                throw new DatosInvalidosException("El ID de la categoría es inválido.");
            var categoria = repositorio.ObtenerCategoriaPorId(idCategoria);

            if (categoria == null)
                throw new EntidadNoEncontradaException("No se encontró la categoría especificada.");

            repositorio.EliminarCategoria(categoria);
        }

        public Categoria BuscarCategoriaPorId(int idCategoria)
        {
            if (idCategoria <= 0)
                throw new DatosInvalidosException("El ID de la categoría es inválido.");
            var categoria = repositorio.ObtenerCategoriaPorId(idCategoria);
            if (categoria == null)
                throw new EntidadNoEncontradaException("No se encontró la categoría especificada.");
            return categoria;
        }
        public Categoria BuscarCategoriaPorNombre(string nombreCategoria)
        {
            if (string.IsNullOrEmpty(nombreCategoria))
                throw new DatosInvalidosException("El nombre de la categoría no puede estar vacío.");
            var categoria = repositorio.ObtenerCategoriaPorNombre(nombreCategoria);
            if (categoria == null)
                throw new EntidadNoEncontradaException("No se encontró la categoría especificada.");
            return categoria;
        }
    }
}
