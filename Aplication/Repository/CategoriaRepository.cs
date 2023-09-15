using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;


namespace Aplication.Repository
{
    public class CategoriaRepository : GenericRepository<Categoria>, ICategoriaRepository
    {
        private readonly ApiDemoContext _context;
        public CategoriaRepository(ApiDemoContext context) : base(context)
        {
            _context = context;
        }
    }
}