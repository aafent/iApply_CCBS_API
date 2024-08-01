// AUTOCODE:	./DownloadRepScheduleSim.cs	DownloadRepScheduleSimResponse	DownloadRepScheduleSim	DownloadRepScheduleSimRequest
using Microsoft.AspNetCore.Mvc;


namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.RepaymentScheduleTag)]
        public CbsDownloadRepScheduleSimResponse DownloadRepScheduleSim(CbsDownloadRepScheduleSimRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

