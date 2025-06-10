using Microsoft.AspNetCore.Mvc;
using SoapApi.CirculationServiceReference;

// Controller phục vụ các API nhật ký thao tác (Audit Trail): truy vấn, thống kê các thao tác trên hệ thống
namespace SoapApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuditController : ControllerBase
    {
        // Lấy nhật ký thao tác (phân trang)
        [HttpGet("search")]
        public async Task<IActionResult> GetAuditTrailSearchPage(
            [FromQuery] int iPostType,
            [FromQuery] string? sFromDate,
            [FromQuery] string? sToDate,
            [FromQuery] int iPage,
            [FromQuery] int iPageSize,
            [FromQuery] string? sPatronBarcode = null,
            [FromQuery] string? sLibrarian = null,
            [FromQuery] int? iFineType = null
        )
        {
            var client = new CirculationServiceClient();
            var result = await client.GetAuditTrailSearchPageAsync(
                sPatronBarcode,
                sLibrarian,
                iFineType ?? 0,
                iPostType,
                sFromDate,
                sToDate,
                iPage,
                iPageSize
            );
            return Ok(result);
        }

        // Lấy tổng số bản ghi nhật ký thao tác
        [HttpGet("count")]
        public async Task<IActionResult> GetAuditTrailSeachCount(
            [FromQuery] int iPostType,
            [FromQuery] string? sFromDate,
            [FromQuery] string? sToDate,
            [FromQuery] string? sPatronBarcode = null,
            [FromQuery] string? sLibrarian = null,
            [FromQuery] int? iFineType = null
        )
        {
            var client = new CirculationServiceClient();
            var result = await client.GetAuditTrailSeachCountAsync(
                sPatronBarcode,
                sLibrarian,
                iFineType ?? 0,
                iPostType,
                sFromDate,
                sToDate
            );
            return Ok(result);
        }
    }
}
