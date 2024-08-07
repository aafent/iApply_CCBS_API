﻿namespace CCBS.Models
{
    public class CbsLetOfGuaBenefRequest : BaseCbsRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Beneficiary Category
        /// </summary>
        public string category { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Tax Id
        /// </summary>
        public string pin { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        public string surname { get; set; }

        #endregion Public Properties
    }
}