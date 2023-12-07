using iApply.CCBS.Shared.CCbsModels;
using IApplyDataAccess.DataModel;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsInsertMortgageRequest : MockupModel
    {
        #region Public Properties

        /// <summary>
        /// Mortgage Amount
        /// Data Type: decimal (15,2)
        /// Entities: v_CBS_Mortgage
        /// </summary>
        public decimal MortgageAmount { get; set; }

        /// <summary>
        /// Mortgage CBS Id
        /// Data Type: integer
        /// Entities: v_CBS_Mortgage
        /// </summary>
        [Mockup(1)]
        public int MortgageCbsId { get; set; }

        /// <summary>
        /// Characterization
        /// Data Type: varchar (40)
        /// Entities: v_CBS_Mortgage
        /// </summary>
        public string MortgageChar { get; set; }

        /// <summary>
        /// Comments
        /// Data Type: varchar (255)
        /// Entities: v_CBS_Mortgage
        /// </summary>
        public string MortgageComments { get; set; }

        /// <summary>
        /// Court
        /// Data Type: varchar (15)
        /// Entities: v_CBS_Mortgage
        /// </summary>
        public string MortgageCourt { get; set; }

        /// <summary>
        /// County Court
        /// Data Type: varchar (40)
        /// Entities: v_CBS_Mortgage
        /// </summary>
        public string MortgageCourtCnty { get; set; }

        /// <summary>
        /// Description
        /// Data Type: varchar (40)
        /// Entities: v_CBS_Mortgage
        /// </summary>
        public string MortgageDescr { get; set; }

        /// <summary>
        /// Decision Number
        /// Data Type: varchar (40)
        /// Entities: v_CBS_Mortgage
        /// </summary>
        public string MortgageDesNo { get; set; }

        /// <summary>
        /// Institution
        /// Data Type: varchar (15)
        /// Entities: v_CBS_MortgageDet
        /// </summary>
        public string MortgageInstit { get; set; }

        /// <summary>
        /// Institution Description
        /// Data Type: varchar (20)
        /// Entities: v_CBS_MortgageDet
        /// Notes: select des from cr__comast where grp ='G089' and cod = Row
        /// </summary>
        public string MortgageInstitDesc { get; set; }

        /// <summary>
        /// Land/Mortgage Reg.
        /// Data Type: integer
        /// Entities: v_CBS_MortgageDet
        /// </summary>
        public int MortgageLandReg { get; set; }

        /// <summary>
        /// Land/Mortgage Reg. Description
        /// Data Type: varchar (20)
        /// Entities: v_CBS_MortgageDet
        /// Notes: select des from cr__comast where grp ='G078' and cod = Row
        /// </summary>
        public string MortgageLandRegDesc { get; set; }

        /// <summary>
        /// Lawyer
        /// Data Type: varchar (40)
        /// Entities: v_CBS_MortgageDet
        /// </summary>
        public string MortgageLawyer { get; set; }

        /// <summary>
        /// Loan Due Balance
        /// Data Type: decimal (15,2)
        /// Entities: v_CBS_Mortgage
        /// </summary>
        public decimal MortgageLoanBalAmount { get; set; }

        /// <summary>
        /// Main Connection
        /// Data Type: varchar (15)
        /// Entities: v_CBS_MortgageDet
        /// </summary>
        public string MortgageMain { get; set; }

        /// <summary>
        /// Notary
        /// Data Type: varchar (40)
        /// Entities: v_CBS_Mortgage
        /// </summary>
        public string MortgageNotary { get; set; }

        /// <summary>
        /// Notary Deed Date
        /// Data Type: datetime
        /// Entities: v_CBS_Mortgage
        /// </summary>
        public DateTime MortgageNotDeedDt { get; set; }

        /// <summary>
        /// Notary Deed Number
        /// Data Type: varchar (40)
        /// Entities: v_CBS_Mortgage
        /// </summary>
        public string MortgageNotDeedNo { get; set; }

        /// <summary>
        /// Registration Date
        /// Data Type: datetime
        /// Entities: v_CBS_Mortgage
        /// </summary>
        public DateTime MortgageRegDt { get; set; }

        /// <summary>
        /// Row
        /// Data Type: integer
        /// Entities: v_CBS_MortgageDet
        /// </summary>
        public int MortgageRow { get; set; }

        /// <summary>
        /// Row Desciption
        /// Data Type: varchar (20)
        /// Entities: v_CBS_MortgageDet
        /// Notes: select des from cr__comast where grp ='G086' and cod = Row
        /// </summary>
        public string MortgageRowDesc { get; set; }

        /// <summary>
        /// Sheet
        /// Data Type: varchar (40)
        /// Entities: v_CBS_MortgageDet
        /// </summary>
        public string MortgageSheet { get; set; }

        public MortgageView MortgageViews { get; set; }

        /// <summary>
        /// Volume
        /// Data Type: varchar (40)
        /// Entities: v_CBS_MortgageDet
        /// </summary>
        public string MortgageVolume { get; set; }

        /// <summary>
        /// Last Waiver Date
        /// Data Type: datetime
        /// Entities: v_CBS_Mortgage
        /// </summary>
        public DateTime MortgageWaivDt { get; set; }

        /// <summary>
        /// Waiver
        /// Data Type: varchar (15)
        /// Entities: v_CBS_MortgageDet
        /// </summary>
        public string MortgageWaiver { get; set; }

        /// <summary>
        /// Mortgage Waiver No
        /// Data Type: varchar (40)
        /// Entities: v_CBS_Mortgage
        /// </summary>
        public string MortgageWaivNo { get; set; }

        /// <summary>
        /// Property CBS Id
        /// Data Type: integer
        /// Entities: v_CBS_MortgageDet
        /// </summary>
        public int PropertyCbsId { get; set; }

        /// <summary>
        /// Property Description
        /// Data Type: varchar (800)
        /// Entities: v_CBS_MortgageDet
        /// </summary>
        public string PropertyDesc { get; set; }

        #endregion Public Properties
    }
}