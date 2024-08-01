namespace CCBS.Models
{
    public class CbsGetLegalCustomerResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Address S/N
        /// <example>19 Green Street, New City</example>
        /// </summary>
        /// <remarks>
        /// This was changed from sn_cbs in order to avoid the same name with CBS SN
        /// </remarks>

        public string address_no { get; set; }

        public List<CbsCustomerAddress> Addresses { get; set; } = new();

        /// <summary>
        /// CRM Id
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public string crm_id { get; set; }

        /// <summary>
        /// Branch
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public int cu_branch { get; set; }

        /// <summary>
        /// Business Nature
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public int cu_bus_nature { get; set; }

        /// <summary>
        /// Communication Language
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public string cu_comlang { get; set; }

        /// <summary>
        /// Client Consent
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public string cu_cons { get; set; }

        /// <summary>
        /// Country of Incorporation
        /// </summary>
        /// <remarks>
        /// Notes:
        /// Select cod Into :ls_Cod From cr_comast where grp='G83' and cps1 = OutRegistryCountryGenericDetailShortDescription
        /// cu_incorp_cntry = result
        /// </remarks>
        public string cu_incorp_cntry { get; set; }

        /// <summary>
        /// Legal Form
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public int cu_legalform { get; set; }

        /// <summary>
        /// Missing PIN
        /// </summary>
        /// <remarks>
        /// Notes:
        /// 1 = Yes
        /// 0 = No
        /// </remarks>
        public string cu_noafm { get; set; }

        /// <summary>
        /// No of Business
        /// </summary>
        /// <remarks>cu_nobus.</remarks>
        public int cu_nobus { get; set; }

        /// <summary>
        /// Communication Method
        /// </summary>
        /// <remarks>
        /// Notes:
        /// Select cod From cr_comast where grp='G28' and tag = OutCustomerCommunMethod
        /// cu_nofication = result
        /// </remarks>
        public string cu_nofication { get; set; }

        /// <summary>
        /// PIN
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public string cu_pin { get; set; }

        /// <summary>
        /// Financial Sector
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public int cu_sector { get; set; }

        /// <summary>
        /// Number of Employees
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public int cu_totnumemp { get; set; }

        /// <summary>
        /// Number of Permanent Employees
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public int cu_totperemp { get; set; }

        /// <summary>
        /// Customer Type
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public int cu_type { get; set; }

        public List<CbsCustomerCategory> CustomerCategories { get; set; } = new();

        public List<CbsCustomerIdentification> CustomerIdentifications { get; set; } = new();

        /// <summary>
        /// Email 1
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public string hc_email { get; set; }

        /// <summary>
        /// Email 2
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public string hc_email2 { get; set; }

        /// <summary>
        /// Mobile 1
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public string hc_mobile1 { get; set; }

        /// <summary>
        /// Mobile 2
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public string hc_mobile2 { get; set; }

        /// <summary>
        /// Trade Name
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public string pe_finam { get; set; }

        /// <summary>
        /// Non Resident
        /// </summary>
        /// <remarks>
        /// Notes:
        /// 1 = Yes
        /// 0 = No
        /// </remarks>
        public string pe_res { get; set; }

        /// <summary>
        /// Company Name
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public string pe_sunam { get; set; }

        /// <summary>
        /// PIN Country
        /// </summary>
        /// <remarks>pincountry = result</remarks>
        public string pincountry { get; set; }

        #endregion Public Properties
    }
}