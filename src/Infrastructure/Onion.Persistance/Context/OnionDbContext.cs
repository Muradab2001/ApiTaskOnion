using Microsoft.EntityFrameworkCore;
using Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Persistance.Context
{
    public class OnionDbContext:DbContext
    {
        public OnionDbContext(DbContextOptions<OnionDbContext> opt):base(opt)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
