
namespace iApplyShared.CbsModels
{
    public class CbsAboutResponse : CommonResponseModel
    {
        /// <summary>
        /// The title of the CBS Software Platform
        /// </summary>
        /// <remarks></remarks>
        public string title { get; set; }

        /// <summary>
        /// The version of the API Implementation
        /// </summary>
        /// <remarks></remarks>
        public string apiVersion { get; set; }

        /// <summary>
        /// iApply installation code
        /// The code is provided by the Relational
        /// </summary>
        /// <remarks></remarks>
        public string code { get; set; }
    }
}
