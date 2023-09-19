using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DynamicFields
    {

        [DataMember]
        virtual public string DynamicCode { get; set; }

        [DataMember]
        virtual public double? CollateralInternalSn { get; set; }

        [DataMember]
        virtual public string CollateralRecordType { get; set; }

        [DataMember]
        virtual public string FieldLabel { get; set; }

        [DataMember]
        virtual public string FieldValue { get; set; }

        [DataMember]
        virtual public string PfgSetCategory { get; set; }

        [DataMember]
        virtual public int? PfgSetSn { get; set; }

        [DataMember]
        virtual public string PfgTag { get; set; }

        [DataMember]
        virtual public string TagSetCode { get; set; }

        [DataMember]
        virtual public int? ShowOrder { get; set; }

        [DataMember]
        virtual public string CheckEditProfile { get; set; }

        [DataMember]
        virtual public string NeedMandatory { get; set; }

        [DataMember]
        virtual public int? FieldsShowOrder { get; set; }

        [DataMember]
        virtual public string ShowToUser { get; set; }

        [DataMember]
        virtual public string SelectChar { get; set; }
    }

}