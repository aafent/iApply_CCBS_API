// AUTOCODE:	./CustomerRelationships/GetCustomerRelationships.cs	GetCustomerRelationshipsResponse	GetCustomerRelationships	GetCustomerRelationshipsRequest
using Microsoft.AspNetCore.Mvc;


namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.CustomerTag)]
        public CbsGetCustomerRelationshipsResponse GetCustomerRelationships(CbsGetCustomerRelationshipsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

