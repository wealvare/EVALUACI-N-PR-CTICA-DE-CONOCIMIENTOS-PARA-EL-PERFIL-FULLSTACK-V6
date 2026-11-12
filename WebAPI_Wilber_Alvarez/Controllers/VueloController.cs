using Microsoft.AspNetCore.Mvc;
using WebAPI_Wilber_Alvarez.Dto.Requets;
using WebAPI_Wilber_Alvarez.Dto.Response;
using WebAPI_Wilber_Alvarez.Service;

namespace WebAPI_Wilber_Alvarez.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VueloController : ControllerBase
    {
        private readonly VueloService _service;

        public VueloController(VueloService service) => _service = service;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VueloResponseDto>>> ObtenerTodos()
        {
            var vuelo = await _service.obtener();
            return Ok(vuelo);
        }

        [HttpPost]
        public async Task<ActionResult<VueloResponseDto>> Guardar(VueloRequetsDto dto)
        {
            var creado = await _service.Guardar(dto);

            return Created("", creado);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<VueloResponseDto>> Actualizar(int id, ActualizarVuelo dto)
        {
            var actualizado = await _service.Actualizar(id, dto);
            return actualizado is null ? NotFound() : Ok(actualizado);
        }


    }
}
