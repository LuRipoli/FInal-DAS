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


        public List<Venta> ObtenerVentas()
        {
            var listaVentas = repositorio.ObtenerVentas().ToList();
            if(listaVentas == null || listaVentas.Count == 0)
                throw new ListaVaciaException("No se encontraron ventas.");
            return listaVentas;
        }
        

        public void AgregarVenta(DateTime fecha, int clienteId, int metodoPago, decimal descto, decimal total)
        {
            if(DateTime.Now < fecha)
                throw new DatosInvalidosException("La fecha de la venta no puede ser futura.");
            var listaVentas = repositorio.ObtenerVentas();
            if(listaVentas.Any(v => v.Fecha == fecha && v.ClienteId == clienteId && v.Total == total))
                throw new EntidadYaExistenteException("Ya existe una venta con esos datos.");
            if(!Enum.IsDefined(typeof(MetodoPago), metodoPago))
                throw new DatosInvalidosException("El método de pago ingresado no es válido.");
            if(descto < 0 || descto > total)
                throw new DatosInvalidosException("El descuento ingresado no es válido."); 
            if(total <= 0)
                throw new DatosInvalidosException("El total de la venta debe ser mayor a cero.");

            Venta nuevaVenta = new Venta();
            nuevaVenta.Fecha = fecha;
            nuevaVenta.ClienteId = clienteId;
            nuevaVenta.MetodoPago = (MetodoPago)metodoPago;
            nuevaVenta.Descuento = descto;
            nuevaVenta.Total = total;
            repositorio.AgregarVenta(nuevaVenta);
        }

        public void ModificarVenta(DateTime fecha, int clienteId, int metodoPago, decimal descto, decimal total)
        {
            var venta = repositorio.ObtenerVentaPorId(clienteId);
            if(venta == null)
                throw new EntidadNoEncontradaException("No se encontró la venta especificada.");
            if (DateTime.Now < fecha)
                throw new DatosInvalidosException("La fecha de la venta no puede ser futura.");
            var listaVentas = repositorio.ObtenerVentas();
            if(listaVentas.Any(v => v.Fecha == fecha && v.ClienteId == clienteId && v.Total == total))
                throw new EntidadYaExistenteException("Ya existe una venta con esos datos.");
            if(!Enum.IsDefined(typeof(MetodoPago), metodoPago))
                throw new DatosInvalidosException("El método de pago ingresado no es válido.");
            if(descto < 0 || descto > total)
                throw new DatosInvalidosException("El descuento ingresado no es válido."); 
            if(total <= 0)
                throw new DatosInvalidosException("El total de la venta debe ser mayor a cero.");

         
            venta.Fecha = fecha;
            venta.ClienteId = clienteId;
            venta.MetodoPago = (MetodoPago)metodoPago;
            venta.Descuento = descto;
            venta.Total = total;

            repositorio.ModificarVenta(venta);
        }

        public void EliminarVenta(int idVenta)
        {
            var venta = repositorio.ObtenerVentaPorId(idVenta);
            if (venta == null)
            {
                throw new EntidadNoEncontradaException("No se encontró la venta especificada.");
            }
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
