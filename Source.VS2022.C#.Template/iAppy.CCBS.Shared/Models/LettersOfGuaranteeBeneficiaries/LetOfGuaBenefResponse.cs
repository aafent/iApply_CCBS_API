using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class LetOfGuaBenefResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public List<LetOfGuaBenefResult> Results { get; set; } = new();

        #endregion Public Properties
    }
}