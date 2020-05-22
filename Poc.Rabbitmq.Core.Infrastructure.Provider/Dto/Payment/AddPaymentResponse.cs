using System.Collections.Generic;
using Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Common;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Payment
{
    public class AddPaymentResponseDto
    {
        public BookingDto BookingDelta { get; set; }
        public List<KeyValuePair<string, string>> PaymentValidations { get; set; }
        public string SessionId { get; set; }
        public bool WaiveFee { get; set; }
        public PaymentDto Payment { get; set; }
    }
}
