using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsRetrieveDrawDownRequest
    {
        #region Public Properties

        /// <summary>
        /// Customer CBS Id (integer)
        /// </summary>
        public int CustomerCBSId { get; set; }

        /// <summary>
        /// Customer Check Digit (integer)
        /// </summary>
        public int CustomerCBSCD { get; set; }

        /// <summary>
        /// Date From (datetime)
        /// </summary>
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Date To (datetime)
        /// </summary>
        public DateTime DateTo { get; set; }

        #endregion Public Properties
    }
}
