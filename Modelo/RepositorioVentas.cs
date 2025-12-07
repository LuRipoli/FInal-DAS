using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioVentas
    {
        private readonly Context context;

        public RepositorioVentas()
        {
            context = new Context();
        }

        public IReadOnlyCollection<Entidades.Venta> ObtenerVentas()
        {
            return context.Ventas.ToList().AsReadOnly();
        }

        public void AgregarVenta(Entidades.Venta venta)
        {
            context.Ventas.Add(venta);
            context.SaveChanges();
        }

        public void EliminarVenta(Entidades.Venta venta)
        {
            context.Ventas.Remove(venta);
            context.SaveChanges();
        }

        public void ModificarVenta(Entidades.Venta venta)
        {
            context.Ventas.Update(venta);
            context.SaveChanges();
        }

        public Venta? ObtenerVentaPorId(int idCategoria)
        {
            return context.Ventas.FirstOrDefault(c => c.Id == idCategoria);
        }

        
        public IReadOnlyCollection<Entidades.Venta> ObtenerVentasdelaSemana()
        {
            return context.Ventas.Where(v => v.Fecha >= DateTime.Now.AddDays(-7)).ToList().AsReadOnly();
        }
        
    }
}
