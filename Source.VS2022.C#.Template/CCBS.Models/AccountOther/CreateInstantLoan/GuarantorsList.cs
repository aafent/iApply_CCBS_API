namespace CCBS.Models
{
    public class GuarantorsList
    {
        #region Public Properties

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Guarantor Check Digit
        /// Data Type: integer
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Customer CBS Id
        /// Data Type: integer
        /// </summary>
        public int CustomerCBSId { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Guarantor Amount
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal GuarantorAmount { get; set; }

        #endregion Public Properties
    }
}