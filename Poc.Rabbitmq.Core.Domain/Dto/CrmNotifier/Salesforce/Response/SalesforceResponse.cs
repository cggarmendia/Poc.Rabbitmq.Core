namespace Poc.Rabbitmq.Core.Domain.Dto.CrmNotifier.Salesforce.Response
{
    public class SalesforceResponseDto
    {
        public bool Result { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
