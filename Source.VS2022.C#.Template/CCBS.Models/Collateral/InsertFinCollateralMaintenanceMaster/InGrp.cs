namespace CCBS.Models
{
    public class InGrp
    {
        #region Public Properties

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Account or Agreement
        /// Data Type: varchar (40)
        /// </summary>
        public string CollAccount { get; set; }

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Account or Agreement Check digit
        /// Data Type: integer
        /// </summary>
        public int CollAccountCd { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Account Type
        /// Data Type: integer
        /// </summary>
        public int CollAccountType { get; set; }

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Allocation Status
        /// Data Type: varchar (10)
        /// </summary>
        public string CollateralStatus { get; set; }

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Allocation CBS Id
        /// Data Type: integer
        /// </summary>
        public int CollateralTrCbsId { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Covered Amount
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollCovAmount { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Estimated Secured Value Amount
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollEstAmount { get; set; }

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Expiration Date
        /// Data Type: datetime
        /// </summary>
        public DateTime CollExpDate { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Return Limit
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollLimit { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Number of Items
        /// Data Type: integer
        /// </summary>
        public int CollNoItems { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Return Percent (%)
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollPerc { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Reevaluation Currency
        /// Data Type: integer
        /// </summary>
        public int CollReCcy { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Reevaluation Current %
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollReCur { get; set; }

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Reference Number
        /// Data Type: varchar (40)
        /// </summary>
        public string CollRefNum { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Reevaluation Original %
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollReOrig { get; set; }

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Reevaluation Init. Sec Value
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollRevValue { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Central Bank Security Amount
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollSecAmount { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Customer CBS Id
        /// Data Type: integer
        /// </summary>
        public int CustomerCbsId { get; set; }

        #endregion Public Properties
    }
}