using Microsoft.AspNetCore.Mvc;
using SoapApi.CirculationServiceReference;

// Controller phục vụ các API hệ thống (System): kiểm tra ngày làm việc, thời gian làm việc, ...
namespace SoapApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SystemController : ControllerBase
    {
        // Ví dụ: Kiểm tra ngày làm việc
        [HttpGet("is-working-day")]
        public IActionResult IsWorkingDay() => throw new NotImplementedException();
        [HttpGet("is-working-time")]
        public IActionResult IsWorkingTime() => throw new NotImplementedException();
        // ... Thêm các API khác tương ứng các method hệ thống ...
    }
}
