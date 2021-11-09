using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnicoConfitec.Domain.Core.Entities
{
    public class Entity<TID> : IIdentity<TID>
    {
        public TID Id { get; protected set; }
    }
}
