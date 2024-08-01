// AUTOCODE:	./InstantLoans/CreateInstantLoan.cs	InstantLoanResponse	CreateInstantLoan	InstantLoanRequest
using Microsoft.AspNetCore.Mvc;


namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.GreenTag)]
        public CbsInstantLoanResponse CreateInstantLoan(CbsInstantLoanRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

