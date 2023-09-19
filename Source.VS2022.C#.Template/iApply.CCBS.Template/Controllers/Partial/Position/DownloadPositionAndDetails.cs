

using iApplyShared.CbsModels;
using Microsoft.AspNetCore.Mvc;


namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {

        [HttpPost("[action]")]
        [Tags(ccbsFolders.PositionTag)]
        public CbsDownloadPositionAndDetailsResponse DownloadPositionAndDetails(CbsDownloadPositionAndDetailsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}