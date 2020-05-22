using System.Text.Json.Serialization;

namespace Poc.Rabbitmq.Core.Domain.Dto.CrmNotifier.Salesforce.Response
{
    public class SalesforceResponseInsertDto
    {
        [JsonPropertyName("result")]
        public bool Result { get; set; }
        [JsonPropertyName("bookingId")]
        public string BookingId { get; set; }
        [JsonPropertyName("recordLocator")]
        public string RecordLocator { get; set; }
        [JsonPropertyName("inventoryLegId")]
        public string InventoryLegId { get; set; }
        [JsonPropertyName("errorCode")]
        public string ErrorCode { get; set; }
        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }

    }
}
