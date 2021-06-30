using CommonBase.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNQuick.Contracts.Persistence
{
    [ContractInfo(ContextType = ContextType.Table)]
    public interface IBookLibrary : IVersionable, ICopyable<IBookLibrary>
    {
        [ContractPropertyInfo(Required = true, MaxLength = 10, IsUnique = true)]
        public string ISBN { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 100)]
        public string BookName { get; set; }

    }
}
