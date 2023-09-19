using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DeleteCustIdentifRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public short CustomerCBSCd { get; set; }

        [DataMember]
        public int CustomerCBSId { get; set; }

        [DataMember]
        public string IdentificationNumber { get; set; }

        [DataMember]
        public int IdentificationType { get; set; }

        #endregion Public Properties
    }
}