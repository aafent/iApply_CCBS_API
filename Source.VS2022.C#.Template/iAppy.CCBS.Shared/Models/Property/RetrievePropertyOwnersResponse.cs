using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrievePropertyOwnersResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public bool HasMissingOwners { get; set; }

        [DataMember]
        public List<CbsPropertyPerson> MissingOwners { get; set; } = new();

        #endregion Public Properties
    }
}