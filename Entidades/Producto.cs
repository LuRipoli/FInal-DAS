namespace Entidades
{
    //codigo, nombre, descripcion, categoria, precio, stock
    //actualizar info segun precios de productos
    //consultar disponibilidad por sucursal 
    //gestionar categorias de productos

    public class Producto
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; } 
        public Categoria categoria { get; set; }
    }
}
