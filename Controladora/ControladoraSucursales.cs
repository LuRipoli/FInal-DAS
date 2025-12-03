using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    internal class ControladoraSucursales
    {
        private RepositorioSucursales repositorio = new RepositorioSucursales();
        private static ControladoraSucursales instancia;

        public static ControladoraSucursales Instancia()
        {
            if (instancia == null)
                instancia = new ControladoraSucursales();

            return instancia;
        }

        private ControladoraSucursales() { }
        public List<Sucursal> ObtenerSucursales()                   //Para obtener todas las sucursales
        {
            var listaventas = repositorio.ObtenerSucursales().ToList();
            if (listaventas == null || listaventas.Count == 0)
                throw new ListaVaciaException("No se encontraron sucursales.");
            return listaventas;
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

            Sucursal nuevaSucursal = new Sucursal();
            nuevaSucursal.Nombre = nombre;
            nuevaSucursal.direccion = direccion;
            repositorio.AgregarSucursal(nuevaSucursal);
        }

        public void ModificarSucursal(int id, string nombre, string direccion)
        {
            var sucursal =  repositorio.ObtenerSucursalPorId(id);
            if (sucursal == null)
                throw new EntidadNoEncontradaException("No se encontró la sucursal especificada.");
            if (string.IsNullOrEmpty(nombre)) 
                throw new DatosInvalidosException("El nombre de la sucursal no puede estar vacío.");
            var listasucursales = repositorio.ObtenerSucursales();
            if(listasucursales.Any(s => s.Nombre.ToLower() == nombre.ToLower() && s.id != id))
                throw new EntidadYaExistenteException("Ya existe una sucursal con ese nombre.");
            if (string.IsNullOrWhiteSpace(direccion))
                throw new DatosInvalidosException("La dirección no puede estar vacía.");

            sucursal.Nombre = nombre;
            sucursal.direccion = direccion;
            repositorio.ModificarSucursal(sucursal);
        }
        public void EliminarSucursal(int idSucursal)
        {
           var sucursal = repositorio.ObtenerSucursalPorId(idSucursal);
            if (sucursal == null)
                throw new EntidadNoEncontradaException("No se encontró la sucursal especificada.");
            repositorio.EliminarSucursal(sucursal);
        }

      
    }
}

