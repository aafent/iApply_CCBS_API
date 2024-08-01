using Microsoft.AspNetCore.Mvc;

namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.CustomerTag)]
        public CbsSearchCustomerResponse SearchCustomer([FromBody] CbsSearchCustomerRequest request)
        {
            throw new NotImplementedException();
        }


    }
}