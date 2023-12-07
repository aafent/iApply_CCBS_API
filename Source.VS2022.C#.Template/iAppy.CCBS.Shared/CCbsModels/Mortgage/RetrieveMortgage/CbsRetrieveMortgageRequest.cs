using iApply.CCBS.Shared.CCbsModels;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsRetrieveMortgageRequest : MockupModel
    {
        #region Public Properties

        /// <summary>
        /// Mortgage CBS Id
        /// Data Type: integer
        /// </summary>
        [Mockup(1)]
        public int MortgageCbsId { get; set; }

        #endregion Public Properties
    }
}