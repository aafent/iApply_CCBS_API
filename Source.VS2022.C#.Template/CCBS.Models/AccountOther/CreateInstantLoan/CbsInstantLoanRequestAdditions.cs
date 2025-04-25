
namespace CCBS.Models
{
    // TODO: Do we need this class?
    //
    public class CbsInstantLoanRequestAdditions
    {
        #region Public Properties
        /// <summary>
        /// Description : The value date (or start) of the contract.
        /// Entity: ???
        /// Data Type: DateTime
        /// </summary>
        public virtual DateTime Start_date { get; set; }

        /// <summary>
        /// Entity: ???
        /// Description : ???
        /// Data Type: int
        /// </summary>
        public virtual int Limit_Reference_ID { get; set; }

        /// <summary>
        /// Entity: ???
        /// Description : Loan product.
        /// Data Type: string
        /// </summary>
        public virtual string Category { get; set; }      // la_produ

        /// <summary>
        /// Entity: ???
        /// Description : Indicates the type of interest rate to be used for the contract.
        /// The following values are defined for the interest rate type field: 1 = Fixed 3 = Floating.
        /// Data Type: int
        /// </summary>
        public virtual int Interest_Rate_Type { get; set; }

        /// <summary>
        /// Entity: ???
        /// Description : The account number of the drawdown account to be used on the Value Date..
        /// Data Type: string
        /// </summary>
        public virtual string Drawdoown_account { get; set; }

        /// <summary>
        /// Entity: ???
        /// Description : Indicates the account number where entries are made for the 
        /// reimbursement of the principal at liquidation.
        /// Data Type: string
        /// </summary>
        public virtual string Principal_liq_acct { get; set; }

        /// <summary>
        /// Entity: ???
        /// Description : Contains the account number where entries are made for the reimbursement of the Interest 
        /// (together with any taxes applicable to that interest) at liquidation.
        /// Data Type: string
        /// </summary>
        public virtual string Interest_liq_acct { get; set; }

        /// <summary>
        /// Entity: ???
        /// Description : example: for contracts with fixed interest rate for 1 year and floating interest rate after
        /// Data Type: DateTime
        /// </summary>
        public virtual DateTime Interest_rate_type_date_change { get; set; }

        /// <summary>
        /// Entity: ???
        /// Description : Begin or End
        /// Data Type: string
        /// </summary>
        public virtual string Annuity_pay_method { get; set; }

        /// <summary>
        /// Entity: ???
        /// Description : Indicates whether the contract is secured or not. Y or N
        /// Data Type: string
        /// </summary>
        public virtual string Secured { get; set; }

        /// <summary>
        /// Entity: ???
        /// Description : Indicates the date when the contract was agreed/ Sign Date
        /// Data Type: DateTime
        /// </summary>
        public virtual DateTime Agreement_date { get; set; }

        /// <summary>
        /// Entity: ???
        /// Description : Indicates whether the contract is secured or not. Y or N
        /// Data Type: string
        /// </summary>
        public virtual string Contract_Number { get; set; }

        /// <summary>
        /// Entity: ???
        /// Description : Indicates whether the contract is secured or not. Y or N
        /// Data Type: string
        /// </summary>
        public virtual decimal Original_Amount { get; set; }

        /// <summary>
        /// Entity: ???
        /// Description : Indicates whether the contract is secured or not. Y or N
        /// Data Type: string
        /// </summary>
        public virtual DateTime Original_Value_Date { get; set; }
        #endregion Public Properties
    }
}