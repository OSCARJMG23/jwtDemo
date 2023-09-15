using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Categoria : BaseEntity
    {
        public string Nombre { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
}