using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnicoConfitec.Domain.Usuarios.ValueObjects
{
    public class Email
    {
        public string Campo { get; private set; }

        public Email(string email)
        {
            Campo = email;
            throw new NotImplementedException();
        }
    }
}
