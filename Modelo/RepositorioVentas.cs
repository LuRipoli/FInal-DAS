using Entidades;
using Microsoft.EntityFrameworkCore;
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

        public IReadOnlyCollection<Venta> ObtenerVentas()
        {
            return context.Ventas.Include(v => v.Cliente).Include(v => v.Producto).ThenInclude(p => p.Categoria).Include(v => v.Sucursal).ToList().AsReadOnly();
        }

        public void AgregarVenta(Entidades.Venta venta)
        {
            context.Ventas.Add(venta);
            context.SaveChanges();
        }

        /*public void EliminarVenta(Entidades.Venta venta)
        {
            context.Ventas.Remove(venta);
            context.SaveChanges();
        }
                                                                  //No tiene mucho sentido Modificar o Eliminar una venta ya realizada. Pero dejamos el método para mostrarlo.
        public void ModificarVenta(Entidades.Venta venta)
        {
            context.Ventas.Update(venta);
            context.SaveChanges();
        }*/

        public Venta? ObtenerVentaPorId(int idVenta)
        {
            return context.Ventas.Include(v => v.Cliente).Include(v => v.Producto).Include(v => v.Sucursal).FirstOrDefault(v => v.Id == idVenta);
        }
        public IReadOnlyCollection<Venta> ObtenerVentasdelaSemana()
        {
            return context.Ventas.Include(v => v.Cliente).Include(v => v.Producto).ThenInclude(p => p.Categoria).Include(v => v.Sucursal).Where(v => v.Fecha >= DateTime.Now.AddDays(-7)).ToList().AsReadOnly();
        }

    }
}
