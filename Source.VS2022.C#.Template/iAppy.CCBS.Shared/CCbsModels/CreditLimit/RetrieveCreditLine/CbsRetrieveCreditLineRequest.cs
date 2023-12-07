using iApply.CCBS.Shared.CCbsModels;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsRetrieveCreditLineRequest : MockupModel
    {
        #region Public Properties

        /// <summary>
        /// Customer Check Digit
        /// Data Type: integer
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Customer CBS Id
        /// Data Type: integer
        /// </summary>
        [Mockup(1)]
        public int CustomerCBSId { get; set; }

        #endregion Public Properties
    }
}