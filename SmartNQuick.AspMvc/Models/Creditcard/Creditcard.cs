using CommonBase.Extensions;
using SmartNQuick.Contracts.Persistence.Creditcard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartNQuick.AspMvc.Models.Creditcard
{
    public class Creditcard : VersionModel, ICreditcard
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
