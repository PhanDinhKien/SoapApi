using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoapApi.CirculationServiceReference;

namespace SoapApi.ServiceReference
{
    public interface ISoapApiService
    {
        CirculationServiceClient CallSoapApi();
    }
}