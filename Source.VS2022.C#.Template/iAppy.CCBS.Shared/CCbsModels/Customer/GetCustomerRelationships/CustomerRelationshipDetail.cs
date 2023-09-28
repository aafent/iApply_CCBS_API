using iApplyShared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CustomerRelationshipDetail
    {
        public int Relationship { get; set; }
        public string Accounts { get; set; }
        public DateTime? RelationshipTmstamp { get; set; }
        public double RelPerc { get; set; }
        public List<CustomerRelationshipAccountDetail> Details { get; set; }
    }
}
