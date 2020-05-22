using System;
using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Infrastructure.Provider.Dto.Common
{
    public class SegmentDto
    {
        public DateTime STD { get; set; }
        public List<PassengerSsrDto> PassengerSsrs { get; set; }
    }
}
