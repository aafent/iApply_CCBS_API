namespace CCBS.Models
{
    public class CbsCustomerIdentification
    {
        #region Public Properties

        /// <summary>
        /// Seq: 4
        /// Entity: cr_cuident
        /// Description: Issue Country
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCountryGenericDetailSerialNum
        /// </summary>
        public int idcountry { get; set; }

        /// <summary>
        /// Seq: 8
        /// Entity: cr_cuident
        /// Description: Authority
        /// Data Type: varchar (100)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmOtherIdIssueAuthority
        /// </summary>
        public string pe_authority { get; set; }

        /// <summary>
        /// Seq: 7
        /// Entity: cr_cuident
        /// Description: Document No
        /// Data Type: varchar (4000)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustomerIncompleteUComnt
        /// </summary>
        public string pe_document { get; set; }

        /// <summary>
        /// Seq: 6
        /// Entity: cr_cuident
        /// Description: Expiry Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmOtherIdExpiryDate
        /// </summary>
        public DateTime pe_exp_date { get; set; }

        /// <summary>
        /// Seq: 3
        /// Entity: cr_cuident
        /// Description: Identification Number
        /// Data Type: varchar (100)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmOtherIdIdNo
        /// </summary>
        public string pe_idnbr { get; set; }

        /// <summary>
        /// Seq: 2
        /// Entity: cr_cuident
        /// Description: Identification Type
        /// Data Type: varchar (10)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmTypeGenericDetailSerialNum
        /// </summary>
        public string pe_idtyp { get; set; }

        /// <summary>
        /// Seq: 5
        /// Entity: cr_cuident
        /// Description: Issue Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmOtherIdIssueDate
        /// </summary>
        public DateTime pe_issuon { get; set; }

        /// <summary>
        /// Seq: 1
        /// Entity: cr_cuident
        /// Description: Main Id
        /// Data Type: varchar(1)
        /// Notes: N/A
        /// </summary>
        /// CBS: OutListGrpOutGrmOtherIdMainFlag
        public string pe_main { get; set; }

        /// <summary>
        /// Seq: 9
        /// Entity: cr_cuident
        /// Description: CBS SN
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmOtherIdSerialNo
        /// </summary>
        public int sn_cbs { get; set; }

        #endregion Public Properties
    }
}