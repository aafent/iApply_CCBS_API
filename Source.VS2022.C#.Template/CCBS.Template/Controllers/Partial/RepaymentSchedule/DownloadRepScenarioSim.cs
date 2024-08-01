// AUTOCODE:	./DownloadRepScenarioSim.cs	DownloadRepScenarioSimResponse	DownloadRepScenarioSim	DownloadRepScenarioSimRequest
using Microsoft.AspNetCore.Mvc;


namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.RepaymentScheduleTag)]
        public CbsDownloadRepScenarioSimResponse DownloadRepScenarioSim(CbsDownloadRepScenarioSimRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

