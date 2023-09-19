using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models

{
    public class RetrieveMembersRequest : BaseRequest
    {
        [DataMember]
        public string CustomerCBSId { get; set; }

        [DataMember]
        public string MemberId { get; set; }
    }
}
