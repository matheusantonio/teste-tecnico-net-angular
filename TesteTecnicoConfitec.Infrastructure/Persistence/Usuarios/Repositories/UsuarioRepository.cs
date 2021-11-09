using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.Domain.Usuarios.Entities;
using TesteTecnicoConfitec.Domain.Usuarios.Repositories;
using TesteTecnicoConfitec.Infrastructure.Persistence.Core;
using TesteTecnicoConfitec.Infrastructure.Persistence.Core.EntityFramework;

namespace TesteTecnicoConfitec.Infrastructure.Persistence.Usuarios.Repositories
{
    public class UsuarioRepository : Repository<Usuario, int>, IUsuarioRepository
    {
        public UsuarioRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
