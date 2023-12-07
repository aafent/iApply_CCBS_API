using iApply.CCBS.Shared.CCbsModels;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsGetLegalCustomerRequest : MockupModel
    {
        #region Public Properties

        /// <summary>
        /// Customer Check Digit
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Customer CBS Id
        /// </summary>
        [Mockup(1)]
        public string CustomerCBSId { get; set; }

        #endregion Public Properties
    }
}