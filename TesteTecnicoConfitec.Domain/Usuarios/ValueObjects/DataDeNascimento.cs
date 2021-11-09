using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnicoConfitec.Domain.Usuarios.ValueObjects
{
    public class DataDeNascimento
    {
        public DateTime Data { get; private set; }
        
        public DataDeNascimento(DateTime data)
        {
            Data = data;
            throw new NotImplementedException();
        }
    }
}
