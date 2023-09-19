using iApplyShared.CbsModels;
using Microsoft.AspNetCore.Mvc;

namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.CustomerTag)]
        public CbsGetLegalCustomerResponse GetLegalCustomer(CbsGetLegalCustomerRequest request)
        {
            throw new NotImplementedException();
        }
    }
}