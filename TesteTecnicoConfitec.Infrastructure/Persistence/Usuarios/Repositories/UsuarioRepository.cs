using System;
using System.Collections.Generic;
using System.Text;
using TesteTecnicoConfitec.Domain.Usuarios.Entities;
using TesteTecnicoConfitec.Domain.Usuarios.Repositories;
using TesteTecnicoConfitec.Infrastructure.Persistence.Core;
using TesteTecnicoConfitec.Infrastructure.Persistence.Core.EntityFramework;

namespace TesteTecnicoConfitec.Infrastructure.Persistence.Usuarios.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Context _context;

        public UsuarioRepository(Context context)
        {
            _context = context;
        }

        public Usuario ObterPeloId(int id) => _context.Usuarios.Find(id);

        public void Remover(Usuario aggregate)
        {
            _context.Usuarios.Remove(aggregate);
            _context.SaveChanges();
        }

        public void Salvar(Usuario aggregate)
        {
            _context.Usuarios.Add(aggregate);
            _context.SaveChanges();
        }

        public void Atualizar()
        {
            _context.SaveChanges();
        }
    }
}
