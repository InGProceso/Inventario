using System;
using System.Collections.Generic;

namespace Inventario.DataAccessLayer.Entidades
{
    public partial class Productos
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
