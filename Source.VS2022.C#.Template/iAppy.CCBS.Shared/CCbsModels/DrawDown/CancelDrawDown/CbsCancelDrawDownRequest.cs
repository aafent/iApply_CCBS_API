using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsCancelDrawDownRequest
    {
        #region Public Properties

        /// <summary>
        /// Drawdown Number (varchar (20))
        /// </summary>
        public string ProfitsId { get; set; }

        /// <summary>
        /// comments (varchar)
        /// </summary>
        public string comments { get; set; }

        /// <summary>
        /// Customer CBS Id (integer)
        /// </summary>
        public int CustomerCBSId { get; set; }

        /// <summary>
        /// Disbursment Branch (integer)
        /// </summary>
        public int BranchId { get; set; }

        /// <summary>
        /// PayeeComment (varchar (180))
        /// </summary>
        public string PayeeComment { get; set; }

        #endregion Public Properties
    }
}
