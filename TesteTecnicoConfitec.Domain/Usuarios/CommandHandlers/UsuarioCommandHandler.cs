using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.Domain.Core.Commands;
using TesteTecnicoConfitec.Domain.Core.Exceptions;
using TesteTecnicoConfitec.Domain.Usuarios.Commands;
using TesteTecnicoConfitec.Domain.Usuarios.Entities;
using TesteTecnicoConfitec.Domain.Usuarios.Exceptions;
using TesteTecnicoConfitec.Domain.Usuarios.Repositories;

namespace TesteTecnicoConfitec.Domain.Usuarios.CommandHandlers
{
    public class UsuarioCommandHandler : ICommandHandler<RegistrarUsuario>,
                                         ICommandHandler<AlterarUsuario>,
                                         ICommandHandler<RemoverUsuario>
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioCommandHandler(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public void Handle(RegistrarUsuario cmd)
        {
            var aggregate = new Usuario(cmd);
            _repository.Salvar(aggregate);
        }

        public void Handle(AlterarUsuario cmd)
        {
            var aggregate = _repository.ObterPeloId(cmd.Id);

            if(aggregate == null)
            {
                throw new DomainException(UsuarioExceptionCode.UsuarioInformadoNaoEncontrado);
            }

            aggregate.AlterarUsuario(cmd);
            _repository.Salvar(aggregate);
        }

        public void Handle(RemoverUsuario cmd)
        {
            var aggregate = _repository.ObterPeloId(cmd.Id);

            if (aggregate == null)
            {
                throw new DomainException(UsuarioExceptionCode.UsuarioInformadoNaoEncontrado);
            }

            _repository.Remover(aggregate);
        }
    }
}
