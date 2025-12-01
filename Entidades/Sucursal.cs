using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //direccion, nombre y stock de productos
    public class Sucursal
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string direccion { get; set; }
        public List<Producto> StockProductos { get; set; } = new List<Producto>();
    }
}
