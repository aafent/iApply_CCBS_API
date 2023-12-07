namespace iApplyShared.CbsModels
{
    public class CbsCollateralMaintenanceDetails
    {
        #region Public Properties

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Account or Agreement
        /// Data Type: varchar (40)
        /// Notes: N/A
        /// CBS: InAccountCollateralAccountCollateralPrftAccount
        /// </summary>
        public string CollAccount { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Account or Agreement Check digit
        /// Data Type: integer
        /// Notes: If CollAccountCd has value
        /// CBS: InAccountCollateralAccountCollateralAccountCd
        /// </summary>
        public int CollAccountCd { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Account Type
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InAccountCollateralAccountCollateralProfitsSystem
        /// </summary>
        public int CollAccountType { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Collateral CBS Id
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InCollateralCollateralSn
        /// </summary>
        public int CollateralCbsId { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Allocation CBS Id
        /// Data Type: integer
        /// Notes: If Collateral Type = 'CH'
        /// CBS: InAccountCollateralAccountCollateralInternalSn
        /// </summary>
        public int CollateralTrCbsId { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Currency
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InCurrencyIdCurrency
        /// </summary>
        public int CollCcy { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Collateral Allocation Class
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: InAccountCollateralAccountCollateralMortgageClass
        /// </summary>
        public string CollClass { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Value Amount
        /// Data Type: decimal (15,2)
        /// Notes: If CollCovAmount has value
        /// CBS: InAccountCollateralAccountCollateralEstInsuranceAmn
        /// </summary>
        public decimal CollCovAmount { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Estimated Secured Value Amount
        /// Data Type: decimal (15,2)
        /// Notes: If CollEstAmount has value
        /// CBS: InAccountCollateralAccountCollateralEstInsuranceAmn
        /// </summary>
        public decimal CollEstAmount { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Expiration Date
        /// Data Type: datetime
        /// Notes: If CollExpDate has value
        /// CBS: InAccountCollateralAccountCollateralExpiryDt
        /// </summary>
        public DateTime CollExpDate { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Return Limit
        /// Data Type: decimal (15,2)
        /// Notes: If CollLimit has value
        /// CBS: InAccountCollateralAccountCollateralYieldLimitAmn
        /// </summary>
        public decimal CollLimit { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Number of Items
        /// Data Type: integer
        /// Notes: If CollNoItems has value
        /// CBS: InAccountCollateralAccountCollateralItemsCnt
        /// </summary>
        public int CollNoItems { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Return Percent (%)
        /// Data Type: decimal (15,2)
        /// Notes: If CollPerc has value
        /// CBS: InAccountCollateralAccountCollateralYieldPerc
        /// </summary>
        public decimal CollPerc { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Reevaluation Currency
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InAccountCollateralAccountCollateralRevaluationCurrid
        /// </summary>
        public int CollReCcy { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Reeval. Current %
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: InAccountCollateralAccountCollateralRevalCurrFixRat
        /// </summary>
        public decimal CollReCur { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Reference Number
        /// Data Type: varchar (40)
        /// Notes: N/A
        /// CBS: InAccountCollateralAccountCollateralReferenceNumber
        /// </summary>
        public string CollRefNum { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Reeval. Original %
        /// Data Type: decimal (15,2)
        /// Notes: N/A
        /// CBS: InAccountCollateralAccountCollateralRevalInitFixRat
        /// </summary>
        public decimal CollReOrig { get; set; }

        ///// <summary>
        ///// Seq: N/A
        ///// Entity: v_CBS_CollateralDet
        ///// Description: Collateral CBS Id
        ///// Data Type: integer
        ///// Notes: N/A
        ///// CBS: InKeyCollateralCollateralSn
        ///// </summary>
        //public int CollateralCbsId { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Reeval. Init. Sec Value
        /// Data Type: decimal (15,2)
        /// Notes: If CollRevValue has value
        /// CBS: InAccountCollateralAccountCollateralRevalInitSv
        /// </summary>
        public decimal CollRevValue { get; set; }

        ///// <summary>
        ///// Seq: N/A
        ///// Entity: v_CBS_CollateralDet
        ///// Description: Customer CBS Id
        ///// Data Type: integer
        ///// Notes: If CustomerCbsId is null then 0
        ///// CBS: InCustomerCustId
        ///// </summary>
        //public int CustomerCbsId { get; set; }
        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Central Bank Security Amount
        /// Data Type: decimal (15,2)
        /// Notes: If CollSecAmount has value
        /// CBS: InAccountCollateralAccountCollateralCbInsuranceAmn
        /// </summary>
        public decimal CollSecAmount { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Collateral Product
        /// Data Type: integer
        /// Notes: If CollType has value
        /// CBS: InCollateralProductIdProduct
        /// </summary>
        public int CollType { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Customer CBS Id
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InGrpInGrmCustomerCustId
        /// </summary>
        public int customerCbsId { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Customer CBS Id
        /// Data Type: integer
        /// Notes: If CustomerCbsId is null then 0
        /// CBS: InNewCustomerCustId
        /// </summary>
        public int CustomerCbsId { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Monitoring Branch
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InMonitoringUnitCode
        /// </summary>
        public int MonUnit { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Opening Branch
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InCollUnitCode
        /// </summary>
        public int OpenUnit { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_CollateralDet
        /// Description: Record Type
        /// Data Type: varchar (2)
        /// Notes: N/A
        /// CBS: InNewColltblCollateralTableRecordType
        /// </summary>
        public string RecordType { get; set; }

        #endregion Public Properties

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