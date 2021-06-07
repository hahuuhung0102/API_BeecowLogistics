using AutoMapper;
using BeecowLogistics.Services.Entities;
using BeecowLogistics.Services.Interfaces;

namespace BeecowLogistics.Services.Services
{
    public abstract class BaseService
    {
        protected readonly BeecowLogisticContext Context;
        protected readonly IMapper Mapper;
        protected readonly MapperConfiguration ConfigMapper;

        protected BaseService(IRepository repository, IMapper mapper, MapperConfiguration mapperConfiguration)
        {
            Context = repository.DbContext;
            Mapper = mapper;
            ConfigMapper = mapperConfiguration;
        }
    }
}
