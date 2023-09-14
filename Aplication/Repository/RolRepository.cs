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
    public class RolRepository : GenericRepository<Rol>, IRolRepository
    {
        private readonly ApiDemoContext _context;

        public RolRepository(ApiDemoContext context) : base(context)
        {
            _context = context;
        }
    }
}