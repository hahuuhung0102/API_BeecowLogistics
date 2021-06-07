using BeecowLogistics.Services.Commons;
using BeecowLogistics.Services.DTOs.Station;
using BeecowLogistics.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeecowLogistics.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : BaseController
    {
        private IStationService _stationService;

        public StationController(IStationService stationService)
        {
            _stationService = stationService;
        }

        [HttpGet("loadData")]
        [AllowAnonymous]
        public async Task<IActionResult> LoadData(string sidx, string sord, int page, int rows)
        {
            if (page < 1)
            {
                page = 1;
            }

            if (rows < 1)
            {
                rows = 10;
            }

            var data = await _stationService.PaginationAsync(new ParamaterPagination { page = page, pageSize = rows });
            return new OkObjectResult(new { total = data.TotalPages, page, records = data.TotalItems, rows = data.Result });
        }

        [HttpPost("insert")]
        [AllowAnonymous]
        public async Task<IActionResult> Insert(StationModel model)
        {
            return new JsonResult(await _stationService.AddAsync(model));
        }

        [HttpPost("update")]
        [AllowAnonymous]
        public async Task<IActionResult> Update(StationModel model)
        {
            return new JsonResult(await _stationService.UpdateAsync(model));
        }

        [HttpPost("delete")]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(Guid id)
        {
            return new JsonResult(await _stationService.DeleteAsync(id));
        }

        [HttpGet("get")]
        [AllowAnonymous]
        public async Task<IActionResult> Get(Guid id)
        {
            return new JsonResult(await _stationService.FindById(id));
        }

    }
}
