using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecowLogistics.Services.Entities
{
    public class BeecowLogisticsDbContext : DbContext
    {

        public BeecowLogisticsDbContext(DbContextOptions<BeecowLogisticsDbContext> options) : base(options)
        {
            this.Database.Migrate();
        }

        public virtual DbSet<T> Repository<T>() where T : class
        {
            return Set<T>();
        }

        public int SaveChangesWithoutUpdateProperty()
        {
            return base.SaveChanges();
        }

        public virtual async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        public DbSet<Users> Users { get; set; }

    }
}
