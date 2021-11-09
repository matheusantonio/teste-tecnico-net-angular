using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.Domain.Core.Entities;

namespace TesteTecnicoConfitec.Domain.Core.Repositories
{
    public interface IRepository<T, in TID> where T : IAggregateRoot<TID>
    {
        T ObterPeloId(TID id);

        void Salvar(T aggregate);

        void Remover(T aggregate);
    }
}
