namespace CCBS.Models
{
    public class CbsDownloadPositionResponse : CommonResponseModel
    {
        #region Public Properties

        public List<PositionModel> PositionsList { get; set; }

        #endregion Public Properties
    }

    public class PositionModel
    {
        #region Public Properties

        /// <summary>
        /// Seq: 7
        /// Entity: cr_cucoba
        /// Description: Account Category
        /// Data Type: varchar (10)
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionEntryType
        /// </summary>
        public string cb_accd { get; set; }

        /// <summary>
        /// Seq: 8
        /// Entity: cr_cucoba
        /// Description: Account Number
        /// Data Type: varchar (30)
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionAccountNumber
        /// </summary>
        public string cb_accn { get; set; }

        /// <summary>
        /// Seq: 6
        /// Entity: cr_cucoba
        /// Description: Account Type
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionPrftSystem
        /// </summary>
        public int cb_accountkind { get; set; }

        /// <summary>
        /// Seq: 5
        /// Entity: cr_cucoba
        /// Description: Account Relation
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionNumber16
        /// </summary>
        public string cb_acountrel { get; set; }

        /// <summary>
        /// Seq: 14
        /// Entity: cr_cucoba
        /// Description: Available Balance
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionAmount10
        /// </summary>
        public decimal cb_avbalan { get; set; }

        /// <summary>
        /// Seq: 11
        /// Entity: cr_cucoba
        /// Description: Balance
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionAmount14
        /// </summary>
        public decimal cb_balan { get; set; }

        /// <summary>
        /// Seq: 22
        /// Entity: cr_cucoba
        /// Description: Capital Outstanding Amount
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionAmount26
        /// </summary>
        public decimal cb_capitalamt { get; set; }

        /// <summary>
        /// Seq: 10
        /// Entity: cr_cucoba
        /// Description: Currency
        /// Data Type: varchar (10)
        /// Notes: If currency description is null the currency id
        /// CBS: OutGrpOutGrmSearchCustPositionCurrencyDesc
        ///OutGrpOutGrmSearchCustPositionCurrencyId
        /// </summary>
        public string cb_ccy { get; set; }

        /// <summary>
        /// Seq: 9
        /// Entity: cr_cucoba
        /// Description: Account Check Digit
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionAccountCd
        /// </summary>
        public int cb_checkdigit { get; set; }

        /// <summary>
        /// Seq: 4
        /// Entity: cr_cucoba
        /// Description: Customer Last Name
        /// Data Type: varchar (70)
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionCustSurname
        /// </summary>
        public string cb_cu_lname { get; set; }

        /// <summary>
        /// Seq: 3
        /// Entity: cr_cucoba
        /// Description: Customer First Name
        /// Data Type: varchar (30)
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionCustFirstName
        /// </summary>
        public string cb_cus_fname { get; set; }

        /// <summary>
        /// Seq: 2
        /// Entity: cr_cucoba
        /// Description: Customer Check Digit
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionCustCd
        /// </summary>
        public int cb_cuscd { get; set; }

        /// <summary>
        /// Seq: 1
        /// Entity: cr_cucoba
        /// Description: Customer CBS Id
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionCustId
        /// </summary>
        public string cb_cusnum { get; set; }

        /// <summary>
        /// Seq: 20
        /// Entity: cr_cucoba
        /// Description: Expiry Date
        /// Data Type: datetime
        /// Notes: If date1 is null then date9
        ///If date9 is null then date15
        ///If date15 is null then date4
        ///If date4 is null then date5
        ///If date5 is null then date7
        ///If date7 is null then date8
        /// CBS: OutGrpOutGrmSearchCustPositionDate1
        ///OutGrpOutGrmSearchCustPositionDate9
        /// OutGrpOutGrmSearchCustPositionDate15
        ///OutGrpOutGrmSearchCustPositionDate4
        ///OutGrpOutGrmSearchCustPositionDate5
        ///OutGrpOutGrmSearchCustPositionDate7
        ///OutGrpOutGrmSearchCustPositionDate8
        /// </summary>
        public DateTime cb_expdt { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq: 23
        /// Entity: cr_cucoba
        /// Description: Monthly Installment Amount
        /// Data Type: decimal (19,3)
        /// Notes: If amount27 is zero then amount23
        /// CBS: OutGrpOutGrmSearchCustPositionAmount27
        ///OutGrpOutGrmSearchCustPositionAmount23
        /// </summary>
        public decimal cb_lastinstamt { get; set; }

        /// <summary>
        /// Seq: 15
        /// Entity: cr_cucoba
        /// Description: Account Limit
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionAmount20
        /// </summary>
        public decimal cb_limit { get; set; }

        /// <summary>
        /// Seq: 19
        /// Entity: cr_cucoba
        /// Description: Open Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionDate8
        /// </summary>
        public DateTime cb_opendt { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq: 16
        /// Entity: cr_cucoba
        /// Description: Overdue Amount
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionAmount15
        /// </summary>
        public decimal cb_outamt { get; set; }

        /// <summary>
        /// Seq: 24
        /// Entity: cr_cucoba
        /// Description: Not Used
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionAmount9
        /// </summary>
        public decimal cb_outint { get; set; }

        /// <summary>
        /// Seq: 12
        /// Entity: cr_cucoba
        /// Description: Product
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionProductId
        /// </summary>
        public int cb_prdcat { get; set; }

        /// <summary>
        /// Seq: 13
        /// Entity: cr_cucoba
        /// Description: Product Description
        /// Data Type: varchar (100)
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionProductDesc
        /// </summary>
        public string cb_proddesc { get; set; }

        /// <summary>
        /// Seq: 18
        /// Entity: cr_cucoba
        /// Description: Securities Evaluation
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionAmount23
        /// </summary>
        public decimal cb_seceval { get; set; }

        /// <summary>
        /// Seq: 26
        /// Entity: cr_cucoba
        /// Description: Not Used
        /// Data Type: varchar (20)
        /// Notes: For all the banks except HF
        /// CBS: OutGrpOutGrmSearchCustPositionFlag10
        /// </summary>
        public string cb_self { get; set; }

        /// <summary>
        /// Seq: 27
        /// Entity: cr_cucoba
        /// Description: Account Status
        /// Data Type: varchar (10)
        /// Notes: If cb_accd = 3 then code from grp =G0223
        ///If cb_accd = 5 then code from grp =G0221
        ///If cb_accd = 6 then code from grp =G0222
        /// CBS: OutGrpOutGrmSearchCustPositionText6
        ///OutGrpOutGrmSearchCustPositionText8
        ///OutGrpOutGrmSearchCustPositionText9
        /// </summary>
        public string cb_status { get; set; }

        /// <summary>
        /// Seq: 25
        /// Entity: cr_cucoba
        /// Description: Not Used
        /// Data Type: varchar (200)
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionFlag09
        /// </summary>
        public string cb_status1 { get; set; }

        /// <summary>
        /// Seq: 17
        /// Entity: cr_cucoba
        /// Description: Unclear Balance
        /// Data Type: decimal (19,3)
        /// Notes: N/A
        /// CBS: OutGrpOutGrmSearchCustPositionAmount22
        /// </summary>
        public decimal cb_unbalan { get; set; }

        /// <summary>
        /// Seq: 21
        /// Entity: cr_cucoba
        /// Description: Application Id (iApply)
        /// Data Type: varchar (15)
        /// Notes: If OutGrpOutGrmSearchCustPositionEntryType then text30 else null
        /// CBS: OutGrpOutGrmSearchCustPositionText30
        /// </summary>
        public string cbs_la_id { get; set; }

        #endregion Public Properties
    }
}