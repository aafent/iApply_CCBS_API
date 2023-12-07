namespace IApplyDataAccess.DataModel
{
    public class IndividualCustomerView
    {
        #region Public Properties

        public virtual string AfmIssueCountry { get; set; }

        public virtual string AfmIssueCountryShortDescription { get; set; }

        public virtual string AfmNo { get; set; }

        public virtual string Agent { get; set; }

        public virtual string AgentCBS { get; set; }

        public virtual string BirthIssueCountry { get; set; }

        public virtual string BirthIssueCountryShortDescription { get; set; }

        public virtual string Birthplace { get; set; }

        public virtual int? BranchCBSId { get; set; }

        public virtual string Category { get; set; }

        public virtual string CategoryCBS { get; set; }

        public virtual string Childhope { get; set; }

        public virtual string ChildhopeCBS { get; set; }

        public virtual int? ChildNo { get; set; }

        public virtual string CitizenshipCountry { get; set; }

        public virtual string CitizenshipCountry2 { get; set; }

        public virtual string CitizenshipCountry2ShortDescription { get; set; }

        public virtual string CitizenshipCountryCountryShortDescription { get; set; }

        public virtual string ClientCons { get; set; }

        public virtual string ComLanguage { get; set; }

        public virtual string ComMethod { get; set; }

        public virtual string Contract { get; set; }

        public virtual DateTime ContractDate { get; set; }

        public virtual int? CustomerCBSCd { get; set; }

        public virtual string CustomerCBSCdId { get; set; }

        public virtual int? CustomerCBSId { get; set; }

        public virtual string CustomerCrmId { get; set; }

        public virtual string CustomerId { get; set; }

        public virtual DateTime? DateOfBirth { get; set; }

        public virtual string DelZone { get; set; }

        public virtual string DelZoneCBS { get; set; }

        public virtual int? DependNo { get; set; }

        public virtual string DIASPORA { get; set; }

        public virtual string DIASPORACBS { get; set; }

        public virtual int? EducationLevelCode { get; set; }

        public virtual string Email { get; set; }

        public virtual string Email2 { get; set; }

        public virtual DateTime EmplDate { get; set; }

        public virtual string EmployeeCode { get; set; }

        public virtual string EmployeeNo { get; set; }

        public virtual string Employement { get; set; }

        public virtual string EmployementCBS { get; set; }

        public virtual string Employer { get; set; }

        public virtual string EmployerAddress { get; set; }

        public virtual string EmployerCode { get; set; }

        public virtual int? EmploymentCode { get; set; }

        public virtual int? FinancialSectorCode { get; set; }

        public virtual string FirstName { get; set; }

        public virtual int? IncomeRange { get; set; }

        public virtual string Insider { get; set; }

        public virtual string InsiderCBS { get; set; }

        public virtual string Investment { get; set; }

        public virtual string InvestmentCBS { get; set; }

        public virtual int? MaritalStatus { get; set; }

        public virtual string MEMBCAT { get; set; }

        public virtual string MEMBCATCBS { get; set; }

        public virtual string MiddleName { get; set; }

        public virtual string MissingAfm { get; set; }

        public virtual string Mobile { get; set; }

        public virtual string Mobile2 { get; set; }

        public virtual int? OccupationCode { get; set; }

        public virtual string Political { get; set; }

        public virtual string PoliticalCBS { get; set; }

        public virtual int? PositionCode { get; set; }

        public virtual int? ProfessionCode { get; set; }

        public virtual string RecruiterBy { get; set; }

        public virtual string ResidencyStatus { get; set; }

        public virtual int? SalaryFreq { get; set; }

        public virtual int? SalaryRange { get; set; }

        public virtual string Secret { get; set; }

        public virtual string SecretCBS { get; set; }

        public virtual string Sex { get; set; }

        public virtual string SHARIA { get; set; }

        public virtual string SHARIACBS { get; set; }

        public virtual string SPECA { get; set; }

        public virtual string SPECACBS { get; set; }

        public virtual string Surname { get; set; }

        public virtual string Title { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            var t = obj as IndividualCustomerView;

            if (t == null) return false;

            return (GetHashCode() == t.GetHashCode());
        }

        public override int GetHashCode()
        {
            return CustomerId.GetHashCode();
        }

        #endregion Public Methods
    }
}