using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class SaveRepScenarioRequest : BaseRequest
    {
        #region Public Properties

        [DataMember(IsRequired = true)]
        public string ApplicationId { get; set; }

        [DataMember(IsRequired = true)]
        public int SerialNumber { get; set; }

        #endregion Public Properties
    }
}