using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsFinalizeCollateralCbsRequest
    {
        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Collateral CBS Id
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int? CollateralCbsId { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: BASIL II Accepted
        /// Data Type: varchar (10)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public string CollBasil { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Central Bank Security Amount
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal CollSecAmount { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Covered Amount
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal CollCovAmount { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Estimated Secured Value Amount
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal CollEstAmount { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Return Limit
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal CollLimit { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Return Percent (%)
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal CollPerc { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Currency
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int CollCcy { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Customer CBS Id
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int CustomerCbsId { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Opening Branch
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int OpenUnit { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Monitoring Branch
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int MonUnit { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Collateral Product
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int CollType { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Registry Code
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public string CollRegid { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Record Type
        /// Data Type: varchar (2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public string RecordType { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Land Registry Info
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public string CollLandReg { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Reevaluation Current %
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal CollReCur { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Reevaluation Original %
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal CollReOrig { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Reevaluation Init. Sec Value
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal CollReEstVal { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Review Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public DateTime CollRevDate { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Next Review Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public DateTime CollNextRevDate { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Responsible User
        /// Data Type: varchar (10)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public string CollOfficer { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Collateral Code
        /// Data Type: varchar (40)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public string CollCode { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Comments
        /// Data Type: varchar (100)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public string CollComments { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Number of Items
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int CollNoItems { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Reevaluation Currency
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int CollReCcy { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Currency Description
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public string CollCcyD { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Account or Agreement
        /// Data Type: varchar (40)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public string CollAccount { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Account Type
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int CollAccountType { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Reference Number
        /// Data Type: varchar (40)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public string CollRefNum { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Allocation Status
        /// Data Type: varchar (10)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public string CollateralStatus { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Allocation CBS Id
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int CollateralTrCbsId { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Account or Agreement Check digit
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public int CollAccountCd { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Expiration Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public DateTime CollExpDate { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Reeval. Init. Sec Value
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: N/A
        /// </summary>
        public decimal CollRevValue { get; set; }

        public InGrp[] InGrpArray { get; set; }
    }
}
