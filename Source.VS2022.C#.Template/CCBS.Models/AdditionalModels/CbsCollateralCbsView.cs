namespace CCBS.Models
{
    public class CbsCollateralCbsView
    {
        #region Public Properties

        public virtual string ApplicationId { get; set; }

        public virtual int? CollateralCbsId { get; set; }

        public virtual string CollateralId { get; set; }

        public virtual string CollatType { get; set; }

        public virtual string CollBasil { get; set; }

        public virtual string CollCcy { get; set; }

        public virtual string CollCcyD { get; set; }

        public virtual string CollCode { get; set; }

        public virtual string CollComments { get; set; }

        public virtual decimal? CollCovAmount { get; set; }

        public virtual decimal? CollEstAmount { get; set; }

        public virtual decimal CollExpenses { get; set; }

        public virtual string CollLandReg { get; set; }

        public virtual decimal? CollLimit { get; set; }

        public virtual DateTime? CollNextRevDate { get; set; }

        public virtual int? CollNoItems { get; set; }

        public virtual string CollOfficer { get; set; }

        public virtual decimal? CollPerc { get; set; }

        public virtual string CollReCcy { get; set; }

        public virtual string CollReCcyD { get; set; }

        public virtual decimal CollReCur { get; set; }

        public virtual decimal CollReEstVal { get; set; }

        public virtual string CollRegid { get; set; }

        public virtual decimal CollReOrig { get; set; }

        public virtual DateTime? CollRevDate { get; set; }

        public virtual decimal? CollSecAmount { get; set; }

        public virtual string CollStatus { get; set; }

        public virtual int? CollType { get; set; }

        public virtual int? CustomerCbsCd { get; set; }

        public virtual string CustomerCbsId { get; set; }

        public virtual string MonUnit { get; set; }

        public virtual string OpenUnit { get; set; }

        public virtual int? PropertyCbsId { get; set; }

        public virtual string RecordType { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as CbsCollateralCbsView;
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