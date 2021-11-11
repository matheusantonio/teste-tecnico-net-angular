using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnicoConfitec.Domain.Core.Entities
{
    public class PaginatedList<T>
    {
        public PaginatedList()
        {
            Itens = new List<T>();
        }

        public int? Pagina { get; set; }
        public int? Limite { get; set; }
        public int Total { get; set; }
        public IList<T> Itens { get; set; }

    }
}
