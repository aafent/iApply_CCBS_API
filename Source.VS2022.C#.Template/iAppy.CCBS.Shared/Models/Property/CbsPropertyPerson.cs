using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CbsPropertyPerson
    {
        #region Public Properties

        [DataMember]
        public short? CustomerCbsCd { get; set; }

        [DataMember]
        public int CustomerCbsId { get; set; }

        [DataMember]
        public string CustomerType { get; set; }

        [DataMember]
        public decimal? OwnerOwnership { get; set; }

        [DataMember]
        public int? PropertyCBSId { get; set; }

        [DataMember]
        public string PropertyId { get; set; }

        [DataMember]
        public int? PropertyTransCBSId { get; set; }

        [DataMember]
        public string RegistProprietor { get; set; }

        [DataMember]
        public string TransactionId { get; set; }

        #endregion Public Properties
    }
}