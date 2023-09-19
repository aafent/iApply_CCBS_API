using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    public class UpdateMemberRegistrationRequest : BaseRequest
    {
        [DataMember]
        public int CustomerCBSId { get; set; }

        [DataMember]
        public int MemberId { get; set; }

        [DataMember]
        public string UpdateIndicator { get; set; }

        [DataMember]
        public string ApplicationId { get; set; }

    }
}
