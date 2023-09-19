using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsRetrieveDrawDownResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Application Id (varchar (15))
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Drawdown Number (varchar (20))
        /// </summary>
        public string profitid_draw { get; set; }

        /// <summary>
        /// Drawdown Status (varchar (2))
        /// </summary>
        public string profitstatus_draw { get; set; }

        /// <summary>
        /// Disbursment Branch (varchar (10))
        /// </summary>
        public string la_offco { get; set; }

        /// <summary>
        /// Currency (varchar (10))
        /// </summary>
        public string la_ccy { get; set; }

        /// <summary>
        /// Loan Account Number (varchar (20))
        /// </summary>
        public string loanaccount { get; set; }

        /// <summary>
        /// Loan Account Check Digit (integer)
        /// </summary>
        public int profitsaccountcd { get; set; }

        /// <summary>
        /// drawDownDate (datetime)
        /// </summary>
        public DateTime drawDownDate { get; set; }

        /// <summary>
        /// Disbursment Amount (decimal (19,3))
        /// </summary>
        public decimal amount { get; set; }

        #endregion Public Properties
    }
}
