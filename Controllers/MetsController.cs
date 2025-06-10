using Microsoft.AspNetCore.Mvc;
using SoapApi.CirculationServiceReference;

// Controller phục vụ các API lưu thông METS (METS circulation): quản lý lưu thông tài liệu số, file METS, ...
namespace SoapApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MetsController : ControllerBase
    {
        // Ví dụ: Lấy thông tin lưu thông METS
        [HttpGet("circulation/{patronId}")]
        public IActionResult GetMetsCirculation(int patronId)
        {
            // TODO: Gọi CirculationServiceClient.GetMetsCirculationAsync
            return Ok();
        }

        [HttpGet("get-mets-circulation")]
        public IActionResult GetMetsCirculation() => throw new NotImplementedException();
        [HttpGet("get-mets-circulation-log")]
        public IActionResult GetMetsCirculationLog() => throw new NotImplementedException();
        [HttpGet("get-mets-file-circulation")]
        public IActionResult GetMetsFileCirculation() => throw new NotImplementedException();
        [HttpGet("get-mets-file-circulation-log")]
        public IActionResult GetMetsFileCirculationLog() => throw new NotImplementedException();
        // ... Thêm các API khác tương ứng các method METS ...
    }
}
