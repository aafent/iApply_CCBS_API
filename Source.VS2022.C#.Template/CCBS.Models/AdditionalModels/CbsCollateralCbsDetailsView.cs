namespace CCBS.Models
{
    public class CbsCollateralCbsDetailsView
    {
        #region Public Properties

        public virtual string ApplicationId { get; set; }

        public virtual string CollAccount { get; set; }

        public virtual int? CollAccountCd { get; set; }

        public virtual int? CollAccountType { get; set; }

        public virtual int? CollateralCbsId { get; set; }

        public virtual string CollateralId { get; set; }

        public virtual string CollateralStatus { get; set; }

        public virtual int? CollateralTrCbsId { get; set; }

        public virtual string CollClass { get; set; }

        public virtual decimal? CollCovAmount { get; set; }

        public virtual decimal? CollEstAmount { get; set; }

        public virtual DateTime? CollExpDate { get; set; }

        public virtual decimal? CollLimit { get; set; }

        public virtual int? CollNoItems { get; set; }

        public virtual decimal? CollPerc { get; set; }

        public virtual decimal? CollReAmount { get; set; }

        public virtual string CollReCcy { get; set; }

        public virtual string CollReCcyD { get; set; }

        public virtual decimal? CollReCur { get; set; }

        public virtual DateTime CollReDate { get; set; }

        public virtual string CollRefNum { get; set; }

        public virtual decimal? CollReOrig { get; set; }

        public virtual decimal? CollRevValue { get; set; }

        public virtual decimal? CollSecAmount { get; set; }

        public virtual int? CollType { get; set; }

        public virtual string MonUnit { get; set; }

        public virtual string OpenUnit { get; set; }

        public virtual string RecordType { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as CbsCollateralCbsDetailsView;
            if (t == null) return false;
            return (GetHashCode() == t.GetHashCode());
        }

        public override int GetHashCode()
        {
            return ApplicationId.GetHashCode() + CollateralId.GetHashCode();
        }

        #endregion Public Methods
    }
}