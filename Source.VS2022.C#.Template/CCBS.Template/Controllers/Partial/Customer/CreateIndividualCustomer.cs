using Microsoft.AspNetCore.Mvc;

namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.CustomerTag)]
        public CbsCreateIndividualCustomerResponse CreateIndividualCustomer(CbsCreateIndividualCustomerRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

