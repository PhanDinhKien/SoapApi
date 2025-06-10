// Controller phục vụ các API lưu thông tài liệu (Circulation): mượn, trả, gia hạn, truy vấn lưu thông, ...
using Microsoft.AspNetCore.Mvc;
using SoapApi.CirculationServiceReference;

namespace SoapApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CirculationController : ControllerBase
    {
        // Ví dụ: Mượn tài liệu
        [HttpPost("check-out-item")]
        public IActionResult CheckOutItem() => throw new NotImplementedException();
        [HttpPost("check-in-item")]
        public IActionResult CheckInItem() => throw new NotImplementedException();
        [HttpPost("renew-item-circulation")]
        public IActionResult RenewItemCirculation() => throw new NotImplementedException();
        [HttpPost("import-item-circulaton-data")]
        public IActionResult ImportItemCirculatonData() => throw new NotImplementedException();
        [HttpGet("get-item-circulations")]
        public IActionResult GetItemCirculations() => throw new NotImplementedException();
        [HttpGet("get-patron-loan-items")]
        public IActionResult GetPatronLoanItems() => throw new NotImplementedException();
        [HttpGet("get-check-in-by-patron-items")]
        public IActionResult GetCheckInByPatronItems() => throw new NotImplementedException();
        [HttpGet("get-item-loan-policy")]
        public IActionResult GetItemLoanPolicy() => throw new NotImplementedException();
        [HttpGet("get-patron-check-out-params")]
        public IActionResult GetPatronCheckOutParams() => throw new NotImplementedException();
        [HttpGet("get-item-check-out-params")]
        public IActionResult GetItemCheckOutParams() => throw new NotImplementedException();
        // ... Thêm các API khác tương ứng các method lưu thông tài liệu ...
    }
}
