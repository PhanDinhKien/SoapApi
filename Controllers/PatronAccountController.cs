// Controller phục vụ các API quản lý tài khoản, phí, phạt của bạn đọc (Patron Account): truy vấn, thanh toán, xóa, ...

using Microsoft.AspNetCore.Mvc;
using SoapApi.CirculationServiceReference;

namespace SoapApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatronAccountController : ControllerBase
    {
        // Ví dụ: Lấy các khoản phí của bạn đọc
        [HttpGet("entries/{patronId}")]
        public IActionResult GetPatronAccountEntries(int patronId)
        {
            // TODO: Gọi CirculationServiceClient.GetPatronAccountEntriesAsync
            return Ok();
        }
        [HttpGet("get-patron-account-entries")]
        public IActionResult GetPatronAccountEntries() => throw new NotImplementedException();
        [HttpPost("insert-patron-account-entry")]
        public IActionResult InsertPatronAccountEntry() => throw new NotImplementedException();
        [HttpPost("pay-patron-account")]
        public IActionResult PayPatronAccount() => throw new NotImplementedException();
        [HttpPost("dismiss-patron-account")]
        public IActionResult DismissPatronAccount() => throw new NotImplementedException();
        [HttpPost("clear-patron-account")]
        public IActionResult ClearPatronAccount() => throw new NotImplementedException();
        // ... Thêm các API khác tương ứng các method tài khoản/phí bạn đọc ...
    }
}
