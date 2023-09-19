using iApplyShared.CbsModels;
using iApplyShared.Models;
using Microsoft.AspNetCore.Mvc;

namespace CcbsApiTemplate.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.GreenTag)]
        public UpdateIndividualCustomerResponse UpdateIndividualCustomer(UpdateIndividualCustomerRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

