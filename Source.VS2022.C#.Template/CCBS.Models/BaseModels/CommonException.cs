using System.Runtime.Serialization;

namespace CCBS.Models
{
    public class CommonException : Exception
    {
        #region Protected Fields

        protected string _ProfitsInnerRequest;

        protected string _ProfitsInnerResponse;

        #endregion Protected Fields

        #region Private Fields

        private string id;

        private string referenceKey;

        #endregion Private Fields

        #region Public Constructors

        public CommonException()
        {
        }

        public CommonException(string message)
            : base(message)
        {
        }

        public CommonException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public CommonException(string message, string id, string referenceKey)
            : this(message, id, referenceKey, null)
        {
            //this._ProfitsInnerRequest = ProfitsInnerCallsManager.RequestData;
            //this._ProfitsInnerResponse = ProfitsInnerCallsManager.ResponseData;
            //ProfitsInnerCallsManager.ClearData();
        }

        public CommonException(string message, string id, string referenceKey, Exception innerException)
            : base(message, innerException)
        {
            this.id = id;
            this.referenceKey = referenceKey;
        }

        #endregion Public Constructors

        #region Protected Constructors

        protected CommonException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            id = info.GetString("id");
            referenceKey = info.GetString("referenceKey");
        }

        #endregion Protected Constructors

        #region Public Properties

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string ProfitsInnerRequest
        {
            get { return _ProfitsInnerRequest; }
        }

        public string ProfitsInnerResponse
        {
            get { return _ProfitsInnerResponse; }
        }

        public string ReferenceKey
        {
            get { return referenceKey; }
            set { referenceKey = value; }
        }

        #endregion Public Properties

        #region Public Methods

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (null == info)
                throw new ArgumentNullException("info");

            info.AddValue("id", id);
            info.AddValue("referenceKey", referenceKey);

            base.GetObjectData(info, context);
        }

        #endregion Public Methods
    }
}