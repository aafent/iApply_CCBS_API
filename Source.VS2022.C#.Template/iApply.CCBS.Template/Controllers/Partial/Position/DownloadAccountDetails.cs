

using iApplyShared.CbsModels;
using Microsoft.AspNetCore.Mvc;

namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.PositionTag)]
        public CbsDownloadAccountDetailsResponse DownloadAccountDetails(CbsDownloadAccountDetailsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}