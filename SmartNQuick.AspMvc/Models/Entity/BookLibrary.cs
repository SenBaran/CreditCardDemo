using CommonBase.Extensions;
using SmartNQuick.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartNQuick.AspMvc.Models.Entity
{
    public class BookLibrary : VersionModel,IBookLibrary
    {
        public string ISBN { get; set; }
        public string BookName { get; set; }

        public void CopyProperties(IBookLibrary other)
        {
            other.CheckArgument(nameof(other));

            RowVersion = other.RowVersion;
            Id = other.Id;
            ISBN = other.ISBN;
            BookName = other.BookName;
        }
    }
}
