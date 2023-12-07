namespace iApplyShared.CbsModels
{
    public class CbsSaveAccountScenarioResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Agreement Number
        /// Data Type: varchar (30)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string agreementno { get; set; }

        /// <summary>
        /// Agreement Check Digit
        /// Data Type: integer
        /// Entities: cr_laaccscenario
        /// </summary>
        public int agreementnocd { get; set; }

        /// <summary>
        /// CBS Request Date
        /// Data Type: datetime
        /// Entities: cr_laaccscenario
        /// </summary>
        public DateTime cbs_request_dt { get; set; }

        /// <summary>
        /// CBS Serial Number
        /// Data Type: integer
        /// Entities: cr_laaccscenario
        /// </summary>
        public int cbs_serial_num { get; set; }

        /// <summary>
        /// Customer Id
        /// Data Type: varchar (15)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string cu_id { get; set; }

        /// <summary>
        /// Deposit Account
        /// Data Type: varchar (30)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string currentaccount { get; set; }

        /// <summary>
        /// Deposit Account Check Digit
        /// Data Type: integer
        /// Entities: cr_laaccscenario
        /// </summary>
        public int currentaccount_cd { get; set; }

        /// <summary>
        /// Advising Bank
        /// Data Type: varchar (15)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_advbank { get; set; }

        /// <summary>
        /// Monitoring Branch
        /// Data Type: varchar (15)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_agrbranch { get; set; }

        /// <summary>
        /// Amount
        /// Data Type: decimal (19,3)
        /// Entities: cr_laaccscenario
        /// </summary>
        public decimal la_appamt { get; set; }

        /// <summary>
        /// Settlement Type
        /// Data Type: varchar (10)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_atsight { get; set; }

        /// <summary>
        /// Monitoring Branch
        /// Data Type: integer
        /// Entities: cr_laaccscenario
        /// </summary>
        public int la_branc { get; set; }

        /// <summary>
        /// Currency
        /// Data Type: varchar (15)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_ccy { get; set; }

        /// <summary>
        /// Central Bank
        /// Data Type: varchar (15)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_centalbank { get; set; }

        /// <summary>
        /// Closing Location
        /// Data Type: varchar (40)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_closingloc { get; set; }

        /// <summary>
        /// Confirming Bank
        /// Data Type: varchar (20)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_confirmbank { get; set; }

        /// <summary>
        /// Application Date
        /// Data Type: datetime
        /// Entities: cr_laaccscenario
        /// </summary>
        public DateTime la_date { get; set; }

        /// <summary>
        /// Irrevocable
        /// Data Type: varchar (1)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_depatm { get; set; }

        /// <summary>
        /// Reference No
        /// Data Type: varchar (60)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_depdescr { get; set; }

        /// <summary>
        /// % of Invoice
        /// Data Type: decimal (19,3)
        /// Entities: cr_laaccscenario
        /// </summary>
        public decimal la_depdsic { get; set; }

        /// <summary>
        /// Partial Shipments
        /// Data Type: varchar (1)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_depmunit { get; set; }

        /// <summary>
        /// Assign of Proceed
        /// Data Type: varchar (1)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_depmutfund { get; set; }

        /// <summary>
        /// Transhipment
        /// Data Type: varchar (1)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_depnoded { get; set; }

        /// <summary>
        /// Comments
        /// Data Type: varchar (40)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_depnotesn { get; set; }

        /// <summary>
        /// Deposit Officer
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_depofficer { get; set; }

        /// <summary>
        /// Red Clause
        /// Data Type: varchar (1)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_depprintma { get; set; }

        /// <summary>
        /// Revolving Limit
        /// Data Type: varchar (1)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_depstatem { get; set; }

        /// <summary>
        /// Charges Currency
        /// Data Type: varchar (15)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_depstfreq { get; set; }

        /// <summary>
        /// Safe Deposit S/N
        /// Data Type: varchar (15)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_deptaxcntry { get; set; }

        /// <summary>
        /// Confirmed
        /// Data Type: varchar (1)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_deptelebank { get; set; }

        /// <summary>
        /// Deposit Type
        /// Data Type: varchar (1)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_deptype { get; set; }

        /// <summary>
        /// Renewal Frequency
        /// Data Type: integer
        /// Entities: cr_laaccscenario
        /// </summary>
        public int la_durat { get; set; }

        /// <summary>
        /// Loading Date
        /// Data Type: datetime
        /// Entities: cr_laaccscenario
        /// </summary>
        public DateTime la_earlier { get; set; }

        /// <summary>
        /// Rental Expiration Date
        /// Data Type: datetime
        /// Entities: cr_laaccscenario
        /// </summary>
        public DateTime la_expdate { get; set; }

        /// <summary>
        /// Final
        /// Data Type: varchar (1)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_final { get; set; }

        /// <summary>
        /// Application Id
        /// Data Type: varchar (15)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Inc Reference No
        /// Data Type: varchar (40)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_increfeno { get; set; }

        /// <summary>
        /// Expiration Type
        /// Data Type: varchar (15)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_invtype { get; set; }

        /// <summary>
        /// Issuing Bank
        /// Data Type: varchar (15)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_issuebank { get; set; }

        /// <summary>
        /// Periodic Com. Posting
        /// Data Type: varchar (10)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_istype { get; set; }

        /// <summary>
        /// Language
        /// Data Type: varchar (10)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_language { get; set; }

        /// <summary>
        /// Delivery Date
        /// Data Type: datetime
        /// Entities: cr_laaccscenario
        /// </summary>
        public DateTime la_later { get; set; }

        /// <summary>
        /// LC Type
        /// Data Type: varchar (15)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_lctype { get; set; }

        /// <summary>
        /// Product Category
        /// Data Type: varchar (2)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_mark_id { get; set; }

        /// <summary>
        /// Negotiating Bank
        /// Data Type: varchar (20)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_negotbank { get; set; }

        /// <summary>
        /// Rental Date
        /// Data Type: datetime
        /// Entities: cr_laaccscenario
        /// </summary>
        public DateTime la_open_date { get; set; }

        /// <summary>
        /// Tolerance %
        /// Data Type: decimal (19,3)
        /// Entities: cr_laaccscenario
        /// </summary>
        public decimal la_ovmaxlimit { get; set; }

        /// <summary>
        /// Product Id
        /// Data Type: varchar (15)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_produ { get; set; }

        /// <summary>
        /// Shipment Place
        /// Data Type: varchar (50)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_shipplace { get; set; }

        /// <summary>
        /// Template
        /// Data Type: varchar (10)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_template { get; set; }

        /// <summary>
        /// Transfer LC Number
        /// Data Type: varchar (40)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_translcacc { get; set; }

        /// <summary>
        /// Transfer LC Number Check Digit
        /// Data Type: integer
        /// Entities: cr_laaccscenario
        /// </summary>
        public int la_translcacc_cd { get; set; }

        /// <summary>
        /// Destination
        /// Data Type: varchar (50)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_transto { get; set; }

        /// <summary>
        /// Commission Calc Unit
        /// Data Type: varchar (10)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string la_unit { get; set; }

        /// <summary>
        /// Serial Number
        /// Data Type: integer
        /// Entities: cr_laaccscenario
        /// </summary>
        public int serial_num { get; set; }

        /// <summary>
        /// Source
        /// Data Type: varchar (1)
        /// Entities: cr_laaccscenario
        /// </summary>
        public string source { get; set; }

        #endregion Public Properties
    }
}