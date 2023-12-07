using iApply.CCBS.Shared.CCbsModels;
using IApplyDataAccess.DataModel;
using iApplyShared.Attributes;

namespace iApplyShared.CbsModels
{
    public class CbsDeleteAdressRequest : MockupModel
    {
        #region Public Properties

        /// <summary>
        /// Address S/N (integer)
        /// </summary>
        public int AddressSerialNumber { get; set; }

        public AddressView AddressView { get; set; }

        /// <summary>
        /// Customer Check Digit (integer)
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Customer CBS Id (varchar (20))
        /// </summary>
        [Mockup(1)]
        public string CustomerCBSId { get; set; }

        #endregion Public Properties
    }
}