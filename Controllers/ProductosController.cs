using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TiendaOnline
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly ProductoService _service;

        public ProductosController(ProductoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _service.ListarAsync());

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Producto producto)
        {
            await _service.CrearAsync(producto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Producto producto)
        {
            if (id != producto.Id)
                return BadRequest();

            await _service.EditarAsync(producto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.EliminarAsync(id);
            return Ok();
        }
    }
}