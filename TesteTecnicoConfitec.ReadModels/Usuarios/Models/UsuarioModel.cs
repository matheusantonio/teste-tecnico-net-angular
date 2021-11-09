using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.Domain.Usuarios.ValueObjects;

namespace TesteTecnicoConfitec.ReadModels.Usuarios.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Escolaridade Escolaridade { get; set; }
    }
}
