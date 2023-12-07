using IApplyDataAccess.DataModel;
using iApplyShared.Models;

namespace iApplyShared.CbsModels
{
    public class CbsRetrieveCbsCollateralResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Entity: crp_CBS_updateCollDetCBSID
        /// Description: Account or Agreement
        /// Data Type: varchar (40)
        /// </summary>
        public string co_account { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollDetCBSID
        /// Description: Account or Agreement Check Digit
        /// Data Type: integer
        /// </summary>
        public int co_accountcd { get; set; }

        /// <summary>
        /// Entity: cr_lacola_det
        /// Description: Account Type
        /// Data Type: integer
        /// </summary>
        public int co_accounttype { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: BASIL II Accepted
        /// Data Type: varchar (10)
        /// </summary>
        public string co_basil { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollCBSID
        /// Description: Collateral CBS Id
        /// Data Type: integer
        /// </summary>
        public int co_cbsid { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Currency
        /// Data Type: varchar (10)
        /// </summary>
        public string co_ccy { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Collateral Code
        /// Data Type: varchar (40)
        /// </summary>
        public string co_code { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Comments
        /// Data Type: varchar (100)
        /// </summary>
        public string co_comments { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Est. Sec. Value Amt
        /// Data Type: decimal (19,3)
        /// </summary>
        public decimal co_estsecval { get; set; }

        /// <summary>
        /// Entity: cr_lacola_det
        /// Description: Expiration Date
        /// Data Type: datetime
        /// </summary>
        public DateTime co_expdate { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Reeval. Expenses
        /// Data Type: decimal (19,3)
        /// </summary>
        public decimal co_expenses { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollCBSID
        /// Description: Collateral Id
        /// Data Type: varchar (15)
        /// </summary>
        public string co_id { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Return Limit
        /// Data Type: decimal (19,3)
        /// </summary>
        public decimal co_limit { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Return Percent (%)
        /// Data Type: decimal (19,3)
        /// </summary>
        public decimal co_limitperc { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Monitoring Branch
        /// Data Type: varchar (15)
        /// </summary>
        public string co_monunit { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Next Review Date
        /// Data Type: datetime
        /// </summary>
        public DateTime co_nextrevdate { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Number of Items
        /// Data Type: integer
        /// </summary>
        public int co_noitems { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Responsible User
        /// Data Type: varchar (10)
        /// </summary>
        public string co_officer { get; set; }

        /// <summary>
        /// Entity: cr_lacola_det
        /// iApply: co_recamount
        /// Data Type: decimal (19,3)
        /// </summary>
        public decimal co_recamount { get; set; }

        /// <summary>
        /// Entity: cr_lacola_det
        /// iApply: co_refnum
        /// Data Type: varchar (40)
        /// </summary>
        public string co_refnum { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Registry Code
        /// Data Type: varchar (20)
        /// </summary>
        public string co_regid { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Reeval. Currency
        /// Data Type: varchar (10)
        /// </summary>
        public string co_revccy { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Reeval. Current %
        /// Data Type: decimal (19,3)
        /// </summary>
        public decimal co_revcur { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Review Date
        /// Data Type: datetime
        /// </summary>
        public DateTime co_revdate { get; set; }

        /// <summary>
        /// Entity: cr_lacola_det
        /// Description: Reeval. Original %
        /// Data Type: decimal (19,3)
        /// </summary>
        public decimal co_revorig { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Reeval. Init. Sec Value
        /// Data Type: decimal (19,3)
        /// </summary>
        public decimal co_revsecval { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Central Bank Sec. Amt
        /// Data Type: decimal (19,3)
        /// </summary>
        public decimal co_secval { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollCBSID
        /// Description: Collateral Status
        /// Data Type: varchar (10)
        /// </summary>
        public string co_status { get; set; }

        /// <summary>
        /// Entity: cr_lacola
        /// Description: Covered Amount
        /// Data Type: decimal (19,3)
        /// </summary>
        public decimal co_sum { get; set; }

        /// <summary>
        /// Entity: crp_CBS_updateCollDetCBSID
        /// Description: Allocation CBS Id
        /// Data Type: integer
        /// </summary>
        public int co_trcbsid { get; set; }

        public List<CollateralCbsDetailItem> CollateralCbsDetailItems { get; set; } = new();

        /// <summary>
        /// Entity: crp_CBS_updateCollCBSID
        /// Description: Application Id
        /// Data Type: varchar (15)
        /// </summary>
        public string la_id { get; set; }

        public List<CollateralCbsDetailsView> OutGrp { get; set; } = new();

        /// <summary>
        /// Entity: crp_CBS_updateCollCBSID
        /// Description: Source
        /// Data Type: varchar (15)
        /// </summary>
        public string source { get; set; }

        #endregion Public Properties
    }
}