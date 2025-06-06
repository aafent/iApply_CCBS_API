using Microsoft.AspNetCore.Mvc;

namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.EndOfDayTag)]
        public CbsExchangeRatesResponse exchangeRates([FromBody] CbsExchangeRatesRequest request)
        {
            throw new NotImplementedException();
        }

    }
}