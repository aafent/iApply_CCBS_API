using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsRepaymentScheduleSaveRequest
    {

        /// <summary>
        /// Seq. 1
        /// iApply: MedCategory
        /// Entities: v_CBS_MediatorsView
        /// </summary>
        public string MedCategory { get; set; }

        /// <summary>
        /// Seq. 2
        /// iApply: MedCategoryDescr
        /// Entities: v_CBS_MediatorsView
        /// </summary>
        public string MedCategoryDescr { get; set; }

        /// <summary>
        /// Seq. 3
        /// iApply: MedCustomerCbsid
        /// Entities: v_CBS_MediatorsView
        /// </summary>
        public string MedCustomerCbsid { get; set; }

        /// <summary>
        /// Seq. 4
        /// iApply: MedCustomerCd
        /// Entities: v_CBS_MediatorsView
        /// </summary>
        public string MedCustomerCd { get; set; }

        /// <summary>
        /// Seq. 5
        /// iApply: MedAccount
        /// Entities: v_CBS_MediatorsView
        /// </summary>
        public string MedAccount { get; set; }

        /// <summary>
        /// Seq. 6
        /// iApply: MedAccountCd
        /// Entities: v_CBS_MediatorsView
        /// </summary>
        public string MedAccountCd { get; set; }

        /// <summary>
        /// Seq. 7
        /// iApply: InsuranceCode
        /// Entities: v_CBS_MediatorsView
        /// Same Name different Entity
        /// </summary>
        public string InsuranceCodeMediatorsView { get; set; }

        /// <summary>
        /// Seq. 8
        /// iApply: MedFullName
        /// Entities: v_CBS_MediatorsView
        /// </summary>
        public string MedFullName { get; set; }

        /// <summary>
        /// Seq.: 9
        /// Insurance Code
        /// </summary>
        public int InsuranceCode { get; set; }

        /// <summary>
        /// Seq.: 10
        /// Applicant Birth Date
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Seq.: 11
        /// Main Beneficiary
        /// </summary>
        /// <remarks>
        /// 1 = Yes
        /// 0 = No
        /// </remarks>
        public string MainBenef { get; set; }

        /// <summary>
        /// Seq.: 12
        /// Insured Amount
        /// </summary>
        public decimal InsuredAmount { get; set; }

        /// <summary>
        /// Seq.: 13
        /// Customer CBS Id
        /// </summary>
        public string CustomerCBSId { get; set; }

        /// <summary>
        /// Seq.: 14
        /// Customer Check Digit
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Seq.: 15
        /// Fixed Duration Unit
        /// </summary>
        public string FixedDurationUnit { get; set; }

        /// <summary>
        /// Seq.: 16
        /// Fixed Duration
        /// </summary>
        public int FixedDuration { get; set; }

        /// <summary>
        /// Seq.: 17
        /// Installment Number
        /// </summary>
        public int InstallmentsNo { get; set; }

        /// <summary>
        /// Seq.: 18
        /// Frequency
        /// </summary>
        public int Frequency { get; set; }


        /// <summary>
        /// Seq.: 19
        /// Loan Expiry Date
        /// </summary>
        public DateTime MaturityDate { get; set; }

        /// <summary>
        /// Seq.: 20
        /// 1st Install.t Date
        /// </summary>
        public DateTime FirstInstallmentDate { get; set; }

        /// <summary>
        /// Seq.: 21
        /// Currency
        /// </summary>
        public int CurrencyCode { get; set; }

        /// <summary>
        /// Seq.: 22
        /// Currency Description
        /// </summary>
        public string CurrencyDescription { get; set; }

        /// <summary>
        /// Seq.: 23
        /// Fixed Interest Rate
        /// </summary>
        public int FixedInterestRate { get; set; }

        /// <summary>
        /// Seq.: 24
        /// Floating Interest Rate
        /// </summary>
        public int FloatingInterestRateCode { get; set; }

        /// <summary>
        /// Seq.: 25
        /// Fixed Percentage
        /// </summary>
        public decimal FixedInterestPerc { get; set; }

        /// <summary>
        /// Seq.: 26
        /// Contribution Interest Rate
        /// </summary>
        public decimal ContributionInterestRate { get; set; }

        /// <summary>
        /// Seq.: 27
        /// Floating Percentage
        /// </summary>
        public decimal FloatingInterestPerc { get; set; }

        /// <summary>
        /// Seq.: 28
        /// Loan Duration
        /// </summary>
        public decimal Term { get; set; }

        /// <summary>
        /// Seq.: 29
        /// Contribution Percentage
        /// </summary>
        public decimal ContributionInterestPerc { get; set; }

        /// <summary>
        /// Seq.: 30
        /// Margin
        /// </summary>
        public decimal Spread { get; set; }


        /// <summary>
        /// Seq.: 31
        /// Grace Period Expiry Date
        /// </summary>
        public DateTime GracePeriodExpiryDate { get; set; }

        /// <summary>
        /// Seq.: 32
        /// Disbursement Amount
        /// </summary>
        public decimal DrawdownCapitalAmount { get; set; }

        /// <summary>
        /// Seq.: 33
        /// Approved Amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Seq.: 34
        /// Product Code
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Seq.: 35
        /// Grace Period Frequency
        /// </summary>
        public int FreqMorat { get; set; }

        /// <summary>
        /// Seq.: 36
        /// Disbursement Date
        /// </summary>
        public DateTime DisbDate { get; set; }

        /// <summary>
        /// Seq.: 37
        /// Fixed Rate Expiry Date
        /// </summary>
        public DateTime FixedIntExpDate { get; set; }

        /// <summary>
        /// Seq.: 38
        /// Maintain Equal Installments
        /// </summary>
        /// <remarks>
        /// 0 = No
        /// </remarks>
        public string MaintainEqInst { get; set; }

        /// <summary>
        /// Seq.: 39
        /// Account Open Date
        /// </summary>
        public DateTime AccountOpenDate { get; set; }

        /// <summary>
        /// Seq.: 40
        /// IR Claimed at GP
        /// </summary>
        public int IntPayFlg { get; set; }

        /// <summary>
        /// Seq.: 41
        /// IR Claimed
        /// </summary>
        public int CapitFlg { get; set; }

        /// <summary>
        /// Seq.: 42
        /// Non IR Capitalization
        /// </summary>
        public int NonCapitFlg { get; set; }

        /// <summary>
        /// Seq.: 43
        /// Flag1
        /// </summary>
        /// <remarks>
        /// 0 = No
        /// </remarks>
        public int Flag1 { get; set; }

        /// <summary>
        /// Seq.: 44
        /// Flag2
        /// </summary>
        /// <remarks>
        /// 0 = No
        /// </remarks>
        public int Flag2 { get; set; }

        /// <summary>
        /// Seq.: 45
        /// Flag3
        /// </summary>
        /// <remarks>
        /// 1 = Yes
        /// </remarks>
        public int Flag3 { get; set; }

        /// <summary>
        /// Seq.: 46
        /// Flag4
        /// </summary>
        /// <remarks>
        /// 0 = No
        /// </remarks>
        public int Flag4 { get; set; }

        /// <summary>
        /// Seq.: 47
        /// GP IR Install No.
        /// </summary>
        public int InGracePeriod { get; set; }

        /// <summary>
        /// Seq.: 48
        /// Agreement Number
        /// </summary>
        public string AgreementNo { get; set; }

        /// <summary>
        /// Seq.: 49
        /// Agreement Check Digit
        /// </summary>
        public int AgreementCd { get; set; }

        /// <summary>
        /// Seq.: 50
        /// Deposit Account
        /// </summary>
        public string DepositNo { get; set; }

        /// <summary>
        /// Seq.: 51
        /// Deposit Check Digit
        /// </summary>
        public int DepositCd { get; set; }

        /// <summary>
        /// Seq.: 52
        /// Customer Category
        /// </summary>
        public int CustomerCategory { get; set; }

        /// <summary>
        /// Seq.: 53
        /// TransactInd
        /// </summary>
        /// <remarks>
        /// 0 = No
        /// </remarks>
        public string TransactInd { get; set; }

        /// <summary>
        /// Seq.: 54
        /// TransactSm
        /// </summary>
        /// <remarks>
        /// 0 = No
        /// </remarks>
        public int TransactSm { get; set; }

        /// <summary>
        /// Seq.: 55
        /// Request Date Time
        /// </summary>
        /// <remarks>
        /// Business datetime
        /// </remarks>
        public DateTime Request_Dt { get; set; }

        /// <summary>
        /// Seq.: 56
        /// Central Bank Tenor
        /// </summary>
        public int CentralBank { get; set; }

        /// <summary>
        /// Seq.: 57
        /// Division Address
        /// </summary>
        public int DivisionAddress { get; set; }

        /// <summary>
        /// Seq.: 58
        /// Loan Purpose
        /// </summary>
        public int LoanPurpose { get; set; }

        /// <summary>
        /// Seq.: 59
        /// Activity Sector
        /// </summary>
        public int ActivitySector { get; set; }

        /// <summary>
        /// Seq.: 60
        /// Financial Sector
        /// </summary>
        public int FinancialSector { get; set; }

        /// <summary>
        /// Seq.: 61
        /// Statement Frequency
        /// </summary>
        public int StmFrequency { get; set; }

        /// <summary>
        /// Seq.: 62
        /// Application Id
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Seq.: 63
        /// Final Scenario
        /// </summary>
        public int FinalScenario { get; set; }

        /// <summary>
        /// Seq.: 64
        /// Sales Unit
        /// </summary>
        public int SalesUnit { get; set; }

        /// <summary>
        /// Seq.: 65
        /// Seller
        /// </summary>
        public int Seller { get; set; }

        /// <summary>
        /// Seq.: 66
        /// Penalty Code
        /// </summary>
        public decimal PenaltyInterestRateCode { get; set; }

        /// <summary>
        /// Seq.: 67
        /// GP IR Amortization
        /// </summary>
        public int AmortGPInter { get; set; }
    }
}
