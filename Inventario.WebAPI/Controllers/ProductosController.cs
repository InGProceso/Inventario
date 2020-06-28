using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventario.Business.Contratos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventario.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoServicio productoServicio;
        public ProductosController(IProductoServicio productoServicio)
        {
            this.productoServicio = productoServicio;
        }
        [HttpGet("{productoId}")]
        public IActionResult Get(int productoId)
        {
            var producto = productoServicio.Get(productoId);
            if (producto==null)
            {
                return NotFound();
            }else
            return Ok(producto);
        }

    }
}
