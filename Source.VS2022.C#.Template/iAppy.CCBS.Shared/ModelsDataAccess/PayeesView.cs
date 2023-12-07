namespace IApplyDataAccess.DataModel
{
    public class PayeesView
    {
        #region Public Properties

        public virtual string ApplicationId { get; set; }

        public virtual int? BranchId { get; set; }

        public virtual string DrawdownId { get; set; }

        public virtual string PayeeAccount { get; set; }

        public virtual decimal? PayeeAmount { get; set; }

        public virtual string PayeeBank { get; set; }

        public virtual string PayeeBankBranch { get; set; }

        public virtual string PayeeBankBranchDes { get; set; }

        public virtual string PayeeBankDes { get; set; }

        public virtual string PayeeComment { get; set; }

        public virtual string PayeeName { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as PayeesView;
            if (t == null) return false;
            return (GetHashCode() == t.GetHashCode());
        }

        public override int GetHashCode()
        {
            return ApplicationId.GetHashCode();
        }

        #endregion Public Methods
    }
}