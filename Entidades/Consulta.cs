using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //reporte de ventas con periodo producto sucursal y vendedor
    //productos mas vendidos 
    //estado de cuenta corriente de los clientes
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public int ProductoId { get; set; }
        public int SucursalId { get; set; }
        public string VendedorId { get; set; }
    }
}
