using Microsoft.AspNetCore.Mvc;
using SoapApi.CirculationServiceReference;

// Controller phục vụ các API quản lý ghi chú bạn đọc (Patron Note): thêm, sửa, xóa, kích hoạt ghi chú
namespace SoapApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatronNoteController : ControllerBase
    {
        // Ví dụ: Thêm ghi chú bạn đọc
        [HttpPost("insert-patron-note")]
        public IActionResult InsertPatronNote() => throw new NotImplementedException();
        [HttpPut("set-active-patron-note")]
        public IActionResult SetActivePatronNote() => throw new NotImplementedException();
        [HttpDelete("delete-patron-note")]
        public IActionResult DeletePatronNote() => throw new NotImplementedException();
        [HttpGet("get-patron-notes")]
        public IActionResult GetPatronNotes() => throw new NotImplementedException();
        // ... Thêm các API khác tương ứng các method ghi chú bạn đọc ...
    }
}
