using SoapApi.Dtos;
using SoapApi.ServiceReference;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoapApi.Service
{
    public class LocationService : ILocationService
    {
        private readonly ISoapApiService _soapApiService;
        public LocationService(ISoapApiService soapApiService)
        {
            _soapApiService = soapApiService;
        }

        public async Task<List<LocationDto>> GetLocationsAsync()
        {
            var response = await _soapApiService.CallSoapApiAsync();
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
    }
}
