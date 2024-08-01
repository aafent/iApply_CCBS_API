// AUTOCODE:	./LettersOfGuaranteeBeneficiaries/GetLetOfGuaBenef.cs	LetOfGuaBenefResponse	GetLetOfGuaBenef	LetOfGuaBenefRequest
using Microsoft.AspNetCore.Mvc;


namespace IA.CCBSAPI.Controllers
{
    public partial class CommonController
    {
        [HttpPost("[action]")]
        [Tags(ccbsFolders.GreenTag)]
        public CbsLetOfGuaBenefResponse GetLetOfGuaBenef(CbsLetOfGuaBenefRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

