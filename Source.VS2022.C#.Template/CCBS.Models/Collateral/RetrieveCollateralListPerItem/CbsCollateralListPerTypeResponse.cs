namespace CCBS.Models
{
    public class CbsCollateralListPerTypeResponse : CommonResponseModel
    {
        public List<CollateralListItem> CollateralList { get; set; }
    }

    public class CollateralListItem
    {
        /// <summary>
        /// Seq: 1
        /// Entity: N/A
        /// Description: Property Cbs Id
        /// Data Type: varchar (40)
        /// Notes: N/A
        /// CBS: OutGrpRecordsOutGrmCollateralTableInternalSn
        /// </summary>
        public string SN { get; set; }

        /// <summary>
        /// Seq: 2
        /// Entity: N/A
        /// Description: Description
        /// Data Type: varchar (100)
        /// Notes: N/A
        /// CBS: OutGrpRecordsOutGrmCollateralTableRecordDescr
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Seq: 3
        /// Entity: N/A
        /// Description: Usage
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpRecordsOutGrmCollateralTableCollateralUsage
        /// </summary>
        public string Usage { get; set; }

        /// <summary>
        /// Seq: 4
        /// Entity: N/A
        /// Description: Status
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpRecordsOutGrmCollateralTableEntryStatus
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Seq: 5
        /// Entity: N/A
        /// Description: Amount
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpRecordsOutGrmPrenAmnIefSuppliedNumber152
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Seq: 6
        /// Entity: N/A
        /// Description: Collateral Cbs Id
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpRecordsOutGrmCollateralTableUsedCollatSn
        /// </summary>
        public int UsedCollatSn { get; set; }

        /// <summary>
        /// Seq: 7
        /// Entity: N/A
        /// Description: Unit
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpRecordsOutGrmCollateralTableUsedUnit
        /// </summary>
        public int UsedUnit { get; set; }

        /// <summary>
        /// Seq: 8
        /// Entity: N/A
        /// Description: Collateral Type
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpRecordsOutGrmCollateralTableUsedCollatType
        /// </summary>
        public int UsedCollatType { get; set; }
    }
}
