using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public abstract class BaseRequest
    {
        #region Public Properties

        [DataMember]
        public RequestCredentials Credentials { get; set; }

        #endregion Public Properties
    }
}