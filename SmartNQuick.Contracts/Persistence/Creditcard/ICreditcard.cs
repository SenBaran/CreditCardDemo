using CommonBase.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNQuick.Contracts.Persistence.Creditcard
{
    [ContractInfo(ContextType = ContextType.Table)]
    public partial interface ICreditcard : IVersionable, ICopyable<ICreditcard>
    {
        [ContractPropertyInfo(Required = true, IsUnique = true)]
        long CreditcardNumber { get; set; }
    }
}
