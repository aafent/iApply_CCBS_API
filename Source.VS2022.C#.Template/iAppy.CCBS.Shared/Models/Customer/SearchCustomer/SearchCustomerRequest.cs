using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class SearchCustomerRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string AccountNumber { get; set; }

        [DataMember]
        public short? CustomerCBSCd { get; set; }

        [DataMember]
        public int? CustomerCBSId { get; set; }

        [DataMember]
        public CustomerType CustomerType { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public string EmployeeNumber { get; set; }

        [DataMember]
        public string EmployerNumber { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string IdNumber { get; set; }

        [DataMember]
        public int IdType { get; set; }

        [DataMember]
        public string MobileNumber { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public string PIN { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public string Email { get; set; }
        #endregion Public Properties
    }
}