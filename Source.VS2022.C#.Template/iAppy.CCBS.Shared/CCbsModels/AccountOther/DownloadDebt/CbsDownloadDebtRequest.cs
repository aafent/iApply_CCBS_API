using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsDownloadDebtRequest
    {
        /// <summary>
        /// Entity: Customer CBS Id
        /// Description: Customer CBS Id
        /// Data Type: varchar (20)
        /// Notes: argument from client
        /// </summary>
        public string CustomerCBSId { get; set; }

        /// <summary>
        /// Entity: Account Number
        /// Description: Account Number
        /// Data Type: varchar (40)
        /// Notes: argument from client
        /// </summary>
        public string AccountNumber { get; set; }
    }
}
