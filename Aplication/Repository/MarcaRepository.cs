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
    public class MarcaRepository : GenericRepository<Marca>, IMarcaRepository
    {
        private readonly ApiDemoContext _context;
        public MarcaRepository(ApiDemoContext context) : base(context)
        {
            _context = context;
        }
    }
}