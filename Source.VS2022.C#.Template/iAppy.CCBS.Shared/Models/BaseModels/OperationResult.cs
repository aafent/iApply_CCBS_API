using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class OperationResult
    {
        #region Public Constructors

        public OperationResult()
        {
            Success = true;
        }

        public OperationResult(OperationError error)
        {
            Success = null == error;
            Error = error;
        }

        #endregion Public Constructors

        #region Public Properties

        [DataMember]
        public OperationError Error { get; set; }

        [DataMember]
        public bool Success { get; set; }

        #endregion Public Properties
    }
}