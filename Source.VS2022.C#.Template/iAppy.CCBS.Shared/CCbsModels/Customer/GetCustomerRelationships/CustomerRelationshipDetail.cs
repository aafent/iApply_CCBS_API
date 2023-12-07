namespace iApplyShared.CbsModels
{
    public class CustomerRelationshipDetail
    {
        #region Public Properties

        public string Accounts { get; set; }

        public List<CustomerRelationshipAccountDetail> Details { get; set; }

        public int Relationship { get; set; }

        public DateTime? RelationshipTmstamp { get; set; }

        public double RelPerc { get; set; }

        #endregion Public Properties
    }
}