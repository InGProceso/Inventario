using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.Business.DTO
{
   public class ProductoDTO
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
