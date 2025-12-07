using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //calcular totales con descuentos
    //procesar los metodos de pago (efectivo, tarjeta, transferencia)
    //generar facturas
    // actualizar automaticamente el inventario
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public MetodoPago MetodoPago { get; set; }   // Efectivo / Tarjeta / Transferencia
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public Producto Producto { get; set; }
    }

    public enum MetodoPago
    {
        Efectivo = 1,
        Tarjeta = 2,
        Transferencia = 3
    }
    
}
