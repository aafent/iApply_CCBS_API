using CCBS.Attributes;

namespace CCBS.Models
{
    public interface IMockupModel
    {
        #region Public Properties

        [Mockup(0)]
        public object MockupKey { get; set; }

        #endregion Public Properties
    }
}