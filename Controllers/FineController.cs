// Controller phục vụ các API quản lý phí phạt (Fine): loại phí, phí của bạn đọc, ...

using Microsoft.AspNetCore.Mvc;
using SoapApi.CirculationServiceReference;

namespace SoapApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FineController : ControllerBase
    {
        // Ví dụ: Lấy loại phí phạt
        [HttpGet("get-fine-type")]
        public IActionResult GetFineType() => throw new NotImplementedException();

        [HttpGet("get-patron-fine-types")]
        public IActionResult GetPatronFineTypes() => throw new NotImplementedException();

        // ... Thêm các API khác tương ứng các method phí phạt ...
    }
}
