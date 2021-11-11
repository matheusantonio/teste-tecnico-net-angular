using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.Domain.Core.Entities;
using TesteTecnicoConfitec.Domain.Usuarios.ValueObjects;
using TesteTecnicoConfitec.ReadModels.Usuarios.Models;

namespace TesteTecnicoConfitec.ReadModels.Usuarios.QueryHandlers
{
    public interface IUsuarioQueryHandler
    {
        public PaginatedList<UsuarioModel> ObterUsuarios(string texto, Escolaridade[] escolaridades, int pagina = 0, int limite = 10);

        public UsuarioModel ObterUsuario(int usuarioId);
    }
}
