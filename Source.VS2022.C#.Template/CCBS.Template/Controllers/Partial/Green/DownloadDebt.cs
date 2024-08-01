// AUTOCODE:	./DebtManagement/DownloadDebt.cs	DownloadDebtResponse	DownloadDebt	DownloadDebtRequest
using Microsoft.AspNetCore.Mvc;


namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.GreenTag)]
        public CbsDownloadDebtResponse DownloadDebt(CbsDownloadDebtRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

