namespace IApplyDataAccess.DataModel
{
    public class MortgageView
    {
        #region Public Properties

        public virtual string ApplicationId { get; set; }

        public virtual decimal MortgageAmount { get; set; }

        public virtual int? MortgageCbsId { get; set; }

        public virtual string MortgageChar { get; set; }

        public virtual string MortgageComments { get; set; }

        public virtual int? MortgageCourt { get; set; }

        public virtual string MortgageCourtCnty { get; set; }

        public virtual decimal MortgageCoverAmount { get; set; }

        public virtual decimal MortgageCurAmount { get; set; }

        public virtual string MortgageDescr { get; set; }

        public virtual string MortgageDesNo { get; set; }

        public virtual string MortgageId { get; set; }

        public virtual decimal MortgageLoanBalAmount { get; set; }

        public virtual string MortgageNotary { get; set; }

        public virtual DateTime MortgageNotDeedDt { get; set; }

        public virtual string MortgageNotDeedNo { get; set; }

        public virtual DateTime MortgageRegDt { get; set; }

        public virtual string MortgageStatus { get; set; }

        public virtual DateTime MortgageWaivDt { get; set; }

        public virtual string MortgageWaivNo { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as MortgageView;
            if (t == null) return false;
            return (GetHashCode() == t.GetHashCode());
        }

        public override int GetHashCode()
        {
            return ApplicationId.GetHashCode() + MortgageId.GetHashCode();
        }

        #endregion Public Methods
    }
}