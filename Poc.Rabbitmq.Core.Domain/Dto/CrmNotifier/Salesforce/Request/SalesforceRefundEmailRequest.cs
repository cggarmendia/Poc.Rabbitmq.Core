using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Domain.Dto.CrmNotifier.Salesforce.Request
{
    public class SalesforceRefundEmailRequestDto : SalesforceRequestDto
    {
        public string TemplateCode { get; set; }
        public string CarrierCode { get; set; }
        public string ContactEmail { get; set; }
        public string ContactFirstname { get; set; }
        public string ContactLastname { get; set; }
        public string ContactLocale { get; set; }
        public Dictionary<string,string> Attributes { get; set; }
    }
}