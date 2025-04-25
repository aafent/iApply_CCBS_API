namespace CCBS.Models
{
    public class ErrorDump
    {
        #region Public Properties

        public string ActionName { get; set; } = "Error";

        public CapturedModelInfo CcbsRequest { get; set; } = new();

        public CapturedModelInfo CcbsResponse { get; set; } = new();

        public CapturedModelInfo IaRequest { get; set; } = new();

        public CapturedModelInfo IaResponse { get; set; } = new();

        public string UniqueIdentifier { get; set; } = string.Empty;

        #endregion Public Properties
    }
}