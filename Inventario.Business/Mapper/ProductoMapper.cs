using Inventario.Business.DTO;
using Inventario.DataAccessLayer.Entidades;

namespace Inventario.Business.Mapper
{
   public static class ProductoMapper
    {
        public static ProductoDTO Map(Productos producto)
        {
            return new ProductoDTO
            {
                ProductoId = producto.ProductoId,
                Descripcion = producto.Descripcion,
                Nombre = producto.Nombre,
                Precio = producto.Precio
            };
        }
        public static Productos Map(ProductoDTO producto)
        {
            return new Productos
            {
                ProductoId = producto.ProductoId,
                Descripcion = producto.Descripcion,
                Nombre = producto.Nombre,
                Precio = producto.Precio
            };
        }
    }
}
