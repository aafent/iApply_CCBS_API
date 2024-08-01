using CCBS.Attributes;

namespace CCBS.Models
{
    public class CbsCreateDrawDownRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Disbursment Branch (integer)
        /// </summary>
        public int BranchId { get; set; }

        /// <summary>
        /// comments (varchar)
        /// </summary>
        public string comments { get; set; }

        /// <summary>
        /// Currency (integer)
        /// </summary>
        public int Currency { get; set; }

        /// <summary>
        /// Customer Check Digit (integer)
        /// </summary>
        public int CustomerCBSCD { get; set; }

        /// <summary>
        /// Customer CBS Id (integer)
        /// </summary>
        [Mockup(1)]
        public int CustomerCBSId { get; set; }

        public CbsDrawDownRequestView DrawDownRequestView { get; set; }

        /// <summary>
        /// Loan Account Check Difgit (integer)
        /// </summary>
        public int LoanAccountCD { get; set; }

        /// <summary>
        /// Loan Account Number (varchar (30))
        /// </summary>
        public string LoanAccountNo { get; set; }

        /// <summary>
        /// Payee Account (varchar (40))
        /// </summary>
        public string PayeeAccount { get; set; }

        /// <summary>
        /// Payee Amount (decimal (15,2))
        /// </summary>
        public decimal PayeeAmount { get; set; }

        /// <summary>
        /// Payee Bank (integer)
        /// </summary>
        public int PayeeBank { get; set; }

        /// <summary>
        /// Payee Bank Branch (varchar (15))
        /// </summary>
        public string PayeeBankBranch { get; set; }

        /// <summary>
        /// Payee Bank Branch Description (varchar (40))
        /// </summary>
        public string PayeeBankBranchDes { get; set; }

        /// <summary>
        /// Payee Bank Description (varchar (40))
        /// </summary>
        public string PayeeBankDes { get; set; }

        /// <summary>
        /// PayeeComment (varchar (180))
        /// </summary>
        public string PayeeComment { get; set; }

        /// <summary>
        /// Payee Name (varchar (80))
        /// </summary>
        public string PayeeName { get; set; }

        public List<CbsPayeesView> PayeesView { get; set; }

        public string Request { get; set; }

        /// <summary>
        /// Disbursment Amount (decimal (15,2))
        /// </summary>
        public decimal RequestedAmount { get; set; }

        #endregion Public Properties
    }
}