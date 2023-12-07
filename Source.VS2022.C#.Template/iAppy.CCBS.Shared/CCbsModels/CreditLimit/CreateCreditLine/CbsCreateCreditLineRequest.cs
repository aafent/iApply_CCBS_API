using iApply.CCBS.Shared.CCbsModels;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsCreateCreditLineRequest : MockupModel
    {
        #region Public Properties

        public CbsRetrieveCreditLineResponse CbsRetrieveCreditLineResponseModel { get; set; }

        /// <summary>
        /// Gets or sets the Credit Limit Amount (decimal (15,2)).
        /// </summary>
        public decimal CrAmount { get; set; }

        /// <summary>
        /// Gets or sets the Credit Limit Currency (integer).
        /// </summary>
        public int CrCcy { get; set; }

        /// <summary>
        /// Gets or sets the Credit Limit Currency Description (varchar (20)).
        /// </summary>
        public string CrCcyDescr { get; set; }

        /// <summary>
        /// Gets or sets the Expiry Date (datetime).
        /// </summary>
        public DateTime CrExpDate { get; set; }

        /// <summary>
        /// Gets or sets the Next Review Date (datetime).
        /// </summary>
        public DateTime CrNextRevDate { get; set; }

        /// <summary>
        /// Gets or sets the Review Date (datetime).
        /// </summary>
        public DateTime CrRevDate { get; set; }

        /// <summary>
        /// Gets or sets the Credit Limit Type (varchar (15)).
        /// </summary>
        public string CrType { get; set; }

        /// <summary>
        /// Gets or sets the Customer Check Digit (integer).
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Gets or sets the Customer CBS Id (integer).
        /// </summary>
        [Mockup(1)]
        public int CustomerCBSId { get; set; }

        #endregion Public Properties
    }
}