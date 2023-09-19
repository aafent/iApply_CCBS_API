using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsInsertFeeRequest
    {
        /// <summary>
        /// Deposit Account
        /// Entities: v_CBS_Fees
        /// </summary>
        public string FeeDepAccount { get; set; }

        /// <summary>
        /// Deposit Account Check Digit
        /// Entities: v_CBS_Fees
        /// </summary>
        public string FeeDepAccountCd { get; set; }

        /// <summary>
        /// Fee Amount
        /// Data Type: Numeric
        /// Entities: v_CBS_Fees
        /// </summary>
        public decimal FeeAmount { get; set; }

        /// <summary>
        /// Transaction Type
        /// Data Type: Text
        /// Entities: v_CBS_Fees
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Fee Justification Code
        /// Entities: v_CBS_Fees
        /// </summary>
        public string FeeJustificCode { get; set; }
    }
}
