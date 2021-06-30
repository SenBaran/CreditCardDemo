using Microsoft.AspNetCore.Mvc;
using SmartNQuick.Contracts.Persistence.Creditcard;

namespace SmartNQuick.WebApi.Controllers.Persistence.Creditcard
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditcardController : GenericController<ICreditcard, Transfer.Models.Persistence.Creditcard.Creditcard>
    {

    }
}
