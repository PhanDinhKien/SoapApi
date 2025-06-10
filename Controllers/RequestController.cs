using Microsoft.AspNetCore.Mvc;
using SoapApi.CirculationServiceReference;

namespace SoapApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequestController : ControllerBase
    {
        // Controller phục vụ các API quản lý yêu cầu tài liệu (Request): đặt mượn, trạng thái yêu cầu, nhật ký yêu cầu, ...
        // Ví dụ: Lấy yêu cầu tài liệu theo bạn đọc
        [HttpGet("bypatron/{patronId}")]
        public IActionResult GetItemRequestByPatron(int patronId)
        {
            // TODO: Gọi CirculationServiceClient.GetItemRequestByPatronAsync
            return Ok();
        }
        [HttpGet("get-item-request-by-patron")]
        public IActionResult GetItemRequestByPatron() => throw new NotImplementedException();
        [HttpGet("get-item-request-by-dmd")]
        public IActionResult GetItemRequestByDmd() => throw new NotImplementedException();
        [HttpGet("get-dmd-requestable-items")]
        public IActionResult GetDmdRequestableItems() => throw new NotImplementedException();
        [HttpPut("update-item-request-librarian-note")]
        public IActionResult UpdateItemRequestLibrarianNote() => throw new NotImplementedException();
        [HttpPut("update-item-request-pending")]
        public IActionResult UpdateItemRequestPending() => throw new NotImplementedException();
        [HttpPut("upadate-item-request-refuse")]
        public IActionResult UpadateItemRequestRefuse() => throw new NotImplementedException();
        [HttpPut("update-item-request-shipped")]
        public IActionResult UpdateItemRequestShipped() => throw new NotImplementedException();
        [HttpPut("update-item-request-arrived")]
        public IActionResult UpdateItemRequestArrived() => throw new NotImplementedException();
        [HttpGet("get-item-request-search-count")]
        public IActionResult GetItemRequestSearchCount() => throw new NotImplementedException();
        [HttpGet("get-item-request-search-page")]
        public IActionResult GetItemRequestSearchPage() => throw new NotImplementedException();
        [HttpGet("get-item-request-log-on-loan")]
        public IActionResult GetItemRequestLogOnLoan() => throw new NotImplementedException();
        [HttpGet("get-item-request-log-on-loan-search-page")]
        public IActionResult GetItemRequestLogOnLoanSearchPage() => throw new NotImplementedException();
        [HttpGet("get-item-request-log-on-loan-search-count")]
        public IActionResult GetItemRequestLogOnLoanSearchCount() => throw new NotImplementedException();
        [HttpGet("get-item-request-log-search-page")]
        public IActionResult GetItemRequestLogSearchPage() => throw new NotImplementedException();
        [HttpGet("get-item-request-log-search-count")]
        public IActionResult GetItemRequestLogSearchCount() => throw new NotImplementedException();
        [HttpGet("get-last-item-request-log-shipping-address-by-circulation-ids")]
        public IActionResult GetLastItemRequestLogShippingAddressByCirculationIds() => throw new NotImplementedException();
        // ... Thêm các API khác tương ứng các method quản lý yêu cầu tài liệu ...
    }
}
