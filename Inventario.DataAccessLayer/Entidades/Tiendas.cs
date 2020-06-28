using System;
using System.Collections.Generic;

namespace Inventario.DataAccessLayer.Entidades
{
    public partial class Tiendas
    {
        public int TiendaId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
    }
}
