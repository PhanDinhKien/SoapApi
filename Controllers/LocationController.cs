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
        [HttpGet("get-locations")]
        public async Task<ActionResult<List<Dtos.LocationDto>>> GetLocationsAsync()
        {
            try
            {
                var locations = await _locationService.GetLocationsAsync();
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
