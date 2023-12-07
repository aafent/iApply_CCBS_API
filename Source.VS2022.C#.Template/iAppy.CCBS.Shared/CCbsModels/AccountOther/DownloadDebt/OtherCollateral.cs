namespace iApplyShared.CbsModels
{
    public class OtherCollateral
    {
        #region Public Properties

        /// <summary>
        /// Property CBS Id
        /// Data Type: integer
        /// Entities: cr_curees_other
        /// </summary>
        public int cbsid { get; set; }

        /// <summary>
        /// Open Market Value
        /// Data Type: decimal (19,3)
        /// Entities: cr_lacola
        /// </summary>
        public decimal co_markval { get; set; }

        /// <summary>
        /// Security Value
        /// Data Type: decimal (19,3)
        /// Entities: cr_lacola
        /// </summary>
        public decimal co_secval { get; set; }

        /// <summary>
        /// Market Value
        /// Data Type: decimal (19,3)
        /// Entities: cr_lacola
        /// </summary>
        public decimal co_sum { get; set; }

        /// <summary>
        /// Property Type
        /// Data Type: varchar (10)
        /// Entities: cr_curees_other
        /// </summary>
        public string CollateralType { get; set; }

        #endregion Public Properties
    }
}