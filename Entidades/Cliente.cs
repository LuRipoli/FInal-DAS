using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //registrar minorista o mayorista
    //tener un historial de compras
    //aplicar descuentos segun el tipo de cliente
    public enum TipoCliente
    {
        Minorista = 1,
        Mayorista = 2
    }
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public TipoCliente TipoCliente { get; set; }
    }
}
