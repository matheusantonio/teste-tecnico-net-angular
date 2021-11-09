using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnicoConfitec.Domain.Core.Commands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        void Handle(T cmd);
    }
}
