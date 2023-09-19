namespace iApplyShared.CbsModels
{
    public class CbsGetIndividualCustomerResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Accommodation Date
        /// </summary>
        public DateTime accdate { get; set; }

        /// <summary>
        /// Street Name, Address Line 1
        /// </summary>
        /// <remarks></remarks>
        public string addres1 { get; set; }

        /// <summary>
        /// Plot/Street No, Address Line 2
        /// </summary>
        /// <remarks></remarks>
        public string addres2 { get; set; }

        /// <summary>
        /// Address S/N
        /// </summary>
        /// <remarks>
        /// This is changed from sn_cbs in order to avoid the same name with CBS SN
        /// </remarks>
        public string address_no { get; set; }

        /// <summary>
        /// Address Status
        /// </summary>
        /// <remarks></remarks>
        public int addstatus { get; set; }

        /// <summary>
        /// Address Type
        /// </summary>
        /// <remarks></remarks>
        public string addtype { get; set; }

        /// <summary>
        /// Apartment
        /// </summary>
        /// <remarks></remarks>
        public string apart { get; set; }

        /// <summary>
        /// Birth Country
        /// </summary>
        public string birthcountry { get; set; }

        /// <summary>
        /// Building Name
        /// </summary>
        /// <remarks></remarks>
        public string build { get; set; }

        /// <summary>
        /// Building
        /// </summary>
        /// <remarks></remarks>
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
        public string city { get; set; }

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
        public string crm_id { get; set; }

        /// <summary>
        /// Branch
        /// </summary>
        public int cu_branch { get; set; }

        /// <summary>
        /// Communication Language
        /// </summary>
        public string cu_comlang { get; set; }

        /// <summary>
        /// Client Consent
        /// </summary>
        public string cu_cons { get; set; }

        /// <summary>
        /// Education Level
        /// </summary>
        public int cu_edulv { get; set; }

        /// <summary>
        /// Bank Employee Id
        /// </summary>
        public string cu_empno { get; set; }

        /// <summary>
        /// Missing PIN
        /// </summary>
        public string cu_noafm { get; set; }

        /// <summary>
        /// Communication Method
        /// </summary>
        public string cu_nofication { get; set; }

        /// <summary>
        /// Payroll No (PF Number)
        /// </summary>
        public string cu_payrollno { get; set; }

        /// <summary>
        /// PIN
        /// </summary>
        public string cu_pin { get; set; }

        /// <summary>
        /// Recruited By
        /// </summary>
        public string cu_recr_by { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        /// <remarks>
        /// Value: If OutCustomerSex = '0' Then 'M' else 'F'
        /// </remarks>
        public string cu_sex { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public string cu_title { get; set; }

        /// <summary>
        /// Customer Type
        /// </summary>
        public string cu_type { get; set; }

        /// <summary>
        /// Address Details SN
        /// </summary>
        public int cuadd_sn { get; set; }

        /// <summary>
        /// Customer Status
        /// </summary>
        public string cus_status { get; set; }

        /// <summary>
        /// custype
        /// </summary>
        /// <remarks></remarks>
        public string custype { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Email 1
        /// </summary>
        public string email1 { get; set; }

        /// <summary>
        /// Fax
        /// </summary>
        /// <remarks></remarks>
        public string fax1 { get; set; }

        /// <summary>
        /// Floor
        /// </summary>
        /// <remarks></remarks>
        public string floor { get; set; }

        /// <summary>
        /// Email 2
        /// </summary>
        public string hc_email2 { get; set; }

        /// <summary>
        /// Mobile 1
        /// </summary>
        public string hc_mobile1 { get; set; }

        /// <summary>
        /// Mobile 2
        /// </summary>
        public string hc_mobile2 { get; set; }

        /// <summary>
        /// Customer Id
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Issue Country
        /// </summary>
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
        public string pe_authority { get; set; }

        /// <summary>
        /// Birth Date
        /// </summary>
        public DateTime pe_birdt { get; set; }

        /// <summary>
        /// Children No
        /// </summary>
        public int pe_child_no { get; set; }

        /// <summary>
        /// Citizenship
        /// </summary>
        public string pe_citizenship { get; set; }

        /// <summary>
        /// Citizenship 2
        /// </summary>
        public string pe_citizenship2 { get; set; }

        /// <summary>
        /// Dependants No
        /// </summary>
        public int pe_depend_no { get; set; }

        /// <summary>
        /// Document No
        /// </summary>
        public string pe_document { get; set; }

        /// <summary>
        /// Expiry Date
        /// </summary>
        public DateTime pe_exp_date { get; set; }

        /// <summary>
        /// Marital Status
        /// </summary>
        public int pe_famst { get; set; }

        /// <summary>
        /// Middle Name
        /// </summary>
        public string pe_fanam { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        public string pe_finam { get; set; }

        /// <summary>
        /// Identification Number
        /// </summary>
        public string pe_idnbr { get; set; }

        /// <summary>
        /// Identification Type
        /// </summary>
        public string pe_idtyp { get; set; }

        /// <summary>
        /// Issue Date
        /// </summary>
        public DateTime pe_issuon { get; set; }

        /// <summary>
        /// Main Id
        /// </summary>
        public string pe_main { get; set; }

        /// <summary>
        /// Nationality
        /// </summary>
        public string pe_natio { get; set; }

        /// <summary>
        /// Non Resident
        /// </summary>
        /// <remarks>
        /// Value: 1 = Yes, 0 = No
        /// </remarks>
        public string pe_res { get; set; }

        /// <summary>
        /// Surname
        /// </summary>
        public string pe_sunam { get; set; }

        /// <summary>
        /// PIN Country
        /// </summary>
        public string pincountry { get; set; }

        /// <summary>
        /// P.O. Box
        /// </summary>
        /// <remarks></remarks>
        public string pobox { get; set; }

        /// <summary>
        /// Postal Code
        /// </summary>
        /// <remarks></remarks>
        public string postal { get; set; }

        /// <summary>
        /// Province/ Post Office
        /// </summary>
        /// <remarks></remarks>
        public int postoffice { get; set; }

        /// <summary>
        /// Contract
        /// </summary>
        public int pr_contrc { get; set; }

        /// <summary>
        /// Contract Date
        /// </summary>
        public DateTime pr_contrc_dt { get; set; }

        /// <summary>
        /// Education Level
        /// </summary>
        public int pr_edulv { get; set; }

        /// <summary>
        /// Employer Address
        /// </summary>
        public string pr_emnam { get; set; }

        /// <summary>
        /// Employee No
        /// </summary>
        public int pr_emplno { get; set; }

        /// <summary>
        /// Activity Sector
        /// </summary>
        public int pr_employ { get; set; }

        /// <summary>
        /// Activity Sector Description
        /// </summary>
        public string pr_employ_description { get; set; }

        /// <summary>
        /// Employer No
        /// </summary>
        public int pr_employer_no { get; set; }

        /// <summary>
        /// Income Range
        /// </summary>
        public int pr_income { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        /// <remarks></remarks>
        public string pr_occup { get; set; }

        /// <summary>
        /// Primary Occupation
        /// </summary>
        public int pr_position { get; set; }

        /// <summary>
        /// Profession Status
        /// </summary>
        public int pr_profe { get; set; }

        /// <summary>
        /// Financial Sector
        /// </summary>
        public int pr_sector { get; set; }

        /// <summary>
        /// Total Employment
        /// </summary>
        public DateTime pr_totemp { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        /// <remarks></remarks>
        public string region { get; set; }

        /// <summary>
        /// CBS SN
        /// </summary>
        public int sn_cbs { get; set; }

        /// <summary>
        /// Telephone 1
        /// </summary>
        /// <remarks></remarks>
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