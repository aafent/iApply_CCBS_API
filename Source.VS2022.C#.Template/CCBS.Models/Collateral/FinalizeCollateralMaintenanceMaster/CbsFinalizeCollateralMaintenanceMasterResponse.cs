namespace CCBS.Models
{
    public class CbsFinalizeCollateralMaintenanceMasterResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Entity: crp_CBS_updateCollDetCBSID
        /// Description: Account or Agreement
        /// Data Type: varchar (40)
        /// </summary>
        public string co_account { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollDetCBSID
        /// Description: Account or Agreement Check Digit
        /// Data Type: integer
        /// </summary>
        public int co_accountcd { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollCBSID
        /// Description: Collateral CBS Id
        /// Data Type: integer
        /// </summary>
        public int co_cbsid { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollCBSID
        /// Description: Collateral Id
        /// Data Type: varchar (15)
        /// </summary>
        public string co_id { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollCBSID
        /// Description: Collateral Status
        /// Data Type: varchar (10)
        /// </summary>
        public string co_status { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollDetCBSID
        /// Description: Allocation CBS Id
        /// Data Type: integer
        /// </summary>
        public int co_trcbsid { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollCBSID
        /// Description: Application Id
        /// Data Type: varchar (15)
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollCBSID
        /// Description: Source
        /// Data Type: varchar (15)
        /// </summary>
        public string source { get; set; }

        #endregion Public Properties
    }
}