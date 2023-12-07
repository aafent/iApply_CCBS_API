namespace iApplyShared.CbsModels
{
    public class CbsGrace
    {
        #region Public Properties

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
        /// Monthly Installment (decimal (19,3))
        /// </summary>
        public decimal rs_minstal { get; set; }

        /// <summary>
        /// Payment Date (datetime)
        /// </summary>
        public DateTime rs_paydate { get; set; }

        /// <summary>
        /// Serial Number (integer)
        /// </summary>
        public int rs_paysn { get; set; }

        /// <summary>
        /// Residual principal (decimal (19,3))
        /// </summary>
        public decimal rs_resprin { get; set; }

        /// <summary>
        /// Installment Type (varchar (15))
        /// 1
        /// </summary>
        public string type { get; set; }

        #endregion Public Properties
    }
}