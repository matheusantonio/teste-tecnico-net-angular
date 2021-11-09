using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.Domain.Usuarios.Entities;

namespace TesteTecnicoConfitec.Infrastructure.Persistence.Usuarios.Mapping.Write
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            
        }
    }
}
