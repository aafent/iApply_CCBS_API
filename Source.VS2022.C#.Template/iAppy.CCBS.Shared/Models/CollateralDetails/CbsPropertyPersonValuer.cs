using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CbsPropertyPersonValuer : CbsPropertyPerson
    {
        #region Public Properties

        [DataMember]
        public string Comment { get; set; }

        [DataMember]
        public string PropertyComments { get; set; }

        [DataMember]
        public decimal? PropertyValAmt1 { get; set; }

        [DataMember]
        public int? PropertyValAmt1Ccy { get; set; }

        [DataMember]
        public decimal? PropertyValAmt2 { get; set; }

        [DataMember]
        public int? PropertyValAmt2Ccy { get; set; }

        [DataMember]
        public DateTime PropertyValDate1 { get; set; }

        [DataMember]
        public int? ValuerId { get; set; }

        #endregion Public Properties
    }
}