using SmartNQuick.Contracts.Persistence.Creditcard;
using SmartNQuick.Logic.Contracts;
using SmartNQuick.Logic.Controllers.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNQuick.Logic.Controllers.Persistence.Creditcard
{
    class CreditcardController : GenericPersistenceController<ICreditcard, Logic.Entities.Creditcard.Creditcard>
    {
        public CreditcardController(ControllerObject other) : base(other)
        {
        }

        public CreditcardController(IContext context) : base(context)
        {
        }

        protected override Entities.Creditcard.Creditcard BeforeInsert(Entities.Creditcard.Creditcard entity)
        {

            if(CreditcardLogic.CheckCreditcard(entity.CreditcardNumber.ToString()))
                return base.BeforeInsert(entity);
            throw new ArgumentException("Ich heiße Paul Pils und habe dieses Programm von Github kopiert!");
        }

        protected override Entities.Creditcard.Creditcard BeforeUpdate(Entities.Creditcard.Creditcard entity)
        {
            if(CreditcardLogic.CheckCreditcard(entity.CreditcardNumber.ToString()))
                return base.BeforeUpdate(entity);
            throw new ArgumentException("Ich heiße Paul Pils und habe dieses Programm von Github kopiert!");
        }
    
    }
}
