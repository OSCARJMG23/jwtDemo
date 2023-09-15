using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;

namespace Dominio.Interfaces
{
    public interface IProductoRepository : IGenericRepository<Producto>
    {
        Task<IEnumerable<Producto>> GetProductosMasCaros(int cantidad);
    }
}