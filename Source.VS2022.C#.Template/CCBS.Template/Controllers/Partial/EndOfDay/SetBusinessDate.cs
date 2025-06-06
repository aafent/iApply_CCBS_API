// AUTOCODE:	./SetBusinessDate.cs	SetBusinessDateResponse	SetBusinessDate	SetBusinessDateRequest

using Microsoft.AspNetCore.Mvc;


namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.EndOfDayTag)]
        public CbsSetBusinessDateResponse SetBusinessDate(CbsBusinessDate request)
        {
            throw new NotImplementedException();
        }
    }
}
