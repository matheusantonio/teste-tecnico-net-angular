using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.Domain.Core.Commands;
using TesteTecnicoConfitec.Domain.Usuarios.ValueObjects;

namespace TesteTecnicoConfitec.Domain.Usuarios.Commands
{
    public class RegistrarUsuario : ICommand
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Escolaridade Escolaridade { get; set; }
    }

    public class AlterarUsuario : RegistrarUsuario 
    {
        public int Id { get; set; }
    }
}
