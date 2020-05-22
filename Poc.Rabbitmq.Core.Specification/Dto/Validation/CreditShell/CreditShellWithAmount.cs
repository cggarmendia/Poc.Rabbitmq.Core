namespace Poc.Rabbitmq.Core.Specification.Dto.Validation.CreditShell
{
    public class CreditShellWithAmountDto
    {
        public decimal AvailableAmount { get; set; }
        public string CurrencyCode { get; set; }
        public decimal CrmPaymentAmount { get; set; }
        public string CrmCurrencyCode { get; set; }

    }

}
