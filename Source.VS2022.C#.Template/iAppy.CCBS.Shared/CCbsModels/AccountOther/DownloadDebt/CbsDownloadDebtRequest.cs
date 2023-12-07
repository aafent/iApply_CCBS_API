using iApply.CCBS.Shared.CCbsModels;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsDownloadDebtRequest : MockupModel
    {
        #region Public Properties

        /// <summary>
        /// Entity: Account Number
        /// Description: Account Number
        /// Data Type: varchar (40)
        /// Notes: argument from client
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Entity: Customer CBS Id
        /// Description: Customer CBS Id
        /// Data Type: varchar (20)
        /// Notes: argument from client
        /// </summary>
        [Mockup(1)]
        public string CustomerCBSId { get; set; }

        #endregion Public Properties
    }
}