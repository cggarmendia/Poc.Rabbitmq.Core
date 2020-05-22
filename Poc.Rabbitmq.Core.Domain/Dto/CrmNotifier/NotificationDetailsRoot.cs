using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Domain.Dto.CrmNotifier
{
    public class NotificationDetailsRoot
    {
        public FlightToProcess NotificationDetails { get; set; }
    }

    public class FlightToProcess
    {
        public List<FlightProcessed> Flight { get; set; }
    }
}