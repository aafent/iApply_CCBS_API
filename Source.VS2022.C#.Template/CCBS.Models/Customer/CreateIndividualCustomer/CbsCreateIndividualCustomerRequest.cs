using CCBS.Attributes;
using CCBS.Models.Customer.CreateIndividualCustomer;

namespace CCBS.Models
{
    public class CbsCreateIndividualCustomerRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Accommodation Date (datetime)
        /// </summary>
        public DateTime AccDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Street Name, Address Line 1 (varchar)
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Plot/Street No, Address Line 2 (varchar)
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Address S/N (integer)
        /// </summary>
        public int AddressSN { get; set; }

        /// <summary>
        /// Address Status (integer)
        /// </summary>
        public int AddressStatus { get; set; }

        /// <summary>
        /// Address Type (varchar)
        /// </summary>
        public string AddressType { get; set; }

        /// <summary>
        /// Address Details SN (integer)
        /// </summary>
        public int AddSerial { get; set; }

        /// <summary>
        /// PIN Country (varchar)
        /// </summary>
        public string AfmIssueCountryShortDescription { get; set; }

        /// <summary>
        /// PIN (varchar)
        /// </summary>
        public string AfmNo { get; set; }

        /// <summary>
        /// Agent (varchar)
        /// If is empty then 0
        /// </summary>
        public string Agent { get; set; }

        /// <summary>
        /// Agent (varchar)
        /// AGENT
        /// </summary>
        public string AgentCBS { get; set; }

        /// <summary>
        /// Apartment (varchar)
        /// </summary>
        public string Apart { get; set; }

        /// <summary>
        /// Birth Country (varchar)
        /// </summary>
        public string BirthIssueCountryShortDescription { get; set; }

        /// <summary>
        /// Nationality (varchar)
        /// </summary>
        public string Birthplace { get; set; }

        /// <summary>
        /// Branch (integer)
        /// </summary>
        public int BranchCBSId { get; set; }

        /// <summary>
        /// Building (varchar)
        /// </summary>
        public string Building { get; set; }

        /// <summary>
        /// Building Name (varchar)
        /// </summary>
        public string BuildName { get; set; }

        /// <summary>
        /// Monthly Capital (decimal)
        /// </summary>
        public decimal CapAmount { get; set; }

        /// <summary>
        /// Member Category (varchar)
        /// If is empty then 0
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Member Category (varchar)
        /// If customer is individual then ISHACAT If customer is legal then GSHACAT If customer is group then CSHACAT
        /// </summary>
        public string CategoryCBS { get; set; }

        /// <summary>
        /// Childhope (varchar)
        /// If is empty then 0
        /// </summary>
        public string Childhope { get; set; }

        /// <summary>
        /// Childhope (varchar)
        /// CHDHP
        /// </summary>
        public string ChildhopeCBS { get; set; }

        /// <summary>
        /// Children No (integer)
        /// </summary>
        public int ChildNo { get; set; }

        /// <summary>
        /// Citizenship (varchar)
        /// </summary>
        public string CitizenshipCountry { get; set; }

        /// <summary>
        /// Citizenship 2 (varchar)
        /// </summary>
        public string CitizenshipCountry2 { get; set; }

        /// <summary>
        /// City (varchar)
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Client Consent (varchar)
        /// 1 = Yes 0 = No
        /// </summary>
        public string ClientCons { get; set; }

        /// <summary>
        /// Communication Language (varchar)
        /// </summary>
        public string ComLanguage { get; set; }

        /// <summary>
        /// Communication Method (varchar)
        /// </summary>
        public string ComMethod { get; set; }

        /// <summary>
        /// Contract (integer)
        /// </summary>
        public int Contract { get; set; }

        /// <summary>
        /// Contract Date (datetime)
        /// </summary>
        public DateTime ContractDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// County (varchar)
        /// </summary>
        public string County { get; set; }

        public string? CountyType { get; set; }

