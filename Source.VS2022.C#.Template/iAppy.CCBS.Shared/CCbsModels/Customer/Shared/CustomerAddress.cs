namespace iApplyShared.CbsModels
{
    public class CustomerAddress
    {
        #region Public Properties

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Accommodation Date
        /// Data Type: datetime
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressAccomodationDate
        /// </summary>
        public DateTime accdate { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Street Name, Address Line 1
        /// Data Type: varchar (255)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressAddress1
        /// </summary>
        public string addres1 { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Plot/Street No, Address Line 2
        /// Data Type: varchar (255)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressAddress2
        /// </summary>
        public string addres2 { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Address Status
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressEntryStatus
        /// </summary>
        public int addstatus { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Address Type
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressAddressType
        /// </summary>
        public string addtype { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Apartment
        /// Data Type: varchar (32)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressAddress6
        /// </summary>
        public string apart { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Building Name
        /// Data Type: varchar (32)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressAddress3
        /// </summary>
        public string build { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Building
        /// Data Type: varchar (32)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressAddress5
        /// </summary>
        public string buildno { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: City
        /// Data Type: varchar (200)
        /// Notes: Select cod cr_comast where grp='G75' and Upper(des)=Upper(OutListGrpOutGrmCustAddressCity)
        ///
        ///If result is not null then cities = result
        ///else
        ///
        ///Select TOP 1 cod From cr_comast where grp='G75' AND tag ='O'
        ///
        ///cities = result
        ///city = OutListGrpOutGrmCustAddressCity
        /// CBS: OutListGrpOutGrmCustAddressCity
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Country
        /// Data Type: varchar (15)
        /// Notes: For Centenary only
        ///
        ///Select isnull(cps,'') From cr_comast Where grp = 'G83' and cod = OutListGrpOutGrmCountryGenericDetailDescription
        ///
        ///If result is not null then
        ///tele1_ac = result
        ///tele2_ac = result
        ///tele3_ac = result
        ///
        /// CBS: OutCountryGenericDetailSerialNum
        /// </summary>
        public string cntry { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: County
        /// Data Type: varchar (15)
        /// Notes: Select cod From cr_comast where grp='G50' and Upper(des)=Upper(OutListGrpOutGrmCustAddressRegion)
        ///
        ///If result is not null then cnty = result
        /// CBS: OutListGrpOutGrmCustAddressRegion
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Address Details SN
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutCustAddrParrelDSn
        /// </summary>
        public int cuadd_sn { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: N/A
        /// Data Type: varchar (1)
        /// Notes: 1
        /// CBS: N/A
        /// </summary>
        public string custype { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Email
        /// Data Type: varchar (100)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressEMail
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Fax
        /// Data Type: varchar (30)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressFaxNo
        /// </summary>
        public string fax1 { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Floor
        /// Data Type: varchar (32)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressAddress4
        /// </summary>
        public string floor { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Communication Address
        /// Data Type: varchar (1)
        /// Notes: If OutListGrpOutGrmCustAddressCommunicationAddress = '*' then mainadd = '1' else '0'
        /// CBS: OutListGrpOutGrmCustAddressCommunicationAddress
        /// </summary>
        public string mainadd { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: P.O. Box
        /// Data Type: varchar (10)
        /// Notes: N/A
        /// CBS: OutCustAddressMailBox
        /// </summary>
        public string pobox { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Postal Code
        /// Data Type: varchar (10)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressZipCode
        /// </summary>
        public string postal { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Province/ Post Office
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutDistrictGenericDetailSerialNum
        /// </summary>
        public int postoffice { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Region
        /// Data Type: varchar (15)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressRegion
        /// </summary>
        public string region { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Address S/N
        /// Data Type: integer
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressSerialNum
        /// </summary>
        public int sn_cbs { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Telephone 1
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressTelephone
        /// </summary>
        public string tele1 { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Telephone 2
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressTelephone2
        /// </summary>
        public string tele2 { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Telephone 3
        /// Data Type: varchar (20)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressTelephone3
        /// </summary>
        public string tele3 { get; set; }

        /// <summary>
        /// Seq: N/A
        /// Entity: cr_cuaddress
        /// Description: Web Site
        /// Data Type: varchar (100)
        /// Notes: N/A
        /// CBS: OutListGrpOutGrmCustAddressInternetAddress
        /// </summary>
        public string website { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(addres1) /*&& string.IsNullOrEmpty(CountryShortDes)*/)
                return false;
            return true;
        }

        #endregion Public Properties
    }
}