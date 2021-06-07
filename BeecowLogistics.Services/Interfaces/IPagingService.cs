using BeecowLogistics.Services.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecowLogistics.Services.Interfaces
{
    public interface IPagingService<T> where T : class
    {
        Task<ProcessingResult> AddAsync(T model);
        Task<ProcessingResult> UpdateAsync(T model);
        Task<ProcessingResult> DeleteAsync(Guid id);
        Task<IList<T>> GetAllAsync();
        Task<T> FindById(Guid id);
        Task<Pager> PaginationAsync(ParamaterPagination paramater);
    }
}
