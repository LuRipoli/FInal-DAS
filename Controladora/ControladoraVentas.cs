using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraVentas
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


        public List<Venta> ObtenerVentas()
        {
            return repositorio.ObtenerVentas()?.ToList() ?? new List<Venta>();
        }

        public List<Venta> ObtenerVentasdelaSemana()
        {
            return repositorio.ObtenerVentasdelaSemana()?.ToList() ?? new List<Venta>();
        }

        public void AgregarVenta(DateTime fecha, int clienteId, int metodoPago, decimal descto, decimal total)
        {
            if (clienteId <= 0)
                throw new DatosInvalidosException("El cliente es obligatorio.");

            if (DateTime.Now < fecha)
                throw new DatosInvalidosException("La fecha de la venta no puede ser futura.");

            if (!Enum.IsDefined(typeof(MetodoPago), metodoPago))
                throw new DatosInvalidosException("El método de pago ingresado no es válido.");

            if (total <= 0)
                throw new DatosInvalidosException("El total de la venta debe ser mayor a cero.");

            if (descto < 0 || descto > total)
                throw new DatosInvalidosException("El descuento ingresado no es válido.");

            var ventas = repositorio.ObtenerVentas() ?? Array.Empty<Venta>();

            if (ventas.Any(v => v.Fecha == fecha &&
                                v.ClienteId == clienteId &&
                                v.Total == total))
                throw new EntidadYaExistenteException("Ya existe una venta con esos datos.");
            var nuevaVenta = new Venta
            {
                Fecha = fecha,
                ClienteId = clienteId,
                MetodoPago = (MetodoPago)metodoPago,
                Descuento = descto,
                Total = total
            };
            repositorio.AgregarVenta(nuevaVenta);
        }

        public void ModificarVenta(int idVenta, DateTime fecha, int clienteId, int metodoPago, decimal descto, decimal total)
        {
            if (idVenta <= 0)
                throw new DatosInvalidosException("El identificador de la venta no es válido.");

            var venta = repositorio.ObtenerVentaPorId(idVenta);
            if (venta == null)
                throw new EntidadNoEncontradaException("No se encontró la venta especificada.");

            if (clienteId <= 0)
                throw new DatosInvalidosException("El cliente es obligatorio.");

            if (DateTime.Now < fecha)
                throw new DatosInvalidosException("La fecha de la venta no puede ser futura.");

            if (!Enum.IsDefined(typeof(MetodoPago), metodoPago))
                throw new DatosInvalidosException("El método de pago ingresado no es válido.");

            if (total <= 0)
                throw new DatosInvalidosException("El total de la venta debe ser mayor a cero.");

            if (descto < 0 || descto > total)
                throw new DatosInvalidosException("El descuento ingresado no es válido.");

            var ventas = repositorio.ObtenerVentas() ?? Array.Empty<Venta>();

            if (ventas.Any(v => v.Id != idVenta &&
                                v.Fecha == fecha &&
                                v.ClienteId == clienteId &&
                                v.Total == total))
                throw new EntidadYaExistenteException("Ya existe otra venta con esos datos.");

            venta.Fecha = fecha;
            venta.ClienteId = clienteId;
            venta.MetodoPago = (MetodoPago)metodoPago;
            venta.Descuento = descto;
            venta.Total = total;
            repositorio.ModificarVenta(venta);
        }
        public void EliminarVenta(int idVenta)
        {
            if (idVenta <= 0)
                throw new DatosInvalidosException("El ID de la venta no es válido.");

            var venta = repositorio.ObtenerVentaPorId(idVenta);
            if (venta == null)
                throw new EntidadNoEncontradaException("No se encontró la venta especificada.");
            repositorio.EliminarVenta(venta);
        }

        public Venta ObtenerVentaPorId(int idVenta)
        {
            if (idVenta <= 0)
            {
                throw new DatosInvalidosException("El ID de la venta no es válido.");
            }
            var venta = repositorio.ObtenerVentaPorId(idVenta);
            if (venta == null)
            {
                throw new EntidadNoEncontradaException("No se encontró la venta especificada.");
            }
            return venta;
        }
    }
}
