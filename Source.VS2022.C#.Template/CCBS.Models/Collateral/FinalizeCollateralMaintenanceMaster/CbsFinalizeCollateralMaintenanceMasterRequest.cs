using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsFinalizeCollateralMaintenanceMasterRequest : BaseCbsRequestModel
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
        /// Description: BASIL II Accepted
        /// Data Type: varchar (10)
        /// </summary>
        public string CollBasil { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Currency
        /// Data Type: integer
        /// </summary>
        public int CollCcy { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Currency Description
        /// Data Type: varchar (20)
        /// </summary>
        public string CollCcyD { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Collateral Code
        /// Data Type: varchar (40)
        /// </summary>
        public string CollCode { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Comments
        /// Data Type: varchar (100)
        /// </summary>
        public string CollComments { get; set; }

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
        public DateTime CollExpDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Return Limit
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollLimit { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Next Review Date
        /// Data Type: datetime
        /// </summary>
        public DateTime CollNextRevDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Number of Items
        /// Data Type: integer
        /// </summary>
        public int CollNoItems { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Responsible User
        /// Data Type: varchar (10)
        /// </summary>
        public string CollOfficer { get; set; }

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
        /// Entity: v_CBS_Collateral
        /// Description: Reevaluation Init. Sec Value
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollReEstVal { get; set; }

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Reference Number
        /// Data Type: varchar (40)
        /// </summary>
        public string CollRefNum { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Registry Code
        /// Data Type: varchar (20)
        /// </summary>
        public string CollRegid { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Reevaluation Original %
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollReOrig { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Review Date
        /// Data Type: datetime
        /// </summary>
        public DateTime CollRevDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Entity: v_CBS_CollateralDet
        /// Description: Reeval. Init. Sec Value
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
        /// Description: Collateral Status
        /// Data Type: varchar (10)
        /// </summary>
        public string CollStatus { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Collateral Product
        /// Data Type: integer
        /// </summary>
        public int CollType { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Customer CBS Id
        /// Data Type: integer
        /// </summary>
        [Mockup(1)]
        public int CustomerCbsId { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Monitoring Branch
        /// Data Type: integer
        /// </summary>
        public int MonUnit { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Opening Branch
        /// Data Type: integer
        /// </summary>
        public int OpenUnit { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Record Type
        /// Data Type: varchar (2)
        /// </summary>
        public string RecordType { get; set; }

        #endregion Public Properties
    }
}