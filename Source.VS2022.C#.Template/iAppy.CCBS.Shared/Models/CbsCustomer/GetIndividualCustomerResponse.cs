using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class GetIndividualCustomerResponse : BaseResponse
    {
        #region Public Properties
            
        [DataMember(EmitDefaultValue = false, Order = 24)]
        public List<CustomerAddress> Addresses { get; set; } = new();

        [DataMember(EmitDefaultValue = false, Order = 32)]
        public string AfmIssueCountryShortDescription { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 33)]
        public string BirthIssueCountryShortDescription { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 7)]
        public int BranchCode { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 8)]
        public string BranchDescription { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 52)]
        public int ChildNo { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 51)]
        public int Citizenship2 { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 30)]
        public int CitizenShipCountry { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 53)]
        public string ClientCons { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 43)]
        public virtual string ComLanguage { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 41)]
        public string ComMethod { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 56)]
        public string Contract { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 57)]
        public DateTime? ContractDate { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 61)]
        public List<CustomerCategory> CustomerCategories { get; set; } = new();

        [DataMember(EmitDefaultValue = false, Order = 44)]
        public string CustomerCrmId { get; set; }

        [DataMember(IsRequired = true)]
        public int CustomerId { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 36)]
        public List<CustomerIdentification >CustomerIdentifications { get; set; } = new();

        [DataMember(EmitDefaultValue = false, Order = 64)]
        public string CustomerStatus { get; set; }

        [DataMember(IsRequired = true, Order = 1)]
        public CustomerType? CustomerType { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 13)]
        public DateTime DateOfBirth { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 40)]
        public int DependNo { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 20)]
        public int EducationCode { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 21)]
        public string EducationDescription { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 34)]
        public string Email { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 55)]
        public string Email2 { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 46)]
        public DateTime EmplDate { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 62)]
        public string EmployeeCode { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 37)]
        public string EmployeeNo { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 22)]
        public string Employer { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 65)]
        public string EmployerAddress { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 63)]
        public string EmployerCode { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 18)]
        public int EmploymentCode { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 19)]
        public string EmploymentDescription { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 27)]
        public DateTime ExpiryDate { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 26)]
        public int FinancialSectorCode { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 2)]
        public string FirstName { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 12)]
        public DateTime IdentificationExpiryDate { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 23)]
        public string IdentificationIssueCountry { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 31)]
        public DateTime? IdentificationIssueDate { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 11)]
        public string IdentificationNumber { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 9)]
        public int IdentificationType { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 10)]
        public string IdentificationTypeDescription { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 42)]
        public int IncomeRange { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 59)]
        public string Litigation { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 39)]
        public int MaritalStatus { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 3)]
        public string MiddleName { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 58)]
        public string MissingAfm { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 35)]
        public string Mobile { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 54)]
        public string Mobile2 { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 50)]
        public int MonitoringUnit { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 5)]
        public string Nationality { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 25)]
        public int NationalityCode { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 45)]
        public int OccupationCode { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 15)]
        public string Pin { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 60)]
        public int Position { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 29)]
        public int PositionCode { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 16)]
        public int ProffesionCode { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 17)]
        public string ProffesionDescription { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 66)]
        public string RecruiterBy { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 6)]
        public CustomerResidencyStatus? ResidencyStatus { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 47)]
        public int ResStatus { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 49)]
        public int SalaryFreq { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 48)]
        public int SalaryRange { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 28)]
        public string SelfEmployed { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 14)]
        public CustomerSex? Sex { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 4)]
        public string Surname { get; set; }

        [DataMember(EmitDefaultValue = false, Order = 38)]
        public string Title { get; set; }

        #endregion Public Properties
    }
}