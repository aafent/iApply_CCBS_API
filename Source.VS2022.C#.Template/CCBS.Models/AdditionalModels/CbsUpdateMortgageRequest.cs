namespace CCBS.Models
{
    public class CbsUpdateMortgageReq : CbsBaseRequest
    {
        #region Public Properties

        public string ApplicationID { get; set; }

        public int MortgageCBSID { get; set; }

        public string MortgageID { get; set; }

        #endregion Public Properties
    }
}