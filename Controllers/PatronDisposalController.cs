using Microsoft.AspNetCore.Mvc;
using SoapApi.CirculationServiceReference;

namespace SoapApi.Controllers
{
    // Controller phục vụ các API xử lý vi phạm bạn đọc (Patron Disposal): kỷ luật, xử lý, tìm kiếm vi phạm, ...
    [ApiController]
    [Route("api/[controller]")]
    public class PatronDisposalController : ControllerBase
    {
        // Ví dụ: Thêm xử lý bạn đọc
        [HttpPost("insert-patron-disposal")]
        public IActionResult InsertPatronDisposal() => throw new NotImplementedException();
        [HttpPut("update-patron-disposal")]
        public IActionResult UpdatePatronDisposal() => throw new NotImplementedException();
        [HttpPut("reset-patron-disposal-status")]
        public IActionResult ResetPatronDisposalStatus() => throw new NotImplementedException();
        [HttpDelete("delete-patron-disposal")]
        public IActionResult DeletePatronDisposal() => throw new NotImplementedException();
        [HttpGet("get-patron-disposals")]
        public IActionResult GetPatronDisposals() => throw new NotImplementedException();
        [HttpGet("get-patron-disposal-details")]
        public IActionResult GetPatronDisposalDetails() => throw new NotImplementedException();
        [HttpPost("insert-update-patron-disposal-detail")]
        public IActionResult InsertUpdatePatronDisposalDetail() => throw new NotImplementedException();
        [HttpDelete("delete-patron-disposal-detail")]
        public IActionResult DeletePatronDisposalDetail() => throw new NotImplementedException();
        [HttpGet("search-disposal-patron")]
        public IActionResult SearchDisposalPatron() => throw new NotImplementedException();
        // ... Thêm các API khác tương ứng các method xử lý bạn đọc ...
    }
}
