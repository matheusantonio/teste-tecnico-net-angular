using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnicoConfitec.Domain.Core.Commands
{
    public interface ICommandRouter
    {
        void Send<T>(T command) where T : ICommand;
    }
}