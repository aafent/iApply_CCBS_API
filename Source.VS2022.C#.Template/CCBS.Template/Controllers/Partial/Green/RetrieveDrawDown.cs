using Microsoft.AspNetCore.Mvc;


namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.GreenTag)]
        public CbsRetrieveDrawDownResponse RetrieveDrawDown(CbsRetrieveDrawDownRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

