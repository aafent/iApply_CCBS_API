using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsRetrieveDrawDownRequest : BaseCbsRequestModel
    {
        #region Public Properties

        public string AppUser { get; set; }

        /// <summary>
        /// Customer Check Digit (integer)
        /// </summary>
        public int CustomerCBSCD { get; set; }

        /// <summary>
        /// Customer CBS Id (integer)
        /// </summary>
        [Mockup(1)]
        public int CustomerCBSId { get; set; }

        /// <summary>
        /// Date From (datetime)
        /// </summary>
        public DateTime DateFrom { get; set; } =  DateTime.Parse("1800-01-01");

        /// <summary>
        /// Date To (datetime)
        /// </summary>
        public DateTime DateTo { get; set; } =  DateTime.Parse("1800-01-01");

        #endregion Public Properties
    }
}