using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TesteTecnicoConfitec.Domain.Core.Exceptions;
using TesteTecnicoConfitec.Domain.Usuarios.Exceptions;

namespace TesteTecnicoConfitec.Domain.Usuarios.ValueObjects
{
    public class Email
    {
        public string Campo { get; private set; }

        private readonly string _pattern = @"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$";

        private Email() { }
        public Email(string email)
        {
            var regex = new Regex(_pattern);
            if(regex.Match(email).Success)
            {
                Campo = email;
            } else
            {
                throw new DomainException(UsuarioExceptionCode.OEmailInformadoNaoEValido);
            }
            
        }
    }
}
