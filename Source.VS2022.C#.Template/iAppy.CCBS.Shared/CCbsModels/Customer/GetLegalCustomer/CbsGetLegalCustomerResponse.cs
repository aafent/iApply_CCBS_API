namespace iApplyShared.CbsModels
{
    public class CbsGetLegalCustomerResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Accommodation Date
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public DateTime accdate { get; set; }

        /// <summary>
        /// Street Name, Address Line 1
        /// </summary>
        public string addres1 { get; set; }

        /// <summary>
        /// Plot/Street No, Address Line 2
        /// </summary>
        public string addres2 { get; set; }

        /// <summary>
        /// Address S/N
        /// </summary>
        /// <remarks>
        /// This was changed from sn_cbs in order to avoid the same name with CBS SN
        /// </remarks>

        public string address_no { get; set; }

        /// <summary>
        /// Address Status
        /// </summary>
        public int addstatus { get; set; }

        /// <summary>
        /// Address Type
        /// </summary>
        public string addtype { get; set; }

        /// <summary>
        /// Apartment
        /// </summary>
        public string apart { get; set; }

        /// <summary>
        /// Building Name
        /// </summary>
        public string build { get; set; }

        /// <summary>
        /// Building
        /// </summary>
        public string buildno { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <remarks>
        /// Select cod cr_comast where grp='G75' and Upper(des)=Upper(OutListGrpOutGrmCustAddressCity)
        /// If result is not null then cities = result
        /// else
        /// Select TOP 1 cod From cr_comast where grp='G75' AND tag ='O'
        /// cities = result
        /// city = OutListGrpOutGrmCustAddressCity
        /// </remarks>
        public string City { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        /// <remarks>
        /// For Centenary only
        /// Select isnull(cps,'') From cr_comast Where grp = 'G83' and cod = OutListGrpOutGrmCountryGenericDetailDescription
        /// If result is not null then
        /// tele1_ac = result
        /// tele2_ac = result
        /// tele3_ac = result
        /// </remarks>
        public string cntry { get; set; }

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

        /// <summary>
        /// Address Details SN
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public int cuadd_sn { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public string email { get; set; }

        /// <summary>
        /// Fax
        /// </summary>
        public string fax1 { get; set; }

        /// <summary>
        /// Floor
        /// </summary>
        public string floor { get; set; }

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
        /// Issue Country
        /// </summary>
        /// <remarks>Identity: cr_cuident</remarks>
        public int idcountry { get; set; }

        /// <summary>
        /// Communication Address
        /// </summary>
        /// <remarks>
        /// If OutListGrpOutGrmCustAddressCommunicationAddress = '*' then mainadd = '1' else '0'
        /// </remarks>
        public string mainadd { get; set; }

        /// <summary>
        /// Authority
        /// </summary>
        /// <remarks>Identity: cr_cuident</remarks>
        public string pe_authority { get; set; }

        /// <summary>
        /// Document No
        /// </summary>
        /// <remarks>Identity: cr_cuident</remarks>
        public string pe_document { get; set; }

        /// <summary>
        /// Expiry Date
        /// </summary>
        /// <remarks>Identity: cr_cuident</remarks>
        public DateTime pe_exp_date { get; set; }

        /// <summary>
        /// Trade Name
        /// </summary>
        /// <remarks>
        /// Notes: -
        /// </remarks>
        public string pe_finam { get; set; }

        /// <summary>
        /// Identification Number
        /// </summary>
        /// <remarks>Identity: cr_cuident</remarks>
        public string pe_idnbr { get; set; }

        /// <summary>
        /// Identification Type
        /// </summary>
        /// <remarks>Identity: cr_cuident</remarks>
        public string pe_idtyp { get; set; }

        /// <summary>
        /// Issue Date
        /// </summary>
        /// <remarks>Identity: cr_cuident</remarks>
        public DateTime pe_issuon { get; set; }

        /// <summary>
        /// Main Id
        /// </summary>
        /// <remarks>Identity: cr_cuident</remarks>
        public string pe_main { get; set; }

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

        /// <summary>
        /// P.O. Box
        /// </summary>
        public string pobox { get; set; }

        /// <summary>
        /// Postal Code
        /// </summary>
        public string postal { get; set; }

        /// <summary>
        /// Province/ Post Office
        /// </summary>
        public int postoffice { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        public string region { get; set; }

        /// <summary>
        /// CBS SN
        /// </summary>
        /// <remarks>Identity: cr_cuident</remarks>
        public int sn_cbs { get; set; }

        /// <summary>
        /// Telephone 1
        /// </summary>
        public string tele1 { get; set; }

        /// <summary>
        /// Telephone 2
        /// </summary>
        public string tele2 { get; set; }

        /// <summary>
        /// Telephone 3
        /// </summary>
        public string tele3 { get; set; }

        /// <summary>
        /// Web Site
        /// </summary>
        public string website { get; set; }

        #endregion Public Properties
    }
}