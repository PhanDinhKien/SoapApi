using SoapApi.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoapApi.Service
{
    public interface ILocationService
    {
        Task<List<LocationDto>> GetLocationsAsync(string sBranchCode, string sLocationCode);
    }
}
