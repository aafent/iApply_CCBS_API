using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsUpdateCollateralMaintenanceMasterRequest : BaseCbsRequestModel
    {
        #region Public Properties

        public List<CbsCollateralMaintenanceDetails> CbsInsertCollateralMaintenanceDetails { get; set; } = new();

        public List<CbsCollateralMaintenanceDetails> CbsUpdateCollateralMaintenanceDetails { get; set; } = new();

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Collateral CBS Id
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InKeyCollateralCollateralSn
        /// </summary>
        public int CollateralCbsId { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: BASIL II Accepted
        /// Data Type: varchar (10)
        /// Notes: N/A
        /// CBS: InCollateralBaselIiAcpt
        /// </summary>
        public string CollBasil { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Currency
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InCurrencyIdCurrency
        /// </summary>
        public int CollCcy { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Currency Description
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: InCurrencyShortDescr
        /// </summary>
        public string CollCcyD { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Collateral Code
        /// Data Type: varchar (40)
        /// Notes: N/A
        /// CBS: InCollateralCollateralCode
        /// </summary>
        public string CollCode { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Comments
        /// Data Type: varchar (100)
        /// Notes: N/A
        /// CBS: InCollateralCollateralDesc
        /// </summary>
        public string CollComments { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Covered Amount
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: InCollateralColEstInsuranceAmn
        /// </summary>
        public decimal CollCovAmount { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Estimated Secured Value Amount
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: InCollateralColEstValueAmn
        /// </summary>
        public decimal CollEstAmount { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Return Limit
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: InCollateralYieldLimitAmn
        /// </summary>
        public decimal CollLimit { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Next Review Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: InCollateralReviseDt
        /// </summary>
        public DateTime CollNextRevDate { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Number of Items
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InCollateralItemsCnt
        /// </summary>
        public int CollNoItems { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Responsible User
        /// Data Type: varchar (10)
        /// Notes: N/A
        /// CBS: InAppraiserBankemployeeId
        /// </summary>
        public string CollOfficer { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Return Percent (%)
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: InCollateralYieldPerc
        /// </summary>
        public decimal CollPerc { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Reevaluation Currency
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InCollateralRevaluationCurrid
        /// </summary>
        public int CollReCcy { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Reevaluation Current %
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: InCollateralRevalCurrFixRat
        /// </summary>
        public decimal CollReCur { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Reevaluation Init. Sec Value
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: InCollateralRevalInitSv
        /// </summary>
        public decimal CollReEstVal { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Registry Code
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: InNewColltblCollateralTableInternalSn
        /// </summary>
        public string CollRegid { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Reevaluation Original %
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: InCollateralRevalInitFixRat
        /// </summary>
        public decimal CollReOrig { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Review Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: InCollateralEstimationDt
        /// </summary>
        public DateTime CollRevDate { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Central Bank Security Amount
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: InCollateralCbInsuranceAmn
        /// </summary>
        public decimal CollSecAmount { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Collateral Status
        /// Data Type: varchar (10)
        /// Notes: N/A
        /// CBS: InCollateralCollateralStatus
        /// </summary>
        public string CollStatus { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Collateral Product
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InCollateralProductIdProduct
        /// </summary>
        public int CollType { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Customer CBS Id
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InCustomerCustId
        /// </summary>
        [Mockup(1)]
        public int CustomerCbsId { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Monitoring Branch
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InMonitoringUnitCode
        /// </summary>
        public int MonUnit { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Opening Branch
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InCollUnitCode
        /// </summary>
        public int OpenUnit { get; set; }

        ///// <summary>
        ///// Seq: N/A
        ///// Entity: v_CBS_Collateral
        ///// Description: Collateral Product
        ///// Data Type: integer
        ///// Notes: N/A
        ///// CBS: InCollateralTypeProductIdProduct
        ///// </summary>
        //public int CollType { get; set; }
        ///// <summary>
        ///// Seq: N/A
        ///// Entity: v_CBS_Collateral
        ///// Description: Customer CBS Id
        ///// Data Type: integer
        ///// Notes: If CustomerCbsId is null then 0
        ///// CBS: InNewColltblCustomerCustId
        ///// </summary>
        //public int CustomerCbsId { get; set; }

        ///// <summary>
        ///// Seq: N/A
        ///// Entity: v_CBS_Collateral
        ///// Description: Customer CBS Id
        ///// Data Type: integer
        ///// Notes: If CustomerCbsId is null then 0
        ///// CBS: InNewCustomerCustId
        ///// </summary>
        //public int CustomerCbsId { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_Collateral
        /// Description: Record Type
        /// Data Type: varchar (2)
        /// Notes: N/A
        /// CBS: InNewColltblCollateralTableRecordType
        /// </summary>
        public string RecordType { get; set; }

        #endregion Public Properties

        ///// <summary>
        ///// Seq: N/A
        ///// Entity: v_CBS_Collateral
        ///// Description: Estimated Secured Value Amount
        ///// Data Type: decimal (15,2)
        ///// Notes: N/A
        ///// CBS: InAccountCollateralAccountCollateralEstInsuranceAmn
        ///// </summary>
        //public decimal CollEstAmount { get; set; }

        ///// <summary>
        ///// Seq: N/A
        ///// Entity: v_CBS_Collateral
        ///// Description: Covered Amount
        ///// Data Type: decimal (15,2)
        ///// Notes: N/A
        ///// CBS: InAccountCollateralAccountCollateralEstValueAmn
        ///// </summary>
        //public decimal CollCovAmount { get; set; }
        ///// <summary>
        ///// Seq: N/A
        ///// Entity: v_CBS_Collateral
        ///// Description: Collateral CBS Id
        ///// Data Type: integer
        ///// Notes: N/A
        ///// CBS: InCollateralCollateralSn
        ///// </summary>
        //public int CollateralCbsId { get; set; }

        ///// <summary>
        ///// Seq: N/A
        ///// Entity: v_CBS_CollateralDet
        ///// Description: Collateral Product
        ///// Data Type: integer
        ///// Notes: If CollType has value
        ///// CBS: InCollateralProductIdProduct
        ///// </summary>
        //public int CollType { get; set; }

        ///// <summary>
        ///// Seq: N/A
        ///// Entity: v_CBS_CollateralDet
        ///// Description: Collateral Product
        ///// Data Type: integer
        ///// Notes: If CollType has value
        ///// CBS: InCollateralTypeProductIdProduct
        ///// </summary>
        //public int CollType { get; set; }
    }
}