using BeecowLogistics.Services.Entities;
using BeecowLogistics.Services.Interfaces;

namespace BeecowLogistics.Services.Services
{
    public class Repository : IRepository
    {
        private readonly BeecowLogisticsDbContext _context;

        public Repository(BeecowLogisticsDbContext context)
        {
            _context = context;
        }

        public BeecowLogisticsDbContext DbContext
        {
            get
            {
                return _context;
            }
        }
    }
}
