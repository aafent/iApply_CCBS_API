namespace CCBS.Models
{
    public class Drawdown
    {
        #region Public Properties

        /// <summary>
        /// Disbursment Amount (decimal (19,3))
        /// </summary>
        public decimal amount { get; set; }

        /// <summary>
        /// Loan Account Number (varchar (20))
        /// </summary>
        public string loanaccount { get; set; }

        /// <summary>
        /// Drawdown Number (varchar (20))
        /// </summary>
        public string profitid_draw { get; set; }

        /// <summary>
        /// Loan Account Check Digit (integer)
        /// </summary>
        public int profitsaccountcd { get; set; }

        /// <summary>
        /// Drawdown Status (varchar (2))
        /// </summary>
        public string profitstatus_draw { get; set; }

        #endregion Public Properties
    }
}