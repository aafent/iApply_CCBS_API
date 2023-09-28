using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsUpdateIndividualCustomerRequest
    {
        #region Public Properties

        /// <summary>
        /// First Name (varchar (20))
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Middle Name (varchar (100))
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Surname (varchar (100))
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gender (varchar (1))
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// PIN (varchar (20))
        /// </summary>
        public string AfmNo { get; set; }

        /// <summary>
        /// Missing PIN (varchar (1))
        /// 1 = Yes 0 = No
        /// </summary>
        public string MissingAfm { get; set; }

        /// <summary>
        /// Birth Date (datetime)
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Non Resident (varchar (1))
        /// 1 = Yes 0 = No
        /// </summary>
        public string ResidencyStatus { get; set; }

        /// <summary>
        /// Nationality (varchar (100))
        /// </summary>
        public string Birthplace { get; set; }

        /// <summary>
        /// Mobile 1 (varchar (20))
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Email 1 (varchar (50))
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Education Level (integer)
        /// </summary>
        public int EducationLevelCode { get; set; }

        /// <summary>
        /// Payroll No (PF Number) (varchar)
        /// </summary>
        public string Employer { get; set; }

        /// <summary>
        /// Activity Sector (integer)
        /// </summary>
        public int EmploymentCode { get; set; }

        /// <summary>
        /// Bank Employee Id (varchar (15))
        /// </summary>
        public string EmployeeNo { get; set; }

        /// <summary>
        /// Position (integer)
        /// </summary>
        public int OccupationCode { get; set; }

        /// <summary>
        /// Employer Address (varchar)
        /// </summary>
        public string EmployerAddress { get; set; }

        /// <summary>
        /// Birth Country (varchar (100))
        /// </summary>
        public string BirthIssueCountryShortDescription { get; set; }

        /// <summary>
        /// Citizenship (varchar (15))
        /// </summary>
        public string CitizenshipCountry { get; set; }

        /// <summary>
        /// Profession Status (integer)
        /// </summary>
        public int PositionCode { get; set; }

        /// <summary>
        /// Branch (integer)
        /// </summary>
        public int BranchCBSId { get; set; }

        /// <summary>
        /// Marital Status (integer)
        /// </summary>
        public int MaritalStatus { get; set; }

        /// <summary>
        /// Dependants No (integer)
        /// </summary>
        public int DependNo { get; set; }

        /// <summary>
        /// Title (varchar (100))
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Communication Method (varchar (150))
        /// </summary>
        public string ComMethod { get; set; }

        /// <summary>
        /// CRM Id (varchar (20))
        /// </summary>
        public string CustomerCrmId { get; set; }

        /// <summary>
        /// Customer Id (varchar (15))
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Children No (integer)
        /// </summary>
        public int ChildNo { get; set; }

        /// <summary>
        /// Income Range (integer)
        /// </summary>
        public int IncomeRange { get; set; }

        /// <summary>
        /// Communication Language (varchar (10))
        /// </summary>
        public string ComLanguage { get; set; }

        /// <summary>
        /// Contract (integer)
        /// </summary>
        public int Contract { get; set; }

        /// <summary>
        /// Contract Date (datetime)
        /// </summary>
        public DateTime ContractDate { get; set; }

        /// <summary>
        /// Employee No (integer)
        /// </summary>
        public int EmployeeCode { get; set; }

        /// <summary>
        /// Employer No (integer)
        /// </summary>
        public int EmployerCode { get; set; }

        /// <summary>
        /// Recruited By (varchar (40))
        /// </summary>
        public string RecruiterBy { get; set; }

        /// <summary>
        /// Politically Exposed (varchar)
        /// CSPEPCAT
        /// </summary>
        public string PoliticalCBS { get; set; }

        /// <summary>
        /// Political (varchar)
        /// If is empty then 0
        /// </summary>
        public string Political { get; set; }

        /// <summary>
        /// Insider Type (varchar (15))
        /// INSIDER
        /// </summary>
        public string InsiderCBS { get; set; }

        /// <summary>
        /// Insider (varchar (15))
        /// If is empty then 0
        /// </summary>
        public string Insider { get; set; }

        /// <summary>
        /// Secret Customer (varchar (15))
        /// SECRET
        /// </summary>
        public string SecretCBS { get; set; }

        /// <summary>
        /// Secret (varchar (15))
        /// If is empty then 0
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// Invest. Member (varchar (15))
        /// IVNMB
        /// </summary>
        public string InvestmentCBS { get; set; }

        /// <summary>
        /// Investment (varchar (15))
        /// If is empty then 0
        /// </summary>
        public string Investment { get; set; }

        /// <summary>
        /// Delegate Zone (varchar (15))
        /// MARCODE
        /// </summary>
        public string DelZoneCBS { get; set; }

        /// <summary>
        /// DelZone (varchar (15))
        /// If is empty then 0
        /// </summary>
        public string DelZone { get; set; }

        /// <summary>
        /// Special Category (varchar (15))
        /// SPECATEG
        /// </summary>
        public string SPECACBS { get; set; }

        /// <summary>
        /// SPECA (varchar (15))
        /// If is empty then 0
        /// </summary>
        public string SPECA { get; set; }

        /// <summary>
        /// Sharia Membership (varchar (15))
        /// SHARIA
        /// </summary>
        public string SHARIACBS { get; set; }

        /// <summary>
        /// SHARIA (varchar (15))
        /// If is empty then 0
        /// </summary>
        public string SHARIA { get; set; }

        /// <summary>
        /// Diaspora (varchar (15))
        /// DIASP
        /// </summary>
        public string DIASPORACBS { get; set; }

        /// <summary>
        /// DIASPORA (varchar (15))
        /// If is empty then 0
        /// </summary>
        public string DIASPORA { get; set; }

        /// <summary>
        /// Member Category (varchar (15))
        /// MEMBCAT
        /// </summary>
        public string MEMBCATCBS { get; set; }

        /// <summary>
        /// MEMBCAT (varchar (15))
        /// If is empty then 0
        /// </summary>
        public string MEMBCAT { get; set; }

        /// <summary>
        /// Childhope (varchar (15))
        /// CHDHP
        /// </summary>
        public string ChildhopeCBS { get; set; }

        /// <summary>
        /// Childhope (varchar (15))
        /// If is empty then 0
        /// </summary>
        public string Childhope { get; set; }

        /// <summary>
        /// Agent (varchar (15))
        /// AGENT
        /// </summary>
        public string AgentCBS { get; set; }

        /// <summary>
        /// Agent (varchar (15))
        /// If is empty then 0
        /// </summary>
        public string Agent { get; set; }

        /// <summary>
        /// Member Category (varchar (15))
        /// If customer is individual then ISHACAT If customer is legal then GSHACAT If customer is group then CSHACAT
        /// </summary>
        public string CategoryCBS { get; set; }

        /// <summary>
        /// Member Category (varchar (15))
        /// If is empty then 0
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Street Name, Address Line 1 (varchar (255))
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Plot/Street No, Address Line 2 (varchar (255)
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// City (varchar (200)
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Telephone 1 (varchar (20))
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// P.O. Box (varchar (10))
        /// </summary>
        public string PoBox { get; set; }

        /// <summary>
        /// County (varchar (15))
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Fax (varchar (30))
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// Postal Code (varchar (10))
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Telephone 2 (varchar (20))
        /// </summary>
        public string Telephone2 { get; set; }

        /// <summary>
        /// Telephone 3 (varchar (20))
        /// </summary>
        public string Telephone3 { get; set; }

        /// <summary>
        /// Address Type (varchar (15))
        /// </summary>
        public string AddressType { get; set; }

        /// <summary>
        /// Building Name (varchar (32))
        /// </summary>
        public string BuildName { get; set; }

        /// <summary>
        /// Floor (varchar (32))
        /// </summary>
        public string Floor { get; set; }

        /// <summary>
        /// Building (varchar (32))
        /// </summary>
        public string Building { get; set; }

        /// <summary>
        /// Apartment (varchar (32))
        /// </summary>
        public string Apart { get; set; }

        /// <summary>
        /// Province/ Post Office (integer)
        /// </summary>
        public int PostOffice { get; set; }

        /// <summary>
        /// Web Site (varchar (100))
        /// </summary>
        public string WebSite { get; set; }

        /// <summary>
        /// Accommodation Date (datetime)
        /// </summary>
        public DateTime AccDate { get; set; }

        /// <summary>
        /// Address Status (integer)
        /// </summary>
        public int AddressStatus { get; set; }

        /// <summary>
        /// Address Details SN (integer)
        /// </summary>
        public int AddSerial { get; set; }

        /// <summary>
        /// CountyType (varchar (15))
        /// </summary>
        public string CountyType { get; set; }

        /// <summary>
        /// Issue Date (datetime)
        /// </summary>
        public DateTime IdentificationIssueDate { get; set; }

        /// <summary>
        /// Identification Number (varchar (100))
        /// </summary>
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// Identification Type (varchar (10))
        /// </summary>
        public string IdentificationType { get; set; }

        /// <summary>
        /// Issue Country Description (varchar(200))
        /// </summary>
        public string IdentificationIssueCountryShortDescription { get; set; }

        /// <summary>
        /// Id Expiry Date (datetime)
        /// </summary>
        public DateTime IdentificationExpiryDate { get; set; }

        /// <summary>
        /// Document No (varchar (4000))
        /// </summary>
        public string IdentificationDocument { get; set; }

        /// <summary>
        /// Address S/N (integer)
        /// </summary>
        public int AddressSerialNumber { get; set; }

        /// <summary>
        /// Country Short Description (varchar (200))
        /// </summary>
        public string CountryShortDes { get; set; }

        /// <summary>
        /// CBS SN (integer)
        /// </summary>
        public int SnCBS { get; set; }

        /// <summary>
        /// Authority (varchar (100))
        /// </summary>
        public string IdentificationAuthority { get; set; }

        /// <summary>
        /// Issue Country (integer)
        /// </summary>
        public int IdentificationIssueCountry { get; set; }

        /// <summary>
        /// Main Id (varchar (1))
        /// 1 = Yes 0 = No
        /// </summary>
        public string IdentificationMain { get; set; }

        /// <summary>
        /// Country (varchar (15))
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Communication Address (varchar (1))
        /// 1 = Yes 0 = No
        /// </summary>
        public string MainAddress { get; set; }

        /// <summary>
        /// Member Category (varchar)
        /// ISHACAT
        /// </summary>
        public string categoryCBSOut { get; set; }

        /// <summary>
        /// Agent (varchar)
        /// AGENT
        /// </summary>
        public string agentOut { get; set; }

        /// <summary>
        /// Childhope (varchar)
        /// CHDHP
        /// </summary>
        public string childhopeOut { get; set; }

        /// <summary>
        /// Member Category (varchar)
        /// MEMBCAT
        /// </summary>
        public string membcatOut { get; set; }

        /// <summary>
        /// Diaspora (varchar)
        /// DIASP
        /// </summary>
        public string diasporaOut { get; set; }

        /// <summary>
        /// Sharia Membership (varchar)
        /// SHARIA
        /// </summary>
        public string shariaOut { get; set; }

        /// <summary>
        /// Special Category (varchar)
        /// SPECATEG
        /// </summary>
        public string specaOut { get; set; }

        /// <summary>
        /// Delegate Zone (varchar)
        /// MARCODE
        /// </summary>
        public string delzoneOut { get; set; }

        /// <summary>
        /// Invest. Member (varchar)
        /// IVNMB
        /// </summary>
        public string investmentOut { get; set; }

        /// <summary>
        /// Secret Customer (varchar)
        /// SECRET
        /// </summary>
        public string secretOut { get; set; }

        /// <summary>
        /// Insider Type (varchar)
        /// INSIDER
        /// </summary>
        public string insiderOut { get; set; }

        /// <summary>
        /// Politically Exposed (varchar)
        /// CSPEPCAT
        /// </summary>
        public string politicalyExposedOut { get; set; }

        /// <summary>
        /// Customer Check Digit (integer)
        /// </summary>
        public int? CustomerCBSCd { get; set; }

        /// <summary>
        /// Customer CBS Id (varchar (20))
        /// </summary>
        public string CustomerCBSId { get; set; }

        #endregion Public Properties
    }
}
