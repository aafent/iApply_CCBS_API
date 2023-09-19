using iApplyShared.CbsModels;
using Microsoft.AspNetCore.Mvc;

namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpGet("[action]")]
        [Tags(ccbsFolders.InformativeTag)]
        public CbsAboutResponse About()
        {
            CbsAboutResponse about =new();
            about.title="ACMEBank Software System";
            about.apiVersion="1.0";
            about.code= "ACMEBank.SoftCompany.S1";

            return about;
        }

    }
}