using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Domain.Dto.CrmNotifier
{
    public class PostRequestDto
    {
        public string Url { get; set; }
        public string RequestData { get; set; }
        public KeyValuePair<string, string> TokenValue { get; set; }
    }
}
