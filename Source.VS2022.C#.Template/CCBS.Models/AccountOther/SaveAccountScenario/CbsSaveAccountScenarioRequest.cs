using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsSaveAccountScenarioRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Account Officer (v_CBS_LGView)
        /// Data Type: varchar (15)
        /// Entities: v_CBS_LGView
        /// Notes: IAPP0001
        /// </summary>
        public string AccountOfficer { get; set; }

        /// <summary>
        /// Monitoring Branch (v_CBS_LGView)
        /// Data Type: integer
        /// Entities: v_CBS_LGView
        /// </summary>
        public int AccountUnit { get; set; }

        /// <summary>
        /// Address S/N
        /// Data Type: integer
        /// Entities: v_CBS_SDView
        /// </summary>
        public int AddressSN { get; set; }

        /// <summary>
        /// Advising Bank (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string AdviseBank { get; set; }

        /// <summary>
        /// Agreement Number (v_CBS_LGView)
        /// Data Type: varchar (30)
        /// Entities: v_CBS_LGView
        /// </summary>
        public string AgreementNo { get; set; }

        /// <summary>
        /// Agreement Check Digit (v_CBS_LGView)
        /// Data Type: integer
        /// Entities: v_CBS_LGView
        /// </summary>
        public int AgreementNo_Cd { get; set; }

        /// <summary>
        /// Account Limit (v_CBS_LGView)
        /// Data Type: decimal (15,2)
        /// Entities: v_CBS_LGView
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// Deposit Account (v_CBS_LGView)
        /// Data Type: varchar (30)
        /// Entities: v_CBS_LGView
        /// </summary>
        public string ApplicantAccNumber { get; set; }

        /// <summary>
        /// Deposit Account Check Digit (v_CBS_LGView)
        /// Data Type: integer
        /// Entities: v_CBS_LGView
        /// </summary>
        public int ApplicantAccNumber_Cd { get; set; }

        /// <summary>
        /// Main Applicant Check Digit (v_CBS_LGView)
        /// Data Type: integer
        /// Entities: v_CBS_LGView
        /// </summary>
        public int ApplicantCBSCd { get; set; }

        /// <summary>
        /// Main Applicant CBS Id (v_CBS_LGView)
        /// Data Type: varchar (15)
        /// Entities: v_CBS_LGView
        /// </summary>
        public string ApplicantCBSId { get; set; }

        /// <summary>
        /// Application Id
        /// Data Type: varchar (15)
        /// Entities: v_CBS_SDView
        /// </summary>
        [Mockup(1)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Application Id (v_CBS_LGView)
        /// Data Type: varchar (15)
        /// Entities: v_CBS_LGView
        /// </summary>
        public string ApplicationId_LGView { get; set; }

        /// <summary>
        /// Assign of Proceed (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int Assign { get; set; }

        /// <summary>
        /// Central Bank (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int CentralBank { get; set; }

        /// <summary>
        /// Charges Currency (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int ChargesCurrencyID { get; set; }

        /// <summary>
        /// Closing Location (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string ClosingLoc { get; set; }

        /// <summary>
        /// Comments
        /// Data Type: varchar (40)
        /// Entities: v_CBS_SDView
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Comments (v_CBS_LGView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_LGView
        /// </summary>
        public string Comments_LGView { get; set; }

        /// <summary>
        /// Confirming Bank (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string ConfirmBank { get; set; }

        /// <summary>
        /// Confirmed (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int Confirmed { get; set; }

        /// <summary>
        /// Account Number for Issuer or Beneficiary (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string ContactAccNumber { get; set; }

        /// <summary>
        /// Account Number Check Digit for Correspondent (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int ContactAccNumber_Cd { get; set; }

        /// <summary>
        /// Address for Issuer or Beneficiary (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string ContactAddress { get; set; }

        /// <summary>
        /// Address 2 for Representative (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string ContactAddress2 { get; set; }

        /// <summary>
        /// Mediator Check Digit (v_CBS_LGView)
        /// Data Type: integer
        /// Entities: v_CBS_LGView
        /// </summary>
        public int ContactCBSCd { get; set; }

        /// <summary>
        /// Mediator CBS Id (v_CBS_LGView)
        /// Data Type: varchar (15)
        /// Entities: v_CBS_LGView
        /// </summary>
        public string ContactCBSId { get; set; }

        /// <summary>
        /// Country for Representative (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string ContactCountry { get; set; }

        /// <summary>
        /// Full Name for Issuer or Beneficiary (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string ContactFullName { get; set; }

        /// <summary>
        /// Work Phone for Representative (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string ContactPhone { get; set; }

        /// <summary>
        /// Region for Representative (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string ContactRegion { get; set; }

        /// <summary>
        /// Representative if is Resident (v_CBS_TradeView)
        /// Data Type: string
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string ContactRes { get; set; }

        /// <summary>
        /// Postal Code for Representative (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string ContactZipCode { get; set; }

        /// <summary>
        /// Country of Origin (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int CountryOrigin { get; set; }

        /// <summary>
        /// Currency (v_CBS_LGView)
        /// Data Type: integer
        /// Entities: v_CBS_LGView
        /// </summary>
        public int CurrencyID { get; set; }

        /// <summary>
        /// Deposit Account
        /// Data Type: varchar (30)
        /// Entities: v_CBS_SDView
        /// </summary>
        public string CustomerAccNumber { get; set; }

        /// <summary>
        /// Deposit Account Check Digit
        /// Data Type: integer
        /// Entities: v_CBS_SDView
        /// </summary>
        public int CustomerAccNumber_Cd { get; set; }

        /// <summary>
        /// Main Applicant Check Digit
        /// Data Type: integer
        /// Entities: v_CBS_SDView
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Main Applicant CBS Id
        /// Data Type: varchar (15)
        /// Entities: v_CBS_SDView
        /// </summary>
        public string CustomerCBSId { get; set; }

        /// <summary>
        /// Delivery Date (v_CBS_TradeView)
        /// Data Type: datetme
        /// Entities: v_CBS_TradeView
        /// </summary>
        public DateTime DestDate { get; set; }

        /// <summary>
        /// Destination (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string DestInfo { get; set; }

        /// <summary>
        /// Dispatch Through (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int Dispatch { get; set; }

        /// <summary>
        /// Document Justification Id (v_CBS_LGView)
        /// Data Type: integer
        /// Entities: v_CBS_LGView
        /// Notes: 14011
        /// </summary>
        public int DocumentJustificId { get; set; }

        /// <summary>
        /// Rental Expiration Date
        /// Data Type: datetime
        /// Entities: v_CBS_SDView
        /// </summary>
        public DateTime ExpDate { get; set; }

        /// <summary>
        /// Expiration Type (v_CBS_LGView)
        /// Data Type: integer
        /// Entities: v_CBS_LGView
        /// </summary>
        public int ExpirationType { get; set; }

        /// <summary>
        /// Commission Calc Frequency (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public decimal? Frequency { get; set; }

        /// <summary>
        /// Commission Calc Unit (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int FrequencyUnit { get; set; }

        /// <summary>
        /// Inc Reference No (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string IncReferenceNo { get; set; }

        /// <summary>
        /// % of Invoice (v_CBS_TradeView)
        /// Data Type: decimal (15,2)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public decimal Invoice { get; set; }

        /// <summary>
        /// Invoice Type (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int InvoiceType { get; set; }

        /// <summary>
        /// Irrevocable (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int Irrevocable { get; set; }

        /// <summary>
        /// Issuing Bank (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string IssueBank { get; set; }

        /// <summary>
        /// Justification Id (v_CBS_TradeView)
        /// Entities: v_CBS_TradeView
        /// Notes: 99011
        /// </summary>
        public int JustificationId { get; set; }

        /// <summary>
        /// Key System
        /// Data Type: varchar (15)
        /// Entities: v_CBS_SDView
        /// Notes: 32
        /// </summary>
        public string KeySystem { get; set; }

        /// <summary>
        /// Key System (v_CBS_LGView)
        /// Data Type: varchar (15)
        /// Entities: v_CBS_LGView
        /// Notes: 14
        /// </summary>
        public string KeySystem_LGView { get; set; }

        /// <summary>
        /// Language (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int Language { get; set; }

        /// <summary>
        /// Transfer LC Number (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string LCAccNo { get; set; }

        /// <summary>
        /// Transfer LC Number Check Digit (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int LCAccNo_Cd { get; set; }

        /// <summary>
        /// LC Type (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int LCType { get; set; }

        /// <summary>
        /// LG Type (v_CBS_LGView)
        /// Data Type: integer
        /// Entities: v_CBS_LGView
        /// </summary>
        public int LgType { get; set; }

        /// <summary>
        /// Maturity/Renewal Date (v_CBS_LGView)
        /// Data Type: datetime
        /// Entities: v_CBS_LGView
        /// </summary>
        public DateTime MaturityDate { get; set; }

        /// <summary>
        /// Monitoring Branch (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int MonitUnit { get; set; }

        /// <summary>
        /// Negotiating Bank (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string NegotBank { get; set; }

        /// <summary>
        /// Effective Date (v_CBS_LGView)
        /// Data Type: datetime
        /// Entities: v_CBS_LGView
        /// </summary>
        public DateTime OpenDate { get; set; }

        /// <summary>
        /// Monitoring Branch
        /// Data Type: integer
        /// Entities: v_CBS_SDView
        /// </summary>
        public int OpeningUnit { get; set; }

        /// <summary>
        /// Partial Shipments (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int Partial { get; set; }

        /// <summary>
        /// Periodic Com. Posting (v_CBS_LGView)
        /// Data Type: integer
        /// Entities: v_CBS_LGView
        /// </summary>
        public int Periodic { get; set; }

        /// <summary>
        /// Product Id
        /// Data Type: integer
        /// Entities: v_CBS_SDView
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Product Id (v_CBS_LGView)
        /// Data Type: integer
        /// Entities: v_CBS_LGView
        /// </summary>
        public int ProductID_LGView { get; set; }

        /// <summary>
        /// Red Clause (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int RedClause { get; set; }

        /// <summary>
        /// Reference No (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string ReferenceNo { get; set; }

        /// <summary>
        /// Rental Date
        /// Data Type: datetime
        /// Entities: v_CBS_SDView
        /// </summary>
        public DateTime RentalDate { get; set; }

        /// <summary>
        /// Revolving Limit (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int Revolving { get; set; }

        /// <summary>
        /// Safe Deposit S/N
        /// Data Type: integer
        /// Entities: v_CBS_SDView
        /// </summary>
        public int SDSN { get; set; }

        /// <summary>
        /// Settlement Type (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int SettlementType { get; set; }

        /// <summary>
        /// Loading Date (v_CBS_TradeView)
        /// Data Type: datetme
        /// Entities: v_CBS_TradeView
        /// </summary>
        public DateTime ShipDate { get; set; }

        /// <summary>
        /// Shipment Place (v_CBS_TradeView)
        /// Data Type: varchar (40)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public string ShipInfo { get; set; }

        /// <summary>
        /// Template (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int Template { get; set; }

        /// <summary>
        /// Tolerance % (v_CBS_TradeView)
        /// Data Type: decimal (15,2)
        /// Entities: v_CBS_TradeView
        /// </summary>
        public decimal Tolerance { get; set; }

        /// <summary>
        /// Transhipment (v_CBS_TradeView)
        /// Data Type: integer
        /// Entities: v_CBS_TradeView
        /// </summary>
        public int Transship { get; set; }

        #endregion Public Properties
    }
}