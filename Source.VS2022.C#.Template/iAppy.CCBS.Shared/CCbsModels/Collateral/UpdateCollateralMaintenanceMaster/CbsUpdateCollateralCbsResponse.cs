namespace iApplyShared.CbsModels
{
    public class CbsUpdateCollateralCbsResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Entity: crp_CBS_updateCollDetCBSID
        /// Description: Allocation CBS Id
        /// Data Type: integer
        /// </summary>
        public int AllocationCbsId { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollDetCBSID
        /// Description: Allocation Status
        /// Data Type: varchar (10)
        /// </summary>
        public string AllocationStatus { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollDetCBSID
        /// Description: Application Id
        /// Data Type: varchar (15)
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollDetCBSID
        /// Description: Account or Agreement
        /// Data Type: varchar (40)
        /// </summary>
        public string CollateralAccount { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollDetCBSID
        /// Description: Account or Agreement Check Digit
        /// Data Type: integer
        /// </summary>
        public int CollateralAccountCd { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollDetCBSID
        /// Description: Collateral CBS Id
        /// Data Type: integer
        /// </summary>
        public int CollateralCbsId { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollDetCBSID
        /// Description: Collateral Id
        /// Data Type: varchar (15)
        /// </summary>
        public string CollateralId { get; set; }

        #endregion Public Properties
    }
}