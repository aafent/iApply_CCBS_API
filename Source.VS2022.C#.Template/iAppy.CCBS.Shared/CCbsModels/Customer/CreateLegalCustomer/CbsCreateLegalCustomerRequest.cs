using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsCreateLegalCustomerRequest
    {
        #region Public Properties

        /// <summary>
        /// Company Name (varchar (100))
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Trade Name (varchar (20))
        /// </summary>
        public string TradeName { get; set; }

        /// <summary>
        /// PIN (varchar (20))
        /// </summary>
        public string AfmNo { get; set; }

        /// <summary>
        /// Missing PIN (varchar (1))
        /// 1 = Yes 0 = No
        /// </summary>
        public string MissingAfm { get; set; }

        /// <summary>
        /// Business Nature (integer)
        /// </summary>
        public int ActivityCode { get; set; }

        /// <summary>
        /// Customer Branch (integer)
        /// </summary>
        public int BranchCode { get; set; }

        /// <summary>
        /// Email 1 (varchar (50))
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Email 2 (varchar (50))
        /// </summary>
        public string Email2 { get; set; }

        /// <summary>
        /// Mobile 1 (varchar (20))
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Mobile 2 (varchar (20))
        /// </summary>
        public string Mobile2 { get; set; }

        /// <summary>
        /// PIN Country (varchar (100))
        /// </summary>
        public string AfmIssueCountryShortDescription { get; set; }

        /// <summary>
        /// Non Resident (varchar (1))
        /// 1 = Yes 0 = No
        /// </summary>
        public string ResidencyStatus { get; set; }

        /// <summary>
        /// TaxOfficeCBSId (integer)
        /// 9999
        /// </summary>
        public int TaxOfficeCBSId { get; set; }

        /// <summary>
        /// Branch (integer)
        /// </summary>
        public int BranchCBSId { get; set; }

        /// <summary>
        /// Incorporation Country (varchar (100))
        /// </summary>
        public string CountryShortDescription { get; set; }

        /// <summary>
        /// Legal Form (integer)
        /// </summary>
        public int LegalFormCode { get; set; }

        /// <summary>
        /// Financial Sector (integer)
        /// </summary>
        public int FinancialSectorCode { get; set; }

        /// <summary>
        /// Communication Method (varchar (150))
        /// </summary>
        public string ComMethod { get; set; }

        /// <summary>
        /// CRM Id (varchar (20))
        /// </summary>
        public string CustomerCrmId { get; set; }

        /// <summary>
        /// Customer Id (varchar (15))
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Communication Language (varchar (10))
        /// </summary>
        public string ComLanguage { get; set; }

        /// <summary>
        /// Recruited By (varchar (40))
        /// </summary>
        public string RecruiterBy { get; set; }

        /// <summary>
        /// Street Name, Address Line 1 (varchar (255))
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Plot/Street No, Address Line 2 (varchar (255))
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Address S/N (integer)
        /// </summary>
        public int AddressSN { get; set; }

        /// <summary>
        /// Address Type (varchar (15))
        /// </summary>
        public string AddressType { get; set; }

        /// <summary>
        /// City (varchar (200))
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Country Short Description (varchar (200))
        /// </summary>
        public string CountryShortDes { get; set; }

        /// <summary>
        /// County (varchar (15))
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Fax (varchar (30))
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// Postal Code (varchar (10))
        /// </summary>
        public string Postal { get; set; }

        /// <summary>
        /// Telephone 1 (varchar (20))
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// Building Name (varchar (32))
        /// </summary>
        public string BuildName { get; set; }

        /// <summary>
        /// Floor (varchar (32))
        /// </summary>
        public string Floor { get; set; }

        /// <summary>
        /// Building (varchar (32))
        /// </summary>
        public string Building { get; set; }

        /// <summary>
        /// Apartment (varchar (32))
        /// </summary>
        public string Apart { get; set; }

        /// <summary>
        /// Telephone 2 (varchar (20))
        /// </summary>
        public string Telephone2 { get; set; }

        /// <summary>
        /// Province/ Post Office (integer)
        /// </summary>
        public int PostOffice { get; set; }

        /// <summary>
        /// Web Site (varchar (100))
        /// </summary>
        public string WebSite { get; set; }

        /// <summary>
        /// Accommodation Date (datetime)
        /// </summary>
        public DateTime AccDate { get; set; }

        /// <summary>
        /// Address Status (integer)
        /// </summary>
        public int AddressStatus { get; set; }

        /// <summary>
        /// Address Details SN (integer)
        /// </summary>
        public int AddSerial { get; set; }

        /// <summary>
        /// CountyType (varchar (200))
        /// If country = DEFAULT then ADDRESS else null
        /// </summary>
        public string? CountyType { get; set; }

        /// <summary>
        /// Id Type (varchar (10))
        /// </summary>
        public string IdentificationType { get; set; }

        /// <summary>
        /// Id Issue Date (datetime)
        /// </summary>
        public DateTime IdentificationIssueDate { get; set; }

        /// <summary>
        /// Document No (varchar (4000))
        /// </summary>
        public string IdentificationDocument { get; set; }

        /// <summary>
        /// Identification Number (varchar (100))
        /// </summary>
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// Id Expiry Date (datetime)
        /// </summary>
        public DateTime IdentificationExpiryDate { get; set; }

        /// <summary>
        /// Id Authority (varchar (100))
        /// </summary>
        public string IdentificationAuthority { get; set; }

        /// <summary>
        /// Insurance Fees (decimal (15,2))
        /// </summary>
        public decimal InsAmount { get; set; }

        /// <summary>
        /// Funeral Fees (decimal (15,2))
        /// </summary>
        public decimal FunAmount { get; set; }

        /// <summary>
        /// Monthly Capital (decimal (15,2))
        /// </summary>
        public decimal CapAmount { get; set; }

        /// <summary>
        /// Customer CBS Id (varchar (20))
        /// </summary>
        public string CustomerCBSId { get; set; }

        /// <summary>
        /// Customer Check Digit (integer)
        /// </summary>
        public int CustomerCBSCd { get; set; }

        /// <summary>
        /// Postal Code (varchar (10))
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Country (varchar (15))
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Communication Address (varchar (1))
        /// 1 = Yes 0 = No
        /// </summary>
        public string MainAddress { get; set; }

        /// <summary>
        /// Address S/N (integer)
        /// </summary>
        public int AddSN { get; set; }

        /// <summary>
        /// P.O. Box (varchar (10))
        /// </summary>
        public string MailBox { get; set; }

        /// <summary>
        /// Telephone 3 (varchar (20))
        /// </summary>
        public string Telephone3 { get; set; }

        /// <summary>
        /// Main Id (varchar (1))
        /// 1 = Yes 0 = No
        /// </summary>
        public string IdentificationMain { get; set; }

        /// <summary>
        /// Issue Country (integer)
        /// </summary>
        public int IdentificationIssueCountry { get; set; }

        /// <summary>
        /// Issue Country Description(varchar (200))
        /// </summary>
        public string IdentificationIssueCountryShortDescription { get; set; }

        /// <summary>
        /// CBS SN (integer)
        /// </summary>
        public int SnCBS { get; set; }

        #endregion Public Properties
    }
}
