using Microsoft.Extensions.Configuration;
using SoapApi.CirculationServiceReference;
using SoapApi.Dtos;
using System.ServiceModel;

namespace SoapApi.Service
{
    /// <summary>
    /// Service class to handle SOAP calls for Location-related operations.
    /// </summary>
    public class LocationSoapService
    {
        private readonly IConfiguration _config;
        public LocationSoapService(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// Calls the SOAP GetLocations API and returns a list of LocationDto.
        /// </summary>
        public async Task<List<LocationDto>> GetLocationsAsync()
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
            var response = await client.GetLocationsAsync("", "");
            var result = response.GetLocationsResult;

            var locations = new List<LocationDto>();
            if (result != null)
            {
                foreach (var xElem in result.Nodes)
                {
                    var tables = xElem.Descendants("Table");
                    foreach (var table in tables)
                    {
                        var location = new LocationDto
                        {
                            LocationCode = table.Element("LOCATION_CODE")?.Value,
                            LocationDescription = table.Element("LOCATION_DESCRIPTION")?.Value,
                            BranchCode = table.Element("BRANCH_CODE")?.Value,
                            ItemBarcodePrefix = table.Element("ITEM_BARCODE_PREFIX")?.Value,
                            ItemLabelCode = table.Element("ITEM_LABEL_CODE")?.Value,
                            RecordAccessLevel = table.Element("RECORD_ACCESS_LEVEL") != null ? (short?)Convert.ToInt16(table.Element("RECORD_ACCESS_LEVEL")?.Value) : null,
                            RecordStatus = table.Element("RECORD_STATUS") != null ? (short?)Convert.ToInt16(table.Element("RECORD_STATUS")?.Value) : null,
                            RecordVersion = table.Element("RECORD_VERSION") != null ? (short?)Convert.ToInt16(table.Element("RECORD_VERSION")?.Value) : null,
                            RecordCreator = table.Element("RECORD_CREATOR")?.Value,
                            RecordCreatedDate = DateTime.TryParse(table.Element("RECORD_CREATED_DATE")?.Value, out var createdDate) ? (DateTime?)createdDate : null,
                            RecordModifier = table.Element("RECORD_MODIFIER")?.Value,
                            RecordModifiedDate = DateTime.TryParse(table.Element("RECORD_MODIFIED_DATE")?.Value, out var modifiedDate) ? (DateTime?)modifiedDate : null,
                            AllowCirculation = table.Element("ALLOW_CIRCULATION") != null ? bool.TryParse(table.Element("ALLOW_CIRCULATION")?.Value, out var allow) ? allow : (bool?)null : null
                        };
                        locations.Add(location);
                    }
                }
            }
            return locations;
        }

        /// <summary>
        /// Calls the SOAP GetLocations API and returns the raw SOAP response.
        /// </summary>
        public async Task<GetLocationsResponse> GetLocationsRawResponseAsync()
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
            var response = await client.GetLocationsAsync("", "");
            return response;
        }
    }
}
