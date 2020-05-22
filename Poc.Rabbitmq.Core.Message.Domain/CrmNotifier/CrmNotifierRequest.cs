using System;
using System.Collections.Generic;
using Poc.Rabbitmq.Core.Message.Domain.Common;

namespace Poc.Rabbitmq.Core.Message.Domain.CrmNotifier
{
    public class CrmNotifierRequest
    {
        public bool Result { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ProcessType { get; set; }
        public string ExternalId { get; set; }
        public string BookingId { get; set; }
        public string RecordLocator { get; set; }
        public string Email { get; set; }
        public string ContactFirstname { get; set; }
        public string ContactLastname { get; set; }
        public string CultureCode { get; set; }
        public decimal Amount { get; set; }
        public decimal OriginalAmount { get; set; }
        public string Currency { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string RefundType { get; set; }
        public decimal RefundValue { get; set; }
        public string RefundCurrencyCode { get; set; }
        public List<FlightProcessedRequest> FlightProcessedList { get; set; }
    }
}
