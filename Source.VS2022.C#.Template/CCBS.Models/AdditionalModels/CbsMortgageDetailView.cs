namespace CCBS.Models
{
    public class CbsMortgageDetailView
    {
        #region Public Properties

        public virtual string ApplicationId { get; set; }

        public virtual decimal MortgageAmount { get; set; }

        public virtual int? MortgageCbsId { get; set; }

        public virtual string MortgageComments { get; set; }

        public virtual string MortgageId { get; set; }

        public virtual int? MortgageInstit { get; set; }

        public virtual string MortgageInstitDesc { get; set; }

        public virtual int? MortgageLandReg { get; set; }

        public virtual string MortgageLandRegDesc { get; set; }

        public virtual string MortgageLawyer { get; set; }

        public virtual string MortgageMain { get; set; }

        public virtual int? MortgageRow { get; set; }

        public virtual string MortgageRowDesc { get; set; }

        public virtual string MortgageSheet { get; set; }

        public virtual string MortgageVolume { get; set; }

        public virtual DateTime MortgageWaivDt { get; set; }

        public virtual string MortgageWaiver { get; set; }

        public virtual int? PropertyCbsId { get; set; }

        public virtual string PropertyDesc { get; set; }

        public virtual string PropertyId { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as CbsMortgageDetailView;
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