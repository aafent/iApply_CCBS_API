﻿using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class GetApplicationListResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public List<ApplicationData> Applications { get; set; } = new();

        #endregion Public Properties
    }
}