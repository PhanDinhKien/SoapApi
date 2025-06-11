using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SoapApi.CirculationServiceReference;
using SoapApi.Service;
using SoapApi.ServiceReference;
using System.ServiceModel;

namespace SoapApi.Controllers
{
    // Controller phục vụ các API quản lý kho, kệ, chi nhánh thư viện (Location, Branch, Shelf)
    // Cho phép lấy danh sách chi nhánh, kho, kệ, ...
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly SoapApi.ServiceReference.ILocationService _locationService;
        public LocationController(IConfiguration config, SoapApi.ServiceReference.ILocationService locationService)
        {
            _config = config;
            _locationService = locationService;
        }

        // Ví dụ: Lấy danh sách chi nhánh
        [HttpGet("get-branches")]
        public IActionResult GetBranches() => throw new NotImplementedException();
        
        /// <summary>
        /// Lấy danh sách vị trí (location) theo chi nhánh và mã vị trí.
        /// </summary>
        /// <param name="sBranchCode">Mã chi nhánh (có thể để trống)</param>
        /// <param name="sLocationCode">Mã vị trí (có thể để trống)</param>
        /// <returns>Danh sách LocationDto</returns>
        /// <response code="200">Trả về danh sách các vị trí (LocationDto)</response>
        /// <response code="400">Yêu cầu không hợp lệ (InvalidOperationException)</response>
        /// <response code="500">Lỗi máy chủ nội bộ</response>
        /// [HttpGet("get-locations")]
        public async Task<ActionResult<List<Dtos.LocationDto>>> GetLocationsAsync([FromQuery] string? sBranchCode, [FromQuery] string? sLocationCode)
        {
            try
            {
                var locations = await _locationService.GetLocationsAsync(sBranchCode ?? string.Empty, sLocationCode ?? string.Empty);
                return Ok(locations);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        
        [HttpGet("get-location-shelfs")]
        public IActionResult GetLocationShelfs() => throw new NotImplementedException();
        // ... Thêm các API khác tương ứng các method kho, kệ, chi nhánh ...
    }
}
