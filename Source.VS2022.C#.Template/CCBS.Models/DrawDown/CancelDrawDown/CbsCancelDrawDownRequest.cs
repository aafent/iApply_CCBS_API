using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsCancelDrawDownRequest : BaseCbsRequestModel
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

        public CbsDrawDownRequestView DrawDownRequestViews { get; set; }

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