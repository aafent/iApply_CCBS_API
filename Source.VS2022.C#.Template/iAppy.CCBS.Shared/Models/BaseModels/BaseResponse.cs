using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public abstract class BaseResponse
    {
        #region Public Constructors

        public BaseResponse()
        {
            Result = new OperationResult();
        }

        #endregion Public Constructors

        #region Public Properties

        [DataMember]
        public OperationResult Result { get; set; }

        #endregion Public Properties
    }
}