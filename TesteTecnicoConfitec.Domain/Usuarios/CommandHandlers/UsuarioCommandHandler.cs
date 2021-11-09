using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.Domain.Core.Commands;
using TesteTecnicoConfitec.Domain.Usuarios.Commands;

namespace TesteTecnicoConfitec.Domain.Usuarios.CommandHandlers
{
    public class UsuarioCommandHandler : ICommandHandler<RegistrarUsuario>,
                                         ICommandHandler<AlterarUsuario>,
                                         ICommandHandler<RemoverUsuario>
    {
        public void Handle(RegistrarUsuario cmd)
        {
            throw new NotImplementedException();
        }

        public void Handle(AlterarUsuario cmd)
        {
            throw new NotImplementedException();
        }

        public void Handle(RemoverUsuario cmd)
        {
            throw new NotImplementedException();
        }
    }
}
