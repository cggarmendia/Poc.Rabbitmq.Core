using System.Collections.Generic;

namespace Poc.Rabbitmq.Core.Specification.Dto.Validation.CreditShell
{
    public class CreditShellUsedDto
    {

        public string Pnr { get; set; }
        public IEnumerable<string> References { get; set; }
    }
}
