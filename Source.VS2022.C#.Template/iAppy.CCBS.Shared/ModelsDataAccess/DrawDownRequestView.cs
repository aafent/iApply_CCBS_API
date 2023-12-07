namespace IApplyDataAccess.DataModel
{
    public class DrawDownRequestView
    {
        #region Public Properties

        public virtual string ApplicationId { get; set; }

        public virtual int? BranchId { get; set; }

        public virtual int? Currency { get; set; }

        public virtual DateTime? CurrentDate { get; set; }

        public virtual short? CustomerCBSCD { get; set; }

        public virtual int? CustomerCBSId { get; set; }

        public virtual DateTime? DateFrom { get; set; }

        public virtual DateTime? DateTo { get; set; }

        public virtual short? LoanAccountCD { get; set; }

        public virtual string LoanAccountNo { get; set; }

        public virtual string ProfitsId { get; set; }

        public virtual decimal? RequestedAmount { get; set; }

        public virtual int? Score { get; set; }

        #endregion Public Properties
    }
}