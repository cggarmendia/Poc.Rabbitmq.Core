using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Common
{
    public class PassengerDto
    {
        public List<PassengerFeeDto> PassengerFees { get; set; }
        public short PassengerNumber { get; set; }
    }
}
