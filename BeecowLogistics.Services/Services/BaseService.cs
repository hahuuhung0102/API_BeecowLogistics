using AutoMapper;
using BeecowLogistics.Services.Entities;
using BeecowLogistics.Services.Interfaces;

namespace BeecowLogistics.Services.Services
{
    public abstract class BaseService
    {
        protected readonly BeecowLogisticsDbContext Context;

        protected readonly IMapperService MapperService;
        protected BaseService(IRepository repository, IMapperService mapperService)
        {
            Context = repository.DbContext;
            this.MapperService = mapperService;
        }
    }
}
