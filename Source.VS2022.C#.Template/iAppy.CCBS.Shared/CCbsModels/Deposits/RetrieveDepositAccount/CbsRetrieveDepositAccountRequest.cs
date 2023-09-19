using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsRetrieveDepositAccountRequest
    {
        #region Public Properties

        /// <summary>
        /// Account Number (varchar (40))
        /// </summary>
        public string profitsAccountNumber { get; set; }

        /// <summary>
        /// Account Check digit (integer)
        /// </summary>
        public int profitsAccountCd { get; set; }

        /// <summary>
        /// Customer CBS Id (integer)
        /// </summary>
        public int InCustomerCustId { get; set; }

        #endregion Public Properties
    }
}
