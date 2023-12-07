namespace iApplyShared.CbsModels
{
    public class CbsInsurance
    {
        #region Public Properties

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