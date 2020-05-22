using System;
using System.Collections.Generic;
using Navitaire.NewSkies.Booking.Contract;
using Navitaire.NewSkies.Common.Enumerations;

namespace Poc.Rabbitmq.Core.Domain.Dto.Infrastructure.Payment
{
    public class PaymentToBookingParam
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
        public List<PaymentField> PaymentFields { get; set; }
        public long ParentPaymentId { get; set; }

        public PaymentToBookingParam()
        {
            PaymentFields = new List<PaymentField>();
            ParentPaymentId = 0;
            ExpirationDate = DateTime.MinValue;
            AccountNumberId = 0;
            PaymentMethodCode = string.Empty;
            AccountTransactionCode = string.Empty;
        }
    }
}

