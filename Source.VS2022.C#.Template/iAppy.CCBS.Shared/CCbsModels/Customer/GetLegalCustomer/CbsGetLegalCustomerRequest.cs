using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsGetLegalCustomerRequest
    {
        #region Public Properties

        /// <summary>
        /// Customer Check Digit
        /// </summary>
        [Mockup(1)]
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Customer CBS Id
        /// </summary>
        [Mockup(2)]
        public string CustomerCBSId { get; set; }

        #endregion Public Properties
    }
}