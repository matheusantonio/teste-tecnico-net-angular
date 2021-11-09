using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnicoConfitec.Domain.Core.Entities
{
    public interface IAggregateRoot<out TID> : IIdentity<TID>
    {
    }
}
