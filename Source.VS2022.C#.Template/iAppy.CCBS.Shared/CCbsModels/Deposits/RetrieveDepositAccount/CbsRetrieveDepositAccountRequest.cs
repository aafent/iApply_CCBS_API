using iApply.CCBS.Shared.CCbsModels;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsRetrieveDepositAccountRequest : MockupModel
    {
        #region Public Properties

        /// <summary>
        /// Customer CBS Id (integer)
        /// </summary>
        [Mockup(1)]
        public int InCustomerCustId { get; set; }

        /// <summary>
        /// Account Check digit (integer)
        /// </summary>
        public int profitsAccountCd { get; set; }

        /// <summary>
        /// Account Number (varchar (40))
        /// </summary>
        public string profitsAccountNumber { get; set; }

        #endregion Public Properties
    }
}