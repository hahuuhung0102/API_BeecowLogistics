using AutoMapper;
using AutoMapper.Configuration;
using AutoMapper.QueryableExtensions;
using BeecowLogistics.Services.Commons;
using BeecowLogistics.Services.DTOs.Station;
using BeecowLogistics.Services.Entities;
using BeecowLogistics.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecowLogistics.Services.Services
{
    public class StationService: BaseService, IStationService
    {
        private ProcessingResult processingResult;
        private readonly MapperConfiguration _configMapper;

        public StationService(
            IRepository repository,
            IMapper mapper,
            MapperConfiguration configMapper) : base(repository, mapper, configMapper)
        {
        }

        public async Task<ProcessingResult> AddAsync(StationModel model)
        {
            try
            {
                model.CreatedUser = "";
                model.CreatedTime = DateTime.Now;
                model.LastSavedUser = "";
                model.LastSavedTime = DateTime.Now;
                model.IsActive = true;

                var item = Mapper.Map<Station>(model);

                //Will remove after complete
                item.StationTypeId = null;

                Context.Stations.Add(item);
                await Context.SaveChangesAsync();

                processingResult = new ProcessingResult() { MessageType = MessageTypeEnum.Success, Message = MessageEnum.SuccessInsert, Success = true, Data = item };
            }
            catch (Exception ex)
            {
                processingResult = new ProcessingResult() { MessageType = MessageTypeEnum.Danger, Message = ex.Message, Success = false };
            }

            return processingResult;
        }

        public async Task<ProcessingResult> DeleteAsync(Guid id)
        {
            try
            {
                var item = await Context.Stations.FirstOrDefaultAsync(x => x.Id == id);
                if (item != null)
                {
                    item.IsActive = false;
                }

                await Context.SaveChangesAsync();

                processingResult = new ProcessingResult() { MessageType = MessageTypeEnum.Success, Message = MessageEnum.SuccessDelete, Success = true, Data = item };
            }
            catch (Exception ex)
            {
                processingResult = new ProcessingResult() { MessageType = MessageTypeEnum.Danger, Message = ex.Message, Success = false };
            }

            return processingResult;
        }

        public async Task<StationModel> FindById(Guid id)
        {
            var item = await Context.Stations.FirstOrDefaultAsync(x => x.Id == id);
            if (item != null)
            {
                return Mapper.Map<StationModel>(item);
            }

            return null;
        }

        public Task<IList<StationModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Pager> PaginationAsync(ParamaterPagination paramater)
        {
            var result = new List<StationModel>();
            var stations = await Context.Stations.ProjectTo<StationModel>(ConfigMapper).ToListAsync();

            return stations.ToPagination(paramater.page , paramater.pageSize);
        }

        public async Task<ProcessingResult> UpdateAsync(StationModel model)
        {
            try
            {
                model.LastSavedUser = "";
                model.LastSavedTime = DateTime.Now;

                var item = Mapper.Map<Station>(model);

                Context.Stations.Update(item);
                await Context.SaveChangesAsync();

                processingResult = new ProcessingResult() { MessageType = MessageTypeEnum.Success, Message = MessageEnum.SuccessDelete, Success = true, Data = item };
            }
            catch (Exception ex)
            {
                processingResult = new ProcessingResult() { MessageType = MessageTypeEnum.Danger, Message = ex.Message, Success = false };
            }

            return processingResult;
        }
    }
}
