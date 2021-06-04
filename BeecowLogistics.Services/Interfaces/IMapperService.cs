using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecowLogistics.Services.Interfaces
{
    public interface IMapperService
    {
        TDestination ConvertTo<TSource, TDestination>(TSource source);
    }
}
