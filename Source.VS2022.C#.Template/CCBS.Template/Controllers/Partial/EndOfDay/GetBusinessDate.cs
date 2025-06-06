using Microsoft.AspNetCore.Mvc;

namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.EndOfDayTag)]
        public CbsBusinessDate GetBusinessDate([FromBody] CbsGetBusinessDateRequest request)
        {
            throw new NotImplementedException();
        }

    }
}