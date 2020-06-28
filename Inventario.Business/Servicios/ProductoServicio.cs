using Inventario.Business.Contratos;
using Inventario.Business.DTO;
using Inventario.Business.Mapper;
using Inventario.DataAccessLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.Business.Servicios
{
    public class ProductoServicio : IProductoServicio
    {
        InventarioContext context = new InventarioContext();
        public ProductoDTO Get(int productoId)
        {
           var producto= context.Productos.Find(productoId);
            return ProductoMapper.Map(producto); 
        }
    }
}
