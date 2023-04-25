using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Magma3_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "World" };
        }
    }
}
