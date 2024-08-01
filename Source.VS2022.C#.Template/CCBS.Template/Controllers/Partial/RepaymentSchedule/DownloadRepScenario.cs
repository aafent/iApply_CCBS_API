// AUTOCODE:	./DownloadRepScenario.cs	DownloadRepScenarioResponse	DownloadRepScenario	DownloadRepScenarioRequest
using Microsoft.AspNetCore.Mvc;


namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.RepaymentScheduleTag)]
        public CbsDownloadRepScenarioResponse DownloadRepScenario(CbsDownloadRepScenarioRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

