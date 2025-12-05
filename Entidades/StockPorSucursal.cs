using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class StockPorSucursal
    {
        public int Id { get; set; }
    public int ProductoId { get; set; }
    public Producto Producto { get; set; }

    public int SucursalId { get; set; }
    public Sucursal Sucursal { get; set; }

    public int Cantidad { get; private set; }  // 

    public void AgregarStock(int cantidad)
    {
        if (cantidad <= 0)
            throw new DatosInvalidosException("La cantidad a agregar debe ser mayor a cero.");

        Cantidad += cantidad;
    }

    public void QuitarStock(int cantidad)
    {
        if (cantidad <= 0)
            throw new DatosInvalidosException("La cantidad a quitar debe ser mayor a cero.");

        if (cantidad > Cantidad)
            throw new StockNegativoException("No hay suficiente stock disponible.");

        Cantidad -= cantidad;
    }

    }
}
