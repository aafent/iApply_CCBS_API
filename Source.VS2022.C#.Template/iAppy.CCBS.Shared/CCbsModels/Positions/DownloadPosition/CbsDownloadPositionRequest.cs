using iApply.CCBS.Shared.CCbsModels;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsDownloadPositionRequest : MockupModel
    {
        #region Public Properties

        /// <summary>
        /// Customer Check Digit
        /// </summary>
        [Mockup(2)]
        public int CustomerCbsCd { get; set; }

        /// <summary>
        /// Customer CBS Id
        /// </summary>
        [Mockup(1)]
        public string customerCbsId { get; set; }

        #endregion Public Properties
    }
}