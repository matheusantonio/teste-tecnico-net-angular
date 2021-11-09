using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteTecnicoConfitec.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterTodosOsUsuarios()
        {
            return Ok();
        }

        [HttpGet("{usuarioId}")]
        public IActionResult ObterUsuario(Guid usuarioId)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult RegistrarUsuario()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult AlterarUsuario()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult RemoverUsuario()
        {
            return Ok();
        }
    }
}
