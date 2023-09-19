namespace iApplyShared.CbsModels
{
    public class CbsDownloadPositionResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Account Category
        /// </summary>
        public string cb_accd { get; set; }

        /// <summary>
        /// Account Number
        /// </summary>
        public string cb_accn { get; set; }

        /// <summary>
        /// Account Type
        /// </summary>
        public int cb_accountkind { get; set; }

        /// <summary>
        /// Account Relation
        /// </summary>
        public string cb_acountrel { get; set; }

        /// <summary>
        /// Available Balance
        /// </summary>
        public decimal cb_avbalan { get; set; }

        /// <summary>
        /// Balance
        /// </summary>
        public decimal cb_balan { get; set; }

        /// <summary>
        /// Capital Outstanding Amount
        /// </summary>
        public decimal cb_capitalamt { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        /// <remarks>If currency description is null the currency id</remarks>
        public string cb_ccy { get; set; }

        /// <summary>
        /// Account Check Digit
        /// </summary>
        public int cb_checkdigit { get; set; }

        /// <summary>
        /// Customer Last Name
        /// </summary>
        public string cb_cu_lname { get; set; }

        /// <summary>
        /// Customer First Name
        /// </summary>
        public string cb_cus_fname { get; set; }

        /// <summary>
        /// Customer Check Digit
        /// </summary>
        public int cb_cuscd { get; set; }

        /// <summary>
        /// Customer CBS Id
        /// </summary>
        public string cb_cusnum { get; set; }

        /// <summary>
        /// Expiry Date
        /// </summary>
        /// <remarks>If date1 is null then date9<br/>If date9 is null then date15<br/>If date15 is null then date4<br/>If date4 is null then date5<br/>If date5 is null then date7<br/>If date7 is null then date8</remarks>
        public DateTime cb_expdt { get; set; }

        /// <summary>
        /// Monthly Installment Amount
        /// </summary>
        /// <remarks>If amount27 is zero then amount23</remarks>
        public decimal cb_lastinstamt { get; set; }

        /// <summary>
        /// Account Limit
        /// </summary>
        public decimal cb_limit { get; set; }

        /// <summary>
        /// Open Date
        /// </summary>
        public DateTime cb_opendt { get; set; }

        /// <summary>
        /// Overdue Amount
        /// </summary>
        public decimal cb_outamt { get; set; }

        /// <summary>
        /// Not Used
        /// </summary>
        public decimal cb_outint { get; set; }

        /// <summary>
        /// Product
        /// </summary>
        public int cb_prdcat { get; set; }

        /// <summary>
        /// Product Description
        /// </summary>
        public string cb_proddesc { get; set; }

        /// <summary>
        /// Securities Evaluation
        /// </summary>
        public decimal cb_seceval { get; set; }

        /// <summary>
        /// Not Used
        /// </summary>
        /// <remarks>For all the banks except HF</remarks>
        public string cb_self { get; set; }

        /// <summary>
        /// Account Status
        /// </summary>
        /// <remarks>If cb_accd = 3 then code from grp =G0223<br/>If cb_accd = 5 then code from grp =G0221<br/>If cb_accd = 6 then code from grp =G0222</remarks>
        public string cb_status { get; set; }

        /// <summary>
        /// Not Used
        /// </summary>
        public string cb_status1 { get; set; }

        /// <summary>
        /// Unclear Balance
        /// </summary>
        public decimal cb_unbalan { get; set; }

        /// <summary>
        /// Application Id (iApply)
        /// </summary>
        /// <remarks>If OutGrpOutGrmSearchCustPositionEntryType then text30 else null</remarks>
        public string cbs_la_id { get; set; }

        #endregion Public Properties
    }
}