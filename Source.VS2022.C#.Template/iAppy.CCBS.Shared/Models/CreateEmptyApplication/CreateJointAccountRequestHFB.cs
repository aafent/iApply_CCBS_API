using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CreateJointAccountRequestHFB : BaseRequest
    {
        [DataMember(IsRequired = true)]
        public string BranchCode { get; set; }

        [DataMember(IsRequired = true)]
        public string CRM_UserName { get; set; }

        [DataMember(IsRequired = true)]
        public List<ParticipantHFB> Participants { get; set; } = new();

        [DataMember(IsRequired = true)]
        public string ApplicationType { get; set; }

        [DataMember(IsRequired = true)]
        public string ProductCategory { get; set; }

        [DataMember(IsRequired = true)]
        public DateTime ApplicationDate { get; set; }

        [DataMember]
        public string CrmLeadId { get; set; }

    }
}