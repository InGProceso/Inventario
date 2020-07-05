using AutoMapper;
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
        private readonly IMapper mapper;
        public ProductoServicio(InventarioContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public ProductoDTO Get(int productoId)
        {
           var producto= context.Productos.Find(productoId);
            if (producto != null)
            {
                return mapper.Map<ProductoDTO>(producto);
            }
            else return null;
        }
    }
}
