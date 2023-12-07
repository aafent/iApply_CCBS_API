namespace iApplyShared.CbsModels
{
    public class CbsRetrieveMortgageResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Mortgage Status
        /// Data Type: varchar (10)
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public string cbs_status { get; set; }

        /// <summary>
        /// Mortgage CBS Id
        /// Data Type: integer
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public int cbsid { get; set; }

        /// <summary>
        /// Characterization
        /// Data Type: varchar (40)
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public string charac { get; set; }

        /// <summary>
        /// Comments
        /// Data Type: varchar (255)
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public string comments { get; set; }

        /// <summary>
        /// Court
        /// Data Type: varchar (15)
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public string court { get; set; }

        /// <summary>
        /// County Court
        /// Data Type: varchar (40)
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public string court_cnty { get; set; }

        /// <summary>
        /// Covered Amount
        /// Data Type: decimal (19,3)
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public decimal cover_amnt { get; set; }

        /// <summary>
        /// Current Mortgage Amount
        /// Data Type: decimal (19,3)
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public decimal cur_mort_amnt { get; set; }

        /// <summary>
        /// Decision Number
        /// Data Type: varchar (40)
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public string des_no { get; set; }

        /// <summary>
        /// Description
        /// Data Type: varchar (40)
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public string descr { get; set; }

        /// <summary>
        /// Institution
        /// Data Type: varchar (15)
        /// Entities: cr_curees_ip_mortdet
        /// </summary>
        public string instit { get; set; }

        /// <summary>
        /// Property Id
        /// Data Type: varchar (15)
        /// Entities: cr_curees_ip_mortdet
        /// </summary>
        public string ip_id { get; set; }

        /// <summary>
        /// Application Id
        /// Data Type: varchar (15)
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Land/Mortgage Reg.
        /// Data Type: varchar (15)
        /// Entities: cr_curees_ip_mortdet
        /// </summary>
        public string land_reg { get; set; }

        /// <summary>
        /// Lawyer
        /// Data Type: varchar (40)
        /// Entities: cr_curees_ip_mortdet
        /// </summary>
        public string lawyer { get; set; }

        /// <summary>
        /// Loan Due Balance
        /// Data Type: decimal (19,3)
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public decimal loan_bal { get; set; }

        /// <summary>
        /// Main Connection
        /// Data Type: varchar (15)
        /// Entities: cr_curees_ip_mortdet
        /// </summary>
        public string main { get; set; }

        /// <summary>
        /// Mortgage Amount
        /// Data Type: decimal (19,3)
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public decimal mort_amnt { get; set; }

        /// <summary>
        /// Mortgage Id
        /// Data Type: varchar (15)
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public string mort_id { get; set; }

        /// <summary>
        ///
        /// </summary>
        public MortgageProperty[] MortgageProperties { get; set; }

        /// <summary>
        /// Notary
        /// Data Type: varchar (40)
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public string notary { get; set; }

        /// <summary>
        /// Notary Deed Date
        /// Data Type: datetime
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public DateTime notdeed_dt { get; set; }

        /// <summary>
        /// Notary Deed Number
        /// Data Type: varchar (40)
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public string notdeed_no { get; set; }

        /// <summary>
        /// Registration Date
        /// Data Type: datetime
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public DateTime reg_dt { get; set; }

        /// <summary>
        /// Row
        /// Data Type: varchar (15)
        /// Entities: cr_curees_ip_mortdet
        /// </summary>
        public string row { get; set; }

        /// <summary>
        /// Sheet
        /// Data Type: varchar (40)
        /// Entities: cr_curees_ip_mortdet
        /// </summary>
        public string sheet { get; set; }

        /// <summary>
        /// Volume
        /// Data Type: varchar (40)
        /// Entities: cr_curees_ip_mortdet
        /// </summary>
        public string volume { get; set; }

        /// <summary>
        /// Last Waiver Date
        /// Data Type: datetime
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public DateTime waiv_dt { get; set; }

        /// <summary>
        /// Mortgage Waiver No
        /// Data Type: varchar (40)
        /// Entities: cr_curees_ip_mort
        /// </summary>
        public string waiv_number { get; set; }

        /// <summary>
        /// Waiver
        /// Data Type: varchar (15)
        /// Entities: cr_curees_ip_mortdet
        /// </summary>
        public string waiver { get; set; }

        #endregion Public Properties
    }
}