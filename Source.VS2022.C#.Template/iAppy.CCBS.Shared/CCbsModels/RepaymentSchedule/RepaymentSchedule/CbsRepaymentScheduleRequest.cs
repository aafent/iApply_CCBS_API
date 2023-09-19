using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsRepaymentScheduleFixRequest
    {
        /// <summary>
        /// Seq. 1
        /// Description: Account Number
        /// </summary>
        public string accountNumber { get; set; }

        /// <summary>
        /// Seq. 2
        /// Description: Account Check Digit
        /// </summary>
        public int accountCd { get; set; }
    }

}
