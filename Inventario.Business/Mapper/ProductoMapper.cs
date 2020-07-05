using AutoMapper;
using Inventario.Business.DTO;
using Inventario.DataAccessLayer.Entidades;

namespace Inventario.Business.Mapper
{
   public class ProductoMapper : Profile
    {
        public ProductoMapper()
        {
            CreateMap<ProductoDTO, Productos>();
            CreateMap<Productos, ProductoDTO>();
        }
    }
}
