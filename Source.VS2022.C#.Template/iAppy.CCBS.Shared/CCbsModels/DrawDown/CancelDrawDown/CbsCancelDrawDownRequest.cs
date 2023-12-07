using iApply.CCBS.Shared.CCbsModels;
using IApplyDataAccess.DataModel;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsCancelDrawDownRequest : MockupModel
    {
        #region Public Properties

        public string AppUser { get; set; }

        /// <summary>
        /// Disbursment Branch (integer)
        /// </summary>
        public int BranchId { get; set; }

        /// <summary>
        /// comments (varchar)
        /// </summary>
        public string comments { get; set; }

        /// <summary>
        /// Customer CBS Id (integer)
        /// </summary>
        [Mockup(1)]
        public int CustomerCBSId { get; set; }

        public DrawDownRequestView DrawDownRequestViews { get; set; }

        /// <summary>
        /// PayeeComment (varchar (180))
        /// </summary>
        public string PayeeComment { get; set; }

        /// <summary>
        /// Drawdown Number (varchar (20))
        /// </summary>
        public string ProfitsId { get; set; }

        #endregion Public Properties
    }
}