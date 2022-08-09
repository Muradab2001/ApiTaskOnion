using Onion.Application.Interfaces.Repositories;
using Onion.Domain.Entities;
using Onion.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Persistance.Repositories
{
    public class CategoryRepository:GenericRepository<Category>
    {
        private readonly OnionDbContext _context;

        public CategoryRepository(OnionDbContext context):base(context)
        {
            _context = context;
        }
    }
}
