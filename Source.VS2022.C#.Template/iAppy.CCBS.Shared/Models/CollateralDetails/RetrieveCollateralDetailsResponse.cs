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
        public CbsPropertyPersonOwner[] MissingOwners { get; set; }

        [DataMember]
        public CbsPropertyPersonValuer[] MissingValuers { get; set; }

        #endregion Public Properties
    }
}