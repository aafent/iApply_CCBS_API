// AUTOCODE:	./Fees/InsertFee.cs	InsertFeeResponse	InsertFee	InsertFeeRequest
using Microsoft.AspNetCore.Mvc;


namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.GreenTag)]
        public CbsInsertFeeResponse InsertFee(CbsInsertFeeRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

