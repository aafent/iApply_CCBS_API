// AUTOCODE:	./LettersOfGuaranteeBeneficiaries/GetLetOfGuaBenef.cs	LetOfGuaBenefResponse	GetLetOfGuaBenef	LetOfGuaBenefRequest
using iApplyShared.CbsModels;
using iApplyShared.Models;
using Microsoft.AspNetCore.Mvc;


namespace CcbsApiTemplate.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.GreenTag)]
        public LetOfGuaBenefResponse GetLetOfGuaBenef(LetOfGuaBenefRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

