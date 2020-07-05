using AutoMapper;
using Inventario.Business.Contratos;
using Inventario.Business.DTO;
using Inventario.Business.Mapper;
using Inventario.DataAccessLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool Delete(int productoId)
        {
            var producto = context.Productos.Find(productoId);
            if (producto!=null)
            {
                context.Productos.Remove(producto);
                context.SaveChanges();
                return true;
            }return false;
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

        public IEnumerable<ProductoDTO> GetAll()
        {
            var listadoProductos = context.Productos.ToList();
            if (listadoProductos != null)
            {
                return mapper.Map<IEnumerable<ProductoDTO>>(listadoProductos);
            }
            else return null;
            
        }

        public bool Insert(ProductoDTO productoDTO)
        {
            var producto = mapper.Map<Productos>(productoDTO);
            if (context.Productos.Add(producto)!=null)
            {
                context.SaveChanges();
                return true;
            }return false;
        }

        public bool Update(ProductoDTO productoDTO)
        {
            var producto = context.Productos.Find(productoDTO.ProductoId);
            if (producto!=null)
            {
                producto.Nombre = productoDTO.Nombre;
                producto.Precio = productoDTO.Precio;
                producto.Descripcion = productoDTO.Descripcion;
                context.Productos.Update(producto);
                context.SaveChanges();
                return true;
            }return false;
        }
    }
}
