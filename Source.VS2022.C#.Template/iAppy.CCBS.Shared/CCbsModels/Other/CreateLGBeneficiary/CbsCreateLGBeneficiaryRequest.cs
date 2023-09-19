using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsCreateLGBeneficiaryRequest
    {
        #region Public Properties

        /// <summary>
        /// Category (integer)
        /// </summary>
        public int Category { get; set; }

        /// <summary>
        /// Address Line 1 (varchar (255))
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Address Line 2 (varchar (255))
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Tax Id (varchar (40))
        /// </summary>
        public string TaxId { get; set; }

        /// <summary>
        /// Id Type (varchar (100))
        /// </summary>
        public string IdType { get; set; }

        /// <summary>
        /// Name (varchar (20))
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Profession (varchar (100))
        /// </summary>
        public string Profession { get; set; }

        /// <summary>
        /// Region (varchar (100))
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Full Name (varchar (100))
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Phone Number (varchar (20))
        /// </summary>
        public string Tele { get; set; }

        /// <summary>
        /// Postal Code (varchar (20))
        /// </summary>
        public string Postal { get; set; }

        /// <summary>
        /// Comments (varchar (255))
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// City (varchar (40))
        /// </summary>
        public string City { get; set; }

        #endregion Public Properties
    }
}
