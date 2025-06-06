// AUTOCODE:	./CreateLegalCustomer.cs	CreateLegalCustomerResponse	CreateLegalCustomer	CreateLegalCustomerRequest
using Microsoft.AspNetCore.Mvc;


namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.CustomerTag)]
        public CbsCreateLegalCustomerResponse CreateLegalCustomer(CbsCreateLegalCustomerRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

