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
        private readonly InventarioContext context;
        public ProductoServicio(InventarioContext context)
        {
            this.context = context;
        }
        public ProductoDTO Get(int productoId)
        {
           var producto= context.Productos.Find(productoId);
            if (producto != null)
            {
                return ProductoMapper.Map(producto);
            }
            else return null;
        }
    }
}
