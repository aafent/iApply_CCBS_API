﻿using iApplyShared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsLetOfGuaBenefResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Beneficiary CBS Id (varchar (20))
        /// </summary>
        public string clnum { get; set; }

        /// <summary>
        /// First Name (varchar (20))
        /// </summary>
        public string co_finam { get; set; }

        /// <summary>
        /// Last Name (varchar (100))
        /// </summary>
        public string co_sunam { get; set; }

        /// <summary>
        /// Address Line 1 (varchar (255))
        /// </summary>
        public string co_address1 { get; set; }

        /// <summary>
        /// Id Type (varchar (100))
        /// </summary>
        public string co_idtype { get; set; }

        /// <summary>
        /// Tax Id (varchar (20))
        /// </summary>
        public string co_pin { get; set; }

        /// <summary>
        /// Address Line 2 (varchar (255)
        /// </summary>
        public string co_address2 { get; set; }

        /// <summary>
        /// Region (varchar (100)
        /// </summary>
        public string co_region { get; set; }

        /// <summary>
        /// Postal Code (varchar (20)
        /// </summary>
        public string co_postal { get; set; }

        /// <summary>
        /// City (varchar (10))
        /// </summary>
        public string co_city { get; set; }

        /// <summary>
        /// Telephone Numbetr (varchar (10))
        /// 2
        /// </summary>
        public string co_tele { get; set; }

        /// <summary>
        /// Profession (varchar (100))
        /// </summary>
        public string co_profes { get; set; }

        /// <summary>
        /// Comments (varchar (255))
        /// 2
        /// </summary>
        public string co_comments { get; set; }

        public List<LetOfGuaBenefResult> OutListGrp { get; set; }
        #endregion Public Properties
    }
}
