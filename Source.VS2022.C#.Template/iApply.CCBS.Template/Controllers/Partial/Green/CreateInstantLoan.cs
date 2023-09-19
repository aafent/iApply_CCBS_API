// AUTOCODE:	./InstantLoans/CreateInstantLoan.cs	InstantLoanResponse	CreateInstantLoan	InstantLoanRequest
using iApplyShared.CbsModels;
using iApplyShared.Models;
using Microsoft.AspNetCore.Mvc;


namespace CcbsApiTemplate.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.GreenTag)]
        public InstantLoanResponse CreateInstantLoan(InstantLoanRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

