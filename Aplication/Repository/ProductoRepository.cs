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
    public class ProductoRepository : GenericRepository<Producto>, IProductoRepository
    {
        private readonly ApiDemoContext _context;
        public ProductoRepository(ApiDemoContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Producto>> GetProductosMasCaros(int cantidad)=>
                            await _context.Productos
                                .OrderByDescending(p=>p.Precio)
                                .Take(cantidad)
                                .ToListAsync();

        public override async Task<Producto> GetByIdAsync(int id)
        {
            return await _context.Productos
                            .Include(p=>p.Marca)
                            .Include(p=>p.Categoria)
                            .FirstOrDefaultAsync(p=> p.Id ==id);
        }
        public override async Task<IEnumerable<Producto>> GetAllAsync()
        {
            return await _context.Productos
                            .Include(u => u.Marca)
                            .Include(u=>u.Categoria)
                            .ToListAsync();
        }
    }

}