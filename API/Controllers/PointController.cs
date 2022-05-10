using Core.DTO.PointDTO;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize]
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
            return Ok(await _pointService.CreatePointAsync(pointCreate));
        }
    }
}
