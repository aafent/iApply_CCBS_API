using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class ApplicationData
    {
        #region Public Properties

        [DataMember]
        public string AcivitySectorCode { get; set; }

        [DataMember]
        public string ActivitySector { get; set; }

        [DataMember]
        public string ApplicationDate { get; set; }

        [DataMember]
        public string ApplicationDecision { get; set; }

        [DataMember]
        public string ApplicationDecisionCode { get; set; }

        [DataMember]
        public string ApplicationId { get; set; }

        [DataMember]
        public string ApplicationStatus { get; set; }

        [DataMember]
        public string ApplicationStatusCode { get; set; }

        [DataMember]
        public string ApplicationType { get; set; }

        [DataMember]
        public string ApplicationTypeCode { get; set; }

        [DataMember]
        public string ApprovedAmount { get; set; }

        [DataMember]
        public string CentralBankTenor { get; set; }

        [DataMember]
        public string CentralBankTenorCode { get; set; }

        [DataMember]
        public string Currency { get; set; }

        [DataMember]
        public string CurrencyCode { get; set; }

        [DataMember]
        public string DivisionAddress { get; set; }

        [DataMember]
        public string DivisionAddressCode { get; set; }

        [DataMember]
        public string FinancialSector { get; set; }

        [DataMember]
        public string FinancialSectorCode { get; set; }

        [DataMember]
        public string FixedInterestRate { get; set; }

        [DataMember]
        public string FixedInterestRateCode { get; set; }

        [DataMember]
        public string FixedRate { get; set; }

        [DataMember]
        public string FloatingInterestRate { get; set; }

        [DataMember]
        public string FloatingInterestRateCode { get; set; }

        [DataMember]
        public string FloatingRate { get; set; }

        [DataMember]
        public string InstallNo { get; set; }

        [DataMember]
        public string la_produ_des { get; set; }

        [DataMember]
        public string LoanDuration { get; set; }

        [DataMember]
        public string LoanFrequency { get; set; }

        [DataMember]
        public string LoanPurpose { get; set; }

        [DataMember]
        public string LoanPurposeCode { get; set; }

        [DataMember]
        public string Margin { get; set; }

        [DataMember]
        public string OfferNo { get; set; }

        [DataMember]
        public string ParticipantType { get; set; }

        [DataMember]
        public string ProductCode { get; set; }

        [DataMember]
        public string RequestedAmount { get; set; }

        [DataMember]
        public string StatementFrequency { get; set; }

        [DataMember]
        public string StatementFrequencyCode { get; set; }

        #endregion Public Properties
    }
}