﻿namespace CCBS.Models
{
    public class CbsUpdateCustomerRelationshipsResponse : CommonResponseModel
    {
        public List<CustomerRelationshipResponse> CustomerRelationships { get; set; } = new();

    }

    public class CustomerRelationshipResponse
    {
        #region Public Properties

        /// <summary>
        /// Customer Check Digit (integer)
        /// </summary>
        public int cu_checkdigit { get; set; }

        /// <summary>
        /// Customer CBS Id (varchar (20))
        /// </summary>
        public string cu_clnum { get; set; }

        /// <summary>
        /// Customer Id (varchar (15))
        /// </summary>
        public string cu_id { get; set; }

        /// <summary>
        /// Relationship (varchar (20))
        /// </summary>
        public string cu_reltype { get; set; }

        /// <summary>
        /// Relationship Master (varchar (20))
        /// </summary>
        public string cu_reltypem { get; set; }

        /// <summary>
        /// Account Number (varchar (40))
        /// </summary>
        public string currentaccount { get; set; }

        /// <summary>
        /// Source (varchar (20))
        /// 1
        /// </summary>
        public string source { get; set; }

        #endregion Public Properties
    }
}