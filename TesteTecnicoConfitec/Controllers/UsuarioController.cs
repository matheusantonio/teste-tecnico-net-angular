using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteTecnicoConfitec.Domain.Core.Commands;
using TesteTecnicoConfitec.Domain.Usuarios.Commands;
using TesteTecnicoConfitec.Domain.Usuarios.ValueObjects;
using TesteTecnicoConfitec.ReadModels.Usuarios.QueryHandlers;

namespace TesteTecnicoConfitec.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ICommandRouter _router;
        private readonly IUsuarioQueryHandler _queryHandler;

        public UsuarioController(ICommandRouter router, IUsuarioQueryHandler queryHandler)
        {
            _router = router;
            _queryHandler = queryHandler;
        }

        [HttpGet]
        public IActionResult ObterUsuarios(
            [FromQuery] string texto = "",
            [FromQuery] Escolaridade[] escolaridades = null,
            int pagina = 0, int limite = 10)
        {
            return Ok(_queryHandler.ObterUsuarios(texto, escolaridades, pagina, limite));
        }

        [HttpGet("{usuarioId}")]
        public IActionResult ObterUsuario(int usuarioId)
        {
            return Ok(_queryHandler.ObterUsuario(usuarioId));
        }

        [HttpPost]
        public IActionResult RegistrarUsuario(RegistrarUsuario cmd)
        {
            _router.Send(cmd);
            return Ok();
        }

        [HttpPut]
        public IActionResult AlterarUsuario(AlterarUsuario cmd)
        {
            _router.Send(cmd);
            return Ok();
        }

        [HttpDelete("{usuarioId}")]
        public IActionResult RemoverUsuario(int usuarioId)
        {
            _router.Send(new RemoverUsuario { Id = usuarioId });
            return Ok();
        }
    }
}
