using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.Domain.Core.Commands;

namespace TesteTecnicoConfitec.Infrastructure.CQRS
{
    public class CommandRouter : ICommandRouter
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandRouter(IServiceProvider provider)
        {
            _serviceProvider = provider;
        }

        public void Send<T>(T command) where T : ICommand
        {
            var instance = _serviceProvider.GetService(typeof(ICommandHandler<T>)) as ICommandHandler<T>;

            if (instance == null)
            {
                throw new InvalidOperationException("Não foi possível encontrar nenhum CommandHandler para tratar este comando.");
            }

            instance.Handle(command);
        }
    }
}
