namespace CCBS.Models
{
    public class CbsRetrieveDrawDownResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Disbursment Amount (decimal (19,3))
        /// </summary>
        public decimal amount { get; set; }

        /// <summary>
        /// drawDownDate (datetime)
        /// </summary>
        public DateTime drawDownDate { get; set; }

        public List<Drawdown> DrawdownsList { get; set; }

        /// <summary>
        /// Currency (varchar (10))
        /// </summary>
        public string la_ccy { get; set; }

        /// <summary>
        /// Application Id (varchar (15))
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Disbursment Branch (varchar (10))
        /// </summary>
        public string la_offco { get; set; }

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