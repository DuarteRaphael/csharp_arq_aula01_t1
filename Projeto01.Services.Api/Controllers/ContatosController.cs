using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Projeto01.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatosController : ControllerBase
    {
        //Criação
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        //Modificação
        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }

        //Exclusão
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok();
        }

        //Buscar todos
        [HttpGet("{page}/{limit}")]
        public IActionResult GetAll(int page, int limit)
        {
            return Ok();
        }

        //Buscas 1 id
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }
    }
}

