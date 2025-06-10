// Controller phục vụ các API quản lý bạn đọc (Patron): đăng ký, cập nhật, tìm kiếm, loại hình, thông tin đào tạo, ...

using Microsoft.AspNetCore.Mvc;
using SoapApi.CirculationServiceReference;

namespace SoapApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatronController : ControllerBase
    {
        // Ví dụ: Lấy thông tin bạn đọc
        [HttpGet("{patronId}")]
        public IActionResult GetPatron(int patronId)
        {
            // TODO: Gọi CirculationServiceClient.GetPatronAsync
            return Ok();
        }
        [HttpGet("get-patron")]
        public IActionResult GetPatron() => throw new NotImplementedException();
        [HttpGet("get-patron-id")]
        public IActionResult GetPatronID() => throw new NotImplementedException();
        [HttpPost("insert-patron")]
        public IActionResult InsertPatron() => throw new NotImplementedException();
        [HttpPut("update-patron")]
        public IActionResult UpdatePatron() => throw new NotImplementedException();
        [HttpDelete("delete-patron")]
        public IActionResult DeletePatron() => throw new NotImplementedException();
        [HttpGet("get-patron-types")]
        public IActionResult GetPatronTypes() => throw new NotImplementedException();
        [HttpGet("get-patron-training-types")]
        public IActionResult GetPatronTrainingTypes() => throw new NotImplementedException();
        [HttpGet("get-patron-training-years")]
        public IActionResult GetPatronTrainingYears() => throw new NotImplementedException();
        [HttpGet("get-patron-training-classes")]
        public IActionResult GetPatronTrainingClasses() => throw new NotImplementedException();
        [HttpGet("get-patron-training-specializations")]
        public IActionResult GetPatronTrainingSpecializations() => throw new NotImplementedException();
        [HttpPut("update-patron-field-value")]
        public IActionResult UpdatePatronFieldValue() => throw new NotImplementedException();
        [HttpPut("update-patron-login-account")]
        public IActionResult UpdatePatronLogInAccount() => throw new NotImplementedException();
        [HttpPost("reset-patron-password")]
        public IActionResult ResetPatronPassword() => throw new NotImplementedException();
        [HttpGet("get-patron-search-count")]
        public IActionResult GetPatronSearchCount() => throw new NotImplementedException();
        [HttpGet("get-patron-search-page")]
        public IActionResult GetPatronSearchPage() => throw new NotImplementedException();
        [HttpGet("get-lookup-patrons")]
        public IActionResult GetLookupPatrons() => throw new NotImplementedException();
        // ... Thêm các API khác tương ứng các method quản lý bạn đọc ...
    }
}
