using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventario.Business.Contratos;
using Inventario.Business.DTO;
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
        // api/productos/{1}
        public IActionResult Get(int productoId)
        {
            var producto = productoServicio.Get(productoId);
            if (producto == null)
            {
                return NotFound();
            } else
                return Ok(producto);
        }
        // insert - update - get all - delete
        [HttpGet]
        // api/productos
        public IActionResult GetAll()
        {
            var listadoProductos = productoServicio.GetAll();
            if (listadoProductos != null)
            {
                return Ok(listadoProductos);
            }
            else return NotFound();
        }
        [HttpPost]
        public IActionResult Insert([FromBody] ProductoDTO productoDTO)
        {
            var result = productoServicio.Insert(productoDTO);
            if (result)
            {
                return Ok(result);
            }return Ok(result);
        }
        [HttpPut]
        public IActionResult Update([FromBody] ProductoDTO productoDTO) {
            var result = productoServicio.Update(productoDTO);
            if (result)
            {
                return Ok(result);
            }return Ok(result);
        }
        [HttpDelete]
        // api/productos/?productoId={1} --> query string
        public IActionResult Delete(int productoId)
        {
            var result = productoServicio.Delete(productoId);
            if (result)
            {
                return Ok(result);
            }
            return Ok(result);
        }
    }
}
