using BeecowLogistics.Services.Entities;
using BeecowLogistics.Services.Interfaces;

namespace BeecowLogistics.Services.Services
{
    public class Repository : IRepository
    {
        private readonly BeecowLogisticsContext _context;

        public Repository(BeecowLogisticsContext context)
        {
            _context = context;
        }

        public BeecowLogisticsContext DbContext
        {
            get
            {
                return _context;
            }
        }
    }
}
