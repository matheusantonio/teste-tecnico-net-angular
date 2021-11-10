using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnicoConfitec.Domain.Usuarios.ValueObjects
{
    public class Nome
    {
        private Nome() { }

        public Nome(string primeiroNome, string sobrenome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
        }

        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }


    }
}
