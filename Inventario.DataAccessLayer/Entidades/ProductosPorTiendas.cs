using System;
using System.Collections.Generic;

namespace Inventario.DataAccessLayer.Entidades
{
    public partial class ProductosPorTiendas
    {
        public int ProductoId { get; set; }
        public int TiendaId { get; set; }

        public virtual Productos Producto { get; set; }
        public virtual Tiendas Tienda { get; set; }
    }
}
