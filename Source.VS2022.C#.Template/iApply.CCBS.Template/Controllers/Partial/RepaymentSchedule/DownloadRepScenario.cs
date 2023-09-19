// AUTOCODE:	./DownloadRepScenario.cs	DownloadRepScenarioResponse	DownloadRepScenario	DownloadRepScenarioRequest
using iApplyShared.CbsModels;
using iApplyShared.Models;
using Microsoft.AspNetCore.Mvc;


namespace CcbsApiTemplate.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.RepaymentScheduleTag)]
        public DownloadRepScenarioResponse DownloadRepScenario(DownloadRepScenarioRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

