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


        public IReadOnlyCollection<Entidades.Sucursal> ObtenerSucursales()        //Para obtener todas las sucursales
        {
            return repositorio.ObtenerSucursales();
        }
       
        public Sucursal? ObtenerSucursalPorID(int idSucursal)                   //Para obtener una sucursal por ID
        {
            if (idSucursal <= 0)
            {
                return null; 
            }
            return repositorio.ObtenerSucursalPorId(idSucursal);
        }

        public void AgregarSucursal(Sucursal sucursal)
        {
            if (sucursal == null)
            {
                throw new ArgumentNullException(nameof(sucursal));
                repositorio.AgregarSucursal(sucursal); 
            }
        }

        public void ModificarSucursal(Sucursal sucursal)
        {
            if (sucursal == null)
            {
                throw new ArgumentNullException(nameof(sucursal));
            }
            repositorio.ModificarSucursal(sucursal);
        }
        public bool EliminarSucursal(int idSucursal)
        {
            if (idSucursal <= 0)
            {
                return false;
            }
            var sucursal = ObtenerSucursalPorID(idSucursal);
            if (sucursal == null)
            {
                return false;
            }
            repositorio.EliminarSucursal(sucursal);
            return true;
        }
    }
}

