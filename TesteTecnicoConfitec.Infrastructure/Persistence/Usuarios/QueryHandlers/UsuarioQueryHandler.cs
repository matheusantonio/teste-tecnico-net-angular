using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteTecnicoConfitec.Domain.Core.Entities;
using TesteTecnicoConfitec.Domain.Usuarios.ValueObjects;
using TesteTecnicoConfitec.Infrastructure.Persistence.Core.EntityFramework;
using TesteTecnicoConfitec.Infrastructure.Persistence.Core.Extensions;
using TesteTecnicoConfitec.ReadModels.Usuarios.Models;
using TesteTecnicoConfitec.ReadModels.Usuarios.QueryHandlers;

namespace TesteTecnicoConfitec.Infrastructure.Persistence.Usuarios.QueryHandlers
{
    public class UsuarioQueryHandler : IUsuarioQueryHandler
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public UsuarioQueryHandler(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public UsuarioModel ObterUsuario(int usuarioId)
        {
            var usuario = _context.Usuarios
                .Where(x => x.Id == usuarioId)
                .FirstOrDefault();

            var result = _mapper.Map<UsuarioModel>(usuario);
            return result;
        }

        public PaginatedList<UsuarioModel> ObterUsuarios(string texto, Escolaridade[] escolaridades, int pagina = 0, int limite = 10)
        {
            var query = _context.Usuarios.AsQueryable();

            if(!string.IsNullOrEmpty(texto))
            {
                query = query.Where(x => x.Nome.PrimeiroNome.Contains(texto) ||
                                         x.Nome.Sobrenome.Contains(texto) ||
                                         x.Email.Campo.Contains(texto));
            }

            if(escolaridades != null && escolaridades.Length > 0)
            {
                query = query.Where(x => escolaridades.Contains(x.Escolaridade));
            }

            var usuarios = query.Paginate(pagina, limite);
            var result = _mapper.Map<PaginatedList<UsuarioModel>>(usuarios);

            return result;
        }
    }
}
