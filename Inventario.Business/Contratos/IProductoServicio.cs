using Inventario.Business.DTO;
using System.Collections;
using System.Collections.Generic;

namespace Inventario.Business.Contratos
{
    public interface IProductoServicio
    {
        ProductoDTO Get(int productoId);
        // insert - update - delete - list all
        bool Insert(ProductoDTO productoDTO);
        bool Update(ProductoDTO productoDTO);
        bool Delete(int productoId);
        IEnumerable<ProductoDTO> GetAll();

    }
}
