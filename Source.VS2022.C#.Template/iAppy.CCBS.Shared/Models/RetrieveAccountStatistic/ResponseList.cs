using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class ResponseList
    {
        #region Public Properties

        [DataMember]
        public int AccountCd { get; set; }

        [DataMember]
        public string AccountNo { get; set; }

        [DataMember]
        public decimal AverageBalance { get; set; }

        [DataMember]
        public string AverageBalanceCcy { get; set; }

        [DataMember]
        public decimal Count { get; set; }

        [DataMember]
        public decimal CreditTurnover { get; set; }

        [DataMember]
        public string CreditTurnoverCcy { get; set; }

        [DataMember]
        public string CurrencyCode { get; set; }

        [DataMember]
        public string CurrencyCode2 { get; set; }

        [DataMember]
        public string CurrencyCode3 { get; set; }

        [DataMember]
        public string CurrencyDesc { get; set; }

        [DataMember]
        public string CurrencyDesc2 { get; set; }

        [DataMember]
        public string CurrencyDesc3 { get; set; }

        [DataMember]
        public decimal DebitTurnover { get; set; }

        [DataMember]
        public string DebitTurnoverCcy { get; set; }

        [DataMember]
        public string DomCurrencyCode1 { get; set; }

        [DataMember]
        public string DomCurrencyCode2 { get; set; }

        [DataMember]
        public string DomCurrencyCode3 { get; set; }

        [DataMember]
        public decimal MaxPayableAmt { get; set; }

        [DataMember]
        public decimal MaxSupPayableAmt { get; set; }

        [DataMember]
        public decimal MinPayableAmt { get; set; }

        [DataMember]
        public decimal MinSupPayableAmt { get; set; }

        [DataMember]
        public string Month { get; set; }

        [DataMember]
        public string MoveCurrency { get; set; }

        [DataMember]
        public decimal PayableAmt { get; set; }

        [DataMember]
        public decimal SupPayableAmt { get; set; }

        #endregion Public Properties
    }
}