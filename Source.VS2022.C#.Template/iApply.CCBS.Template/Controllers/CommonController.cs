using iApplyShared.CbsModels;
using Microsoft.AspNetCore.Mvc;

namespace IA.CCBSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags(ccbsFolders.OtherTag)]
    public partial class CommonController : ControllerBase
    {
        protected readonly ILogger<CommonController> _logger;

        public CommonController(ILogger<CommonController> logger)
        {
            _logger = logger;
        }

      
    }
}