using Microsoft.AspNetCore.Mvc;
using SoapApi.CirculationServiceReference;

namespace SoapApi.Controllers
{
    // Controller phục vụ các API quản lý tài liệu (Item): thêm, sửa, xóa, phân loại, kiểm kê, barcode, ...
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        // Ví dụ: Lấy thông tin tài liệu
        [HttpGet("{itemId}")]
        public IActionResult GetItem(int itemId)
        {
            // TODO: Gọi CirculationServiceClient.GetItemAsync
            return Ok();
        }
        [HttpGet("get-item")]
        public IActionResult GetItem() => throw new NotImplementedException();
        [HttpPost("insert-item")]
        public IActionResult InsertItem() => throw new NotImplementedException();
        [HttpPut("update-item")]
        public IActionResult UpdateItem() => throw new NotImplementedException();
        [HttpDelete("delete-item")]
        public IActionResult DeleteItem() => throw new NotImplementedException();
        [HttpGet("get-item-classes")]
        public IActionResult GetItemClasses() => throw new NotImplementedException();
        [HttpGet("get-inventory-item")]
        public IActionResult GetInventoryItem() => throw new NotImplementedException();
        [HttpPut("update-item-field-value")]
        public IActionResult UpdateItemFieldValue() => throw new NotImplementedException();
        [HttpGet("get-dmd-item-count")]
        public IActionResult GetDmdItemCount() => throw new NotImplementedException();
        [HttpGet("get-dmd-item-page")]
        public IActionResult GetDmdItemPage() => throw new NotImplementedException();
        [HttpGet("get-dmd-items-statistic")]
        public IActionResult GetDmdItemsStatistic() => throw new NotImplementedException();
        [HttpGet("get-next-item-barcode")]
        public IActionResult GetNextItemBarcode() => throw new NotImplementedException();
        [HttpGet("get-item-max-barcode")]
        public IActionResult GetItemMaxBarcode() => throw new NotImplementedException();
        [HttpPost("lock-barcode-or-prefix")]
        public IActionResult LockBarcodeOrPrefix() => throw new NotImplementedException();
        [HttpPost("unlock-barcode-or-prefix")]
        public IActionResult UnlockBarcodeOrPrefix() => throw new NotImplementedException();
        [HttpGet("is-locked-barcode-or-prefix")]
        public IActionResult IsLockedBarcodeOrPrefix() => throw new NotImplementedException();
        // ... Thêm các API khác tương ứng các method quản lý tài liệu ...
    }
}
