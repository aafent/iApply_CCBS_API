using iApplyShared.Attributes;
using System.ComponentModel.DataAnnotations;

namespace iApplyShared.CbsModels
{
    public class CbsSearchCustomerRequest
    {
        #region Public Properties

        /// <summary>
        /// Customer Account Number (varchar)
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Customer Check Digit (integer)
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Customer CBS Id (varchar)
        /// </summary>
        public string CustomerCBSId { get; set; }

        /// <summary>
        /// Customer Type
        /// </summary>
        public string CustomerType { get; set; }

        /// <summary>
        /// Customer Birth Date (datetime)
        /// If the CustomerCBSId is not 0 (empty), then we don’t pass anything to this property.
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Customer Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Customer PF Number (varchar)
        /// </summary>
        public string EmployeeNumber { get; set; }

        /// <summary>
        /// Customer Employer Number (varchar)
        /// </summary>
        public string EmployerNumber { get; set; }

        /// <summary>
        /// Customer First Name (varchar)
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Customer Id Number (varchar)
        /// </summary>
        public string IdNumber { get; set; }

        /// <summary>
        /// Customer Id Type (varchar from LOV)
        /// </summary>
        public string IdType { get; set; }

        /// <summary>
        /// Customer Mobile Number
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// Customer Phone Number (varchar)
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Customer PIN (varchar)
        /// Bulgaria: EGN or BULSTAT
        /// </summary>
        [Mockup(1)]
        public string PIN { get; set; }

        /// <summary>
        /// Customer Surname (varchar)
        /// </summary>
        [Mockup(2)]
        public string Surname { get; set; }

        #endregion Public Properties
    }
}