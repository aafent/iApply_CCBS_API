using IApplyDataAccess.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsUpdateDepositAccountRequest
    {
        #region Public Properties

        public List<DepositAccountView> DepositAccountViews { get; set; }

        public CbsRetrieveDepositAccountResponse RetrieveDepositAccountModel { get; set; }

        public short? AccountCd { get; set; }

        public string AccountNumber { get; set; }

        #endregion Public Properties
    }
}
