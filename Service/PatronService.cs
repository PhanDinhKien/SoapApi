using System.Threading.Tasks;
using SoapApi.CirculationServiceReference;

namespace SoapApi.Service
{
    public class PatronService : SoapApi.ServiceReference.IPatronService
    {
        private readonly SoapApi.ServiceReference.ISoapApiService _soapApiService;
        public PatronService(SoapApi.ServiceReference.ISoapApiService soapApiService)
        {
            _soapApiService = soapApiService;
        }

        public async Task<object?> GetPatronAsync(int patronId)
        {
            var client = _soapApiService.CallSoapApi();
            // TODO: Gọi client.GetPatronAsync và xử lý kết quả
            return await Task.FromResult<object?>(null);
        }

        public async Task<int> InsertPatronAsync(Dtos.InsertPatronDto dto)
        {
            var client = _soapApiService.CallSoapApi();
            var response = await client.InsertPatronAsync(
                dto.Barcode,
                dto.AlternateCode,
                dto.TypeCode,
                dto.FirstName,
                dto.LastName,
                dto.ImageUrl,
                dto.Gender,
                dto.DateOfBirth,
                dto.TrainingYear,
                dto.TrainingClass,
                dto.TrainingType,
                dto.TrainingSpecialization,
                dto.Address1,
                dto.Address2,
                dto.Email,
                dto.Phone,
                dto.MemberDate,
                dto.ExpireDate,
                dto.Remark,
                dto.AlertMessage,
                dto.StatusCode,
                dto.RecordStatus
            );
            return response.InsertPatronResult;
        }

        public async Task<object?> GetPatronSearchPageAsync(int pageNumber, int pageSize)
        {
            var client = _soapApiService.CallSoapApi();
            // Gọi với các tham số tìm kiếm mặc định (rỗng), chỉ phân trang
            var response = await client.GetPatronSearchPageAsync(
                string.Empty, // sSearchField1
                string.Empty, // sSearchValue1
                string.Empty, // sSearchField2
                string.Empty, // sSearchValue2
                string.Empty, // sGender
                string.Empty, // sTypeCode
                string.Empty, // sMemberDateFrom
                string.Empty, // sMemberDateTo
                string.Empty, // sExpireDateFrom
                string.Empty, // sExpireDateTo
                0,            // iLoginAccountStatus
                string.Empty, // sSortOrderBy
                pageNumber,   // iPage
                pageSize      // iPageSize
            );
            return response.GetPatronSearchPageResult;
        }
        // Thêm các method khác ở đây
    }
}
