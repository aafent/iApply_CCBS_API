using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrieveCollateralDetailsResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public bool HasMissingOwners { get; set; }

        [DataMember]
        public bool HasMissingValuers { get; set; }

        [DataMember]
        public List<CbsPropertyPersonOwner> MissingOwners { get; set; } = new();

        [DataMember]
        public List<CbsPropertyPersonValuer> MissingValuers { get; set; } = new();

        #endregion Public Properties
    }
}