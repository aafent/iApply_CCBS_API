// AUTOCODE:	./DownloadRepSchedule/DownloadRepSchedule.cs	DownloadRepScheduleResponse	DownloadRepSchedule	DownloadRepScheduleRequest
using Microsoft.AspNetCore.Mvc;


namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.RepaymentScheduleTag)]
        public CbsDownloadRepScheduleResponse DownloadRepSchedule(CbsDownloadRepScheduleRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

