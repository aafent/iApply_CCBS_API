using Microsoft.AspNetCore.Mvc;

namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.PositionTag)]
        public CbsSearchCustomerAccountsResponse SearchCustomerAccounts(CbsSearchCustomerAccountsRequest request)
        {
            throw new NotImplementedException();
        }

    }
}