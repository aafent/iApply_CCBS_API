// AUTOCODE:	./CollateralMaintenanceRetrieve/RetrieveCbsCollateral.cs	CollateralCbsRetrieveResponse	RetrieveCbsCollateral	CollateralCbsRetrieveRequest
using iApplyShared.CbsModels;
using iApplyShared.Models;
using Microsoft.AspNetCore.Mvc;


namespace CcbsApiTemplate.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.GreenTag)]
        public CollateralCbsRetrieveResponse RetrieveCbsCollateral(CollateralCbsRetrieveRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

