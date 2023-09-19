using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RequestCredentials
    {
        #region Public Properties

        [DataMember]
        public string ExternalUserId { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Username { get; set; }

        #endregion Public Properties
    }
}