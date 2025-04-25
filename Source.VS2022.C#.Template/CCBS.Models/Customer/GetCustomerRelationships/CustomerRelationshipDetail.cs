namespace CCBS.Models
{
    public class CustomerRelationshipDetail
    {
        #region Public Properties

        public string Accounts { get; set; }

        public List<CustomerRelationshipAccountDetail> Details { get; set; }

        public int Relationship { get; set; }

        public DateTime? RelationshipTmstamp { get; set; } =  DateTime.Parse("0001-01-01");

        public double RelPerc { get; set; }

        #endregion Public Properties
    }
}