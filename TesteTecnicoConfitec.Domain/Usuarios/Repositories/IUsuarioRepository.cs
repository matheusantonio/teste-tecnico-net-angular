using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.Domain.Core.Repositories;
using TesteTecnicoConfitec.Domain.Usuarios.Entities;

namespace TesteTecnicoConfitec.Domain.Usuarios.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario, int>
    {
    }
}
