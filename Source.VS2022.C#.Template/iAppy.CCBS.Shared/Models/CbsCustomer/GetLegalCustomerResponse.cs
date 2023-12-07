using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class GetLegalCustomerResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public List<CustomerAddress> Addresses { get; set; } = new();

        [DataMember]
        public string AfmIssueCountryShortDescription { get; set; } = string.Empty;

        [DataMember]
        public int BranchCode { get; set; }

        [DataMember]
        public string BranchDescription { get; set; } = string.Empty;

        [DataMember]
        public string ClientCons { get; set; } = string.Empty;

        [DataMember]
        public string ClientConsent { get; set; } = string.Empty;

        [DataMember]
        public string ComLanguage { get; set; } = string.Empty;

        [DataMember]
        public string ComMethod { get; set; } = string.Empty;

        [DataMember]
        public string CompanyName { get; set; } = string.Empty;

        [DataMember]
        public string CorrespondenceAddress1 { get; set; } = string.Empty;

        [DataMember]
        public string CorrespondenceAddress2 { get; set; } = string.Empty;

        [DataMember]
        public string CorrespondenceCity { get; set; } = string.Empty;

        [DataMember]
        public string CorrespondenceCountryCode { get; set; } = string.Empty;

        [DataMember]
        public string CorrespondenceCountryDescription { get; set; } = string.Empty;

        [DataMember]
        public int CorrespondenceCountyCode { get; set; }

        [DataMember]
        public string CorrespondenceCountyDescription { get; set; } = string.Empty;

        [DataMember]
        public string CorrespondencePOBox { get; set; } = string.Empty;

        [DataMember]
        public string CorrespondenceZipCode { get; set; } = string.Empty;

        [DataMember]
        public string CountryOfIcorporationDescription { get; set; } = string.Empty;

        [DataMember]
        public string CountryOfIncorporationCode { get; set; } = string.Empty;

        [DataMember]
        public List<CustomerCategory> CustomerCategories { get; set; } = new();

        [DataMember]
        public string CustomerCrmId { get; set; } = string.Empty;

        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public List<CustomerIdentification> CustomerIdentifications { get; set; } = new();

        [DataMember]
        public CustomerType CustomerType { get; set; }

        [DataMember]
        public string DependNo { get; set; } = string.Empty;

        [DataMember]
        public string Email { get; set; } = string.Empty;

        [DataMember]
        public string Email2 { get; set; } = string.Empty;

        [DataMember]
        public string Fax { get; set; } = string.Empty;

        [DataMember]
        public int FinancialSectorCode { get; set; }

        [DataMember]
        public int LegalFormCode { get; set; }

        [DataMember]
        public string Litigation { get; set; } = string.Empty;

        [DataMember]
        public string MaritalStatus { get; set; } = string.Empty;

        [DataMember]
        public string MissingAfm { get; set; } = string.Empty;

        [DataMember]
        public string Mobile { get; set; } = string.Empty;

        [DataMember]
        public string Mobile2 { get; set; } = string.Empty;

        [DataMember]
        public int NatureOfBusinessCode { get; set; }

        [DataMember]
        public string NatureOfBusinessDescription { get; set; } = string.Empty;

        [DataMember]
        public int NoofBusiness { get; set; }

        [DataMember]
        public int NoOfEmpl { get; set; }

        [DataMember]
        public int NoOfPermEmpl { get; set; }

        [DataMember]
        public string PIN { get; set; } = string.Empty;

        [DataMember]
        public string RecruiterBy { get; set; } = string.Empty;

        [DataMember]
        public string RegistrationBy { get; set; } = string.Empty;

        [DataMember]
        public DateTime RegistrationDate { get; set; }

        [DataMember]
        public string RegistrationNumber { get; set; } = string.Empty;

        [DataMember]
        public CustomerResidencyStatus? ResidencyStatus { get; set; }

        [DataMember]
        public string Telephone { get; set; } = string.Empty;

        [DataMember]
        public string TradeName { get; set; } = string.Empty;

        #endregion Public Properties
    }
}