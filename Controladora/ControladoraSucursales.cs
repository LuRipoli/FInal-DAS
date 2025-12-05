using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraSucursales
    {
        private RepositorioSucursales repositorio = new RepositorioSucursales();
        private static ControladoraSucursales instancia;
        private ControladoraSucursales()
        {
            repositorio = new RepositorioSucursales();
        }
        public static ControladoraSucursales Instancia()
        {
            if (instancia == null)
                instancia = new ControladoraSucursales();

            return instancia;
        }
        public List<Sucursal> ObtenerSucursales()
        {
            return repositorio.ObtenerSucursales()?.ToList() ?? new List<Sucursal>();
        }

        public void AgregarSucursal(string nombre, string direccion)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new DatosInvalidosException("El nombre de la sucursal no puede estar vacío.");
            var listasucursales = repositorio.ObtenerSucursales();
            if (listasucursales.Any(s => s.Nombre.ToLower() == nombre.ToLower()))
                throw new EntidadYaExistenteException("Ya existe una sucursal con ese nombre.");
            if (string.IsNullOrWhiteSpace(direccion)) 
            throw new DatosInvalidosException("La dirección no puede estar vacía.");

             if (listasucursales.Any(s => s.Direccion.ToLower() == direccion.ToLower()))
                throw new EntidadYaExistenteException("Ya existe una sucursal en esa dirección.");

            Sucursal nuevaSucursal = new Sucursal();
            nuevaSucursal.Nombre = nombre;
            nuevaSucursal.Direccion = direccion;
            repositorio.AgregarSucursal(nuevaSucursal);
        }

        public void ModificarSucursal(int id, string nombre, string direccion)
        {
            if (id <= 0)
                throw new DatosInvalidosException("El identificador de la sucursal no es válido.");

            var sucursal = repositorio.ObtenerSucursalPorId(id);
            if (sucursal == null)
                throw new EntidadNoEncontradaException("No se encontró la sucursal especificada.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new DatosInvalidosException("El nombre de la sucursal no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(direccion))
                throw new DatosInvalidosException("La dirección no puede estar vacía.");

            var sucursales = repositorio.ObtenerSucursales() ?? new List<Sucursal>();

            if (sucursales.Any(s => s.Nombre.ToLower() == nombre.ToLower() && s.Id != id))
                throw new EntidadYaExistenteException("Ya existe una sucursal con ese nombre.");

            sucursal.Nombre = nombre;
            sucursal.Direccion = direccion;

            repositorio.ModificarSucursal(sucursal);
        }
        public void EliminarSucursal(int idSucursal)
        {
            if (idSucursal <= 0)
                throw new DatosInvalidosException("El identificador de la sucursal no es válido.");

            var sucursal = repositorio.ObtenerSucursalPorId(idSucursal);
            if (sucursal == null)
                throw new EntidadNoEncontradaException("No se encontró la sucursal especificada.");

            repositorio.EliminarSucursal(sucursal);
        }   

        public Sucursal BuscarSucursalPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new DatosInvalidosException("El nombre de la sucursal no puede estar vacío.");
            var sucursal = repositorio.BuscarSucursalPorNombre(nombre);
            if (sucursal == null)
                throw new EntidadNoEncontradaException("No se encontró la sucursal especificada.");
            return sucursal;
        }
    }
}

