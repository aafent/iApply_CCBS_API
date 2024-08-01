namespace CCBS.Models
{
    public class CbsMediators
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
        /// Application Id (varchar (15))
        /// </summary>
        public string la_id { get; set; }

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