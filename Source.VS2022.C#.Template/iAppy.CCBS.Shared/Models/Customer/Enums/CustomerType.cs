using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public enum CustomerType
    {
        [EnumMember(Value = "0")]
        IndividualCustomer = 0,

        [EnumMember(Value = "1")]
        CorporateCustomer = 1,

        [EnumMember(Value = "2")]
        Representative = 2,

        [EnumMember(Value = "3")]
        Group = 3,

        [EnumMember(Value = "4")]
        Joint = 4
    }
}