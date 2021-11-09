using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.ReadModels.Usuarios.Models;
using TesteTecnicoConfitec.ReadModels.Usuarios.QueryHandlers;

namespace TesteTecnicoConfitec.Infrastructure.Persistence.Usuarios.QueryHandlers
{
    public class UsuarioQueryHandler : IUsuarioQueryHandler
    {
        public UsuarioModel ObterUsuario(int usuarioId)
        {
            throw new NotImplementedException();
        }

        public IList<UsuarioModel> ObterUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
