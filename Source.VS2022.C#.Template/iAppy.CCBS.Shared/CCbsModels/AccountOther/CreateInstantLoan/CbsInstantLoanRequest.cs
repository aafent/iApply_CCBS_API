using iApply.CCBS.Shared.CCbsModels;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsInstantLoanRequest : MockupModel
    {
        #region Public Properties

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Account Officer
        /// Data Type: integer
        /// </summary>
        public int AccountOfficer { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Activity Sector
        /// Data Type: integer
        /// </summary>
        public int ActivitySector { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Requested or Approved Amount
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Central Bank
        /// Data Type: integer
        /// </summary>
        public int CentralBank { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Application Id
        /// Data Type: varchar (30)
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Currency Code
        /// Data Type: integer
        /// </summary>
        public int Currency { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Currency Description
        /// Data Type: varchar (30)
        /// </summary>
        public string CurrencyDescr { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Customer Category
        /// Data Type: integer
        /// </summary>
        public int CustomerCategory { get; set; }

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
        /// Description: Delay Officer
        /// Data Type: integer
        /// </summary>
        public int DelayOfficer { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Deposit Account
        /// Data Type: varchar (30)
        /// </summary>
        public string DepositNo { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Division Address
        /// Data Type: integer
        /// </summary>
        public int DivisionAddress { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Loan Expiry Date
        /// Data Type: datetime
        /// </summary>
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Financial Sector
        /// Data Type: integer
        /// </summary>
        public int FinancialSector { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Fixed Rate
        /// Data Type: integer
        /// </summary>
        public int FixedInterestRate { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Floating Rate
        /// Data Type: integer
        /// </summary>
        public int FloatingInterestRateCode { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Loan Frequency
        /// Data Type: integer
        /// </summary>
        public int Frequency { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Grace Period Expiry Date
        /// Data Type: datetime
        /// </summary>
        public DateTime GracePeriodExpiryDate { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Guarantor Amount
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal GuarantorAmount { get; set; }

        public GuarantorsList[] GuarantorsList { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Installments No
        /// Data Type: integer
        /// </summary>
        public int InstallmentsNo { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Loan Purpose
        /// Data Type: integer
        /// </summary>
        public int LoanPurpose { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Margin
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal Margin { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Mechanism
        /// Data Type: integer
        /// </summary>
        public int Mechanism { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Main Applicant Mobile
        /// Data Type: varchar (30)
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Program Id
        /// Data Type: integer
        /// </summary>
        public int ProgramId { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Sales Unit
        /// Data Type: integer
        /// </summary>
        public int SalesUnit { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Seller
        /// Data Type: integer
        /// </summary>
        public int Seller { get; set; }

        /// <summary>
        /// Entity: v_CBS_InstantLoanView
        /// Description: Supplied Number 2
        /// Data Type: integer
        /// Notes: This property doesn't have a description in your provided data.
        /// </summary>
        public int SuppliedNum2 { get; set; }

        #endregion Public Properties
    }
}