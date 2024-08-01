using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsUpdateDepositStatusRequest : BaseCbsRequestModel
    {
        #region Public Properties

        public short? AccountCd { get; set; }

        [Mockup(1)]
        public string AccountNumber { get; set; }

        public string Status { get; set; }

        #endregion Public Properties
    }
}