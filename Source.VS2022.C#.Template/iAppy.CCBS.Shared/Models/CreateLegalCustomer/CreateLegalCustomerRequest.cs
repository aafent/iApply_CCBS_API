using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    public class CreateLegalCustomerRequest : BaseRequest
    {
        [DataMember]
        public string CustomerId { get; set; }
    }
}
