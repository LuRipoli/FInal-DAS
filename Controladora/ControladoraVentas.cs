using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    internal class ControladoraVentas
    {
        private RepositorioVentas repositorio = new RepositorioVentas();
        private static ControladoraVentas instancia;

        public static ControladoraVentas Instancia()
        {
            if (instancia == null)
                instancia = new ControladoraVentas();

            return instancia;
        }

        private ControladoraVentas() { }


        public IReadOnlyCollection<Entidades.Venta> ObtenerVentas()        //Para obtener todas las ventas
        {
            return repositorio.ObtenerVentas();
        }

        public Venta? ObtenerVentaPorID(int idVenta)                   //Para obtener una venta por ID
        {
            if (idVenta <= 0)
            {
                return null;
            }
            return repositorio.ObtenerVentaPorId(idVenta);
        }

        public void AgregarVenta(Venta venta)
        {
            if (venta == null)
            {
                throw new ArgumentNullException(nameof(venta));
                repositorio.AgregarVenta(venta);
            }
        }

        public void ModificarVenta(Venta venta)
        {
            if (venta == null)
            {
                throw new ArgumentNullException(nameof(venta));
            }
            repositorio.ModificarVenta(venta);
        }

        public bool EliminarVenta(int idVenta)
        {
            if (idVenta <= 0)
            {
                return false;
            }
            var venta = repositorio.ObtenerVentaPorId(idVenta);
            if (venta == null)
            {
                return false;
            }
            repositorio.EliminarVenta(venta);
            return true;
        }
    }
}
