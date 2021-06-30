using SmartNQuick.Contracts.Persistence;
using SmartNQuick.Logic.Contracts;
using SmartNQuick.Logic.Controllers.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNQuick.Logic.Controllers.BookLibrary
{

    class BookLibraryController : GenericPersistenceController<IBookLibrary, Logic.Entities.BookLibrary.BookLibrary>
    {
        public BookLibraryController(IContext context) : base(context)
        {

        }

        public BookLibraryController(ControllerObject other) : base(other)
        {
        }

        protected override Entities.BookLibrary.BookLibrary BeforeInsert(Entities.BookLibrary.BookLibrary entity)
        {
            if (Logic.Business.ISBNBusiness.validateISBN(entity.ISBN))
            {
                return base.BeforeInsert(entity);
            }

            throw new Exception("Falsche ISBN Nummer ");

        }

        protected override Entities.BookLibrary.BookLibrary BeforeUpdate(Entities.BookLibrary.BookLibrary entity)
        {
            if (Logic.Business.ISBNBusiness.validateISBN(entity.ISBN))
            {
                return base.BeforeUpdate(entity);
            }

            throw new Exception("Falsche ISBN Nummer ");
        }
    }
}
