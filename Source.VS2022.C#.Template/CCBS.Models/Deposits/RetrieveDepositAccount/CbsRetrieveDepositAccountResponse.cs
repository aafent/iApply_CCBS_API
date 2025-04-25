namespace CCBS.Models
{
    public class CbsRetrieveDepositAccountResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Agreement Number (varchar (30))
        /// </summary>
        public string agreementno { get; set; }

        /// <summary>
        /// Agreement Check Digit (integer)
        /// </summary>
        public int agreementnocd { get; set; }

        /// <summary>
        /// Main Participant CBS Id (integer)
        /// </summary>
        public int CorrespondenseCustomerSN { get; set; }

        /// <summary>
        /// Main Participant Main Address CBS S/N (integer)
        /// </summary>
        public int CorrespondenseHolderSN { get; set; }

        /// <summary>
        /// G.Ledger Acct Group (varchar (10))
        /// </summary>
        public string la_actsec { get; set; }

        /// <summary>
        /// Monit/Agree Branch (varchar (10))
        /// </summary>
        public string la_agrbranch { get; set; }

        /// <summary>
        /// Central Bank L Purp (varchar (10))
        /// </summary>
        public string la_btenor { get; set; }

        /// <summary>
        /// Currency (varchar (10))
        /// </summary>
        public string la_ccy { get; set; }

        /// <summary>
        /// Customer Category (varchar (15))
        /// </summary>
        public string la_custcat { get; set; }

        /// <summary>
        /// Account Type (varchar (1))
        /// </summary>
        public string la_depacctype { get; set; }

        /// <summary>
        /// Margin of Warning Validity - After Maturity (integer)
        /// </summary>
        public int la_depaftermat { get; set; }

        /// <summary>
        /// la_depantol (integer)
        /// </summary>
        public int la_depantol { get; set; }

        /// <summary>
        /// Approval S/N Cheques (varchar (7))
        /// </summary>
        public string la_depappcheque { get; set; }

        /// <summary>
        /// As Collateral (varchar (1))
        /// </summary>
        public string la_depascoll { get; set; }

        /// <summary>
        /// Atm Card (varchar (1))
        /// </summary>
        public string la_depatm { get; set; }

        /// <summary>
        /// Automatic Renewal (varchar (1))
        /// </summary>
        public string la_depautoren { get; set; }

        /// <summary>
        /// Margin of Warning Validity - Before Maturity (integer)
        /// </summary>
        public int la_depbeforemat { get; set; }

        /// <summary>
        /// CP Disposal Account Number (varchar (40))
        /// </summary>
        public string la_depcapacc { get; set; }

        /// <summary>
        /// CP Disposal Account Check Digit (integer)
        /// </summary>
        public int la_depcapacc_cd { get; set; }

        /// <summary>
        /// Capital Incr. Amount (decimal (19,3))
        /// </summary>
        public decimal la_depcapamnt { get; set; }

        /// <summary>
        /// Fixed Credit IR (varchar (1))
        /// </summary>
        public string la_depcfixed { get; set; }

        /// <summary>
        /// Margin Changed IR (decimal (19,3))
        /// </summary>
        public decimal la_depchangemar { get; set; }

        /// <summary>
        /// Change % (decimal (19,3))
        /// </summary>
        public decimal la_depchangeperc { get; set; }

        /// <summary>
        /// Auto. Chequebook Order (varchar (1))
        /// </summary>
        public string la_depchequebook { get; set; }

        /// <summary>
        /// Cheque Approval Date (datetime)
        /// </summary>
        public DateTime la_depchequefdate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Cheque Iss. Exp. % (decimal (19,3))
        /// </summary>
        public decimal la_depchequeperc { get; set; }

        /// <summary>
        /// Max Period Disc. Cheque(M) (integer)
        /// </summary>
        public int la_depchequepermax { get; set; }

        /// <summary>
        /// Cheque Expiry Date (datetime)
        /// </summary>
        public DateTime la_depchequetdate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Credit Indicator (varchar (1))
        /// </summary>
        public string la_depcind { get; set; }

        /// <summary>
        /// Collateral Date (datetime)
        /// </summary>
        public DateTime la_depcolldate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Conditional Account (varchar (1))
        /// </summary>
        public string la_depconacc { get; set; }

        /// <summary>
        /// Credit Spread (decimal (19,3))
        /// </summary>
        public decimal la_depcspread { get; set; }

        /// <summary>
        /// Account Description (varchar (60))
        /// </summary>
        public string la_depdescr { get; set; }

        /// <summary>
        /// Debit Expiry Date (datetime)
        /// </summary>
        public DateTime la_depdexpdt { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Debit Indicator (varchar (1))
        /// </summary>
        public string la_depdind { get; set; }

        /// <summary>
        /// Discount Cheques Percentage (decimal (19,3))
        /// </summary>
        public decimal la_depdiscperc { get; set; }

        /// <summary>
        /// Withdrawals From Day (integer)
        /// </summary>
        public int la_depdrawdfrom { get; set; }

        /// <summary>
        /// Withdrawals To Day (integer)
        /// </summary>
        public int la_depdrawdto { get; set; }

        /// <summary>
        /// Withdrawals From Month (integer)
        /// </summary>
        public int la_depdrawmfrom { get; set; }

        /// <summary>
        /// Withdrawals To Month (integer)
        /// </summary>
        public int la_depdrawmto { get; set; }

        /// <summary>
        /// Withdrawals Validity Period (integer)
        /// </summary>
        public int la_depdrawper { get; set; }

        /// <summary>
        /// Service Charges % (decimal (19,3))
        /// </summary>
        public decimal la_depdsic { get; set; }

        /// <summary>
        /// Debit Spread (decimal (19,3))
        /// </summary>
        public decimal la_depdspread { get; set; }

        /// <summary>
        /// External Account (varchar (1))
        /// </summary>
        public string la_depextacc { get; set; }

        /// <summary>
        /// Fixed Income Amount (decimal (19,3))
        /// </summary>
        public decimal la_depfixamnt { get; set; }

        /// <summary>
        /// Fixed Income Frequency (integer)
        /// </summary>
        public int la_depfixfreq { get; set; }

        /// <summary>
        /// IR Disposal Account Number (varchar (40))
        /// </summary>
        public decimal la_depintacc { get; set; }

        /// <summary>
        /// IR Disposal Account Check Digit (integer)
        /// </summary>
        public int la_depintacc_cd { get; set; }

        /// <summary>
        /// Withdrawals Max drawdown Amt (decimal (19,3))
        /// </summary>
        public decimal la_depmaxdrawamnt { get; set; }

        /// <summary>
        /// Mon. Gross Salary Multip. (integer)
        /// </summary>
        public int la_depmonfgross { get; set; }

        /// <summary>
        /// Moved by House Unit (varchar (1))
        /// </summary>
        public string la_depmunit { get; set; }

        /// <summary>
        /// Mutual Funds of Own Capital (varchar (1))
        /// </summary>
        public string la_depmutfund { get; set; }

        /// <summary>
        /// No. of Approved Cheques (integer)
        /// </summary>
        public int la_depnocheque { get; set; }

        /// <summary>
        /// Non Tax Inter Deduction (varchar (1))
        /// </summary>
        public string la_depnoded { get; set; }

        /// <summary>
        /// Notes (varchar (40))
        /// </summary>
        public string la_depnotesn { get; set; }

        /// <summary>
        /// Account Officer (varchar (10))
        /// </summary>
        public string la_depofficer { get; set; }

        /// <summary>
        /// Account Limit (decimal (19,3))
        /// </summary>
        public decimal la_depovlimit { get; set; }

        /// <summary>
        /// Account Indicator (varchar (15))
        /// </summary>
        public string la_depprtype { get; set; }

        /// <summary>
        /// Renewal Date (datetime)
        /// </summary>
        public DateTime la_deprenewaldt { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Review Date (datetime)
        /// </summary>
        public DateTime la_depreviewdt { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Discount Cheques Risk Diversification (decimal (19,3))
        /// </summary>
        public decimal la_depriskdiv { get; set; }

        /// <summary>
        /// Secondary Account Number (varchar (40))
        /// </summary>
        public string la_depsecacc { get; set; }

        /// <summary>
        /// Secondary Account Check Digit (integer)
        /// </summary>
        public int la_depsecacc_cd { get; set; }

        /// <summary>
        /// Special Account (varchar (1))
        /// </summary>
        public string la_depspeacc { get; set; }

        /// <summary>
        /// Statement (varchar (1))
        /// </summary>
        public string la_depstatem { get; set; }

        /// <summary>
        /// Statement Frequency (varchar (15))
        /// </summary>
        public string la_depstfreq { get; set; }

        /// <summary>
        /// Tax Country Description (varchar (15))
        /// </summary>
        public string la_deptaxcntry { get; set; }

        /// <summary>
        /// Telebank (varchar (1))
        /// </summary>
        public string la_deptelebank { get; set; }

        /// <summary>
        /// Temporary Limit Expiry Date (datetime)
        /// </summary>
        public DateTime la_deptemenddt { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Temporary Limit Excess (decimal (19,3))
        /// </summary>
        public decimal la_deptemlimit { get; set; }

        /// <summary>
        /// Temporary Limit Start Date (datetime)
        /// </summary>
        public DateTime la_deptemstdt { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Limit Encr/nt Toler. (decimal (19,3))
        /// </summary>
        public decimal la_deptollimit { get; set; }

        /// <summary>
        /// Deposit Type (varchar (1))
        /// </summary>
        public string la_deptype { get; set; }

        /// <summary>
        /// Withdrawal from Unclear (varchar (1))
        /// </summary>
        public string la_depwunclear { get; set; }

        /// <summary>
        /// Debit IR (varchar (15))
        /// </summary>
        public string la_flintrate { get; set; }

        /// <summary>
        /// Credit IR (varchar (10))
        /// </summary>
        public string la_intrate { get; set; }

        /// <summary>
        /// Purpose (varchar (10))
        /// </summary>
        public string la_lpurp { get; set; }

        /// <summary>
        /// Overdraft Maturity Date (datetime)
        /// </summary>
        public DateTime la_ovexpdt { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Over. Limit Margin (decimal (19,3))
        /// </summary>
        public decimal la_ovmaxlimit { get; set; }

        /// <summary>
        /// Excess IR (varchar (10))
        /// </summary>
        public string la_pintrate { get; set; }

        /// <summary>
        /// Product CBS Id (varchar (10))
        /// </summary>
        public string la_produ { get; set; }

        /// <summary>
        /// Sales Unit (varchar (10))
        /// </summary>
        public string la_salesunit { get; set; }

        /// <summary>
        /// Seller (varchar (10))
        /// </summary>
        public string la_seller { get; set; }

        #endregion Public Properties
    }
}