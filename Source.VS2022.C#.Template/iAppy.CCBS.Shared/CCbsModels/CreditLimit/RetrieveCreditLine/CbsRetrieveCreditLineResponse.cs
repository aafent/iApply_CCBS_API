namespace iApplyShared.CbsModels
{
    public class CbsRetrieveCreditLineResponse : CommonResponseModel
    {
        #region Public Properties

        public List<RetrieveCredit> RetrieveCredits { get; set; }

        #endregion Public Properties
    }

    public class RetrieveCredit
    {
        #region Public Properties

        /// <summary>
        /// Credit Limit Amount
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucreditline
        /// </summary>
        public decimal cr_amount { get; set; }

        /// <summary>
        /// Assignment Date
        /// Entities: cr_cucreditline
        /// </summary>
        public DateTime cr_assigndt { get; set; }

        /// <summary>
        /// Credit Limit Currency
        /// Data Type: integer
        /// Entities: cr_cucreditline
        /// </summary>
        public int cr_ccy { get; set; }

        /// <summary>
        /// Expiry Date
        /// Data Type: datetime
        /// Entities: cr_cucreditline
        /// </summary>
        public DateTime cr_expdt { get; set; }

        /// <summary>
        /// Next Review Date
        /// Data Type: datetime
        /// Entities: cr_cucreditline
        /// </summary>
        public DateTime cr_nextreviewdt { get; set; }

        /// <summary>
        /// Review Date
        /// Data Type: datetime
        /// Entities: cr_cucreditline
        /// </summary>
        public DateTime cr_reviewdt { get; set; }

        /// <summary>
        /// Credit Limit Status
        /// Data Type: varchar (15)
        /// Entities: cr_cucreditline
        /// </summary>
        public string cr_status { get; set; }

        /// <summary>
        /// Credit Limit Type
        /// Data Type: varchar (15)
        /// Entities: cr_cucreditline
        /// </summary>
        public string cr_type { get; set; }

        /// <summary>
        /// Utilized Limit
        /// Data Type: decimal (19,3)
        /// Entities: cr_cucreditline
        /// </summary>
        public decimal cr_utamount { get; set; }

        /// <summary>
        /// Customer Id
        /// Data Type: varchar (15)
        /// Entities: cr_cucreditline
        /// </summary>
        public string cu_id { get; set; }

        #endregion Public Properties
    }
}