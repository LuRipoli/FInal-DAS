using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class RepositorioSucursales
    {
        private readonly Context context;

        public RepositorioSucursales()
        {
            context = new Context();
        }

        public IReadOnlyCollection<Entidades.Sucursal> ObtenerSucursales()
        {
            return context.Sucursales.Include(s => s.StocksPorSucursal).ThenInclude(sp => sp.Producto).ToList();
        }

        public void AgregarSucursal(Entidades.Sucursal sucursal)
        {
            context.Sucursales.Add(sucursal);
            context.SaveChanges();
        }

        public void EliminarSucursal(Entidades.Sucursal sucursal)
        {
            context.Sucursales.Remove(sucursal);
            context.SaveChanges();
        }

        public void ModificarSucursal(Entidades.Sucursal sucursal)
        {
            context.Sucursales.Update(sucursal);
            context.SaveChanges();
        }

        public Sucursal? ObtenerSucursalPorId(int idCategoria)
        {
            return context.Sucursales.FirstOrDefault(c => c.Id == idCategoria);
        }
        public Sucursal? BuscarSucursalPorNombre(string nombreSucursal)
        {
            return context.Sucursales.FirstOrDefault(s => s.Nombre == nombreSucursal);
        }
    }


}

