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
        public MetodoPago MetodoPago { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public int SucursalId { get; set; }
        public Sucursal Sucursal { get; set; }
        public int Cantidad { get; set; }
        public string NombreVendedor { get; set; }

        public void CalcularTotal(decimal precioUnitario, int cantidad, decimal descuento)
        {
            var subtotal = precioUnitario * cantidad;
            var montoDescuento = (subtotal * descuento) / 100m;
            Total = subtotal - montoDescuento;
        }
    }

    public enum MetodoPago
    {
        Efectivo = 1,
        Tarjeta = 2,
        Transferencia = 3
    }
    
}
