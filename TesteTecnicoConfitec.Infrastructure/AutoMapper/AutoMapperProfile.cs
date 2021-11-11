using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.Domain.Core.Entities;
using TesteTecnicoConfitec.Domain.Usuarios.Entities;
using TesteTecnicoConfitec.ReadModels.Usuarios.Models;

namespace TesteTecnicoConfitec.Infrastructure.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Usuario, UsuarioModel>()
                .ForMember(um => um.Nome,
                    map => map.MapFrom(u => u.Nome.PrimeiroNome))
                .ForMember(um => um.Sobrenome,
                    map => map.MapFrom(u => u.Nome.Sobrenome))
                .ForMember(um => um.Email,
                    map => map.MapFrom(u => u.Email.Campo))
                .ForMember(um => um.DataDeNascimento,
                    map => map.MapFrom(u => u.DataDeNascimento.Data));

            CreateMap<PaginatedList<Usuario>, PaginatedList<UsuarioModel>>();
        }
    }
}
