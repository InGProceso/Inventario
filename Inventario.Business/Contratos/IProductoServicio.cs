using Inventario.Business.DTO;
namespace Inventario.Business.Contratos
{
    public interface IProductoServicio
    {
        ProductoDTO Get(int productoId);
    }
}
