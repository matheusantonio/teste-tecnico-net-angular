using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.Domain.Usuarios.ValueObjects;
using TesteTecnicoConfitec.ReadModels.Usuarios.Models;

namespace TesteTecnicoConfitec.ReadModels.Usuarios.QueryHandlers
{
    public interface IUsuarioQueryHandler
    {
        public IList<UsuarioModel> ObterUsuarios(string texto, Escolaridade[] escolaridades);

        public UsuarioModel ObterUsuario(int usuarioId);
    }
}
