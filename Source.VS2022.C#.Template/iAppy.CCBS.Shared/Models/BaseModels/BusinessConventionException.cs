using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [Serializable]
    public class BusinessConventionException : Exception
    {
        #region Private Fields

        private string id;

        #endregion Private Fields

        #region Public Constructors

        public BusinessConventionException()
        {
        }

        public BusinessConventionException(string message)
            : base(message)
        {
        }

        public BusinessConventionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public BusinessConventionException(string message, string id)
            : this(message, id, null)
        {
        }

        public BusinessConventionException(string message, string id, Exception innerException)
            : base(message, innerException)
        {
            this.id = id;
        }

        #endregion Public Constructors

        #region Protected Constructors

        protected BusinessConventionException(SerializationInfo info, StreamingContext context)
           : base(info, context)
        {
            id = info.GetString("id");
        }

        #endregion Protected Constructors

        #region Public Properties

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        #endregion Public Properties

        #region Public Methods

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (null == info)
                throw new ArgumentNullException("info");

            info.AddValue("id", id);

            base.GetObjectData(info, context);
        }

        #endregion Public Methods
    }
}