using BeecowLogistics.Services.Entities;
using BeecowLogistics.Services.Interfaces;

namespace BeecowLogistics.Services.Services
{
    public class Repository : IRepository
    {
        private readonly BeecowLogisticContext _context;

        public Repository(BeecowLogisticContext context)
        {
            _context = context;
        }

        public BeecowLogisticContext DbContext
        {
            get
            {
                return _context;
            }
        }
    }
}
