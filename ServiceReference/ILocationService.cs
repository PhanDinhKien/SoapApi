using SoapApi.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoapApi.ServiceReference
{
    public interface ILocationService
    {
        Task<List<LocationDto>> GetLocationsAsync();
    }
}
