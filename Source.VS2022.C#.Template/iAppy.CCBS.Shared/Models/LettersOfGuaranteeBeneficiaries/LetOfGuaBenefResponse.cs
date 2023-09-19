using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class LetOfGuaBenefResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public LetOfGuaBenefResult[] Results { get; set; }

        #endregion Public Properties
    }
}