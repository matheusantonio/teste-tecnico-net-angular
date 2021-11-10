using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteTecnicoConfitec.Domain.Usuarios.ValueObjects;
using TesteTecnicoConfitec.Infrastructure.Persistence.Core.EntityFramework;
using TesteTecnicoConfitec.ReadModels.Usuarios.Models;
using TesteTecnicoConfitec.ReadModels.Usuarios.QueryHandlers;

namespace TesteTecnicoConfitec.Infrastructure.Persistence.Usuarios.QueryHandlers
{
    public class UsuarioQueryHandler : IUsuarioQueryHandler
    {
        private readonly Context _context;

        public UsuarioQueryHandler(Context context)
        {
            _context = context;
        }

        public UsuarioModel ObterUsuario(int usuarioId)
        {
            return _context.Usuarios
                .Where(x => x.Id == usuarioId)
                .Select(u => new UsuarioModel
                {
                    Id = u.Id,
                    Nome = u.Nome.PrimeiroNome,
                    Sobrenome = u.Nome.Sobrenome,
                    Email = u.Email.Campo,
                    DataDeNascimento = u.DataDeNascimento.Data,
                    Escolaridade = u.Escolaridade
                })
                .FirstOrDefault();
        }

        public IList<UsuarioModel> ObterUsuarios(string texto, Escolaridade[] escolaridades)
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

            return query
                .Select(u => 
                    new UsuarioModel
                    {
                        Id = u.Id,
                        Nome = u.Nome.PrimeiroNome,
                        Sobrenome = u.Nome.Sobrenome,
                        Email = u.Email.Campo,
                        DataDeNascimento = u.DataDeNascimento.Data,
                        Escolaridade = u.Escolaridade
                    }).ToList();
        }
    }
}
