using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class LetOfGuaBenefRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public int Category { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Pin { get; set; }

        [DataMember]
        public string Surname { get; set; }

        #endregion Public Properties
    }
}