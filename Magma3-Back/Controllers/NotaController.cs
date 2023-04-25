using AutoMapper;
using Magma3_Back.Entities;
using Magma3_Back.Services;
using Microsoft.AspNetCore.Mvc;

namespace Magma3_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotaController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly NotaService _notaService;

        public NotaController(IMapper mapper, NotaService notaService)
        {
            _mapper = mapper;
            _notaService = notaService;
        }

        [HttpGet]
        public ActionResult<List<Nota>> GetAllNotas()
        {
            return _notaService.GetAllNotas();
        }

        [HttpGet("{id}")]
        public ActionResult<Nota> GetNotaById(int id)
        {
            return _notaService.GetNotaById(id);
        }

        [HttpPost]
        public ActionResult<Nota> CreateNota(Nota nota)
        {
            _notaService.CreateNota(nota);
            return CreatedAtAction(nameof(GetNotaById), new { id = nota.Id }, nota);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateNota(int id, [FromBody] Nota NotaAtualizada)
        {
            _notaService.UpdateNota(id, NotaAtualizada);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNota(int id)
        {
            _notaService.DeleteNota(id);
            return NoContent();
        }

    }
}
