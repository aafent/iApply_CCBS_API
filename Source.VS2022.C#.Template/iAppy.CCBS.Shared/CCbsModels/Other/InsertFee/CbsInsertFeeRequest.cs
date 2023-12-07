using iApply.CCBS.Shared.CCbsModels;

namespace iApplyShared.CbsModels
{
    public class CbsInsertFeeRequest : MockupModel
    {
        #region Public Properties

        /// <summary>
        /// Fee Amount
        /// Data Type: Numeric
        /// Entities: v_CBS_Fees
        /// </summary>
        public decimal FeeAmount { get; set; }

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
        /// Fee Justification Code
        /// Entities: v_CBS_Fees
        /// </summary>
        public string FeeJustificCode { get; set; }

        /// <summary>
        /// Transaction Type
        /// Data Type: Text
        /// Entities: v_CBS_Fees
        /// </summary>
        public string Type { get; set; }

        #endregion Public Properties
    }
}