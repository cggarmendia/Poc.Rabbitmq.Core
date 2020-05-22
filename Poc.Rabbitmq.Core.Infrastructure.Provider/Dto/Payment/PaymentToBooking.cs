using System;
using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Payment
{
    public class PaymentToBookingDto
    {
        public decimal BalanceDue { get; set; }
        public string Signature { get; set; }
        public string CurrencyCode { get; set; }
        public string PaymentText { get; set; }
        public string AccountTransactionCode { get; set; }
        public string AccountNumber { get; set; }
        public PaymentMethodType PaymentMethodType { get; set; }
        public bool IsCreditFile { get; set; }
        public long AccountNumberId { get; set; }
        public string PaymentMethodCode { get; set; }
        public DateTime ExpirationDate { get; set; }
        public List<KeyValuePair<string,string>> PaymentFields { get; set; }
        public long ParentPaymentId { get; set; }

        public PaymentToBookingDto()
        {
            PaymentFields = new List<KeyValuePair<string, string>>();
            ParentPaymentId = 0;
            ExpirationDate = DateTime.MinValue;
            AccountNumberId = 0;
            PaymentMethodCode = string.Empty;
            AccountTransactionCode = string.Empty;
        }
    }
}
