using Microsoft.AspNetCore.Mvc;

namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.CustomerTag)]
        public CbsUpdateIndividualCustomerResponse UpdateIndividualCustomer(CbsUpdateIndividualCustomerRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

