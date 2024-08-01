namespace CCBS.Models
{
    public class BaseCbsRequestModel : IMockupModel
    {
        #region Private Fields

        private object _mockupKey;

        #endregion Private Fields

        #region Public Properties

        public object MockupKey { get => _mockupKey ?? string.Empty; set => _mockupKey = value; }

        #endregion Public Properties
    }
}