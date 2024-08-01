namespace CCBS.Models
{
    public class CbsCustomerIdentificationView
    {
        #region Public Properties

        public virtual int? CustomerCBSCd { get; set; }

        public virtual int? CustomerCBSId { get; set; }

        public virtual string CustomerId { get; set; }

        public virtual string IdentificationAuthority { get; set; }

        public virtual string IdentificationDocument { get; set; }

        public virtual DateTime? IdentificationExpiryDate { get; set; }

        public virtual int? IdentificationIssueCountry { get; set; }

        public virtual string IdentificationIssueCountryShortDescription { get; set; }

        public virtual DateTime? IdentificationIssueDate { get; set; }

        public virtual string IdentificationMain { get; set; }

        public virtual string IdentificationNumber { get; set; }

        public virtual int? IdentificationType { get; set; }

        public virtual int? SnCBS { get; set; }

        #endregion Public Properties
    }
}