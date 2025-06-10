using Microsoft.Extensions.Configuration;
using SoapApi.CirculationServiceReference;
using SoapApi.Dtos;
using SoapApi.ServiceReference;
using System.ServiceModel;

namespace SoapApi.Service
{
    /// <summary>
    /// Service class to handle SOAP calls for Location-related operations.
    /// </summary>
    public class SoapApiService: ISoapApiService
    {
        private readonly IConfiguration _config;
        public SoapApiService(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// Calls the SOAP GetLocations API and returns the raw SOAP response.
        /// </summary>
        public CirculationServiceClient CallSoapApi()
        {
            var soapSettings = _config.GetSection("SoapSettings");
            var url = soapSettings["Url"];
            var username = soapSettings["Username"];
            var password = soapSettings["Password"];

            if (string.IsNullOrWhiteSpace(url) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new InvalidOperationException("Missing SOAP configuration. Please check SoapSettings:Url, Username, and Password in appsettings.json.");
            }

            var endpoint = new EndpointAddress(url);
            var client = new CirculationServiceClient(CirculationServiceClient.EndpointConfiguration.WSHttpBinding_ICirculationService, endpoint);
            client.ClientCredentials.UserName.UserName = username;
            client.ClientCredentials.UserName.Password = password;
            return client;
        }
    }
}
