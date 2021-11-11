using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteTecnicoConfitec.Domain.Core.Entities;

namespace TesteTecnicoConfitec.Infrastructure.Persistence.Core.Extensions
{
    public static class QueryableExtensions
    {
        public static PaginatedList<T> Paginate<T>(this IQueryable<T> collection, int page, int limit)
        {
            var items = collection.Skip(page * limit).Take(limit).ToList();
            var count = collection.Count();

            return new PaginatedList<T>
            {
                Itens = items,
                Total = count,
                Pagina = page,
                Limite = limit
            };
        }
    }
}
