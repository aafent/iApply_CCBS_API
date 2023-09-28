using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsUpdateDepositStatusRequest
    {
        #region Public Properties

        public short? AccountCd { get; set; }

        public string AccountNumber { get; set; }

        public string Status { get; set; }

        #endregion
    }
}
