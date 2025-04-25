namespace CCBS.Models
{
    public class CbsCollateralCbsDetailItem
    {
        #region Public Properties

        public string CollAccount { get; set; }

        public string CollAccountCd { get; set; }

        public int? CollAccountType { get; set; }

        public string CollateralStatus { get; set; }

        public int? CollateralTrCbsId { get; set; }

        public string CollClass { get; set; }

        public decimal? CollCovAmount { get; set; }

        public decimal? CollEstAmount { get; set; }

        public DateTime? CollExpDate { get; set; } =  DateTime.Parse("1800-01-01");

        public decimal? CollLimit { get; set; }

        public int? CollNoItems { get; set; }

        public decimal? CollPerc { get; set; }

        public decimal? CollReAmount { get; set; }

        public string CollReCcy { get; set; }

        public decimal? CollReCur { get; set; }

        public DateTime? CollReDate { get; set; } =  DateTime.Parse("1800-01-01");

        public string CollRefNum { get; set; }

        public decimal? CollReOrig { get; set; }

        public decimal? CollRevValue { get; set; }

        public decimal? CollSecAmount { get; set; }

        #endregion Public Properties
    }
}