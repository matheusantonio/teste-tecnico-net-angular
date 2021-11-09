using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnicoConfitec.Domain.Core.Entities
{
    public interface IIdentity { }
    public interface IIdentity<out TID> : IIdentity
    {
        TID Id { get; }
    }
}
