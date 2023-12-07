using System.Text.Json.Serialization;

namespace iApplyShared.CbsModels
{
    public class CbsCustomerInfo
    {
        #region Public Properties

        /// <summary>
        /// Customer Address 1 (varchar (15))
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Customer Address 2 (varchar (15))
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Member Business Registry (varchar (1))
        /// Y or N
        /// </summary>
        public string Businessregistry { get; set; }

        /// <summary>
        /// Customer Id Number (varchar (30))
        /// </summary>
        public string CertificationId { get; set; }

        /// <summary>
        /// Customer Id Type Description (varchar (30))
        /// </summary>
        public string CertificationTypeDescription { get; set; }

        /// <summary>
        /// Customer Id Type (certification_type)
        /// </summary>
        public string CertificationTypeId { get; set; }

        /// <summary>
        /// Customer Country (varchar (30))
        /// Not Used
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Customer City (varchar (30))
        /// </summary>
        public string CustomerCity { get; set; }

        /// <summary>
        /// Status (varchar (20))
        /// </summary>
        public string CustomerStatus { get; set; }

        /// <summary>
        /// Customer Full Name (varchar (250))
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Member Id (varchar (30))
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// Member Status (varchar (20))
        /// </summary>
        public string MemberStatus { get; set; }

        /// <summary>
        /// Member Subflag (varchar (20))
        /// </summary>
        public string MemberSubflag { get; set; }

        /// <summary>
        /// Customer Phone Number (varchar (30))
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Customer PIN (varchar (30))
        /// Not Used
        /// </summary>
        public string PIN { get; set; }

        /// <summary>
        /// Customer Check Digit (varchar (10))
        /// </summary>
        public string ProfitsCD { get; set; }

        /// <summary>
        /// Customer CBS Id (varchar (30))
        /// </summary>
        public string ProfitsID { get; set; }

        /// <summary>
        /// Customer Zip Code (varchar (20))
        /// </summary>
        public string ZipCode { get; set; }

        #endregion Public Properties
    }

    public class CbsSearchCustomerResponse : CommonResponseModel
    {
        #region Public Properties

        [JsonPropertyName("cbsCustomerInfos")]
        public List<CbsCustomerInfo> CbsCustomerInfos { get; set; } = new();

        #endregion Public Properties
    }
}