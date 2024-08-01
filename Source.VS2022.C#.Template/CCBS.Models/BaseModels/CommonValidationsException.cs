namespace CCBS.Models
{
    public class CommonValidationsException : CommonException
    {
        #region Public Constructors

        public CommonValidationsException()
        {
        }

        public CommonValidationsException(string message)
            : base(message)
        {
        }

        public CommonValidationsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public CommonValidationsException(string message, string id, string referenceKey)
            : base(message, id, referenceKey)
        {
        }

        public CommonValidationsException(string message, string id, string referenceKey, Exception innerException)
            : base(message, id, referenceKey, innerException)
        {
        }

        #endregion Public Constructors
    }
}