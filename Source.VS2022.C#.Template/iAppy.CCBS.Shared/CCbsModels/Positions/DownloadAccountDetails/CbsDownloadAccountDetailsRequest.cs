using iApply.CCBS.Shared.CCbsModels;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsDownloadAccountDetailsRequest : MockupModel
    {
        #region Public Properties

        /// <summary>
        /// Account Check Digit
        /// </summary>
        [Mockup(2)]
        public int accountCD { get; set; }

        /// <summary>
        /// Account Number
        /// </summary>
        [Mockup(1)]
        public string accountNumber { get; set; }

        /// <summary>
        /// Account Type
        /// </summary>
        public int accountType { get; set; }

        #endregion Public Properties
    }
}