using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsUpdateIndividualCustomerRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: PIN
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: InOtherAfmAfmNo
        /// </summary>
        public string AfmNo { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Birth Country
        /// Data Type: varchar (100)
        /// Notes: N/A
        /// CBS: InBirthCountryGenericDetailShortDescription
        /// </summary>
        public string BirthIssueCountryShortDescription { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Nationality
        /// Data Type: varchar (100)
        /// Notes: N/A
        /// CBS: InNationalityGenericDetailSerialNum
        /// </summary>
        public string Birthplace { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Branch
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InMonitoringUnitCode
        /// </summary>
        public int BranchCBSId { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Children No
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InCustomerNumOfChildren
        /// </summary>
        public int ChildNo { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Citizenship
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: InCitizenshipGenericDetailSerialNum
        /// </summary>
        public string CitizenshipCountry { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Communication Language
        /// Data Type: varchar (10)
        /// Notes: N/A
        /// CBS: InCommunicationLanguageGenericDetailSerialNum
        /// </summary>
        public string ComLanguage { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Communication Method
        /// Data Type: varchar (150)
        /// Notes: N/A
        /// CBS: InCustomerCommunMethod
        /// </summary>
        public string ComMethod { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Contract
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InCustomerContract
        /// </summary>
        public int Contract { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Contract Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: InCustomerContractExpiryDate
        /// </summary>
        public DateTime ContractDate { get; set; } =  DateTime.Parse("1800-01-01");

        public List<CbsCustomerAddress> CustomerAddresses { get; set; } = new List<CbsCustomerAddress>();

        public List<CbsCustomerCategory> CustomerCategories { get; set; } = new List<CbsCustomerCategory>();

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Customer CBS Id
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: InCustomerCustId
        /// </summary>
        [Mockup(1)]
        public string CustomerCBSId { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: CRM Id
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: InCustomerCrmId
        /// </summary>
        public string CustomerCrmId { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Customer Id
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: InCustomerIapplyId
        /// </summary>
        public string CustomerId { get; set; }

        public List<CbsCustomerIdentification> CustomerIdentifications { get; set; } = new List<CbsCustomerIdentification>();

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Birth Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: InCustomerDateOfBirth
        /// </summary>
        public DateTime DateOfBirth { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Dependants No
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InCustomerFamilyMembers
        /// </summary>
        public int DependNo { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Education Level
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InEducationLevelGenericDetailSerialNum
        /// </summary>
        public int EducationLevelCode { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Email 1
        /// Data Type: varchar (50)
        /// Notes: N/A
        /// CBS: InCustomerEMail
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Employee No
        /// Data Type: N/A
        /// Notes: N/A
        /// CBS: InCustomerEmployeeId
        /// </summary>
        public string EmployeeCode { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Bank Employee Id
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: InBankemployeeId
        /// </summary>
        public string EmployeeNo { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Payroll No (PF Number)
        /// Data Type: varchar (100)
        /// Notes: N/A
        /// CBS: InCustomerEmployer
        /// </summary>
        public string Employer { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Employer Address
        /// Data Type: N/A
        /// Notes: N/A
        /// CBS: InCustomerEmployerAddress
        /// </summary>
        public string EmployerAddress { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Employer No
        /// Data Type: N/A
        /// Notes: N/A
        /// CBS: InCustomerChamberId
        /// </summary>
        public string EmployerCode { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Activity Sector
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InActivityGenericDetailSerialNum
        /// </summary>
        public int EmploymentCode { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Financial Sector
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InEconomicGroupGenericDetailSerialNum
        /// </summary>
        public int FinancialSectorCode { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: First Name
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: InCustomerFirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Income Range
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InIncomeLevelGenericDetailSerialNum
        /// </summary>
        public int IncomeRange { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Marital Status
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InFamilyStatusGenericDetailSerialNum
        /// </summary>
        public int MaritalStatus { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Middle Name
        /// Data Type: varchar (100)
        /// Notes: N/A
        /// CBS: InCustomerMiddleName
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Missing PIN
        /// Data Type: varchar(1)
        /// Notes: N/A
        /// CBS: InCustomerNoAfm
        /// </summary>
        public string MissingAfm { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Mobile 1
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: InCustomerMobileTel
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Position
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InProfessionCategoryGenericDetailSerialNum
        /// </summary>
        public int OccupationCode { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Profession Status
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InProfessionStatusGenericDetailSerialNum
        /// </summary>
        public int PositionCode { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Primary Occupation
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: InProfessionGenericDetailSerialNum
        /// </summary>
        public int ProfessionCode { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Recruited By
        /// Data Type: varchar (40)
        /// Notes: N/A
        /// CBS: InCustomerAttractionDetails
        /// </summary>
        public string RecruiterBy { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Non Resident
        /// Data Type: varchar(1)
        /// Notes: N/A
        /// CBS: InCustomerNonResident
        /// </summary>
        public string ResidencyStatus { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Gender
        /// Data Type: varchar (1)
        /// Notes: N/A
        /// CBS: InCustomerSex
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Surname
        /// Data Type: varchar (100)
        /// Notes: N/A
        /// CBS: InCustomerSurname
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: v_CBS_IndividualCustomerView
        /// Description: Title
        /// Data Type: varchar (100)
        /// Notes: N/A
        /// CBS: InCustomerTitle
        /// </summary>
        public string Title { get; set; }

        #endregion Public Properties
    }
}