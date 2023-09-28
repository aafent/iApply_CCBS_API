using IApplyDataAccess.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsDownloadRepScheduleSimRequest
    {
        #region Public Properties

        /// <summary> 
        /// Applicant Birth Date (datetime) 
        /// </summary> 
        public DateTime BirthDate { get; set; }

        /// <summary> 
        /// Main Beneficiary (varchar (1)) 
        /// 1 = Yes 0 = No
        /// </summary> 
        public string MainBenef { get; set; }

        /// <summary> 
        /// Insurance Code (integer) 
        /// </summary> 
        public int InsuranceCode { get; set; }

        /// <summary> 
        /// Insured Amount (decimal (14,2)) 
        /// </summary> 
        public decimal InsuredAmount { get; set; }

        /// <summary> 
        /// Installment Number (integer) 
        /// </summary> 
        public int InstallmentsNo { get; set; }

        /// <summary> 
        /// Frequency (integer) 
        /// </summary> 
        public int Frequency { get; set; }

        /// <summary> 
        /// Loan Expiry Date (datetime) 
        /// </summary> 
        public DateTime MaturityDate { get; set; }

        /// <summary> 
        /// Account Open Date (datetime) 
        /// </summary> 
        public DateTime AccountOpenDate { get; set; }

        /// <summary> 
        /// 1st Install.t Date (datetime) 
        /// </summary> 
        public DateTime FirstInstallmentDate { get; set; }

        /// <summary> 
        /// Currency Code (integer) 
        /// </summary> 
        public int CurrencyCode { get; set; }

        /// <summary> 
        /// Currency Description (varchar (20)) 
        /// </summary> 
        public string CurrencyDescription { get; set; }

        /// <summary> 
        /// Fixed Interest Rate (integer) 
        /// </summary> 
        public int FixedInterestRate { get; set; }

        /// <summary> 
        /// Fixed Duration (integer) 
        /// If duration unit = 1 DAYS then 0, If duration unit = 2 MONTHS then interest duration,If duration unit = 3 YEARS then interest duration/12
        /// </summary> 
        public int FixedDurationInMonths { get; set; }

        /// <summary> 
        /// Floating Interest Rate (integer) 
        /// </summary> 
        public int FloatingInterestRateCode { get; set; }

        /// <summary> 
        /// Fixed Percentage (decimal (19,2)) 
        /// </summary> 
        public decimal FixedInterestPerc { get; set; }

        /// <summary> 
        /// Floating Percentage (decimal (19,2)) 
        /// </summary> 
        public decimal FloatingInterestPerc { get; set; }

        /// <summary> 
        /// Loan Duration (decimal (19,2)) 
        /// </summary> 
        public decimal Term { get; set; }

        /// <summary> 
        /// Contribution Percentage (decimal (19,2)) 
        /// </summary> 
        public decimal ContributionInterestPerc { get; set; }

        /// <summary> 
        /// Margin (decimal (19,2)) 
        /// </summary> 
        public decimal Spread { get; set; }

        /// <summary> 
        /// Grace Period Expiry Date (datetime) 
        /// </summary> 
        public DateTime GracePeriodExpiryDate { get; set; }

        /// <summary> 
        /// Requested or Approved Amount (decimal (19,2)) 
        /// If approved amount is empty then requested amount else approved amount
        /// </summary> 
        public decimal DrawdownCapitalAmount { get; set; }

        /// <summary> 
        /// Product Code (integer) 
        /// </summary> 
        public int ProductId { get; set; }

        /// <summary> 
        /// Requested or Approved Amount (decimal (19,2)) 
        /// If approved amount is empty then requested amount else approved amount
        /// </summary> 
        public decimal Amount { get; set; }

        /// <summary> 
        /// Grace Period Expiry Date (datetime) 
        /// </summary> 
        public DateTime DrawDownExpDate { get; set; }

        /// <summary> 
        /// Grace Period Frequency (integer) 
        /// </summary> 
        public int FreqMorat { get; set; }

        /// <summary> 
        /// Supplied (varchar (1)) 
        /// 1
        /// </summary> 
        public string Supplied { get; set; }

        /// <summary> 
        /// Base Days (integer)
        /// If fixed base days are zero then floating base days else fixed base days, For MCB are the base days for the currency
        /// </summary> 
        public int DaysBase { get; set; }

        /// <summary> 
        /// DiffIntAlgorithm (varchar (1)) 
        /// 0
        /// </summary> 
        public string DiffIntAlgorithm { get; set; }

        /// <summary> 
        /// Disbursement Date (datetime) 
        /// </summary> 
        public DateTime DisbDate { get; set; }

        /// <summary> 
        /// Fixed Rate Expiry Date (datetime) 
        /// </summary> 
        public DateTime FixedIntExpDate { get; set; }

        /// <summary> 
        /// MaintainEqInst (varchar (1)) 
        /// 0
        /// </summary> 
        public string MaintainEqInst { get; set; }

        /// <summary> 
        /// IR Claimed (varchar (1)) 
        /// </summary> 
        public string CapitFlg { get; set; }

        /// <summary> 
        /// PayFlg (varchar (1)) 
        /// If GP IR Amortization=1 then 1 else, if IR Claimed at GP = '1' THEN 1 else IR Capitalization
        /// </summary> 
        public string PayFlg { get; set; }

        /// <summary> 
        /// IR Claimed at GP (varchar (1)) 
        /// </summary> 
        public string IntPayFlg { get; set; }

        /// <summary> 
        /// Non IR Capitalization (varchar (1)) 
        /// </summary> 
        public string NonCapitFlg { get; set; }

        /// <summary> 
        /// Flag1 (integer) 
        /// 0
        /// </summary> 
        public int Flag1 { get; set; }

        /// <summary> 
        /// Flag2 (integer) 
        /// 0
        /// </summary> 
        public int Flag2 { get; set; }

        /// <summary> 
        /// Flag3 (integer) 
        /// 1
        /// </summary> 
        public int Flag3 { get; set; }

        /// <summary> 
        /// DecimalPlace (integer) 
        /// 2
        /// </summary> 
        public int DecimalPlace { get; set; }

        /// <summary> 
        /// IPF Type (varchar (1)) 
        /// If product category is IPF then 1 else 0
        /// </summary> 
        public string IsIpf { get; set; }

        /// <summary> 
        /// GP IR Amortization (integer) 
        /// </summary> 
        public int AmortGPInter { get; set; }

        /// <summary> 
        /// Product General Flags (integer) 
        /// </summary> 
        public int GeneralFlags { get; set; }
        public RepaymentScheduleSimView RepaymentScheduleSimViews { get; set; }

        public List<RepaymentScheduleSimInsuranceData> RepaymentScheduleSimInsuranceData { get; set; }

        #endregion Public Properties
    }
}
