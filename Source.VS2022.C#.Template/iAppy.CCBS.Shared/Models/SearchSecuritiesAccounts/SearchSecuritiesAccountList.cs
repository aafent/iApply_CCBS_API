using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class SearchSecuritiesAccountListItem
    {
        #region Public Properties

        [DataMember]
        public decimal? BondDenomination { get; set; }

        [DataMember]
        public decimal? BondInitDistrVal { get; set; }

        [DataMember]
        public int CurrencyId { get; set; }

        [DataMember]
        public int CustomerCbsIs { get; set; }

        [DataMember]
        public short CustomerCDigit { get; set; }

        [DataMember]
        public DateTime? DisEndDate { get; set; }

        [DataMember]
        public string DisposalFlg { get; set; }

        [DataMember]
        public DateTime? DisStartDate { get; set; }

        [DataMember]
        public string DurationUnit { get; set; }

        [DataMember]
        public short DurationVal { get; set; }

        [DataMember]
        public DateTime? EndOfOrdersTime { get; set; }

        [DataMember]
        public string EntryStatus { get; set; }

        [DataMember]
        public DateTime? FmtEnd { get; set; }

        [DataMember]
        public DateTime? FmtStart { get; set; }

        [DataMember]
        public string IssuerDescr { get; set; }

        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public decimal? Quantity { get; set; }

        [DataMember]
        public string RegisterFlag { get; set; }

        [DataMember]
        public string SecurityCode { get; set; }

        [DataMember]
        public string SecurityDesc { get; set; }

        [DataMember]
        public string SecurityISIN { get; set; }

        #endregion Public Properties
    }
}