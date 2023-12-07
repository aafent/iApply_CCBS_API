using IApplyDataAccess.DataModel;

namespace iApplyShared.CbsModels
{
    public class CbsCreateDrawDownResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Payee Bank (varchar (15))
        /// </summary>
        public string bank_paye { get; set; }

        /// <summary>
        /// Serial Number (integer)
        /// </summary>
        public int co_id { get; set; }

        /// <summary>
        /// Disbursment Amount (decimal (19,3))
        /// </summary>
        public decimal disb_amount { get; set; }

        /// <summary>
        /// Disbursment Date (datetime)
        /// </summary>
        public DateTime disb_date { get; set; }

        /// <summary>
        /// Drawdown Date (datetime)
        /// </summary>
        public DateTime draw_date { get; set; }

        /// <summary>
        /// Drawdown Transaction Date (datetime)
        /// </summary>
        public DateTime drawtr_dt { get; set; }

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
        /// Payee Bank Branch (varchar (15))
        /// </summary>
        public string paye_branch { get; set; }

        public List<PayeesView> PayeesView { get; set; }

        /// <summary>
        /// Payee Account (varchar (40))
        /// </summary>
        public string payes_account { get; set; }

        /// <summary>
        /// Payee Amount (decimal (19,3))
        /// </summary>
        public decimal payes_amount { get; set; }

        /// <summary>
        /// Payee Name (varchar (80))
        /// </summary>
        public string payes_name { get; set; }

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

        /// <summary>
        /// Source (varchar (1))
        /// 2
        /// </summary>
        public string source { get; set; }

        #endregion Public Properties
    }
}