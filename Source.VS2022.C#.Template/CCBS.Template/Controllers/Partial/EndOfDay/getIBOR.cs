using Microsoft.AspNetCore.Mvc;

namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.EndOfDayTag)]
        public CbsIborResponse getIBOR([FromBody] CbsIborRequest request)
        {
            throw new NotImplementedException();
        }

    }
}