        /// <summary>
        /// Country Short Description (varchar)
        /// </summary>
        public string CtryShortDescription { get; set; }

        public List<Custcat> CustcatList { get; set; }

        public List<CbsCustomerAddress> CustomerAddressesList { get; set; }

        /// <summary>
        /// CRM Id (varchar)
        /// </summary>
        public string CustomerCrmId { get; set; }

        /// <summary>
        /// Customer Id (varchar)
        /// </summary>
        [Mockup(1)]
        public string CustomerId { get; set; }

        public List<CbsCustomerIdentification> CustomerIdentificationsList { get; set; }

        /// <summary>
        /// Birth Date (datetime)
        /// </summary>
        public DateTime DateOfBirth { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// DelZone (varchar)
        /// If is empty then 0
        /// </summary>
        public string DelZone { get; set; }

        /// <summary>
        /// Delegate Zone (varchar)
        /// MARCODE
        /// </summary>
        public string DelZoneCBS { get; set; }

        /// <summary>
        /// Dependants No (integer)
        /// </summary>
        public int DependNo { get; set; }

        /// <summary>
        /// DIASPORA (varchar)
        /// If is empty then 0
        /// </summary>
        public string DIASPORA { get; set; }

        /// <summary>
        /// Diaspora (varchar)
        /// DIASP
        /// </summary>
        public string DIASPORACBS { get; set; }

        /// <summary>
        /// Education Level (integer)
        /// </summary>
        public int EducationLevelCode { get; set; }

        /// <summary>
        /// Email 1 (varchar)
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Email 2 (varchar)
        /// </summary>
        public string Email2 { get; set; }

        /// <summary>
        /// Total Employment (datetime)
        /// </summary>
        public DateTime EmplDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Employee No (integer)
        /// </summary>
        public int EmployeeCode { get; set; }

        /// <summary>
        /// Bank Employee Id (varchar)
        /// </summary>
        public string EmployeeNo { get; set; }

        /// <summary>
        /// Employement (varchar)
        /// If is empty then 0
        /// </summary>
        public string Employement { get; set; }

        /// <summary>
        /// Employment Sector (varchar)
        /// EMPLSEC
        /// </summary>
        public string EmployementCBS { get; set; }

        /// <summary>
        /// Payroll No (PF Number) (varchar)
        /// </summary>
        public string Employer { get; set; }

        /// <summary>
        /// Employer Address (varchar)
        /// </summary>
        public string EmployerAddress { get; set; }

        /// <summary>
        /// Employer No (integer)
        /// </summary>
        public int EmployerCode { get; set; }

        /// <summary>
        /// Activity Sector (integer)
        /// </summary>
        public int EmploymentCode { get; set; }

        /// <summary>
        /// Fax (varchar)
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// Financial Sector (integer)
        /// </summary>
        public int FinancialSectorCode { get; set; }

        /// <summary>
        /// First Name (varchar)
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Floor (varchar)
        /// </summary>
        public string Floor { get; set; }

        /// <summary>
        /// Funeral Fees (decimal)
        /// </summary>
        public decimal FunAmount { get; set; }

        /// <summary>
        /// Document No (varchar)
        /// </summary>
        public string IdentificationDocument { get; set; }

        /// <summary>
        /// Id Expiry Date (datetime)
        /// </summary>
        public DateTime IdentificationExpiryDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Issue Country (varchar)
        /// </summary>
        public string IdentificationIssueCountryShortDescription { get; set; }

        /// <summary>
        /// Id Issue Date (datetime)
        /// </summary>
        public DateTime IdentificationIssueDate { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Identification Number (varchar)
        /// </summary>
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// Id Type (varchar)
        /// </summary>
        public string IdentificationType { get; set; }

        /// <summary>
        /// Income Range (integer)
        /// </summary>
        public int IncomeRange { get; set; }

        public CbsIndividualCustomerView IndividualCustomerViews { get; set; }

        /// <summary>
        /// Insurance Fees (decimal)
        /// </summary>
        public decimal InsAmount { get; set; }

        /// <summary>
        /// Insider (varchar)
        /// If is empty then 0
        /// </summary>
        public string Insider { get; set; }

        /// <summary>
        /// Insider Type (varchar)
        /// INSIDER
        /// </summary>
        public string InsiderCBS { get; set; }

        /// <summary>
        /// Investment (varchar)
        /// If is empty then 0
        /// </summary>
        public string Investment { get; set; }

        /// <summary>
        /// Invest. Member (varchar)
        /// IVNMB
        /// </summary>
        public string InvestmentCBS { get; set; }

        /// <summary>
        /// Marital Status (integer)
        /// </summary>
        public int MaritalStatus { get; set; }

        /// <summary>
        /// MEMBCAT (varchar)
        /// If is empty then 0
        /// </summary>
        public string MEMBCAT { get; set; }

        /// <summary>
        /// Member Category (varchar)
        /// MEMBCAT
        /// </summary>
        public string MEMBCATCBS { get; set; }

        /// <summary>
        /// Middle Name (varchar)
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Missing PIN (varchar)
        /// 1 = Yes 0 = No
        /// </summary>
        public string MissingAfm { get; set; }

        /// <summary>
        /// Mobile 1 (varchar)
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Mobile 2 (varchar)
        /// </summary>
        public string Mobile2 { get; set; }

        /// <summary>
        /// Position (integer)
        /// </summary>
        public int OccupationCode { get; set; }

        /// <summary>
        /// P.O. Box (varchar)
        /// </summary>
        public string PoBox { get; set; }

        /// <summary>
        /// Political (varchar)
        /// If is empty then 0
        /// </summary>
        public string Political { get; set; }

        /// <summary>
        /// Politically Exposed (varchar)
        /// CSPEPCAT
        /// </summary>
        public string PoliticalCBS { get; set; }

        /// <summary>
        /// Profession Status (integer)
        /// </summary>
        public int PositionCode { get; set; }

        /// <summary>
        /// Postal Code (varchar)
        /// </summary>
        public string Postal { get; set; }

        /// <summary>
        /// Province/ Post Office (integer)
        /// </summary>
        public int PostOffice { get; set; }

        /// <summary>
        /// Primary Occupation (integer)
        /// </summary>
        public int ProfessionCode { get; set; }

        /// <summary>
        /// Recruited By (varchar)
        /// </summary>
        public string RecruiterBy { get; set; }

        /// <summary>
        /// Non Resident (varchar)
        /// 1 = Yes 0 = No
        /// </summary>
        public string ResidencyStatus { get; set; }

        /// <summary>
        /// Secret (varchar)
        /// If is empty then 0
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// Secret Customer (varchar)
		/// SECRET
        /// </summary>
        public string SecretCBS { get; set; }

        /// <summary>
        /// Gender (varchar)
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// SHARIA (varchar)
        /// If is empty then 0
        /// </summary>
        public string SHARIA { get; set; }

        /// <summary>
        /// Sharia Membership (varchar)
        /// SHARIA
        /// </summary>
        public string SHARIACBS { get; set; }

        /// <summary>
        /// SPECA (varchar)
        /// If is empty then 0
        /// </summary>
        public string SPECA { get; set; }

        /// <summary>
        /// Special Category (varchar)
        /// SPECATEG
        /// </summary>
        public string SPECACBS { get; set; }

        /// <summary>
        /// Surname (varchar)
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Telephone 1 (varchar)
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// Telephone 2 (varchar)
        /// </summary>
        public string Telephone2 { get; set; }

        /// <summary>
        /// Telephone 3 (varchar)
        /// </summary>
        public string Telephone3 { get; set; }

        /// <summary>
        /// Title (varchar)
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Web Site (varchar)
        /// </summary>
        public string WebSite { get; set; }

        /// <summary>
        /// CountyType (varchar)
        /// If country = DEFAULT then ADDRESS else null
        /// </summary>
#nullable enable
#nullable disable

        #endregion Public Properties
    }
}