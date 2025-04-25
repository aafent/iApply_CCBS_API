using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsDeleteCollateralMaintDtlsRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Entity: v_CBS_CollateralDet
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
        /// Entity: v_CBS_CollateralDet
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
        /// Entity: v_CBS_CollateralDet
        /// Description: Value Amount
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollCovAmount { get; set; }

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Estimated Secured Value Amount
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollEstAmount { get; set; }

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Expiration Date
        /// Data Type: datetime
        /// </summary>
        public DateTime CollExpDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Return Limit
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollLimit { get; set; }

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Number of Items
        /// Data Type: integer
        /// </summary>
        public int CollNoItems { get; set; }

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Return Percent (%)
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollPerc { get; set; }

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Reevaluation Currency
        /// Data Type: integer
        /// </summary>
        public int CollReCcy { get; set; }

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Reeval. Current %
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
        /// Entity: v_CBS_CollateralDet
        /// Description: Reeval. Original %
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollReOrig { get; set; }

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Reeval. Init. Sec Value
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollRevValue { get; set; }

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Central Bank Security Amount
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollSecAmount { get; set; }

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Customer CBS Id
        /// Data Type: integer
        /// </summary>
        [Mockup(1)]
        public int customerCbsId { get; set; }

        #endregion Public Properties
    }
}