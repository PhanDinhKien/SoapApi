using Microsoft.AspNetCore.Mvc;
using SoapApi.CirculationServiceReference;

namespace SoapApi.Controllers
{
    // Controller phục vụ các API kiểm kê tài liệu (Inventory): kiểm kê, thống kê, duyệt kho, ...
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        // Ví dụ: Lấy thông tin kiểm kê tài liệu
        [HttpGet("get-item-inventory")]
        public IActionResult GetItemInventory() => throw new NotImplementedException();

        [HttpGet("get-item-inventory-search-count")]
        public IActionResult GetItemInventorySearchCount() => throw new NotImplementedException();

        [HttpGet("get-item-inventory-search-page")]
        public IActionResult GetItemInventorySearchPage() => throw new NotImplementedException();

        [HttpGet("get-location-browse-search-count")]
        public IActionResult GetLocationBrowseSearchCount() => throw new NotImplementedException();

        [HttpGet("get-location-browse-search-page")]
        public IActionResult GetLocationBrowseSearchPage() => throw new NotImplementedException();

        // ... Thêm các API khác tương ứng các method kiểm kê tài liệu ...
    }
}
