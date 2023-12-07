﻿using iApply.CCBS.Shared.CCbsModels;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsDownloadRepScheduleRequest : MockupModel
    {
        #region Public Properties

        /// <summary>
        /// Seq: 2
        /// Entity: N/A
        /// Description: Account Check Digit
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: ProfitsAccountCd
        /// </summary>
        public int accountCd { get; set; }

        /// <summary>
        /// Seq: 1
        /// Entity: N/A
        /// Description: Account Number
        /// Data Type: varchar (30)
        /// Notes: N/A
        /// CBS: ProfitsAccountNumber
        /// </summary>
        [Mockup(1)]
        public string accountNumber { get; set; }

        #endregion Public Properties
    }
}