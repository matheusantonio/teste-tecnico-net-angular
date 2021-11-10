using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.Domain.Core.Exceptions;
using TesteTecnicoConfitec.Domain.Usuarios.Exceptions;

namespace TesteTecnicoConfitec.Domain.Usuarios.ValueObjects
{
    public class DataDeNascimento
    {
        public DateTime Data { get; private set; }
        
        private DataDeNascimento() { }
        public DataDeNascimento(DateTime data)
        {
            if(data > DateTime.Now)
            {
                throw new DomainException(UsuarioExceptionCode.ADataDeNascimentoDeveSerSuperiorADataAtual);
            }
            Data = data;
        }
    }
}
