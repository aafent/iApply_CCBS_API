using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsDeleteAdressRequest
    {
        #region Public Properties

        /// <summary>
        /// Customer CBS Id (varchar (20))
        /// </summary>
        public string CustomerCBSId { get; set; }

        /// <summary>
        /// Customer Check Digit (integer)
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Address S/N (integer)
        /// </summary>
        public int AddressSerialNumber        { get; set; }

        #endregion Public Properties
    }
}
