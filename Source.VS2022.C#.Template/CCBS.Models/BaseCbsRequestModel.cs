namespace CCBS.Models
{
    /// <summary>
    /// Base CBS Request Model
    /// </summary>
    public class BaseCbsRequestModel : IMockupModel, IrequestAdditionals
    {
        #region Private Fields

        private object _mockupKey;
        private object _additionals;

        #endregion Private Fields

        #region Public Properties

        /// <summary>
        /// Not applicable, used internally by the mock-up mechanism. 
        /// </summary>
        public object MockupKey { get => _mockupKey ?? string.Empty; set => _mockupKey = value; }

        /// <summary>
        /// Implementation of the Additionals concept
        /// </summary>
        //public object additionals { get; set; }
        public object additionals { get => _additionals ?? string.Empty; set => _additionals = value; }

        #endregion Public Properties
    }
}