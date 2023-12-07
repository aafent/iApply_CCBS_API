using iApply.CCBS.Shared.CCbsModels;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsDeleteCollateralCbsRequest : MockupModel
    {
        #region Public Properties

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Collateral CBS Id
        /// Data Type: integer
        /// </summary>
        [Mockup(1)]
        public int CollateralCbsId { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Estimated Secured Value Amount
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollEstAmount { get; set; }

        /// <summary>
        /// Entity: v_CBS_Collateral
        /// Description: Central Bank Security Amount
        /// Data Type: decimal (15,2)
        /// </summary>
        public decimal CollSecAmount { get; set; }

        #endregion Public Properties
    }
}