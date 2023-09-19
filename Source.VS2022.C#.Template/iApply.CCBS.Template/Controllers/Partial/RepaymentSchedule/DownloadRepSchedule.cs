// AUTOCODE:	./DownloadRepSchedule/DownloadRepSchedule.cs	DownloadRepScheduleResponse	DownloadRepSchedule	DownloadRepScheduleRequest
using iApplyShared.CbsModels;
using iApplyShared.Models;
using Microsoft.AspNetCore.Mvc;


namespace CcbsApiTemplate.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.RepaymentScheduleTag)]
        public DownloadRepScheduleResponse DownloadRepSchedule(DownloadRepScheduleRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

