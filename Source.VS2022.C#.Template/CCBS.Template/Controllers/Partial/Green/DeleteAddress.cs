using Microsoft.AspNetCore.Mvc;


namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.GreenTag)]
        public CbsDeleteAdressResponse DeleteAddress(CbsDeleteAdressRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

