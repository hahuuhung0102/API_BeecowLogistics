using BeecowLogistics.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecowLogistics.Services.Interfaces
{
    public interface IRepository
    {
        BeecowLogisticContext DbContext { get; }
    }
}
