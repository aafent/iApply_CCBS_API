﻿using iApply.CCBS.Shared.CCbsModels;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsRetrieveDrawDownRequest : MockupModel
    {
        #region Public Properties

        public string AppUser { get; set; }

        /// <summary>
        /// Customer Check Digit (integer)
        /// </summary>
        public int CustomerCBSCD { get; set; }

        /// <summary>
        /// Customer CBS Id (integer)
        /// </summary>
        [Mockup(1)]
        public int CustomerCBSId { get; set; }

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