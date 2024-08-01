namespace CCBS.Models
{
    public class CbsDownloadRepScheduleSimResponse : CommonResponseModel
    {
        #region Public Properties

        public List<CbsGrace> Grace { get; set; }

        public List<RepaymentScheduleSimulation> RepaymentScheduleSimulations { get; set; } = new();

        #endregion Public Properties
    }

    public class RepaymentScheduleSimulation
    {
        #region Public Properties

        /// <summary>
        /// Mediator Check Digit (integer)
        /// </summary>
        public int checkdigit2 { get; set; }

        /// <summary>
        /// Mediator CBS Id (varchar (20))
        /// </summary>
        public string clnum2 { get; set; }

        /// <summary>
        /// Type (varchar (15))
        /// </summary>
        public string co_relat { get; set; }

        /// <summary>
        /// Mediator Full Name (varchar (100))
        /// </summary>
        public string co_sunam { get; set; }

        /// <summary>
        /// Deposit Account  (varchar (20))
        /// </summary>
        public string currentaccount { get; set; }

        /// <summary>
        /// Deposit Account Check Digit (integer)
        /// </summary>
        public int currentaccount_cd { get; set; }

        /// <summary>
        /// Insurance Id (varchar (20))
        /// </summary>
        public string insurance_id { get; set; }

        /// <summary>
        /// Insured Amount (decimal (19,3))
        /// </summary>
        public decimal insured_amnt { get; set; }

        /// <summary>
        /// Birth Date (datetime)
        /// </summary>
        public DateTime insurer_birthdate { get; set; }

        /// <summary>
        /// Main Beneficiary (varchar (15))
        /// </summary>
        public string insurer_mainbf { get; set; }

        /// <summary>
        /// Application Id (varchar (15))
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Commission (decimal (19,3))
        /// </summary>
        public decimal rs_commision { get; set; }

        /// <summary>
        /// Contribution (decimal (19,3))
        /// </summary>
        public decimal rs_contrib { get; set; }

        /// <summary>
        /// Insurance (decimal (19,3))
        /// </summary>
        public decimal rs_insurance { get; set; }

        /// <summary>
        /// Insurance with Installments (decimal (19,3))
        /// </summary>
        public decimal rs_insurance2 { get; set; }

        /// <summary>
        /// Interest Payment (decimal (19,3))
        /// </summary>
        public decimal rs_intrpay { get; set; }

        /// <summary>
        /// Monthly Installment (decimal (19,3))
        /// </summary>
        public decimal rs_minstal { get; set; }

        /// <summary>
        /// Normal Interest (decimal (19,3))
        /// </summary>
        public decimal rs_norm_int { get; set; }

        /// <summary>
        /// Payment Date (datetime)
        /// </summary>
        public DateTime rs_paydate { get; set; }

        /// <summary>
        /// Principal Payment (decimal (19,3))
        /// </summary>
        public decimal rs_payprin { get; set; }

        /// <summary>
        /// Serial Number (integer)
        /// </summary>
        public int rs_paysn { get; set; }

        /// <summary>
        /// Residual principal (decimal (19,3))
        /// </summary>
        public decimal rs_resprin { get; set; }

        /// <summary>
        /// Spread (decimal (19,3))
        /// </summary>
        public decimal rs_spread { get; set; }

        /// <summary>
        /// Serial Number (integer)
        /// </summary>
        public int serial_num { get; set; }

        /// <summary>
        /// Installment Type (varchar (15))
        /// 1
        /// </summary>
        public string type { get; set; }

        #endregion Public Properties
    }
}