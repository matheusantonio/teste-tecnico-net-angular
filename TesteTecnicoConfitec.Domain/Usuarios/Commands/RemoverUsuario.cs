using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.Domain.Core.Commands;

namespace TesteTecnicoConfitec.Domain.Usuarios.Commands
{
    public class RemoverUsuario : ICommand
    {
        public int Id { get; set; }
    }
}
