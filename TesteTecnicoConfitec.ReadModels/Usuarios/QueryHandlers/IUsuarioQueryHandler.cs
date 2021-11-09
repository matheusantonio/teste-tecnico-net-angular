using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.ReadModels.Usuarios.Models;

namespace TesteTecnicoConfitec.ReadModels.Usuarios.QueryHandlers
{
    public interface IUsuarioQueryHandler
    {
        public IList<UsuarioModel> ObterUsuarios();

        public UsuarioModel ObterUsuario(int usuarioId);
    }
}
