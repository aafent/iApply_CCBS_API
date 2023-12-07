using iApply.CCBS.Shared.CCbsModels;

namespace iApplyShared.CbsModels
{
    public class CbsCollateralListPerTypeRequest : MockupModel
    {
        /// <summary>
        /// Seq: 1
        /// Entity: N/A
        /// Description: Customer Cbs Id
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InSelectedCustomerCustId
        /// </summary>
        public int mainCustomerCBSId { get; set; }

        /// <summary>
        /// Seq: 2
        /// Entity: N/A
        /// Description: Customer Check Digit
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InSelectedCustomerCDigit
        /// </summary>
        public int mainCustomerCBSCd { get; set; }

        /// <summary>
        /// Seq: 3
        /// Entity: N/A
        /// Description: Record Type
        /// Data Type: varchar (40)
        /// Notes: select cod from cr__comast where grp = 'G64'
        /// CBS: InRecordTypeCollateralWorkRecordType
        /// </summary>
        public string recordType { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: N/A
        /// Description: N/A
        /// Data Type: integer
        /// Notes: Το service επιστρέφει μέχρι 20 γραμμές. Για τις επόμενες 20 στέλνουμε το OutContinueCollateralTableInternalSn
        /// CBS: InContinueCollateralTableInternalSn
        /// </summary>
        //public int N/A { get; set; }
    }
}
