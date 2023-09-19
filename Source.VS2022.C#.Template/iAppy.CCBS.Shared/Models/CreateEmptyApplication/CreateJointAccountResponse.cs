using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    public class CreateJointAccountResponse : BaseResponse
    {
        [DataMember]
        public string ApplicationId { get; set; }
    }
}