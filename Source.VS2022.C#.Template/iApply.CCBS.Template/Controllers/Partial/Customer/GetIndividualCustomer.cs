using iApplyShared.CbsModels;
using Microsoft.AspNetCore.Mvc;

namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.CustomerTag)]
        public CbsGetIndividualCustomerResponse GetIndividualCustomer(CbsGetIndividualCustomerRequest request)
        {
            throw new NotImplementedException();
        }

    }
}