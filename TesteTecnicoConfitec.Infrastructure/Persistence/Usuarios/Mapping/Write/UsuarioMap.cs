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
            builder.ToTable("Usuarios");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome.PrimeiroNome).HasColumnName("Nome").IsRequired();
            builder.Property(x => x.Nome.Sobrenome).HasColumnName("Sobrenome").IsRequired();
            builder.Property(x => x.Email.Campo).HasColumnName("Email").IsRequired();
            builder.Property(x => x.DataDeNascimento).HasColumnName("DataNascimento").IsRequired();
            builder.Property(x => x.Escolaridade).HasColumnName("Escolaridade").IsRequired();
        }
    }
}
