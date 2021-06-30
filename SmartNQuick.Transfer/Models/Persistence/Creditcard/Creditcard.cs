using CommonBase.Extensions;
using SmartNQuick.Contracts.Persistence.Creditcard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNQuick.Transfer.Models.Persistence.Creditcard
{
    public partial class Creditcard : VersionModel, Contracts.Persistence.Creditcard.ICreditcard
    {
        public long CreditcardNumber { get; set; }

        public void CopyProperties(ICreditcard other)
        {
            other.CheckArgument(nameof(other));

            Id = other.Id;
            RowVersion = other.RowVersion;
            CreditcardNumber = other.CreditcardNumber;
        }
    }
}
