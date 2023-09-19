using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class OperationError
    {
        #region Public Constructors

        public OperationError()
        {
        }

        public OperationError(string code, string category, string message)
        {
            Code = code;
            Category = category;
            Message = message;
        }

        #endregion Public Constructors

        #region Public Properties

        [DataMember]
        public string Category { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Message { get; set; }

        #endregion Public Properties
    }
}