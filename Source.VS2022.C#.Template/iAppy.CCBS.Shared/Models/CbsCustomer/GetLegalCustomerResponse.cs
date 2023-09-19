using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class GetLegalCustomerResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public CustomerAddress[] Addresses { get; set; }

        [DataMember]
        public string AfmIssueCountryShortDescription { get; set; }

        [DataMember]
        public int BranchCode { get; set; }

        [DataMember]
        public string BranchDescription { get; set; }

        [DataMember]
        public string ClientCons { get; set; }

        [DataMember]
        public string ClientConsent { get; set; }

        [DataMember]
        public string ComLanguage { get; set; }

        [DataMember]
        public string ComMethod { get; set; }

        [DataMember]
        public string CompanyName { get; set; }

        [DataMember]
        public string CorrespondenceAddress1 { get; set; }

        [DataMember]
        public string CorrespondenceAddress2 { get; set; }

        [DataMember]
        public string CorrespondenceCity { get; set; }

        [DataMember]
        public string CorrespondenceCountryCode { get; set; }

        [DataMember]
        public string CorrespondenceCountryDescription { get; set; }

        [DataMember]
        public int CorrespondenceCountyCode { get; set; }

        [DataMember]
        public string CorrespondenceCountyDescription { get; set; }

        [DataMember]
        public string CorrespondencePOBox { get; set; }

        [DataMember]
        public string CorrespondenceZipCode { get; set; }

        [DataMember]
        public string CountryOfIcorporationDescription { get; set; }

        [DataMember]
        public string CountryOfIncorporationCode { get; set; }

        [DataMember]
        public CustomerCategory[] CustomerCategories { get; set; }

        [DataMember]
        public string CustomerCrmId { get; set; }

        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public CustomerIdentification[] CustomerIdentifications { get; set; }

        [DataMember]
        public CustomerType CustomerType { get; set; }

        [DataMember]
        public string DependNo { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Email2 { get; set; }

        [DataMember]
        public string Fax { get; set; }

        [DataMember]
        public int FinancialSectorCode { get; set; }

        [DataMember]
        public int LegalFormCode { get; set; }

        [DataMember]
        public string Litigation { get; set; }

        [DataMember]
        public string MaritalStatus { get; set; }

        [DataMember]
        public string MissingAfm { get; set; }

        [DataMember]
        public string Mobile { get; set; }

        [DataMember]
        public string Mobile2 { get; set; }

        [DataMember]
        public int NatureOfBusinessCode { get; set; }

        [DataMember]
        public string NatureOfBusinessDescription { get; set; }

        [DataMember]
        public int NoofBusiness { get; set; }

        [DataMember]
        public int NoOfEmpl { get; set; }

        [DataMember]
        public int NoOfPermEmpl { get; set; }

        [DataMember]
        public string PIN { get; set; }

        [DataMember]
        public string RecruiterBy { get; set; }

        [DataMember]
        public string RegistrationBy { get; set; }

        [DataMember]
        public DateTime RegistrationDate { get; set; }

        [DataMember]
        public string RegistrationNumber { get; set; }

        [DataMember]
        public CustomerResidencyStatus? ResidencyStatus { get; set; }

        [DataMember]
        public string Telephone { get; set; }

        [DataMember]
        public string TradeName { get; set; }

        #endregion Public Properties
    }
}