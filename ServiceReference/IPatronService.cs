using System.Threading.Tasks;

namespace SoapApi.ServiceReference
{
    public interface IPatronService
    {
        Task<object?> GetPatronAsync(int patronId);
        Task<int> InsertPatronAsync(SoapApi.Dtos.InsertPatronDto dto);
        Task<object?> GetPatronSearchPageAsync(int pageNumber, int pageSize);
        // Thêm các method khác như UpdatePatronAsync, ...
    }
}
