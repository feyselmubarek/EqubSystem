using Equb_System.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equb_System.Utilites
{
    class EqubDbContext : DbContext
    {
        public DbSet<Account> Account { get; set; }
    }
}
