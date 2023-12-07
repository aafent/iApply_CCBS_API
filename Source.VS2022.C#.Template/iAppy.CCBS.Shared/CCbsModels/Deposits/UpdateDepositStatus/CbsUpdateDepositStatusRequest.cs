using iApply.CCBS.Shared.CCbsModels;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsUpdateDepositStatusRequest : MockupModel
    {
        #region Public Properties

        public short? AccountCd { get; set; }

        [Mockup(1)]
        public string AccountNumber { get; set; }

        public string Status { get; set; }

        #endregion Public Properties
    }
}