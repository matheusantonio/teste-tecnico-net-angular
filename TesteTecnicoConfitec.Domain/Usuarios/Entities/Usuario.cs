using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.Domain.Core.Entities;
using TesteTecnicoConfitec.Domain.Usuarios.Commands;
using TesteTecnicoConfitec.Domain.Usuarios.ValueObjects;

namespace TesteTecnicoConfitec.Domain.Usuarios.Entities
{
    public class Usuario : Entity<int>, IAggregateRoot<int>
    {
        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public DataDeNascimento DataDeNascimento { get; private set; }
        public Escolaridade Escolaridade { get; private set; }

        public Usuario(RegistrarUsuario cmd)
        {
            Nome = new Nome(cmd.Nome, cmd.Sobrenome);
            Email = new Email(cmd.Email);
            DataDeNascimento = new DataDeNascimento(cmd.DataDeNascimento);
            Escolaridade = cmd.Escolaridade;
        }

        public void AlterarUsuario(AlterarUsuario cmd)
        {
            Nome = new Nome(cmd.Nome, cmd.Sobrenome);
            Email = new Email(cmd.Email);
            DataDeNascimento = new DataDeNascimento(cmd.DataDeNascimento);
            Escolaridade = cmd.Escolaridade;
        }
    }
}
