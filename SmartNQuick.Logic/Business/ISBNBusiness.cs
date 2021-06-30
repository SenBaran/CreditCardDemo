using SmartNQuick.Contracts.Persistence;
using SmartNQuick.Logic.Controllers.Persistence;
using SmartNQuick.Logic.Entities.BookLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNQuick.Logic.Business
{
    public static class ISBNBusiness
    {
        public static bool validateISBN(string ISBN)
        {
            if(ISBN != null && ISBN.Length == 10 && int.TryParse(ISBN, out int intISBN))
            {
                return true;
            }

            return false;
        }
    }
}
