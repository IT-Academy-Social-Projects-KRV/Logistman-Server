using System.Threading.Tasks;
using AutoMapper;
using Core.DTO.PointDTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointController : ControllerBase
    {
        private readonly IPointService _pointService;
        public PointController(IPointService pointService)
        {
            _pointService = pointService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] PointCreateDTO pointCreate)
        {
            await _pointService.CreatePoint(pointCreate);
            return Ok(pointCreate);
        }
    }
}
