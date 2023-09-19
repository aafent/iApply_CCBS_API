

using iApplyShared.CbsModels;
using Microsoft.AspNetCore.Mvc;

namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.PositionTag)]
        public CbsDownloadPositionResponse DownloadPosition(CbsDownloadPositionRequest request)
        {
            throw new NotImplementedException();
        }
    }
}