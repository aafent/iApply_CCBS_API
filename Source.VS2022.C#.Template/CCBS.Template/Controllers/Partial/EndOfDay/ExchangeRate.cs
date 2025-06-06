using Microsoft.AspNetCore.Mvc;

namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.EndOfDayTag)]
        public CbsExchangeRatesResponse exchangeRate([FromBody] CbsExchangeRateRequest request)
        {
            throw new NotImplementedException();
        }


    }
}